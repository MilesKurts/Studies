﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            Console.WriteLine("A data atual é dia "+dia+" do mês "+mes+" do ano "+ano);

            int hora = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;
            Console.WriteLine("A hora atual é " + hora + " horas " + min + " minuto(s) " + sec+" segundo(s)");
            Console.ReadKey();
        }
    }
}
