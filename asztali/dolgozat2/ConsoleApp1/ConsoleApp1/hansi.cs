using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class hansi
    {
        public int penztarc;
        public int keszpenz;

        public hansi(int penztarc, int keszpenz)
        {
            this.penztarc = penztarc;
            this.keszpenz = keszpenz;
        }
        public static hansi operator +(jürgen a, hansi b)
        {
            hansi x = new hansi(0, 0);
            b.keszpenz = a.penztarc;
            a.penztarc = 0;
            x.keszpenz = b.keszpenz;
            return x;
        }








        public override string ToString()
        {
            return $"{penztarc}, {keszpenz}";
        }
    }
}
