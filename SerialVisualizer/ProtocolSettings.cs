using System.IO.Ports;
using System.Text.Json.Serialization;

namespace SerialVisualizer
{
    internal class ProtocolSettings
    {
        [JsonInclude]
        private string frameStart;
        [JsonInclude]
        private bool endianess;
        [JsonInclude]
        private int addrLength;
        [JsonInclude]
        private bool chckSum;

        public ProtocolSettings() { }

        public ProtocolSettings(string frameStart, bool endianess, int addrLength, bool chckSum) {
            this.frameStart = frameStart;
            this.endianess = endianess;
            this.addrLength = addrLength;
            this.chckSum = chckSum;
        }

        public string getFrameStart() { return frameStart; }
        public void setFrameStart(string frameStart) { this.frameStart = frameStart; }
        public bool getEndianess() { return endianess; }
        public void setEndianess(bool endianess) { this.endianess = endianess; }
        public int getAddrLength() { return addrLength; }
        public void setAddrLength(int addrLength) { this.addrLength = addrLength; }
        public bool getChckSum() { return chckSum; }
        public void setChckSum(bool chckSum) { this.chckSum = chckSum; }

    }
}
