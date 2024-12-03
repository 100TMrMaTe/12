using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class kömuves
    {
        public int penztarc;
        public int keszpenz;

        public kömuves(int penztarc, int keszpenz)
        {
            this.penztarc = penztarc;
            this.keszpenz = keszpenz;
        }

        public static kömuves operator +(money a,kömuves b)
        {
            return new kömuves(b.penztarc + a.penztarc, 0);
        }
    }
}
