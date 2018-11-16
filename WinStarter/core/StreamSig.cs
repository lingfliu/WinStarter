using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinStarter.core
{
    class StreamSig
    {
        public double[] Data { get; set; }
        public int DataLen { get; set; }

        public int Sps { get; set; }
        public long StartTime { get; set; }
        public long StopTime { get; set; }

        public StreamSig()
        {
        }

        public StreamSig[] split() {
            return null;
        }

        public static StreamSig merge() {
            return null;
        }
    }
} 