using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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


            Pen lapis = new Pen(Color.Black, 5);
            Pen lapis2 = new Pen(Color.Blue, 10);

            Rectangle rect1 = new Rectangle(100, 50, 300, 200);
            Rectangle rect2 = new Rectangle(50, 250, 100, 50);
            Rectangle rect3 = new Rectangle(150, 150, 120, 100);

            //lapis, cordenada x cordenada y, largura,altura
            //desenhador.DrawRectangle(lapis, rect1);
            //desenhador.DrawRectangle(lapis2, 110,100,250,250);

            Rectangle[] rectangles =
            {
                rect1 , rect2 , rect3
            };
            desenhador.DrawRectangles(lapis, rectangles);

            Brush pincel = new SolidBrush(Color.Green);
            Brush pincel2 = new LinearGradientBrush(rect3,Color.Gray, Color.Goldenrod,90);
            desenhador.FillRectangle(pincel2,rect3);

            desenhador.FillRectangles(pincel2,rectangles);

            pictureBox1.BackgroundImage = folha;
            folha.Save("D:\\Download\\adesenho.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
