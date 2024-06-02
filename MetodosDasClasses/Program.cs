using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metodos m = new Metodos();
            //m.Cumprimentar();
            //m.Somar(10, 5);
            //m.Apresentar("Gabriel", 35);

            //int valor1 = 100;
            //int valor2 = 100;

            //m.AumentarValor(valor1);
            //m.AumentarRef(ref valor2);

            //Console.WriteLine($"Valor 1 :{valor1}");
            //Console.WriteLine($"Valor 2 :{valor2}(Por referencia o valor da variavel altera tambem!)");
            //string nomeCompleto = m.MontaNome("Gabriel", "Artigas");
            //int codigoChar = m.CodigoChar('a');
            //double pi = m.ValorPi();

//            Console.WriteLine(nomeCompleto);
  //          Console.WriteLine(codigoChar);
    //        Console.WriteLine(pi);

            Console.ReadKey();

        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é "+nome+" e tenho "+idade+ " de idade.");
        }

        //Passagem de parametro por valor
        
    }
}
