using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak_nev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader nevek = new StreamReader("nevek");

 
            List<string> nev = new List<string>();
             string sor=nevek.ReadLine().Trim();
             while (sor != null) { 
                nev.Add(sor);
             }
            for (int i = 0; i < nev.Count; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
