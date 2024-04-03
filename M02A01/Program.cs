using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXEMPLO DE OP ARITMÉTICOS
            int op1, op2 = 0;

            //entrada de dados//
            Console.WriteLine("Digite o primeiro numero: ");
            int.TryParse(Console.ReadLine(), out op1);

            Console.WriteLine("Digite o Segundo numero: ");
            int.TryParse(Console.ReadLine(), out op2);

            //calculos//
            Console.WriteLine($"Calculando +{op1} = {+ op1}");
            Console.WriteLine($"Calculando -{op2} = {-op2}");
            Console.WriteLine($"Calculando {op1} + {op2} = {op1+ op2}");
            Console.WriteLine($"Calculando {op1}-{op2}={op1-op2}");
            Console.WriteLine($"Calculando {op1}x{op2}={op1 * op2}");
            Console.WriteLine($"Calculando {op1}/{op2}={op1/op2}/divisão inteira");
            Console.WriteLine($"Calculando {op1} % {op2}={op1%op2} /resto da divisão inteira");
            Console.ReadKey();
        }
    }
}
