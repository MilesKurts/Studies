using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A13A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Gustavo";
            float sal = 555.7556f;
            int idade = 22;
            Console.WriteLine($"{nome, 10} tem {idade, -5:D3} Ganha {sal,20:C3} por mes");
            Console.ReadKey();
        }
    }
}
