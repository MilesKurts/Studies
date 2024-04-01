using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A12AA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}! tudo bem?");

            int day = DateTime.Now.Day;
            int mounth = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            Console.WriteLine($"Today is {day} of {mounth} of {year}");
            Console.ReadKey();
        }
    }
}
