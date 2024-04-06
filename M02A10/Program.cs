using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02A10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1 = 0f;
            float n2 = 0f;
            Console.WriteLine("Primeira nota do aluno: ");
            float.TryParse(Console.ReadLine(), out n1);
            Console.WriteLine("Segunda nota do aluno: ");
            float.TryParse(Console.ReadLine(), out n2);

            float m = (n1 + n2) / 2;

            bool sit01 = m >= 0.0 && m <= 4.0;
            bool sit02 = m >= 4.0 && m <=7.0;
            bool sit03 = m >= 7.0 && m <=10.0;



            Console.WriteLine($"A média do aluno é: {m}");
            Console.WriteLine($"Aluno esta reprovado? {sit01}");
            Console.WriteLine($"Aluno esta de recuperação? {sit02}");
            Console.WriteLine($"Aluno passou? {sit03}");
            Console.ReadKey();
        }
    }
}
