using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class kutya
    {
        public string nev;
        public void ugat() 
        {
            Console.WriteLine("wau");
        }
        private float _suly;
        public float suly
        {
            get
            {
                return _suly;
            }
            set 
            {
                _suly = Math.Abs(value);
            }
        }
    }
}
