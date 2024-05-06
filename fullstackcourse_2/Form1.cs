using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullstackcourse_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string messagetext = "Simple message text";
            string messagetitle = "title";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(messagetext,messagetitle,buttons);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            else if(result == DialogResult.No)
            {
                string message2 = "did you see icon?";
                string title = "OK";
                MessageBox.Show(message2,title,MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            btn1.Text = "changed";
            comboBox1.Items.Add("Thursday");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello!");
            button1.Text = "OK";
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            button1.Text = "Enter";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "First label";
            label1.BackColor = Color.Red;
            label1.ForeColor = Color.White;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                e.Handled = true;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
