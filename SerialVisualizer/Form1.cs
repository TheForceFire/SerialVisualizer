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
        SerialPort serial;
        Thread myThread;
        bool cont = false;
        ManualResetEvent stopEvent = new ManualResetEvent(false);
        Series series;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public Form1()
        {
            logger.Info("Инициализация");
            InitializeComponent();
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
            series = chart1.Series[0];
            series.LegendText = "Данные";
        }

        private void b_connect(object sender, EventArgs e)
        {
            logger.Info("Нажата кнопка 'Connect/Disconnect'");
            string selectedState = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedState))
            {
                MessageBox.Show("Выберите COM-порт");
                return;
            }

            serial = new SerialPort(selectedState);
            serial.BaudRate = 9600;

            try
            {
                if (serial.IsOpen)
                {
                    cont = false;
                    stopEvent.Set();
                    if (myThread != null && myThread.IsAlive) myThread.Join();
                    serial.Close();
                    button1.Text = "Connect";
                    label1.Visible = false;
                }
                else
                {
                    myThread = new Thread(ReadBytes);
                    myThread.IsBackground = true;
                    serial.Open();
                    cont = true;
                    stopEvent.Reset();
                    myThread.Start();
                    button1.Text = "Disconnect";
                    label1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        private void b_refresh(object sender, EventArgs e)
        {
            logger.Info("Обновление списка COM-портов");
            comboBox1.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }
        private void CB_SIC(object sender, EventArgs e)
        {
            logger.Debug("Произошел выбор COM-порта");
        }
        private void ReadBytes()
        {
            logger.Info("Поток чтения запущен");
            while (cont && serial.IsOpen)
            {
                if (stopEvent.WaitOne(0))
                {
                    break;
                }
                try
                {
                    int bytesToRead = serial.BytesToRead;
                    if (bytesToRead > 0)
                    {
                        byte[] bytes = new byte[bytesToRead];
                        int bytesRead = serial.Read(bytes, 0, bytesToRead);
                        logger.Debug($"Получено {bytesRead} байт(а): {BitConverter.ToString(bytes)}");
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
                    logger.Error(ex, "InvalidOperationException произошла");
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "Произошла ошибка в потоке чтения");
                    cont = false;
                    break;
                }
            }
            logger.Info("Поток чтения завершен");
        }
    }
}