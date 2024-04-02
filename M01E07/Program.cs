using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M01E07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ini, fim;
            Console.Write("Inicio: ");
            int.TryParse(Console.ReadLine(), out ini);
            Console.Write("Fim: ");
            int.TryParse(Console.ReadLine(), out fim);

            Console.SetCursorPosition(0,4);
            Console.WriteLine("Sorteando...");
            Thread.Sleep(1000);

            Random gerador =  new Random();
            int num = gerador.Next(ini, fim+1);
            Console.SetCursorPosition(0,4);
            Console.Write($"Acabei de sorteear o valor de {num}");
            Console.ReadKey();
        }
    }
}
