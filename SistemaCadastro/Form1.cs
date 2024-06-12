﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Form1 : Form
    {
        
        List<Pessoa> pessoas;
        public Form1()
        {
            InitializeComponent();
            pessoas = new List<Pessoa>();
            comboEC.Items.Add("Casado");
            comboEC.Items.Add("Solteiro");
            comboEC.Items.Add("Viuvo");
            comboEC.Items.Add("Separado");
            comboEC.SelectedItem = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboEC.SelectedItem = 0;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach(Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == txtNome.Text)
                {
                    index = pessoas.IndexOf(pessoa);
                }
            }
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome.");
                txtNome.Focus();
                return;
            }
            if (txtTelefone.Text == "(  )     -    ")
            {
                MessageBox.Show("Preencha o campo Telefone.");
                txtTelefone.Focus();
                return;
            }
             string sexo;
            if (radioM.Checked)
            {
                sexo = "M";
            }else if (radioF.Checked)
            {
                sexo = "F";
            }
            else
            {
                sexo = "O";
            }

            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.Telefone = txtTelefone.Text;
            p.DataNascimento = txtData.Text;
            p.EstadoCivil = comboEC.SelectedItem.ToString();
            p.CasaPropria = checkCasa.Checked;
            p.Veiculo = checkVeiculo.Checked;
            p.Sexo = sexo;

            if (index < 0)
            {
                pessoas.Add(p);
            }
            else
            {
                pessoas[index] = p;
            }


            btnLimpar_Click(btnLimpar, EventArgs.Empty);

            Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int  indice = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = ""; txtTelefone.Text = "";txtTelefone.Text = ""; comboEC.SelectedIndex = 0;checkCasa.Checked = false; checkVeiculo.Checked = false;radioM.Checked = true; radioF.Checked = false; radioO.Checked = false; txtNome.Focus();
        }

        private void Listar()
        {
            lista.Items.Clear();
            foreach (Pessoa p in pessoas)
            {
                lista.Items.Add(p.Nome);
            }
        }
    }
}
