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
    }
}
