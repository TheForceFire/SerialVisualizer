using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using NLog;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SerialVisualizer
{
    internal class SerialWorker
    {
        SerialPort serial;
        Logger logger;
        double[] scales;
        ManualResetEvent stopEvent;
        ClassDataSaverParser classDataSaverParser;
        bool isNeedToWriteLog;
        string path;
        bool firstTimeError = true;
        DataType currentDataType;
        private Action<int, int, double[], double[]> guiCallback;
        Series[] series;
        private CancellationToken token;

        public SerialWorker(SerialPort serial, Logger logger, double[] scales, ManualResetEvent stopEvent, 
            ClassDataSaverParser classDataSaverParser, bool isNeedToWriteLog, string path, bool firstTimeError,
            DataType currentDataType, Action<int, int, double[], double[]> guiCallback, Series[] series)
        {
            this.serial = serial;
            this.logger = logger;
            this.scales = scales;
            this.stopEvent = stopEvent;
            this.classDataSaverParser = classDataSaverParser;
            this.isNeedToWriteLog = isNeedToWriteLog;
            this.path = path;
            this.firstTimeError = firstTimeError;
            this.currentDataType = currentDataType;
            this.guiCallback = guiCallback;
            this.series = series;
        }

        public void updateScales(double[] scales)
        {
            this.scales = scales;
        }
        public void updateIsNeedToWriteLog(bool isNeedToWriteLog)
        {
            this.isNeedToWriteLog=isNeedToWriteLog;
        }
        public void updateFirstTimeError(bool firstTimeError)
        {
            this.firstTimeError = firstTimeError;
        }
        public void updateCurrentDataType(DataType currentDataType)
        {
            this.currentDataType = currentDataType;
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

        public void ReadBytes()
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
                                if (isNeedToWriteLog)
                                {
                                    if (File.Exists(path))
                                    {
                                        File.AppendAllText(path, writeDataLog(dataSaver, currentDataType));
                                    }
                                    else if (firstTimeError)
                                    {
                                        MessageBox.Show("Selected directory has been deleted");
                                        firstTimeError = false;
                                    }
                                }

                                int currentActiveSeries = CountActiveSeries();
                                int lastXcoordinate = GetLastXCoordinate();

                                switch (currentDataType)
                                {
                                    case DataType.Int8:
                                        {
                                            sbyte[] data = dataSaver.ToInt8();
                                            int dataAmount = Math.Min(data.Length, currentActiveSeries);
                                            int xCoordinate = lastXcoordinate + 1;

                                            double[] dataD = new double[dataAmount];
                                            for (int i = 0; i < dataAmount; i++)
                                            {
                                                dataD[i] = data[i];
                                            }
                                            guiCallback.Invoke(dataAmount, xCoordinate, dataD, scales);
                                        }
                                        break;
                                    case DataType.Uint8:
                                        {
                                            byte[] data = dataSaver.ToUInt8();
                                            int dataAmount = Math.Min(data.Length, currentActiveSeries);
                                            int xCoordinate = lastXcoordinate + 1;

                                            double[] dataD = new double[dataAmount];
                                            for (int i = 0; i < dataAmount; i++)
                                            {
                                                dataD[i] = data[i];
                                            }
                                            guiCallback.Invoke(dataAmount, xCoordinate, dataD, scales);
                                        }
                                        break;
                                    case DataType.Int16:
                                        {
                                            short[] data = dataSaver.ToInt16();
                                            int dataAmount = Math.Min(data.Length, currentActiveSeries);
                                            int xCoordinate = lastXcoordinate + 1;

                                            double[] dataD = new double[dataAmount];
                                            for (int i = 0; i < dataAmount; i++)
                                            {
                                                dataD[i] = data[i];
                                            }
                                            guiCallback.Invoke(dataAmount, xCoordinate, dataD, scales);
                                        }
                                        break;
                                    case DataType.Uint16:
                                        {
                                            ushort[] data = dataSaver.ToUInt16();
                                            int dataAmount = Math.Min(data.Length, currentActiveSeries);
                                            int xCoordinate = lastXcoordinate + 1;

                                            double[] dataD = new double[dataAmount];
                                            for (int i = 0; i < dataAmount; i++)
                                            {
                                                dataD[i] = data[i];
                                            }
                                            guiCallback.Invoke(dataAmount, xCoordinate, dataD, scales);
                                        }
                                        break;
                                    case DataType.Int32:
                                        {
                                            int[] data = dataSaver.ToInt32();
                                            int dataAmount = Math.Min(data.Length, currentActiveSeries);
                                            int xCoordinate = lastXcoordinate + 1;

                                            double[] dataD = new double[dataAmount];
                                            for (int i = 0; i < dataAmount; i++)
                                            {
                                                dataD[i] = data[i];
                                            }
                                            guiCallback.Invoke(dataAmount, xCoordinate, dataD, scales);
                                        }
                                        break;
                                    case DataType.Uint32:
                                        {
                                            uint[] data = dataSaver.ToUInt32();
                                            int dataAmount = Math.Min(data.Length, currentActiveSeries);
                                            int xCoordinate = lastXcoordinate + 1;

                                            double[] dataD = new double[dataAmount];
                                            for (int i = 0; i < dataAmount; i++)
                                            {
                                                dataD[i] = data[i];
                                            }
                                            guiCallback.Invoke(dataAmount, xCoordinate, dataD, scales);
                                        }
                                        break;
                                    case DataType.Float:
                                        {
                                            float[] data = dataSaver.ToFloat();
                                            int dataAmount = Math.Min(data.Length, currentActiveSeries);
                                            int xCoordinate = lastXcoordinate + 1;

                                            double[] dataD = new double[dataAmount];
                                            for (int i = 0; i < dataAmount; i++)
                                            {
                                                dataD[i] = data[i];
                                            }
                                            guiCallback.Invoke(dataAmount, xCoordinate, dataD, scales);
                                        }
                                        break;
                                    case DataType.Double:
                                        {
                                            double[] data = dataSaver.ToDouble();
                                            int dataAmount = Math.Min(data.Length, currentActiveSeries);
                                            int xCoordinate = lastXcoordinate + 1;

                                            double[] dataD = new double[dataAmount];
                                            for (int i = 0; i < dataAmount; i++)
                                            {
                                                dataD[i] = data[i];
                                            }
                                            guiCallback.Invoke(dataAmount, xCoordinate, dataD, scales);
                                        }
                                        break;
                                }
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

        private string writeDataLog(ClassDataSaver classDataSaver, DataType dataType)
        {
            string logRow = "";
            logRow += Encoding.ASCII.GetString(classDataSaver.start_b.ToArray()) + ";";
            if (classDataSaver.sender_b.Count != 0)
            {
                logRow += Encoding.ASCII.GetString(classDataSaver.sender_b.ToArray()) + ";";
            }
            else
            {
                logRow += "null;";
            }

            int currentActiveSeries = CountActiveSeries();

            switch (dataType)
            {
                case DataType.Int8:
                    {
                        sbyte[] data = classDataSaver.ToInt8();
                        int dataAmount = Math.Min(data.Length, currentActiveSeries);

                        for (int i = 0; i < dataAmount; i++)
                        {
                            logRow += data[i].ToString() + ";";
                        }
                    }
                    break;
                case DataType.Uint8:
                    {
                        byte[] data = classDataSaver.ToUInt8();
                        int dataAmount = Math.Min(data.Length, currentActiveSeries);

                        for (int i = 0; i < dataAmount; i++)
                        {
                            logRow += data[i].ToString() + ";";
                        }
                    }
                    break;
                case DataType.Int16:
                    {
                        short[] data = classDataSaver.ToInt16();
                        int dataAmount = Math.Min(data.Length, currentActiveSeries);

                        for (int i = 0; i < dataAmount; i++)
                        {
                            logRow += data[i].ToString() + ";";
                        }
                    }
                    break;
                case DataType.Uint16:
                    {
                        ushort[] data = classDataSaver.ToUInt16();
                        int dataAmount = Math.Min(data.Length, currentActiveSeries);

                        for (int i = 0; i < dataAmount; i++)
                        {
                            logRow += data[i].ToString() + ";";
                        }
                    }
                    break;

                case DataType.Int32:
                    {
                        int[] data = classDataSaver.ToInt32();
                        int dataAmount = Math.Min(data.Length, currentActiveSeries);

                        for (int i = 0; i < dataAmount; i++)
                        {
                            logRow += data[i].ToString() + ";";
                        }
                    }
                    break;
                case DataType.Uint32:
                    {
                        uint[] data = classDataSaver.ToUInt32();
                        int dataAmount = Math.Min(data.Length, currentActiveSeries);

                        for (int i = 0; i < dataAmount; i++)
                        {
                            logRow += data[i].ToString() + ";";
                        }
                    }
                    break;
                case DataType.Float:
                    {
                        float[] data = classDataSaver.ToFloat();
                        int dataAmount = Math.Min(data.Length, currentActiveSeries);

                        for (int i = 0; i < dataAmount; i++)
                        {
                            logRow += data[i].ToString() + ";";
                        }
                    }
                    break;
                case DataType.Double:
                    {
                        double[] data = classDataSaver.ToDouble();
                        int dataAmount = Math.Min(data.Length, currentActiveSeries);

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


    }


}
