using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullstackcourse_3
{
    public partial class newform : Form
    {
        public newform()
        {
            InitializeComponent();
        }

        private void newform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Surname = textBox2.Text;
            string namesurname = Name + Surname;
            new_show s3 = new new_show();
            s3.label1.Text = namesurname;
            s3.Show();
        }
    }
}
