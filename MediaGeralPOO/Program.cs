using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "### Media Geral dos alunos ###";

            Console.WriteLine("Quantos alunos: ");
            int nalunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] alunos = new Aluno[nalunos];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write($"Aluno # {i + 1} Nome..:");
            }
        }
    }
}
