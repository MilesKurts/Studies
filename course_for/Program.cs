using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ivalue = "";
            for(int i = 0;i<10;i++)
            {
                for(int k = 0; k < 8; k++)
                {
                    ivalue += "i: "+i+" k "+k+ Environment.NewLine;
                }
                
            }
            Console.WriteLine(ivalue);
            Console.ReadKey();
        }
    }
}
