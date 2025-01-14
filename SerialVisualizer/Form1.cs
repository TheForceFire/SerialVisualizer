using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace SerialVisualizer
{
    public partial class Form1 : Form
    {
        SerialPort serial;
        Thread myThread;
        bool cont = false;
        private ManualResetEvent stopEvent = new ManualResetEvent(false);
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
        }

        private void b_connect(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem?.ToString(); // Обработка null
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
                    if (myThread != null && myThread.IsAlive) myThread.Join(); // Проверка на null и IsAlive
                    serial.Close();
                    button1.Text = "Connect";
                    label1.Visible = false;
                }
                else
                {
                    myThread = new Thread(ReadBytes);
                    myThread.IsBackground = true; // Важно для корректного завершения приложения
                    serial.Open();
                    cont = true;
                    stopEvent.Reset();
                    myThread.Start();
                    button1.Text = "Disconnect";
                    label1.Visible = false;
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}"); // Используем MessageBox для вывода ошибок
            }
        }
        private void b_refresh(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }
        private void CB_SIC(object sender, EventArgs e)
        {
            // null
        }
        private void ReadBytes()
        {
            while (cont)
            {
                if (stopEvent.WaitOne(0)) // Проверка события без блокировки
                {
                    break;
                }
                try
                {
                    int bytesToRead = serial.BytesToRead;
                    if (bytesToRead > 0) // Проверка на наличие данных
                    {
                        byte[] bytes = new byte[bytesToRead];
                        int bytesRead = serial.Read(bytes, 0, bytesToRead); // Используем bytesRead для проверки
                        if (bytesRead > 0)
                        {
                            //Обработка данных - нужно убедиться, что вызывается на UI-потоке для WinForms
                            this.BeginInvoke(new Action(() =>
                            {
                                Series series = chart1.Series[0];
                                series.Points.AddXY(series.Points.Count + 1, bytes[0]);
                            }));

                        }
                    }
                }
                catch (InvalidOperationException) { }
                catch (Exception ex)
                {
                    cont = false;
                    break;
                }
            }
        }
    }
}