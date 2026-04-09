using System;
using System.Collections.Generic;

namespace SerialVisualizer
{
    public static class CommandGenerator
    {
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
    }
}