using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Escrever_arq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscreverTxt_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Mile kurtz\source\repos\ambM01\Escrever_arq\text\novo.txt";
            StreamWriter writer = new StreamWriter(path, true, Encoding.Default);

            string linha = txtConteudo.Text;
            writer.WriteLine(linha);

            writer.Flush();
            writer.Dispose();
            writer.Close();
        }

        private void leiaTxt_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();
            string path = @"C:\Users\Mile kurtz\source\repos\ambM01\Escrever_arq\text\novo.txt";

            StreamReader reader = new StreamReader(path, Encoding.Default);

            string txt = reader.ReadToEnd();

            txtConteudo.Text = txt;
        }
    }
}
