using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01E04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            float num = 0;
            float.TryParse(txt_num.Text, out num);
            int n1 = (int)num;
            int n2 = Convert.ToInt16(num);
            lbl_msg_1.Text = $" Voce digitou o valor {num}";
            lbl_msg_2.Text = $"A parte inteira é {n1:D}";
            lbl_msg_3.Text = $"Arredondando fica {n2:D}";
            pan_res.Visible = true;

        }
    }
}
