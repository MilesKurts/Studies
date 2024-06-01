using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For structure.
            int valor = 0;
            do
            {
                valor++;
                Console.WriteLine($" O valor é {valor}");
            } while (valor < 10);
            #endregion

            string[] nomes = { "Gabriel", "Danny", "Arthur", "joão" };
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.ReadKey();
        }
    }
}
