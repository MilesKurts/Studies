using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            Console.WriteLine("digite um numero: ");
            int.TryParse(Console.ReadLine(), out n1);
            Console.WriteLine("Digite outro valor: ");
            int.TryParse(Console.ReadLine(), out n2);
            Console.WriteLine($"{n1} = {n2}? {n1==n2}");
            Console.WriteLine($"{n1} != {n2}={n1!=n2}");
            Console.WriteLine($"{n1} > {n2}={n1 > n2}");
            Console.WriteLine($"{n1} < {n2}={n1 < n2}");
            Console.WriteLine($"{n1} >= {n2}={n1 >= n2}");
            Console.WriteLine($"{n1} <= {n2}={n1 <= n2}");
            Console.ReadKey();
        }
    }
}
