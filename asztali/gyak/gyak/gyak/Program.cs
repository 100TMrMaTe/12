using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> szavak = new List<string>();
            StreamReader szoveg = new StreamReader("szoveg.txt");
                
            szoveg.Close();
        }
    }
}
