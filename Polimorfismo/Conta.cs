using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class CaixaEletronico : IConta
    {
        public string Usuario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Depositar()
        {
            throw new NotImplementedException();
        }

        public void Sacar()
        {
            throw new NotImplementedException();
        }

        public void Saldo()
        {
            throw new NotImplementedException();
        }
        public void SolicitarEmprestimo()
        {

        }
    }
    interface  IConta
    {
        string Usuario { get; set; }
        void Depositar();
        void Sacar();
        void Saldo();
    }
}
