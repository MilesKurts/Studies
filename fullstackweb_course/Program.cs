using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullstackweb_course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name}, it's a pleasure knowing you!");
            Console.ReadKey();
            Console.WriteLine("Let's know about Variable conversion - casting");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("Implicit casting byte->short->int->long->float->double");
            Console.WriteLine("byte cars_byte = 4;");
            Console.WriteLine("short cars_short = cars_byte;");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("Explicit casting");
            Console.WriteLine("double x = 24;\nint y;\ny = (int)x;");
            Console.WriteLine("double x =24;\nint y;\ny = Convert.ToInt32(x);");
            Console.ReadKey(); 
        }
    }
}
