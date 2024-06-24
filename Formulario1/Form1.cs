using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSegunda_Click(object sender, EventArgs e)
        {
            Hide();
            FormSegunda f = new FormSegunda("Bem vindo!");
            
            f.ShowDialog();

            if (f.Mensagem != null)
            {
                lblTitulo.Text = f.Mensagem;
            }

            this.Show();
        }

        private void btnSegundaFormThread_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t =  new Thread(() => Application.Run(new FormSegunda()));
            t.Start();
        }

        private void abriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormSegunda f = new FormSegunda();
            f.ShowDialog();
            Show();

        }

        private void mFileNovo_Click(object sender, EventArgs e)
        {

        }

        private void menuBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mFileSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mHelpSobreDesenvolvedor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Miles");
        }

        private void mHelpSobreVersao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 1.0");
        }

        private void comboNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNew.SelectedIndex == 0)
            {
                menuFile.Text = "File";
                mHelpSobre.Text = "Help";
            }
            else
            {
                menuFile.Text = "Arquivo";
                mHelpSobre.Text = "Ajuda";
            }
        }

        private void comboNew_Click(object sender, EventArgs e)
        {
            
        }

        private void mPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) 
            {
                lblTitulo.Text = mPesquisar.Text;
                mPesquisar.Text = "";
            }
        }
    }
}
