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
            Metodos m = new Metodos();
            m.Cumprimentar();
            m.Somar(10, 5);
            m.Apresentar("Gabriel", 35);
            Console.ReadKey();

        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é "+nome+" e tenho "+idade+ " de idade.");
        }
    }
}
