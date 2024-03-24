using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A02D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(50, 0);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello, My Friend");
            Console.ReadKey();
            Console.ResetColor();  
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("My Name is Khonshu");
            Console.ReadKey();
        }
    }
}
