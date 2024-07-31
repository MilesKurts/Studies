namespace Graficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xValor = new System.Windows.Forms.TextBox();
            this.Yvalor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInserirValores = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tipoGrafico = new System.Windows.Forms.ComboBox();
            this.palleteCor = new System.Windows.Forms.ComboBox();
            this.grafico3D = new System.Windows.Forms.CheckBox();
            this.btnAleatório = new System.Windows.Forms.Button();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor de X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor de Y";
            // 
            // xValor
            // 
            this.xValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xValor.Location = new System.Drawing.Point(19, 96);
            this.xValor.Name = "xValor";
            this.xValor.Size = new System.Drawing.Size(126, 26);
            this.xValor.TabIndex = 2;
            this.xValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xValor_KeyPress);
            // 
            // Yvalor
            // 
            this.Yvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yvalor.Location = new System.Drawing.Point(151, 96);
            this.Yvalor.Name = "Yvalor";
            this.Yvalor.Size = new System.Drawing.Size(126, 26);
            this.Yvalor.TabIndex = 3;
            this.Yvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Yvalor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gráfico";
            // 
            // btnInserirValores
            // 
            this.btnInserirValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirValores.Location = new System.Drawing.Point(12, 128);
            this.btnInserirValores.Name = "btnInserirValores";
            this.btnInserirValores.Size = new System.Drawing.Size(276, 49);
            this.btnInserirValores.TabIndex = 5;
            this.btnInserirValores.Text = "Insira o valor no gráfico";
            this.btnInserirValores.UseVisualStyleBackColor = true;
            this.btnInserirValores.Click += new System.EventHandler(this.btnInserirValores_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.dataGridView1.Location = new System.Drawing.Point(12, 183);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(294, 159);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.SizeChanged += new System.EventHandler(this.dataGridView1_SizeChanged);
            // 
            // x
            // 
            this.x.HeaderText = "Eixo X";
            this.x.Name = "x";
            this.x.ReadOnly = true;
            this.x.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // y
            // 
            this.y.HeaderText = "EixoY";
            this.y.Name = "y";
            this.y.ReadOnly = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(12, 348);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(295, 55);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar Gráfico";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tipoGrafico
            // 
            this.tipoGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoGrafico.FormattingEnabled = true;
            this.tipoGrafico.Location = new System.Drawing.Point(15, 422);
            this.tipoGrafico.Name = "tipoGrafico";
            this.tipoGrafico.Size = new System.Drawing.Size(291, 28);
            this.tipoGrafico.TabIndex = 8;
            this.tipoGrafico.SelectedIndexChanged += new System.EventHandler(this.tipoGrafico_SelectedIndexChanged);
            // 
            // palleteCor
            // 
            this.palleteCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palleteCor.FormattingEnabled = true;
            this.palleteCor.Location = new System.Drawing.Point(310, 422);
            this.palleteCor.Name = "palleteCor";
            this.palleteCor.Size = new System.Drawing.Size(291, 28);
            this.palleteCor.TabIndex = 9;
            this.palleteCor.SelectedIndexChanged += new System.EventHandler(this.palleteCor_SelectedIndexChanged);
            // 
            // grafico3D
            // 
            this.grafico3D.AutoSize = true;
            this.grafico3D.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grafico3D.Location = new System.Drawing.Point(619, 429);
            this.grafico3D.Name = "grafico3D";
            this.grafico3D.Size = new System.Drawing.Size(87, 17);
            this.grafico3D.TabIndex = 10;
            this.grafico3D.Text = "Gráfico 3D";
            this.grafico3D.UseVisualStyleBackColor = true;
            this.grafico3D.CheckedChanged += new System.EventHandler(this.grafico3D_CheckedChanged);
            // 
            // btnAleatório
            // 
            this.btnAleatório.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAleatório.Location = new System.Drawing.Point(712, 422);
            this.btnAleatório.Name = "btnAleatório";
            this.btnAleatório.Size = new System.Drawing.Size(153, 51);
            this.btnAleatório.TabIndex = 11;
            this.btnAleatório.Text = "Inserir Valores Aleatorios";
            this.btnAleatório.UseVisualStyleBackColor = true;
            this.btnAleatório.Click += new System.EventHandler(this.btnAleatório_Click);
            // 
            // grafico
            // 
            chartArea2.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafico.Legends.Add(legend2);
            this.grafico.Location = new System.Drawing.Point(335, 99);
            this.grafico.Name = "grafico";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "X vs Y";
            this.grafico.Series.Add(series2);
            this.grafico.Size = new System.Drawing.Size(529, 303);
            this.grafico.TabIndex = 12;
            this.grafico.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 482);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.btnAleatório);
            this.Controls.Add(this.grafico3D);
            this.Controls.Add(this.palleteCor);
            this.Controls.Add(this.tipoGrafico);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInserirValores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Yvalor);
            this.Controls.Add(this.xValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xValor;
        private System.Windows.Forms.TextBox Yvalor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInserirValores;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox tipoGrafico;
        private System.Windows.Forms.ComboBox palleteCor;
        private System.Windows.Forms.CheckBox grafico3D;
        private System.Windows.Forms.Button btnAleatório;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
    }
}

