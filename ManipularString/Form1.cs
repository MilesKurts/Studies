using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //string texto = "Esse tipo de variavel é alfaNumerico!";

            //if (texto.Contains("tipo"))
            //{
            //    label1.Text = "Contém.";
            //}
            //else
            //{
            //    label1.Text = "Não contem!";
            //}

            //int num = 5400;
            //label1.Text = num.ToString();

            //bool res = true;
            //label1.Text = res.ToString();

            //string nome = "Gabriel Artigas";
            ////string nomeFinal = nome.Insert(7, " Lucas ");
            //string nomeFinal = nome.Replace("a", "x");
            //label1.Text = nomeFinal;

            string nome = "Gabriel Artigas";
            label1.Text = nome.Length.ToString();
        }
    }
}
