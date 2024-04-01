using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Muito prazer em te conhecer "+nome);
            Console.ReadKey();
        }
    }
}
