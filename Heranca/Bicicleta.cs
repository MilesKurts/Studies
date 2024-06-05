using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Bicicleta : Veiculo
    {
     

        public void Pedalar()
        {

        }
        public override void Acelerar()
        {
            Console.WriteLine("Acelerou a bicicleta!");
        }
    }
}
