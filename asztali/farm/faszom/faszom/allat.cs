using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace faszom
{
    internal class allat
    {
        public string nev;
        public int suly;
        public int ara;

        public allat(string nev, int suly, int ara)
        {
            this.nev = nev;
            this.suly = suly;
            this.ara = ara;
        }
    }
}