﻿using System;
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
    }
}
