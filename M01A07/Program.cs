using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conversão implicita
            /*int a = 8;
            float b = a;
            */

            /*
             * conversão explicita
            float a = 8;
            int b = (int)a;

            */

            float a = 8.502f;
            int b = Convert.ToInt16(a);
            Console.WriteLine("O valor de a é " + a + "Do tipo " + a.GetType());
            Console.WriteLine("O valor de b é " + b + "Do tipo " + b.GetType());
            Console.ReadKey();
        }
    }
}
