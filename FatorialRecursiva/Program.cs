using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fatorial de : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"O fatorial de {num} é {Fatorial(num)}");
            Console.ReadKey();
        }
        static int Fatorial(int num)
        {
            if (num <= 0)
            {
                return 1;
            }
            return num* Fatorial(num - 1);
        }
    }
}
