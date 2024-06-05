using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Humano
    {
        public virtual void Olhos()
        {
            Console.WriteLine("Humano.Olhos");
        }
        public virtual void Cabeloas()
        {
            Console.WriteLine("Humano.Cabelos");
        }
    }
    class Pessoa : Humano
    {
        public override void Olhos()
        {
            Console.WriteLine("Humano.Olhos");
        }
        
    }
}
