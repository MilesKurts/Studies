using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A11A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Digite um numero inteiro: ");
            int.TryParse(Console.ReadLine(), out num);


            Console.WriteLine($"O número {num:D} que voce digitou é {((num % 2 == 0) ?"Par":"impar")}");
            Console.ReadKey();
        }
    }
}
