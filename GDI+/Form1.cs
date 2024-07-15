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

            desenhador.Clear(Color.White);


            //Pen lapis = new Pen(Color.Black, 5);
            //Pen lapis2 = new Pen(Color.Blue, 10);


            //Rectangle rect2 = new Rectangle(50, 250, 100, 50);
            //Rectangle rect3 = new Rectangle(150, 150, 120, 100);

            //lapis, cordenada x cordenada y, largura,altura
            //desenhador.DrawRectangle(lapis, rect1);
            //desenhador.DrawRectangle(lapis2, 110,100,250,250);

            //Rectangle[] rectangles =
            //{
            //    rect1 , rect2 , rect3
            //};
            //desenhador.DrawRectangles(lapis, rectangles);

            //Brush pincel = new SolidBrush(Color.Green);
            //Brush pincel2 = new LinearGradientBrush(rect3,Color.Gray, Color.Goldenrod,90);
            //desenhador.FillRectangle(pincel2,rect3);

            //desenhador.FillRectangles(pincel2,rectangles);

            #region Elipse e circulos

            //Pen lapis3 = new Pen(Color.Black, 5);
            //Rectangle rect1 = new Rectangle(50, 50, 100, 200);

            //desenhador.DrawRectangle(lapis3, rect1);
            //desenhador.DrawEllipse(lapis3, rect1);

            //Brush pincel = new SolidBrush(Color.Black);

            //desenhador.FillEllipse(Brushes.Gray, rect1);
            #endregion

            #region Poligonos
            //Pen lapis = new Pen(Color.Black, 5);

            //Point[] pontos = {
            //    new Point(100,100),
            //    new Point(300,200),
            //    new Point(250,250),
            //    new Point(100,200)
            //    };
            ////desenhador.DrawPolygon(lapis, pontos);
            //Brush pincel = new LinearGradientBrush(new Rectangle(100,100,200,200), Color.Red,Color.Yellow,45);
            //desenhador.FillPolygon(pincel,pontos);

            #endregion

            #region Curvas

            //Pen lapis = new Pen(Color.Black,5);

            //Point[] pontos =
            //{
            //    new Point(100,50),
            //    new Point(200,150),
            //    new Point(300,100),
            //    new Point(500,250),
            //    new Point(300,300)
            //};

            ////desenhador.DrawCurve(lapis, pontos,1.5f);
            ////desenhador.DrawClosedCurve(lapis,pontos,1.5f,FillMode.Alternate);
            //desenhador.FillClosedCurve(Brushes.Red, pontos,FillMode.Winding,1.5f);

            #endregion

            #region Arcos 
            //Pen lapis = new Pen(Color.Black,5);

            //Rectangle rect = new Rectangle(100, 100, 400, 200);

            ////desenhador.DrawRectangle(lapis, rect);
            //desenhador.DrawArc(lapis,rect,0f,270f);


            #endregion

            #region Beziers
            //    Pen lapis = new Pen(Color.Black, 5);

            //    Point p1 = new Point(50, 300);
            //    Point p2 = new Point(200, 400);
            //    Point p3 = new Point(300, 10);
            //    Point p4 = new Point(500, 100);

            //    //desenhador.DrawBezier(lapis, p1, p2, p3, p4);

            //    Point[] pontos =
            //    {
            //    new Point(50, 300),
            //    new Point(150, 350),
            //    new Point(300, 100),
            //    new Point(400, 150),
            //    new Point(500, 400),
            //    new Point(550, 10),
            //    new Point(600, 100)
            //};
            //    desenhador.DrawBeziers(lapis,pontos);

            #endregion

            #region pie

            //Pen lapis = new Pen(Color.Black, 5);
            //Rectangle rect = new Rectangle(50, 50, 300, 300);

            //desenhador.DrawRectangle(lapis, rect);
            ////desenhador.DrawPie(lapis, rect, 270, 90);
            //desenhador.FillPie(Brushes.Red, rect, 270, 90);  

            #endregion

            #region Path

            Pen lapis = new Pen(Color.Black, 5);
            GraphicsPath graphicsPath = new GraphicsPath(FillMode.Alternate);

            graphicsPath.AddEllipse(new RectangleF(10,10,100,150));

            desenhador.DrawPath(lapis, graphicsPath);

            #endregion
            pictureBox1.BackgroundImage = folha;
            folha.Save("D:\\Download\\adesenho.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
