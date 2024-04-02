using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01E05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que ano voce nasceu?");
            int nasc;
            int.TryParse(Console.ReadLine(), out nasc);
            int atual = DateTime.Now.Year;
            int idade = atual - nasc;
            Console.WriteLine($"Voce tem {idade} anos de idade");
            Console.ReadKey();

        }
    }
}
