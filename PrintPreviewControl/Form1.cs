﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintPreviewControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string txt = txtPrint.Text;
            Font letra = new Font("Arial", 24, FontStyle.Bold);
            e.Graphics.DrawString(txt,letra,Brushes.Black,50,50);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            printPreview.Document = printDocument1;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
