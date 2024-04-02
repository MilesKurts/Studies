using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace M01E08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ini, fim;
            int.TryParse(txt_n1.Text, out ini);
            int.TryParse(txt_n2.Text, out fim);

            label4.Text = "Sorteando";
            label4.Visible = true;
            Task.Delay(1000);

            Random sortear = new Random();
            int num = sortear.Next(ini, fim);
            label4.Text = $"Sorteado o numero :{num}";
        }
    }
}
