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
                string nome = Console.ReadLine();

                Console.WriteLine($"Aluno #{i+1} provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                Console.WriteLine($"Insira as notas do aluno {nome}");
                alunos[i].InserirNotas();
            }
            Console.Clear();

            double mediaGeral = 0;

            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Aluno {aluno.Nome}");
                Console.WriteLine($"Media {aluno.Media}");
                Console.WriteLine();
                mediaGeral += aluno.Media;
            }
            double resultadoFinal = mediaGeral / alunos.Length;
            Console.WriteLine($"Média geral dos alunos: {resultadoFinal}");
            Console.ReadKey();
        }
    }
}
