using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float altura = 0f;
            Console.WriteLine("Qual sua altura? ");
            float.TryParse(Console.ReadLine(), out altura);
            string status = (altura <= 1.70)?"baixa":"alta";
            Console.WriteLine($"{status}");
            Console.ReadKey(); 
        }
    }
}
