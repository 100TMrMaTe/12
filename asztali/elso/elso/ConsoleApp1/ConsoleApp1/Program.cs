using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("stream.txt"))
            {
                int a = 1;
                while (a != 0)
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    writer.Write(a+" ");
                    writer.WriteLine(a*a);

                }
            }
            
        }
    }
}
