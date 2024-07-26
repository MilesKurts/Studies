using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacao_Assincrona
{
    public partial class Form1 : Form
    {
        public static ListBox lstRes;
        public Form1()
        {
            InitializeComponent();
            lstRes = listaResultados;
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            listaResultados.Items.Add("Evento do botão foi iniciado : clique aqui");

            Exemplo obj = new Exemplo();
            obj.Task_LongaDuracao();

            listaResultados.Items.Add("Evento do botao foi concluido");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            listaResultados.Items.Add("Evento do botão foi iniciado : clique aqui");

            ExemploAsync obj = new ExemploAsync();
            await obj.Task_LongaDuracao();

            listaResultados.Items.Add("Evento do botão foi concluido");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaResultados.Items.Clear();
        }
    }
}
