using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text.Json.Serialization;

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


        public static byte[] GenerateCommand(byte[] header, byte[] address, byte[] payload, bool useCrc)
        {
            List<byte> packet = new List<byte>();


            if (header != null) packet.AddRange(header);
            if (address != null) packet.AddRange(address);
            if (payload != null) packet.AddRange(payload);


            if (useCrc)
            {
                byte crc = CalculateCRC8(packet.ToArray());
                packet.Add(crc);
            }

            return packet.ToArray();
        }

        private static byte CalculateCRC8(byte[] data)
        {
            byte crc = 0xFF;
            for (int i = 0; i < data.Length; i++)
            {
                crc ^= data[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x80) != 0)
                        crc = (byte)((crc << 1) ^ 0x31);
                    else
                        crc <<= 1;
                }
            }
            return crc;
        }
        public int getBaudRate() => BaudRate;
        public void setBaudRate(int value) => BaudRate = value;

        public Parity getParity() => Parity;
        public void setParity(Parity value) => Parity = value;

        public int getDataBits() => DataBits;
        public void setDataBits(int value) => DataBits = value;

        public StopBits getStopBits() => StopBits;
        public void setStopBits(StopBits value) => StopBits = value;
    }
}
