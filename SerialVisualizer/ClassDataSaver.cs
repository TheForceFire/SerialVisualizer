using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SerialVisualizer
{
    class ClassDataSaver
    {
        public List<byte> start_b = new List<byte>();
        public List<byte> sender_b = new List<byte>();
        public List<byte> data_b = new List<byte>();
        public List<byte> cs_b = new List<byte>();
        public ClassDataSaver(byte start, byte sender, byte data, byte cs) {
            start_b.Add(start);
            sender_b.Add(sender);
            data_b.Add(data);
            cs_b.Add(cs);
        }
    }
}
