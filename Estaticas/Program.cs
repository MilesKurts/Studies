using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matematica.taxa = 10;

            //            int valor1 = Matematica.Adicionar(200);
            //          Console.WriteLine(valor1+"\n");
            //        int valor2 = Matematica.Diminuir(200);
            //      Console.WriteLine(valor2);//

            Pessoa.maioridade = 21;
            Pessoa p1 = new Pessoa();
            p1.nome = "Gabriel";
            p1.idade = Pessoa.CalcularIdade(1985);
            Console.WriteLine(p1.nome +"\n"+ p1.idade);
            Console.ReadKey();
        }
    }
}
