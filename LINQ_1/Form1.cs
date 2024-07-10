using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_1
{
    public partial class Form1 : Form
    {
        List<string> lista_nomes;
        List<int> lista_numeros;
        Dictionary<string, double> lista_produto;
        Dictionary<string, string> lista_estados;
        public Form1()
        {
            InitializeComponent();

            lista_nomes = new List<string>();
            lista_nomes.Add("Ariovaldo");
            lista_nomes.Add("Bruno");
            lista_nomes.Add("Carlos");
            lista_nomes.Add("David");
            lista_nomes.Add("Emanuel");
            lista_nomes.Add("Flavio");
            lista_nomes.Add("Gabriel");
            lista_nomes.Add("Hiago");
            lista_nomes.Add("Igor");
            lista_nomes.Add("Jose");
            lista_nomes.Add("Kaique");
            lista_nomes.Add("Lazarro");
            lista_nomes.Add("Miles");
            lista_nomes.Add("Noé");
            lista_nomes.Add("Osvaldo");
            lista_nomes.Add("Pedro");
            lista_nomes.Add("Quadrado");
            lista_nomes.Add("Ronaldo");
            lista_nomes.Add("Saulo");
            lista_nomes.Add("Tutancamom");
            lista_nomes.Add("Urias");
            lista_nomes.Add("Vlademir");
            lista_nomes.Add("Washington");
            lista_nomes.Add("Xablau");
            lista_nomes.Add("Ygor");
            lista_nomes.Add("Zambrolio");

            lista_numeros = new List<int>();
            lista_numeros.Add(0);
            lista_numeros.Add(10);
            lista_numeros.Add(25);
            lista_numeros.Add(30);
            lista_numeros.Add(47);
            lista_numeros.Add(50);
            lista_numeros.Add(63);
            lista_numeros.Add(70);
            lista_numeros.Add(89);
            lista_numeros.Add(90);
            lista_numeros.Add(104);
            lista_numeros.Add(113);
            lista_numeros.Add(120);
            lista_numeros.Add(131);
            lista_numeros.Add(140);
            lista_numeros.Add(255);

            lista_produto = new Dictionary<string, double>();
            lista_produto.Add("Teclado USB", 49.50);
            lista_produto.Add("pC 2000", 1209.40);
            lista_produto.Add("HD SSD 1TB", 59.50);
            lista_produto.Add("Camisa Gamer", 69.50);
            lista_produto.Add("Mouse", 79.50);
            lista_produto.Add("Monitor", 145.70);
            lista_produto.Add("Memoria RAM", 149.50);
            lista_produto.Add("HD rigido", 100.20);
            lista_produto.Add("Placa Mãe", 10.62);
            lista_produto.Add("Gabinete", 142.22);
            lista_produto.Add("Mouse Pad", 100.50);

            lista_estados = new Dictionary<string, string>();
            lista_estados.Add("São Paulo", "São Paulo");
            lista_estados.Add("Rio De Janeiro", "Rio de Janeiro");
            lista_estados.Add("Acre", "Rio Branco");
            lista_estados.Add("Alagoas", "Maceio");
            lista_estados.Add("Amapá", "Macapá");
            lista_estados.Add("Roraima", "Boa vista");
            lista_estados.Add("Santa Catarina", "Florianopoles");
            lista_estados.Add("Sergipe", "Aracaju");


        }

        private void btExecutar_Click(object sender, EventArgs e)
        {

            ////obter a fonte dos dados
            lista.Items.Clear();
            ////criar a consulta
            //IEnumerable<int> res = from num in lista_numeros where num % 2 == 0 select num;
            
            ////Executar a consulta
            //foreach (int num in res)
            //{
            //    lista.Items.Add(num);
            //}
            string txt = txtConsulta.Text;
            IEnumerable<string> res2 = from nome in lista_nomes where nome.StartsWith(txt) select nome; 
            lista.Items.AddRange(res2.ToArray());
        }
    }
}
