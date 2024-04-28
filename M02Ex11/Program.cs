using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op1 = 35;
            int op2 = 4;

            Console.WriteLine($"O valor de {op1} & {op2} é {op1 & op2}");
            Console.WriteLine($"O valor de {op1} | {op2} é {op1 | op2}");
            Console.WriteLine($"O valor de {op1} ^ {op2} é {op1 ^ op2}");
            Console.WriteLine($"O valor de {op1} ~ {op2} é {~op1} e {~op2}");
            Console.WriteLine($"O valor de {op1} >> {op2} é {op1 >> op2}");
            Console.WriteLine($"O valor de {op1} << {op2} é {op1 << op2}");
            Console.ReadKey();
        }
    }
}
