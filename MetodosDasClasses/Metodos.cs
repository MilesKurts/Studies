using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {
        //Métodos Simples
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, seja bem vindo.");
        }
        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("A soma é: "+resultado);

        }
        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine($"Meu nome {nome} e tenho {idade} de idade");
        }
    }
}
