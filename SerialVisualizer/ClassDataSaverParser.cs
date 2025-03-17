using System;
using System.Collections.Generic;
using System.Linq;

namespace SerialVisualizer
{
    internal class ClassDataSaverParser
    {
        public byte[] frameStart;
        public ReadingType readingType;
        public int addressLength;
        public bool isAddressEnable;
        public bool isChecksumEnable;

        public ClassDataSaverParser(ReadingType readingType, int addressLength, bool isAddressEnable, bool isChecksumEnable)
        {
            frameStart = new byte[0];
            this.readingType = readingType;
            this.addressLength = addressLength;
            this.isAddressEnable = isAddressEnable;
            this.isChecksumEnable = isChecksumEnable;
        }

        public ClassDataSaver Parse(byte[] bytes)
        {
            int startIndex = FindFrameStart(bytes);
            if(startIndex == -1)
            {
                return null;
            }
            List<byte> frameStartList = frameStart.ToList();
            int currentIndex = startIndex + frameStart.Length;

            List<byte> addressList = new List<byte>();
            if (isAddressEnable)
            {
                addressList = FindAddress(bytes, currentIndex);
                if(addressList == null)
                {
                    return null;
                }
                currentIndex += addressLength;
            }

            int dataStartIndex = currentIndex;
            int dataEndIndex = isChecksumEnable ? bytes.Length - 2 : bytes.Length - 1;


            byte[] data = new byte[dataEndIndex - dataStartIndex + 1];
            Array.Copy(bytes, currentIndex, data, 0, data.Length);
            if (readingType == ReadingType.LittleEndian)
            {
                data = ConvertEndian(data);
            }
            List<byte> dataList = data.ToList();


            List<byte> checksumList = new List<byte>();
            if (isChecksumEnable)
            {
                checksumList.Add(bytes[bytes.Length - 1]);
            }

            ClassDataSaver classData = new ClassDataSaver(frameStartList, addressList, dataList, checksumList);
            return classData;
        }

        private List<byte> FindAddress(byte[] bytes, int currentIndex)
        {
            if(addressLength == -1)
            {
                return null;
            }

            List<byte> addressList = new List<byte>();

            for(int i = currentIndex; i < currentIndex + addressLength; i++)
            {
                if(i > bytes.Length)
                {
                    return null;
                }
                addressList.Add(bytes[i]);
            }

            return addressList;
        }

        private int FindFrameStart(byte[] bytes)
        {
            if (frameStart == null)
            {
                return -1;
            }

            if (frameStart.Length == 0 || bytes.Length < frameStart.Length)
            {
                return -1;
            }

            for (int i = 0; i <= bytes.Length - frameStart.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < frameStart.Length; j++)
                {
                    if (bytes[i + j] != frameStart[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    return i;
                }
            }
            return -1;
        }

        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        public byte[] ConvertEndian(byte[] data)
        {
            byte[] result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++) {
                result[i] = data[data.Length - 1 - i];
            }
            return result;
        }
    }
}

public enum ReadingType
{
    LittleEndian,
    BigEndian
}
