using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool p = true;
            bool q = false;

            Console.WriteLine($"não(~) {p}");
            Console.WriteLine($"{p} e {q} = {p && q}");
            Console.WriteLine($"{p} ou {q} = {p || q}");
            Console.ReadKey();
        }
    }
}
