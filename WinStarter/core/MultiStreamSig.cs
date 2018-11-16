using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinStarter.core
{
    class MultiStreamSig
    {
        List<StreamSig> Sigs;
        List<string> Descriptions;

        public MultiStreamSig()
        {
            Sigs = new List<StreamSig>();
        }

        public void Join(StreamSig sig, string description)
        {
            Sigs.Add(sig);
            Descriptions.Add(description);
        }

    }
}
