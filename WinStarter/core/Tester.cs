using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinStarter.core
{
    class Tester
    {
        StreamSig sig;

        public void test()
        {
            sig = new StreamSig();
            sig.Sps = 500;
            sig.DataLen = 1000;
            sig.StartTime = 1;
            sig.StopTime = 1;

            var multiSig = new MultiStreamSig();
        }
    }
}
