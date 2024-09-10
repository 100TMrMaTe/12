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
        static void Main(string[] args, Random random1)
        {
            List<string> list = new List<string>();
            StreamReader nevek = new StreamReader("nevek.txt");


            while (!nevek.EndOfStream) {
                list.Add(nevek.ReadLine());
            }
            nevek.Close();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            
        }
        
    }
}
