using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save.Filter = "text| *.txt| Document|*.doc|Portavel|*.pdf";

            if (save.ShowDialog() != DialogResult.Cancel)
            {
                label1.Text = save.Filter;

            }
        }
    }
}
