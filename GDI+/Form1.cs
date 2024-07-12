using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDesenhar_Click(object sender, EventArgs e)
        {
            Bitmap folha = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Graphics desenhador = Graphics.FromImage(folha);

            desenhador.Clear(Color.Red);

            pictureBox1.BackgroundImage = folha;
            folha.Save("D:\\Download\\adesenho.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
