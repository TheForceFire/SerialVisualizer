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
        public ClassDataSaver(List<byte> start_b, List<byte> sender_b, List<byte> data_b, List<byte> cs_b) {
            this.start_b = start_b;
            this.sender_b = sender_b;
            this.data_b = data_b;
            this.cs_b = cs_b;
        }
    }
}
