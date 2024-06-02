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
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine($"O valor final (por valor) é: {valor}");
        }
        //Passagem de parametro por referencia
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine($"O valor final (por referencia ) é: {valor}");
        }
        
        //metodo com retorno de valores

        public string MontaNome(string nome, string sobrenome)
        {
            string nomeCompleto = nome + " " + sobrenome;
            return nomeCompleto;
        }
        public int CodigoChar(char caractere)
        {
            int codigo = caractere;
            return codigo;
        }
        public double ValorPi()
        {
            return 3.1415;
        }

        //sobrecarga de metodos
        public void Cumprimentar(string nome)
        {
            Console.WriteLine("Olá, " + nome);
        }
        public void Cumprimentar(string nome, int hora)
        {
            string mensagem = hora <12? "Bom dia " + nome : "Boa Tarde "+nome;
            Console.WriteLine(mensagem );
        }
    }
}
