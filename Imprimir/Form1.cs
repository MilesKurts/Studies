﻿using System;
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
        int pagina;
        int num_Paginas;
        public Form1()
        {
            InitializeComponent();
            pagina = 0;
            num_Paginas = 0;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() != DialogResult.Cancel)
            {
                largura = printDocument1.DefaultPageSettings.Bounds.Width;
                altura = printDocument1.DefaultPageSettings.Bounds.Height;
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }

            
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
                "1. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "2. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "3. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "4. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "5. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "6. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "7. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "8. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "9. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "10. Lorem, ipsum dolor sit amet consectetur adipisicing elit.",
                "1. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "2. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "3. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "4. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "5. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "6. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "7. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "8. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "9. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "20. Lorem, ipsum dolor sit amet consectetur adipisicing elit.",
                "1. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "2. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "3. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "4. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "5. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "6. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "7. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "8. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "9. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "30. Lorem, ipsum dolor sit amet consectetur adipisicing elit.",
                "1. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "2. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "3. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "4. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "5. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "6. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "7. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "8. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "9. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "40. Lorem, ipsum dolor sit amet consectetur adipisicing elit.",
                "1. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "2. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "3. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "4. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "5. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "6. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "7. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "8. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "9. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "50. Lorem, ipsum dolor sit amet consectetur adipisicing elit.",
                "1. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "2. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "3. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "4. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "5. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "6. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "7. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "8. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "9. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "60. Lorem, ipsum dolor sit amet consectetur adipisicing elit.",
                "1. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "2. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "3. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "4. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "5. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "6. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "7. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "8. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "9. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "70. Lorem, ipsum dolor sit amet consectetur adipisicing elit.",
                "1. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "2. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "3. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "4. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "5. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "6. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "7. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "8. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "9. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "80. Lorem, ipsum dolor sit amet consectetur adipisicing elit.",
                "1. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "2. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "3. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "4. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "5. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "6. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "7. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "8. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "9. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "90. Lorem, ipsum dolor sit amet consectetur adipisicing elit.",
                "1. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "2. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "3. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "4. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "5. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "6. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "7. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "8. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "9. Lorem, ipsum dolor sit amet consectetur adipisicing elit. ",
                "100. Lorem, ipsum dolor sit amet consectetur adipisicing elit."
            };

            string titulo = "Titulo da Página";
            Font letraTitulo = new Font("Verdana", 24, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Brush pincelTitulo = new SolidBrush(Color.Red);
            Rectangle areaTitulo = new Rectangle(x, y, largura - 100, 100);
            StringFormat formatoTitulo = new StringFormat();
            formatoTitulo.Alignment = StringAlignment.Center;
            formatoTitulo.LineAlignment = StringAlignment.Center;

            //// Desenhar o documetno para ser impresso
            Font letra = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
            Brush pincel = new SolidBrush(Color.Black);

            while (num_linhas < linhas.Count)
            {
                if (num_linhas == 0)
                {
                    e.Graphics.DrawString(titulo, letraTitulo, pincelTitulo, areaTitulo, formatoTitulo);
                    y += 150;
                }

                e.Graphics.DrawString(linhas[num_linhas], letra, pincel, new Point(x, y));
                y += 30;
                num_linhas++;

                if (y >= altura - 50)
                {
                    // Mudar de Pagina
                    y = 50;
                    e.HasMorePages = true;
                    num_Paginas++;
                    break;
                }

                }
                #endregion
            }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;

            printPreviewControl1.Document = printDocument1;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (pagina > 0) 
            {
                printPreviewControl1.StartPage = --pagina;
            }
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            if (pagina < num_Paginas)
            {
                printPreviewControl1.StartPage = ++pagina;
            }
        }

        private void btnVisuPadrao_Click(object sender, EventArgs e)
        {
            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
    }

