using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_break
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ivalue = "";
            for (int i = 0; i < 5; i++) { 
                if (i == 4)
                break;
                ivalue += " " + i + " ";

            }
            MessageBox.Show(ivalue);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ivalue = "";
            for (int i = 0; i < 5; i++)
            {
                if (i == 1)
                    continue;
                ivalue += " " + i + " ";

            }
            MessageBox.Show(ivalue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string messagetext = "";
            int x = 3;
            switch (x) {
                case 1:
                    messagetext = "number 1";
                    break;
                case 2:
                    messagetext = "Number 2";
                    break;
                case 3:
                    messagetext = "Number 3";
                    goto case 2;
                default:
                    messagetext = "Number 4";
                    break ;
            }
            MessageBox.Show(messagetext);
        }
    }
}
