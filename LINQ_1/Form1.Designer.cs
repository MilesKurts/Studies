namespace LINQ_1
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
            this.lista = new System.Windows.Forms.ListBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btExecutar = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.OrderBy = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnAgregacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 29;
            this.lista.Location = new System.Drawing.Point(7, 10);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(453, 294);
            this.lista.TabIndex = 0;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(492, 10);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(184, 31);
            this.txtConsulta.TabIndex = 1;
            // 
            // btExecutar
            // 
            this.btExecutar.Location = new System.Drawing.Point(513, 76);
            this.btExecutar.Name = "btExecutar";
            this.btExecutar.Size = new System.Drawing.Size(151, 58);
            this.btExecutar.TabIndex = 2;
            this.btExecutar.Text = "Executar";
            this.btExecutar.UseVisualStyleBackColor = true;
            this.btExecutar.Click += new System.EventHandler(this.btExecutar_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(513, 140);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(151, 58);
            this.btnWhere.TabIndex = 3;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // OrderBy
            // 
            this.OrderBy.Location = new System.Drawing.Point(513, 204);
            this.OrderBy.Name = "OrderBy";
            this.OrderBy.Size = new System.Drawing.Size(151, 58);
            this.OrderBy.TabIndex = 4;
            this.OrderBy.Text = "Order By";
            this.OrderBy.UseVisualStyleBackColor = true;
            this.OrderBy.Click += new System.EventHandler(this.OrderBy_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(513, 268);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(151, 58);
            this.btnGroup.TabIndex = 5;
            this.btnGroup.Text = "Group By";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnAgregacao
            // 
            this.btnAgregacao.Location = new System.Drawing.Point(513, 332);
            this.btnAgregacao.Name = "btnAgregacao";
            this.btnAgregacao.Size = new System.Drawing.Size(151, 58);
            this.btnAgregacao.TabIndex = 6;
            this.btnAgregacao.Text = "Operadores Agregação";
            this.btnAgregacao.UseVisualStyleBackColor = true;
            this.btnAgregacao.Click += new System.EventHandler(this.btnAgregacao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregacao);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.OrderBy);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btExecutar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btExecutar;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button OrderBy;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnAgregacao;
    }
}

