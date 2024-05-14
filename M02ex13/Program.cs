using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lotação = 10;
            int total = 0;

            int grupo = 0;
            Console.Write("Qauntas pessoas chegaram?");
            int.TryParse(Console.ReadLine(), out grupo);
            total += grupo;

            Console.WriteLine($"Chegaram um grupo de {grupo} pessoas, temos {total} pessoas no local");

            Console.WriteLine($"lotou a balada? {total>=lotação}");
            Console.ReadKey();

        }
    }
}
