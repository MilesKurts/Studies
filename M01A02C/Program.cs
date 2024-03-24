using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A02C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Miles\tKurts");
            Console.WriteLine("Miles\bKurts");
            Console.WriteLine("Miles\aKurts");
            Console.WriteLine("Miless\rKurts");
            Console.WriteLine("Miles\\Kurts");
            Console.WriteLine("Miles\"Kurts");
            Console.ReadKey();
        }
    }
}
