using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operacoes;

namespace methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void HideRadioButtons()
        {
            groupBox1.Visible = false;

        }
        public void ClearAllText()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        public void FillTextBox(string text)
        {
            textBox2.Text = text;
        }
        public void SetnNumber(int age)
        {
            label1.Text = "You are "+ age.ToString()+" Years old.";
        }
        string GetName()
        {
            string name = "Charles";
            return name;
        }
        int Sum(int x, int y) {
            int result = x + y;
            return result;
        }
        string ValueControl(string name, bool control)
        {
            string text = "";
            return text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int result = Sum(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            MessageBox.Show(result.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Matematica.Valor1 = 10;
            Matematica.Valor2 = 20;
            label1.Text = Matematica.Somar().ToString();
        }
    }
}
