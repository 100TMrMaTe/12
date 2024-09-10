using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader vezeteknev = new StreamReader("vnevek.txt");
            StreamReader keresztnev = new StreamReader("nevek.txt");
            List<string> fiu = new List<string>();
            List<string> vez = new List<string>();
            while (vezeteknev.EndOfStream != true)
            {
                string fiu1=vezeteknev.ReadLine();
                string vez1 = vezeteknev.ReadLine();
                fiu.Add(fiu1);
                vez.Add(vez1);
            }
            vezeteknev.Close();
            keresztnev.Close();
            StreamWriter ir = new StreamWriter("nevek1.txt");
            Random rand= new Random();
            for (int i = 0; i < fiu.Count; i++)
            {
                int szam = rand.Next(0, 101);
                ir.WriteLine(fiu[szam]+" "+vez[szam]);
            }
            ir.Close();

        }
    }
}
