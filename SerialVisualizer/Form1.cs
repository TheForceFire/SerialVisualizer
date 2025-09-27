using System;
using System.Windows.Forms;
using System.IO.Ports;
using NLog;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SerialVisualizer
{
    public partial class Form1 : Form
    {
        SerialPort serial = new SerialPort();
        DataType currentDataType = DataType.Uint8;
        Thread myThread;
        ManualResetEvent stopEvent = new ManualResetEvent(false);
        Series[] series;
        Series[] originSeries;
        double[] scales;
        static readonly Logger logger = LogManager.GetCurrentClassLogger();
        bool isUserCheckMessage = false;
        string log = "";
        ClassDataSaverParser classDataSaverParser;

        public Form1()
        {
            logger.Info("Initializing");
            InitializeComponent();
            comboBoxSelectedPort.Items.AddRange(SerialPort.GetPortNames());
            buttonConnectComPort.Click += b_connect;
            buttonRefreshPortList.Click += b_refresh;
            button3.Click += b_clear;

            originSeries = new Series[10];
            for (int i = 0; i < 10; i++)
            {
                originSeries[i] = new Series();
            }
            scales = new double[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            series = new Series[10];
            series[0] = chart1.Series[0];
            series[0].LegendText = "Series1";
            series[0].ChartType = SeriesChartType.Spline;

            comboBoxBaudRate.SelectedIndex = 4;
            comboBoxParity.SelectedIndex = 0;
            numericUpDownDataBits.Value = 8;
            comboBoxStopBits.SelectedIndex = 1;
            pictureBox1.BackColor = Color.Red;
            seriesChange.Maximum = CountActiveSeries();


            classDataSaverParser = new ClassDataSaverParser(ReadingType.BigEndian, 1, true, false);
            classDataSaverParser.frameStart = ClassDataSaverParser.StringToByteArray(textBoxFrameStart.Text);
        }


        private Parity GetParity(string selectedP)
        {
            switch (selectedP)
            {
                case "None":
                    return Parity.None;
                case "Odd":
                    return Parity.Odd;
                case "Even":
                    return Parity.Even;
                case "Mark":
                    return Parity.Mark;
                case "Space":
                    return Parity.Space;
            }
            logger.Info("Change parity");
            return Parity.None;
        }

        private StopBits GetStopBits(string selectedSB)
        {
            switch (double.Parse(selectedSB))
            {
                case 1:
                    return StopBits.One;
                case 1.5:
                    return StopBits.OnePointFive;
                case 2:
                    return StopBits.Two;
                case 3:
                    return StopBits.None;
            }
            logger.Info("Change stop bits");
            return StopBits.None;
        }


        private void b_connect(object sender, EventArgs e)
        {
            logger.Info("Button 'Connect/Disconnect' clicked");

            string selectedPort = comboBoxSelectedPort.SelectedItem?.ToString();


            string selectedBR = comboBoxBaudRate.SelectedItem.ToString();
            string selectedP = comboBoxParity.SelectedItem.ToString();
            string enterdDB = numericUpDownDataBits.Value.ToString();
            string selectedSB = comboBoxStopBits.SelectedItem.ToString();


            int BR = int.Parse(selectedBR);
            int DB = int.Parse(enterdDB);
            Parity P = GetParity(selectedP);
            StopBits SB = GetStopBits(selectedSB);

            OpenPort(selectedPort, BR, DB, P, SB);

        }
        private void OpenPort(string selectedPort, int BR, int DB, Parity P, StopBits SB)
        {
            try
            {
                if (serial.IsOpen && serial.PortName != null)
                {
                    stopEvent.Set();
                    if (myThread != null && myThread.IsAlive) myThread.Join();
                    serial.Close();
                    isUserCheckMessage = false;
                    buttonConnectComPort.Text = "Connect";
                    pictureBox1.BackColor = Color.Red;
                    labelConnectionStatus.Text = "Disonnected";
                }
                else
                {
                    SetSerialSettings(selectedPort, BR, DB, P, SB);

                    myThread = new Thread(ReadBytes);
                    myThread.IsBackground = true;
                    serial.Open();
                    stopEvent.Reset();
                    myThread.Start();
                    buttonConnectComPort.Text = "Disconnect";
                    pictureBox1.BackColor = Color.Green;
                    labelConnectionStatus.Text = $"Connected to {selectedPort}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                pictureBox1.BackColor = Color.DarkRed;
                labelConnectionStatus.Text = $"Closed with error";
            }
        }
        private void SetSerialSettings(string selectedPort, int BR, int DB, Parity P, StopBits SB)
        {
            serial.PortName = selectedPort;
            serial.BaudRate = BR;
            serial.DataBits = DB;
            serial.Parity = P;
            serial.StopBits = SB;
        }
        private void b_refresh(object sender, EventArgs e)
        {
            CheckChanges();
            logger.Info("Updating the list of COM-port");
            comboBoxSelectedPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comboBoxSelectedPort.Items.AddRange(ports);
        }
        private void b_clear(object sender, EventArgs e)
        {
            logger.Info("Graphics cleared");
            for (int i = 0; i < series.Length; i++)
                if (series[i] != null)
                {
                    series[i].Points.Clear();
                }
            for (int i = 0; i < originSeries.Length; i++)
                originSeries[i].Points.Clear();

        }
        private void CB_SIC(object sender, EventArgs e)
        {
            CheckChanges();
            logger.Debug("User select COM-port");
        }

        private void ReadBytes()
        {
            logger.Info("Read thread start");
            while (serial.IsOpen)
            {
                if (stopEvent.WaitOne(0))
                {
                    break;
                }
                try
                {
                    int bytesToRead = serial.BytesToRead;
                    int startBytesToRead;
                    if (bytesToRead > 0)
                    {
                        do 
                        {
                            startBytesToRead = bytesToRead;

                            Thread.Sleep(10);
                            bytesToRead = serial.BytesToRead;
                        }
                        while (bytesToRead != startBytesToRead);


                        byte[] bytes = new byte[bytesToRead];
                        int bytesRead = serial.Read(bytes, 0, bytesToRead);
                        logger.Debug($"Received {bytesRead} byte(s): {BitConverter.ToString(bytes)}");
                        if (bytesRead > 0)
                        {
                            ClassDataSaver dataSaver = classDataSaverParser.Parse(bytes);

                            if (dataSaver != null)
                            {

                                //Для записи лога необходимы проверки:
                                //Стоит ли checkBox на запись в состоянии Selected (true)
                                //Существует ли папка, на которую ссылается путь для записи (если нет, то нужно предупредить об этом)
                                log += writeDataLog(dataSaver, currentDataType);

                                this.BeginInvoke(new Action(() =>
                                {
                                    switch (currentDataType)
                                    {
                                        case DataType.Int8:
                                            {
                                                sbyte[] data = dataSaver.ToInt8();
                                                int dataAmount = Math.Min(data.Length, CountActiveSeries());
                                                int xCoordinate = GetLastXCoordinate() + 1;

                                                for (int i = 0; i < dataAmount; i++)
                                                {
                                                    series[i].Points.AddXY(xCoordinate, data[i] * scales[i]);
                                                    originSeries[i].Points.AddXY(xCoordinate, data[i]);
                                                }
                                            }
                                            break;
                                        case DataType.Uint8:
                                            {
                                                byte[] data = dataSaver.ToUInt8();
                                                int dataAmount = Math.Min(data.Length, CountActiveSeries());
                                                int xCoordinate = GetLastXCoordinate() + 1;

                                                for (int i = 0; i < dataAmount; i++)
                                                {
                                                    series[i].Points.AddXY(xCoordinate, data[i] * scales[i]);
                                                    originSeries[i].Points.AddXY(xCoordinate, data[i]);
                                                }
                                            }
                                            break;
                                        case DataType.Int16:
                                            {
                                                short[] data = dataSaver.ToInt16();
                                                int dataAmount = Math.Min(data.Length, CountActiveSeries());
                                                int xCoordinate = GetLastXCoordinate() + 1;

                                                for (int i = 0; i < dataAmount; i++)
                                                {
                                                    series[i].Points.AddXY(xCoordinate, data[i] * scales[i]);
                                                    originSeries[i].Points.AddXY(xCoordinate, data[i]);
                                                }
                                            }
                                            break;
                                        case DataType.Uint16:
                                            {
                                                ushort[] data = dataSaver.ToUInt16();
                                                int dataAmount = Math.Min(data.Length, CountActiveSeries());
                                                int xCoordinate = GetLastXCoordinate() + 1;

                                                for (int i = 0; i < dataAmount; i++)
                                                {
                                                    series[i].Points.AddXY(xCoordinate, data[i] * scales[i]);
                                                    originSeries[i].Points.AddXY(xCoordinate, data[i]);
                                                }
                                            }
                                            break;
                                        case DataType.Int32:
                                            {
                                                int[] data = dataSaver.ToInt32();
                                                int dataAmount = Math.Min(data.Length, CountActiveSeries());
                                                int xCoordinate = GetLastXCoordinate() + 1;

                                                for (int i = 0; i < dataAmount; i++)
                                                {
                                                    series[i].Points.AddXY(xCoordinate, data[i] * scales[i]);
                                                    originSeries[i].Points.AddXY(xCoordinate, data[i]);
                                                }
                                            }
                                            break;
                                        case DataType.Uint32:
                                            {
                                                uint[] data = dataSaver.ToUInt32();
                                                int dataAmount = Math.Min(data.Length, CountActiveSeries());
                                                int xCoordinate = GetLastXCoordinate() + 1;

                                                for (int i = 0; i < dataAmount; i++)
                                                {
                                                    series[i].Points.AddXY(xCoordinate, data[i] * scales[i]);
                                                    originSeries[i].Points.AddXY(xCoordinate, data[i]);
                                                }
                                            }
                                            break;
                                        case DataType.Float:
                                            {
                                                float[] data = dataSaver.ToFloat();
                                                int dataAmount = Math.Min(data.Length, CountActiveSeries());
                                                int xCoordinate = GetLastXCoordinate() + 1;

                                                for (int i = 0; i < dataAmount; i++)
                                                {
                                                    series[i].Points.AddXY(xCoordinate, data[i] * scales[i]);
                                                    originSeries[i].Points.AddXY(xCoordinate, data[i]);
                                                }
                                            }
                                            break;
                                        case DataType.Double:
                                            {
                                                double[] data = dataSaver.ToDouble();
                                                int dataAmount = Math.Min(data.Length, CountActiveSeries());
                                                int xCoordinate = GetLastXCoordinate() + 1;

                                                for (int i = 0; i < dataAmount; i++)
                                                {
                                                    series[i].Points.AddXY(xCoordinate, data[i] * scales[i]);
                                                    originSeries[i].Points.AddXY(xCoordinate, data[i]);
                                                }
                                            }
                                            break;
                                    }
                                }));
                            }

                        }
                    }
                }
                catch (InvalidOperationException ex)
                {
                    logger.Error(ex);
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "Error in read thread");
                    break;
                }
            }
            logger.Info("Read thread finish");
        }

        bool CheckChanges()
        {
            if (serial.IsOpen && !isUserCheckMessage)
            {
                MessageBox.Show("The new settings will be applied only after the port is reopened");
                logger.Info("Warning");
                isUserCheckMessage = true;
                return true;
            }
            return false;
        }

        private string writeDataLog(ClassDataSaver classDataSaver, DataType dataType)
        {
            string logRow = "";
            logRow += Encoding.ASCII.GetString(classDataSaver.start_b.ToArray()) + ";";
            if(classDataSaver.sender_b.Count != 0)
            {
                logRow += Encoding.ASCII.GetString(classDataSaver.sender_b.ToArray()) + ";";
            }
            else
            {
                logRow += "null;";
            }


            switch (dataType)
            {
                case DataType.Int8:
                    {
                        sbyte[] data = classDataSaver.ToInt8();
                        int dataAmount = Math.Min(data.Length, CountActiveSeries());

                        for (int i = 0; i < dataAmount; i++)
                        {
                            logRow += data[i].ToString() + ";";
                        }
                    }
                    break;
                case DataType.Uint8:
                    {
                        byte[] data = classDataSaver.ToUInt8();
                        int dataAmount = Math.Min(data.Length, CountActiveSeries());

                        for (int i = 0; i < dataAmount; i++)
                        {
                            logRow += data[i].ToString() + ";";
                        }
                    }
                    break;
                case DataType.Int16:
                    {
                        short[] data = classDataSaver.ToInt16();
                        int dataAmount = Math.Min(data.Length, CountActiveSeries());

                        for (int i = 0; i < dataAmount; i++)
                        {
                            logRow += data[i].ToString() + ";";
                        }
                    }
                    break;
                case DataType.Uint16:
                    {
                        ushort[] data = classDataSaver.ToUInt16();
                        int dataAmount = Math.Min(data.Length, CountActiveSeries());

                        for (int i = 0; i < dataAmount; i++)
                        {
                            logRow += data[i].ToString() + ";";
                        }
                    }
                    break;

                case DataType.Int32:
                    {
                        int[] data = classDataSaver.ToInt32();
                        int dataAmount = Math.Min(data.Length, CountActiveSeries());

                        for (int i = 0; i < dataAmount; i++)
                        {
                            logRow += data[i].ToString() + ";";
                        }
                    }
                    break;
                case DataType.Uint32:
                    {
                        uint[] data = classDataSaver.ToUInt32();
                        int dataAmount = Math.Min(data.Length, CountActiveSeries());

                        for (int i = 0; i < dataAmount; i++)
                        {
                            logRow += data[i].ToString() + ";";
                        }
                    }
                    break;
                case DataType.Float:
                    {
                        float[] data = classDataSaver.ToFloat();
                        int dataAmount = Math.Min(data.Length, CountActiveSeries());

                        for (int i = 0; i < dataAmount; i++)
                        {
                            logRow += data[i].ToString() + ";";
                        }
                    }
                    break;
                case DataType.Double:
                    {
                        double[] data = classDataSaver.ToDouble();
                        int dataAmount = Math.Min(data.Length, CountActiveSeries());

                        for (int i = 0; i < dataAmount; i++)
                        {
                            logRow += data[i].ToString() + ";";
                        }
                    }
                    break;
            }


            if (classDataSaver.cs_b.Count != 0)
            {
                logRow += Encoding.ASCII.GetString(classDataSaver.cs_b.ToArray()) + Environment.NewLine;
            }
            else
            {
                logRow += "null" + Environment.NewLine;
            }

            return logRow;
        }




        private void textBoxFrameStart_TextChanged(object sender, EventArgs e)
        {
            try
            {
                classDataSaverParser.frameStart = ClassDataSaverParser.StringToByteArray(textBoxFrameStart.Text);
                textBoxFrameStart.BackColor = Color.White;
            }
            catch
            {
                classDataSaverParser.frameStart = null;
                textBoxFrameStart.BackColor = Color.OrangeRed;
            }
        }

        private void radioButtonEndianLittle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEndianLittle.Checked)
            {
                classDataSaverParser.readingType = ReadingType.LittleEndian;
            }
        }

        private void radioButtonEndianBig_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEndianBig.Checked)
            {
                classDataSaverParser.readingType = ReadingType.BigEndian;
            }

        }

        private void radioButtonNoAddress_CheckedChanged(object sender, EventArgs e)
        {
            classDataSaverParser.isAddressEnable = radioButtonYesAddress.Checked;
        }

        private void radioButtonYesAddress_CheckedChanged(object sender, EventArgs e)
        {
            classDataSaverParser.isAddressEnable = radioButtonYesAddress.Checked;
        }

        private void textBoxAddresLength_TextChanged(object sender, EventArgs e)
        {
            try
            {
                classDataSaverParser.addressLength = int.Parse(textBoxAddresLength.Text);
                textBoxAddresLength.BackColor = Color.White;
            }
            catch
            {
                classDataSaverParser.addressLength = -1;
                textBoxAddresLength.BackColor = Color.OrangeRed;
            }
        }

        private void radioButtonNoChecksum_CheckedChanged(object sender, EventArgs e)
        {
            classDataSaverParser.isChecksumEnable = radioButtonYesChecksum.Checked;
        }

        private void radioButtonYesChecksum_CheckedChanged(object sender, EventArgs e)
        {
            classDataSaverParser.isChecksumEnable = radioButtonYesChecksum.Checked;
        }

        private void radioButtonInt8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInt8.Checked)
            {
                currentDataType = DataType.Int8;
            }
        }

        private void radioButtonUint8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUint8.Checked)
            {
                currentDataType = DataType.Uint8;
            }
        }

        private void radioButtonInt16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInt16.Checked)
            {
                currentDataType = DataType.Int16;
            }
        }

        private void radioButtonUint16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUint16.Checked)
            {
                currentDataType = DataType.Uint16;
            }
        }

        private void radioButtonInt32_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInt32.Checked)
            {
                currentDataType = DataType.Int32;
            }
        }

        private void radioButtonUint32_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUint32.Checked)
            {
                currentDataType = DataType.Uint32;
            }
        }

        private void radioButtonFloat_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFloat.Checked)
            {
                currentDataType = DataType.Float;
            }
        }

        private void radioButtonDouble_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDouble.Checked)
            {
                currentDataType = DataType.Double;
            }
        }

        private void numericUpDownDataAmount_ValueChanged(object sender, EventArgs e)
        {
            int currentSeries = (int)numericUpDownDataAmount.Value;

            if (currentSeries < 1 || currentSeries > 10)
            {
                currentSeries = 1;
            }


            int seriesDiff = CountActiveSeries() - currentSeries;
            seriesChange.Maximum = CountActiveSeries() + 1;

            if (seriesDiff < 0)
            {
                for (int i = 0; i < currentSeries; i++)
                {
                    if (chart1.Series.Count <= i)
                    {
                        chart1.Series.Add("Series" + (i + 1));
                    }

                    series[i] = chart1.Series[i];
                    series[i].ChartType = SeriesChartType.Spline;
                }
            }
            else if (seriesDiff > 0)
            {
                for (int i = currentSeries; i > 0; i--)
                {
                    if (chart1.Series.Count > currentSeries)
                    {
                        chart1.Series.RemoveAt(i);
                        series[i] = null;
                    }
                }
            }
            logger.Info("Series changed to " + chart1.Series.Count);
        }


        private int CountActiveSeries()
        {
            int length = 0;

            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] != null)
                {
                    length++;
                }
            }

            return length;
        }

        private int GetLastXCoordinate()
        {
            int lastX = 0;

            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] != null)
                {
                    if (series[i].Points.Count > lastX)
                    {
                        lastX = series[i].Points.Count;
                    }
                }
            }

            return lastX;
        }

        private void comboBoxBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckChanges();
        }

        private void comboBoxParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckChanges();
        }

        private void numericUpDownDataBits_ValueChanged(object sender, EventArgs e)
        {
            CheckChanges();
        }

        private void comboBoxStopBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentSeries = (int)seriesChange.Value - 1;
            string nameToRename = RenameBox.Text;
            logger.Info("Graphic " + currentSeries + " renamed");
            if (currentSeries >= 0 && currentSeries < CountActiveSeries())
            {
                series[currentSeries].LegendText = nameToRename;
            }
        }

        private void seriesChange_ValueChanged(object sender, EventArgs e)
        {
            int index = (int)seriesChange.Value - 1;
            textBoxScaleValues.Text = scales[index].ToString();
        }

        private void buttonAddScale_Click(object sender, EventArgs e)
        {
            int index = (int)seriesChange.Value - 1;
            logger.Info("Multiplier up");
            switch (scales[index])
            {
                case 0.001:
                    scales[index] = 0.01;
                    break;
                case 0.01:
                    scales[index] = 0.1;
                    break;
                case 0.1:
                    scales[index] = 1;
                    break;
                case 1:
                    scales[index] = 10;
                    break;
                case 10:
                    scales[index] = 100;
                    break;
                case 100:
                    scales[index] = 1000;
                    break;
                case 1000:
                    break;
                default:
                    break;
            }
            textBoxScaleValues.Text = scales[index].ToString();


            series[index].Points.Clear();

            foreach (DataPoint p in originSeries[index].Points)
            {
                series[index].Points.AddXY(p.XValue, p.YValues[0] * scales[index]);
            }
        }

        private void buttonRemoveScale_Click(object sender, EventArgs e)
        {
            int index = (int)seriesChange.Value - 1;
            logger.Info("Multiplier down");
            switch (scales[index])
            {
                case 0.001:
                    break;
                case 0.01:
                    scales[index] = 0.001;
                    break;
                case 0.1:
                    scales[index] = 0.01;
                    break;
                case 1:
                    scales[index] = 0.1;
                    break;
                case 10:
                    scales[index] = 1;
                    break;
                case 100:
                    scales[index] = 10;
                    break;
                case 1000:
                    scales[index] = 100;
                    break;
                default:
                    break;
            }
            textBoxScaleValues.Text = scales[index].ToString();

            series[index].Points.Clear();

            foreach (DataPoint p in originSeries[index].Points)
            {
                series[index].Points.AddXY(p.XValue, p.YValues[0] * scales[index]);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (chart1.Series.Any(s => s.Enabled))
                {
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "Image Files|*.png;";
                    save.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff";
                    save.Title = "Save Chart Image As file";
                    save.FileName = "Chart " + DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss");
                    save.DefaultExt = ".png";
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        var imgFormats = new Dictionary<string, ChartImageFormat>()
            {
                {".bmp", ChartImageFormat.Bmp},
                {".gif", ChartImageFormat.Gif},
                {".jpg", ChartImageFormat.Jpeg},
                {".jpeg", ChartImageFormat.Jpeg},
                {".png", ChartImageFormat.Png},
                {".tiff", ChartImageFormat.Tiff},
            };
                        var fileExt = System.IO.Path.GetExtension(save.FileName).ToString().ToLower();
                        if (imgFormats.ContainsKey(fileExt))
                        {
                            chart1.SaveImage(save.FileName, imgFormats[fileExt]);
                            MessageBox.Show("Chart saved successfully");
                        }
                        else
                        {
                            throw new Exception(String.Format("Only image formats '{0}' supported", string.Join(", ", imgFormats.Keys)));
                        }
                    }
                }
                else
                {
                    throw new Exception("Nothing to export");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SaveChartAsImage()", ex.Message);
            }
        }

        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            if (serial.IsOpen)
            {
                stopEvent.Set();
                if (myThread != null && myThread.IsAlive) myThread.Join();
                serial.Close();
            }
            if (checkBox1.Checked)
            {
                try
                {
                    string path = label11.Text + "/tables/table " + DateTime.Now.ToString("MM-dd-yyyy_HH-mm-ss") + ".csv";
                    Directory.CreateDirectory(label11.Text + "/tables");
                    File.Create(path).Close();
                    File.WriteAllText(path, log);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error writing log file: " + ex.Message);
                }
            }
        }

        enum DataType
        {
            Int8,
            Uint8,
            Int16,
            Uint16,
            Int32,
            Uint32,
            Float,
            Double
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DirDialog = new FolderBrowserDialog();
            DirDialog.Description = "Выбор директории";
            DirDialog.SelectedPath = @"./tables";

            if (DirDialog.ShowDialog() == DialogResult.OK)
            {
                label11.Text = DirDialog.SelectedPath;
            }
        }
    }
}