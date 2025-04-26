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

        public sbyte[] ToInt8() {
            List<sbyte> int8Data = new List<sbyte>();
            foreach (byte b in data_b)
            {
                sbyte sbyteValue = (sbyte) b;
                int8Data.Add(sbyteValue);
            }
            return int8Data.ToArray();
        }

        public byte[] ToUInt8()
        {
            return data_b.ToArray();
        }

        public short[] ToInt16() {
            List<short> int16Data = new List<short>();
            if (data_b.Count % 2 != 0)
            {
                data_b.Add(0);
            }
            for (int i = 0; i < data_b.Count; i += 2)
            {
                if (i + 1 < data_b.Count)
                {
                    int16Data.Add(BitConverter.ToInt16(data_b.ToArray(), i));
                }
            }
            return int16Data.ToArray();
        }

        public ushort[] ToUInt16() {
            List<ushort> uint16Data = new List<ushort>();
            if (data_b.Count % 2 != 0)
            {
                data_b.Add(0);
            }
            for (int i = 0; i < data_b.Count; i += 2)
            {
                if (i + 1 < data_b.Count)
                {
                    uint16Data.Add(BitConverter.ToUInt16(data_b.ToArray(), i));
                }
            }
            return uint16Data.ToArray();
        }

        public int[] ToInt32()
        {
            List<int> int32Data = new List<int>();
            while (data_b.Count % 4 != 0)
            {
                data_b.Add(0);
            }
            for (int i = 0; i < data_b.Count; i += 4)
            {
                if (i + 3 < data_b.Count)
                {
                    int32Data.Add(BitConverter.ToInt32(data_b.ToArray(), i));
                }
            }
            return int32Data.ToArray();
        }

        public uint[] ToUInt32()
        {
            List<uint> uint32Data = new List<uint>();
            while (data_b.Count % 4 != 0)
            {
                data_b.Add(0);
            }
            for (int i = 0; i < data_b.Count; i += 4)
            {
                if (i + 3 < data_b.Count)
                {
                    uint32Data.Add(BitConverter.ToUInt32(data_b.ToArray(), i));
                }
            }
            return uint32Data.ToArray();
        }

        public float[] ToFloat()
        {
            List<float> floatData = new List<float>();
            while (data_b.Count % 4 != 0)
            {
                data_b.Add(0);
            }
            for (int i = 0; i < data_b.Count; i += 4)
            {
                if (i + 3 < data_b.Count)
                {
                    floatData.Add(BitConverter.ToSingle(data_b.ToArray(), i));
                }
            }
            return floatData.ToArray();
        }

        public double[] ToDouble()
        {
            List<double> doubleData = new List<double>();
            while (data_b.Count % 8 != 0)
            {
                data_b.Add(0);
            }
            for (int i = 0; i < data_b.Count; i += 8)
            {
                if (i + 7 < data_b.Count)
                {
                    doubleData.Add(BitConverter.ToDouble(data_b.ToArray(), i));
                }
            }
            return doubleData.ToArray();
        }
    }
}
