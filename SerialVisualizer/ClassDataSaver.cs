using System;
using System.Collections.Generic;

namespace SerialVisualizer
{
    class ClassDataSaver
    {
        public List<byte> start_b = new List<byte>();
        public List<byte> sender_b = new List<byte>();
        public List<byte> data_b = new List<byte>();
        public List<byte> cs_b = new List<byte>();
        public ClassDataSaver(List<byte> start_b, List<byte> sender_b, List<byte> data_b, List<byte> cs_b) {
            this.start_b = start_b;
            this.sender_b = sender_b;
            this.data_b = data_b;
            this.cs_b = cs_b;
        }
        public char[] ToChar() {
            List<char> charData = new List<char>();
            for (int i = 0; i != data_b.Count; i+=2)
            {
                if (i + 1 < data_b.Count)
                {
                    charData.Add(BitConverter.ToChar(data_b.ToArray(), i));
                }
            }
            return charData.ToArray();
        }
        public sbyte[] ToInt8() {
            List<sbyte> int8Data = new List<sbyte>();
            foreach (byte b in data_b)
            {
                sbyte sbyteValue = (sbyte) b;
                int8Data.Add(sbyteValue);
            }
            return int8Data.ToArray();
        }
        public short[] ToInt16() {
            List<short> int16Data = new List<short>();
            for (int i = 0; i != data_b.Count; i += 2)
            {
                if (i + 1 < data_b.Count)
                {
                    int16Data.Add(BitConverter.ToInt16(data_b.ToArray(), i));
                }
            }
            return int16Data.ToArray();
        }
        public byte[] ToUInt8() {
            return data_b.ToArray();
        }
        public ushort[] ToUInt16() {
            List<ushort> uint16Data = new List<ushort>();
            for (int i = 0; i != data_b.Count; i += 2)
            {
                if (i + 1 < data_b.Count)
                {
                    uint16Data.Add(BitConverter.ToUInt16(data_b.ToArray(), i));
                }
            }
            return uint16Data.ToArray();
        }
    }
}
