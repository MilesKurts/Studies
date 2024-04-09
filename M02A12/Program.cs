using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Digite um numero: ");
            int.TryParse(Console.ReadLine(), out n);

            Console.WriteLine($"O numero {n} corresponde a {Convert.ToString(n, toBase: 2)} em binario");
            Console.WriteLine($"O numero {n} corresponde a {Convert.ToString(n, toBase: 8)} em binario");
            Console.WriteLine($"O numero {n} corresponde a {Convert.ToString(n, toBase: 16)} em binario");

            Console.ReadLine();
        }
    }
}
