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
            Console.WriteLine("Variable conversion - casting");
            Console.ReadKey();
            Console.WriteLine("Implicit casting byte->short->int->long->float->double");
            Console.ReadKey();
        }
    }
}
