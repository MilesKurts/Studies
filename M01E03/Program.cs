using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01E03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero Real");
            float num;
            float.TryParse(Console.ReadLine(), out num);

            int n1 = (int) num;
            int n2 = Convert.ToInt16(num);

            Console.WriteLine($"Voce digitou o numero {num:N}");
            Console.WriteLine($"A parte inteira de num é {n1}");
            Console.WriteLine($"Arredondando fica {n2}");

            Console.ReadKey();
        }
    }
}
