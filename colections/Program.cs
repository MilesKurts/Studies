using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] nova_ = new int[2,3];
            nova_[0,0] = 1;
            nova_[0,1] = 2;
            nova_[0,2] = 3;
            nova_[1,0] = 4;
            nova_[1,1] = 5;
            nova_[1,2] = 6;
            int i = 0;
            int j = 0;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    Console.WriteLine(nova_[i,j]);
                }
            }
            Console.ReadKey();
        }
    }
}
