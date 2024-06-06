using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    class  Teste
    {
        private string nome;
        public string sobrenome;
        
        public void Metodo1() { }
        public void Executar() { }
    }
    class Humano
    {
        protected string nome;
        public string sobrenome;
    }
    class Homem : Humano
    {
        public void Metodo()
        {
            nome = "";
        }
    }
}
