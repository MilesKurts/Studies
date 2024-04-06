using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A10A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano;
            int anoAt = DateTime.Now.Year;
            Console.WriteLine("Que ano voce nasceu? ");
            int.TryParse(Console.ReadLine(), out ano);
            int idade = anoAt-ano;
            if (idade<= 15) {
                Console.WriteLine("Digite uma idade valida!");
            }
            else if (idade <=18)
            {
                Console.WriteLine("O seu voto não é obrigatorio");
            }
            else if (idade < 65)
            {
                Console.WriteLine("O seu voto é obrigatório");
            }
            else
            {
                Console.WriteLine("O seu voto não é obrigatório");
            }
            Console.ReadKey();
        }
    }
}
