﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            t.Nome = "Gabriel";
            t.Idade = 39;

            Console.WriteLine($"{t.Nome} {t.Sobrenome}" );
            Console.ReadKey();
        }
    }
}
