﻿namespace Imprimir
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProxima = new System.Windows.Forms.Button();
            this.btnVisuPadrao = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(567, 413);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(104, 53);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(12, 12);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(557, 507);
            this.printPreviewControl1.TabIndex = 1;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(575, 12);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(213, 53);
            this.btnVisualizar.TabIndex = 2;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(567, 71);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(104, 53);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProxima
            // 
            this.btnProxima.Location = new System.Drawing.Point(685, 71);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(103, 53);
            this.btnProxima.TabIndex = 4;
            this.btnProxima.Text = "Proxima";
            this.btnProxima.UseVisualStyleBackColor = true;
            this.btnProxima.Click += new System.EventHandler(this.btnProxima_Click);
            // 
            // btnVisuPadrao
            // 
            this.btnVisuPadrao.Location = new System.Drawing.Point(685, 413);
            this.btnVisuPadrao.Name = "btnVisuPadrao";
            this.btnVisuPadrao.Size = new System.Drawing.Size(104, 53);
            this.btnVisuPadrao.TabIndex = 5;
            this.btnVisuPadrao.Text = "Visualizar Padrao";
            this.btnVisuPadrao.UseVisualStyleBackColor = true;
            this.btnVisuPadrao.Click += new System.EventHandler(this.btnVisuPadrao_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.btnVisuPadrao);
            this.Controls.Add(this.btnProxima);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.btnImprimir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProxima;
        private System.Windows.Forms.Button btnVisuPadrao;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

