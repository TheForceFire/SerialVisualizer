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
using System.Collections.Concurrent;

namespace SerialVisualizer
{
    internal class SerialWorker
    {
        SerialPort serial;
        Logger logger;

        ManualResetEvent stopEvent;

        private CancellationToken token;

        private BlockingCollection<byte[]> readQueue = new BlockingCollection<byte[]>();

        public SerialWorker(SerialPort serial, BlockingCollection<byte[]> readQueue, Logger logger, ManualResetEvent stopEvent)
        {
            this.serial = serial;
            this.readQueue = readQueue;
            this.logger = logger;
            this.stopEvent = stopEvent;
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
                            readQueue.Add(bytes);
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
