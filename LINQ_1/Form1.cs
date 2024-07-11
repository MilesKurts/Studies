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
        Dictionary<string, double> lista_produtos;
        Dictionary<string, string> lista_estados;

        public Form1()
        {
            InitializeComponent();

            #region Lista de Nomes
            lista_nomes = new List<string>();
            lista_nomes.Add("Gabriel");
            lista_nomes.Add("Danny");
            lista_nomes.Add("Arthur");
            lista_nomes.Add("Danielle");
            lista_nomes.Add("Thuxs");
            lista_nomes.Add("Logan");
            lista_nomes.Add("Artigas");
            lista_nomes.Add("Flávio");
            lista_nomes.Add("Beatriz");
            lista_nomes.Add("Glória");
            lista_nomes.Add("Maria");
            lista_nomes.Add("Bia");
            lista_nomes.Add("Eduardo");
            lista_nomes.Add("Márcio");
            lista_nomes.Add("Miguel");
            lista_nomes.Add("Sarah");
            lista_nomes.Add("Saray");
            lista_nomes.Add("Larissa");
            lista_nomes.Add("Lucas");
            lista_nomes.Add("Guilherme");
            lista_nomes.Add("Maciel");
            #endregion

            #region Lista Números
            lista_numeros = new List<int>();
            lista_numeros.Add(10);
            lista_numeros.Add(5);
            lista_numeros.Add(8);
            lista_numeros.Add(54);
            lista_numeros.Add(57);
            lista_numeros.Add(2);
            lista_numeros.Add(3);
            lista_numeros.Add(15);
            lista_numeros.Add(12);
            lista_numeros.Add(7);
            #endregion

            #region Lista Produtos
            lista_produtos = new Dictionary<string, double>();
            lista_produtos.Add("Teclado USB", 49.95);
            lista_produtos.Add("Teclado PS2", 45.95);
            lista_produtos.Add("Teclado Gamer", 358.99);
            lista_produtos.Add("Mouse", 29.5);
            lista_produtos.Add("Monitor", 780.85);
            lista_produtos.Add("Memória 16Gb", 700.00);
            lista_produtos.Add("Memória 8Gb", 375.65);
            lista_produtos.Add("Processador", 1250);
            lista_produtos.Add("Placa Mãe", 623.75);
            lista_produtos.Add("Gabinete mATX", 150);
            lista_produtos.Add("Gabinete ATX", 190);
            #endregion

            #region Lista Estados
            lista_estados = new Dictionary<string, string>();
            lista_estados.Add("Rio de Janeiro", "Brasil");
            lista_estados.Add("New York", "Estados Unidos");
            lista_estados.Add("São Paulo", "Brasil");
            lista_estados.Add("Porto", "Portugal");
            lista_estados.Add("Lisboa", "Portugal");
            lista_estados.Add("Bahia", "Brasil");
            lista_estados.Add("Washington", "Estados Unidos");
            lista_estados.Add("Algarve", "Portugal");
            #endregion

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            // Metodo Comum
            //foreach (int num in lista_numeros)
            //{
            //    if (num % 2 == 0)
            //    {
            //        lista.Items.Add(num);
            //    }
            //}

            ////Utilizando LINQ
            // Obter a fonte dos dados.
            // Criar a consulta.
            // Executar a consulta.

            //IEnumerable<int> res = from num in lista_numeros where num % 2 == 0 select num;

            //foreach (int n in res)
            //{
            //    lista.Items.Add(n);
            //}

            string txt = txtConsulta.Text;
            IEnumerable<string> res2 = from nome in lista_nomes
                                       where nome.StartsWith(txt)
                                       select nome;

            lista.Items.AddRange(res2.ToArray());

            //foreach (string n in res2)
            //{
            //    lista.Items.Add(n);
            //}
        }

        private void btExecutar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            // Metodo Comum
            //foreach (int num in lista_numeros)
            //{
            //    if (num % 2 == 0)
            //    {
            //        lista.Items.Add(num);
            //    }
            //}

            ////Utilizando LINQ
            // Obter a fonte dos dados.
            // Criar a consulta.
            // Executar a consulta.

            //IEnumerable<int> res = from num in lista_numeros where num % 2 == 0 select num;

            //foreach (int n in res)
            //{
            //    lista.Items.Add(n);
            //}

            string txt = txtConsulta.Text;
            IEnumerable<string> res2 = from nome in lista_nomes
                                       where nome.StartsWith(txt)
                                       select nome;

            lista.Items.AddRange(res2.ToArray());

            //foreach (string n in res2)
            //{
            //    lista.Items.Add(n);
            //}

        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            string txt = txtConsulta.Text;

            var res = from nome in lista_nomes where nome.ToLower().Contains(txt) select nome;
            foreach (var item in res)
            {
                
                lista.Items.Add(item);
            }
        }
    } 
}