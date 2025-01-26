using System;
using System.Windows.Forms;
using System.IO.Ports;
using NLog;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

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
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
            series = chart1.Series[0];
            series.LegendText = "Data";
            button1.Click += b_connect;
            button2.Click += b_refresh;
            button3.Click += b_clear;
        }

        private void b_connect(object sender, EventArgs e)
        {
            logger.Info("Button 'Connect/Disconnect' clicked");
            string selectedPort = comboBox1.SelectedItem?.ToString();
            string selectedBR = comboBox2.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedPort))
            {
                MessageBox.Show("Select COM-port");
                return;
            }
            if (string.IsNullOrEmpty(selectedBR))
            {
                MessageBox.Show("Select Baud Rate");
                return;
            }
            int BR = int.Parse(selectedBR);

            try
            {
                if (serial.IsOpen && serial.PortName != null)
                {
                    stopEvent.Set();
                    if (myThread != null && myThread.IsAlive) myThread.Join();
                    serial.Close();
                    button1.Text = "Connect";
                    pictureBox1.BackColor = System.Drawing.Color.Red;
                    label2.Text = "Disonnected";
                }
                else
                {
                    serial.PortName = selectedPort;
                    serial.BaudRate = BR;
                    myThread = new Thread(ReadBytes);
                    myThread.IsBackground = true;
                    serial.Open();
                    stopEvent.Reset();
                    myThread.Start();
                    button1.Text = "Disconnect";
                    pictureBox1.BackColor = System.Drawing.Color.Green;
                    label2.Text = $"Connected to {selectedPort}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                pictureBox1.BackColor = System.Drawing.Color.DarkRed;
                label2.Text = $"Error: {ex}";
            }
        }
        private void b_refresh(object sender, EventArgs e)
        {
            logger.Info("Updating the list of COM-port");
            comboBox1.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
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