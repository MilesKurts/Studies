using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imprimir
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        int largura;
        int altura;
        int num_linhas;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 1;

            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            #region Parte 1

            //string texto = "Trabalhando com impressao.";
            //Font letra = new Font("Arial", 20, FontStyle.Bold,GraphicsUnit.Point);
            //Brush pincel1 = new SolidBrush(Color.Black);
            //Point pontoInicial = new Point(100, 50);
            ////desenhar o documento para ser impresso
            //e.Graphics.DrawString(texto,letra,pincel1,pontoInicial);

            #endregion

            #region Parte 2 

            //Rectangle area =  printDocument1.DefaultPageSettings.Bounds;
            //int x = printDocument1.DefaultPageSettings.Bounds.X;
            //int y = printDocument1.DefaultPageSettings.Bounds.Y;
            //int largura = printDocument1.DefaultPageSettings.Bounds.Width;
            //int altura = printDocument1.DefaultPageSettings.Bounds.Height;

            //string titulo = "Titulo da Pagina.";
            //Font letraTitulo = new Font("Verdana", 24, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            //Brush pincelTitulo = new SolidBrush(Color.Plum);
            //Rectangle areaTitulo = new Rectangle(x + 50, y + 100, largura - 100, 100);
            //StringFormat formatoTitulo = new StringFormat();
            //formatoTitulo.Alignment = StringAlignment.Center;
            //formatoTitulo.LineAlignment = StringAlignment.Center;

            //string texto = "Olá! Estamos felizes em informar que você avançou para a próxima etapa do nosso processo seletivo do Pecege! Parabéns pela sua dedicação e pelo interesse em fazer parte da nossa equipe. Gostaríamos de convidá-lo(a) para uma entrevista com a nossa Tech Recruiter. Esta será uma oportunidade para conhecermos mais sobre a sua trajetória profissional e também sobre você. Em breve entraremos em contato através do whatsapp.";
            //Font letra = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
            //Brush pincel1 = new SolidBrush(Color.Black);
            //Rectangle areaTexto = new Rectangle(x + 50,y+200,largura - 100, altura -400);

            ////desenhar o documento para ser impresso
            //e.Graphics.DrawString(titulo, letraTitulo, pincelTitulo, areaTitulo,formatoTitulo);
            //e.Graphics.DrawString(texto, letra, pincel1, areaTexto);

            //e.Graphics.DrawRectangle(new Pen(Color.Blue), areaTitulo);
            //e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTexto);
            #endregion

            #region Parte 3

            List<string> linhas = new List<string>()
            {
                "Olá! Estamos felizes", "em informar que você", "avançou para a próxima etapa", "do nosso processo seletivo do Pecege!", "Parabéns pela sua dedicação e pelo interesse", "em fazer parte da nossa equipe.", "Gostaríamos de convidá-lo(a) para uma entrevista", "com a nossa Tech Recruiter.", "Esta será uma oportunidade para conhecermos mais sobre a sua trajetória profissional", "e também sobre você. Em breve entraremos em contato através do whatsapp."
            };

            Rectangle area = printDocument1.DefaultPageSettings.Bounds;

            string titulo = "Titulo da Pagina.";
            Font letraTitulo = new Font("Verdana", 24, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Brush pincelTitulo = new SolidBrush(Color.Plum);
            Rectangle areaTitulo = new Rectangle(x + 50, y + 100, largura - 100, 100);
            StringFormat formatoTitulo = new StringFormat();
            formatoTitulo.Alignment = StringAlignment.Center;
            formatoTitulo.LineAlignment = StringAlignment.Center;

            string texto = "Olá! Estamos felizes em informar que você avançou para a próxima etapa do nosso processo seletivo do Pecege! Parabéns pela sua dedicação e pelo interesse em fazer parte da nossa equipe. Gostaríamos de convidá-lo(a) para uma entrevista com a nossa Tech Recruiter. Esta será uma oportunidade para conhecermos mais sobre a sua trajetória profissional e também sobre você. Em breve entraremos em contato através do whatsapp.";
            Font letra = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
            Brush pincel1 = new SolidBrush(Color.Black);
            Rectangle areaTexto = new Rectangle(x + 50, y + 200, largura - 100, altura - 400);

            //desenhar o documento para ser impresso
            e.Graphics.DrawString(titulo, letraTitulo, pincelTitulo, areaTitulo, formatoTitulo);
            e.Graphics.DrawString(texto, letra, pincel1, areaTexto);

            e.Graphics.DrawRectangle(new Pen(Color.Blue), areaTitulo);
            e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTexto);

            #endregion
        }
    }
}
