using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ola, Meus amigos!");
            //MessageBox.Show("Mensagem", "Titulo!");
            //DialogResult res =MessageBox.Show("Message", "Titulo",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            //if (res == DialogResult.Yes)
            //{
            //    lblResultado.Text = "Clicou em Yes";
            //}
            //else if (res == DialogResult.No)
            //{
            //    lblResultado.Text = "Clicou em NO";
            //}
            //else
            //{
            //    lblResultado.Text = "Clicou em cancelar";
            //}
            //MessageBox.Show("Message", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            MessageBox.Show("Message", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int valor = r.Next(100);

            lblResultado.Text = valor.ToString();
            

        }

        private void btnTimeSpoan_Click(object sender, EventArgs e)
        {
            
            //lblResultado.Text = TimeSpan.FromMinutes(60).ToString();
            //lblResultado.Text = TimeSpan.TicksPerMinute.ToString();

            TimeSpan inicio = new TimeSpan(5,30,30);

            TimeSpan fim = new TimeSpan(18,25,0);
            TimeSpan intervalo = inicio - fim;
            lblResultado.Text = intervalo.Hours.ToString();
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //lblResultado.Text = DateTime.Now.ToString();
            //lblResultado.Text = DateTime.Today.ToString();
            //lblResultado.Text = DateTime.DaysInMonth(2024,06).ToString();
            //lblResultado.Text = DateTime.IsLeapYear(2024).ToString();
            //lblResultado.Text = DateTime.Now.ToLongDateString();
            //lblResultado.Text = DateTime.Now.ToShortDateString();
            //lblResultado.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


            DateTime data = new DateTime(1985,01,10,14,15,30);
            //lblResultado.Text =  data.AddYears(2).ToString();

            TimeSpan tempo = new TimeSpan(5, 10, 5, 20);
            lblResultado.Text = data.Add(tempo).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color vermelho = Color.Red;
            Color amarelo = Color.Yellow;
            lblResultado.ForeColor = vermelho;
            lblResultado.BackColor = amarelo;
        }
    }
}
