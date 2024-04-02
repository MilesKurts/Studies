using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M01E01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("MEU ");
            Console.ResetColor();
            
            Console.BackgroundColor= ConsoleColor.Yellow;
            Console.ForegroundColor= ConsoleColor.Green;
            Thread.Sleep(1000);
            Console.Write("BRASIL ");
            Console.ResetColor();

            Thread.Sleep(1000);
            Console.Write("BRASILEIRO!");
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
