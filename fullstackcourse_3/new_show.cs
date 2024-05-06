using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fullstackcourse_3
{
    public partial class new_show : Form
    {
        public new_show()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newform s1 = new newform();
            s1.Show();

         }
    }
}
