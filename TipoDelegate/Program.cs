using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Program
    {
        delegate void Operecao(int num1, int num2);
        static void Main(string[] args)
        {
            Matematica m = new Matematica();

            Operecao conta = null;

            conta += m.Somar;
            conta += m.Subtrair;
            conta += m.Multiplicar;
            conta += m.Dividir;

            conta(10, 2);
            Console.ReadKey();
        }
    }
}
