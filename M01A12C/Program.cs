using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A12C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sal = 0;
            Console.WriteLine("qual é o seu salário? ");
            float.TryParse(Console.ReadLine(), out sal);
            Console.WriteLine($"Você ganha {sal:C}");
            Console.ReadKey();
        }
    }
}
