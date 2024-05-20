using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace null_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? num = null;

            int x = num ??900;

            Console.WriteLine($"A variavel tem valor nulo? {num is null}");
            Console.WriteLine($"A variavel tem valor? {num.HasValue}");
            Console.WriteLine($"a VARIÁVEL X TEM VALOR? {x} ");
            Console.ReadKey();
        }
    }
}
