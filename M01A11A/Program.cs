using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M01A11A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            Console.Write("hoje é o dia "+dia); 
            Thread.Sleep(4000);
            Console.Write(" Do mês " + mes); 
            Thread.Sleep(4000);
            Console.Write(" Do ano "+ano);
            Thread.Sleep(4000);
            Console.Write(" Thanks");
            Thread.Sleep(1200);
        }
    }
}
