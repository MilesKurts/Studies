using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01A08g
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            int n = 0;
            int.TryParse(txt_num.Text, out n);
            int d = n * 2;
            lbl_msg.Text = "O dobro de " + n + " é " + d;
            lbl_msg.Visible = true;
        }
    }
}
