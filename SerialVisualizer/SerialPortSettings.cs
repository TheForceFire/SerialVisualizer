using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SerialVisualizer
{
    internal class SerialPortSettings
    {
        [JsonInclude]
        private int BaudRate;
        [JsonInclude]
        private Parity Parity;
        [JsonInclude]
        private int DataBits;
        [JsonInclude]
        private StopBits StopBits;

        public SerialPortSettings() { }

        public SerialPortSettings(int BaudRate, Parity Parity, int DataBits, StopBits StopBits)
        {
            this.BaudRate = BaudRate;
            this.Parity = Parity;
            this.DataBits = DataBits;
            this.StopBits = StopBits;
        }

        public int getBaudRate()
        {
            return BaudRate;
        }
        public void setBaudRate(int value)
        {
            BaudRate = value;
        }

        public Parity getParity()
        {
            return Parity;
        }
        public void setParity(Parity value)
        {
            Parity = value;
        }

        public int getDataBits()
        {
            return DataBits;
        }
        public void setDataBits(int value)
        {
            DataBits = value;
        }

        public StopBits getStopBits()
        {
            return StopBits;
        }
        public void setStopBits(StopBits value)
        {
            StopBits = value;
        }
    }
}
