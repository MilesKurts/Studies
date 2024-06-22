using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Task t1 = new Task(Tarefa);
            //t1.Start();

            //            Task.Run(Tarefa);

            //Task.Factory.StartNew(Tarefa);

            //Task.Run(() => {
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("Tarefa anônima.");
            //    }
            //});
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Principal.");
            //}
            #endregion
            Task[] tasks = 
            {
                Task.Factory.StartNew(() => 
                {
                    Console.WriteLine("Tarefa #1");
                }),
                Task.Factory.StartNew(() => 
                {
                    Console.WriteLine("Tarefa #2");
                }),
                Task.Factory.StartNew(() => 
                {
                    Console.WriteLine("Tarefa #3");
                })
            };

            Task.WaitAll(tasks);

            Console.WriteLine("Principal");
            Console.ReadKey();
        }
        static private void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa do task.");
            }

        }
    }
}
