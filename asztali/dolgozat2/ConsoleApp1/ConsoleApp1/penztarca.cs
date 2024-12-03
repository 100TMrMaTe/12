using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class money
    {
        public int penztarc;
        public int keszpenz;

        public money(int penztarc, int keszpenz)
        {
            this.penztarc = penztarc;
            this.keszpenz = keszpenz;
        }
        public static money operator -(money a,money b)
        {
            money x = new money(0,0);
            x.penztarc = a.penztarc-b.penztarc;
            return x;



        }

        public override string ToString()
        {
            return $"{penztarc}, {keszpenz}";
        }
    }
}
