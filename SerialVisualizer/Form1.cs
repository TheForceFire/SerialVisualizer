using System;
using System.Windows.Forms;
using System.IO.Ports;
using NLog;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;

namespace SerialVisualizer
{
    public partial class Form1 : Form
    {
        SerialPort serial = new SerialPort();
        Thread myThread;
        ManualResetEvent stopEvent = new ManualResetEvent(false);
        Series series;
        static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public Form1()
        {
            logger.Info("Initializing");
            InitializeComponent();
            comboBoxSelectedPort.Items.AddRange(SerialPort.GetPortNames());
            series = chart1.Series[0];
            series.LegendText = "Data";
            buttonConnectComPort.Click += b_connect;
            buttonRefreshPortList.Click += b_refresh;
            button3.Click += b_clear;


            comboBoxBaudRate.SelectedIndex = 4;
            comboBoxParity.SelectedIndex = 0;
            numericUpDownDataBits.Value = 8;
            comboBoxStopBits.SelectedIndex = 1;
            pictureBox1.BackColor = System.Drawing.Color.Red;
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

            return StopBits.None;
        }


        private void b_connect(object sender, EventArgs e)
        {
            logger.Info("Button 'Connect/Disconnect' clicked");

            string selectedPort = comboBoxStopBits.SelectedItem?.ToString();


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
                    buttonConnectComPort.Text = "Connect";
                    pictureBox1.BackColor = System.Drawing.Color.Red;
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
                    pictureBox1.BackColor = System.Drawing.Color.Green;
                    labelConnectionStatus.Text = $"Connected to {selectedPort}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                pictureBox1.BackColor = System.Drawing.Color.DarkRed;
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
            logger.Info("Updating the list of COM-port");
            comboBoxSelectedPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comboBoxSelectedPort.Items.AddRange(ports);
        }
        private void b_clear(object sender, EventArgs e)
        {
            if (series != null)
            {
                series.Points.Clear();
            }
        }
        private void CB_SIC(object sender, EventArgs e)
        {
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
                        do {
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
                            this.BeginInvoke(new Action(() =>
                            {
                                series.Points.AddXY(series.Points.Count + 1, bytes[0]);
                            }));

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
    }
}