namespace Formulario1
{
    partial class FormMain
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSegunda = new System.Windows.Forms.Button();
            this.btnSegundaFormThread = new System.Windows.Forms.Button();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mFileSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpSobreDesenvolvedor = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpSobreVersao = new System.Windows.Forms.ToolStripMenuItem();
            this.comboNew = new System.Windows.Forms.ToolStripComboBox();
            this.mPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(45, 119);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(680, 164);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Principal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSegunda
            // 
            this.btnSegunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegunda.Location = new System.Drawing.Point(42, 286);
            this.btnSegunda.Name = "btnSegunda";
            this.btnSegunda.Size = new System.Drawing.Size(169, 67);
            this.btnSegunda.TabIndex = 1;
            this.btnSegunda.Text = "Segunda Form";
            this.btnSegunda.UseVisualStyleBackColor = true;
            this.btnSegunda.Click += new System.EventHandler(this.btnSegunda_Click);
            // 
            // btnSegundaFormThread
            // 
            this.btnSegundaFormThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundaFormThread.Location = new System.Drawing.Point(217, 286);
            this.btnSegundaFormThread.Name = "btnSegundaFormThread";
            this.btnSegundaFormThread.Size = new System.Drawing.Size(169, 67);
            this.btnSegundaFormThread.TabIndex = 2;
            this.btnSegundaFormThread.Text = "Segunda Form Thread";
            this.btnSegundaFormThread.UseVisualStyleBackColor = true;
            this.btnSegundaFormThread.Click += new System.EventHandler(this.btnSegundaFormThread_Click);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.mHelpSobre,
            this.comboNew,
            this.mPesquisar});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(800, 27);
            this.menuBar.TabIndex = 3;
            this.menuBar.Text = "menuStrip1";
            this.menuBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuBar_ItemClicked);
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileNovo,
            this.mFileAbrir,
            this.toolStripSeparator1,
            this.mFileSair});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 23);
            this.menuFile.Text = "File";
            // 
            // mFileNovo
            // 
            this.mFileNovo.Name = "mFileNovo";
            this.mFileNovo.ShortcutKeyDisplayString = "Control + N";
            this.mFileNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mFileNovo.Size = new System.Drawing.Size(180, 22);
            this.mFileNovo.Text = "Novo";
            // 
            // mFileAbrir
            // 
            this.mFileAbrir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mFileAbrir.Name = "mFileAbrir";
            this.mFileAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mFileAbrir.Size = new System.Drawing.Size(180, 22);
            this.mFileAbrir.Text = "Abrir";
            this.mFileAbrir.Click += new System.EventHandler(this.abriToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mFileSair
            // 
            this.mFileSair.Name = "mFileSair";
            this.mFileSair.Size = new System.Drawing.Size(180, 22);
            this.mFileSair.Text = "Sair";
            this.mFileSair.Click += new System.EventHandler(this.mFileSair_Click);
            // 
            // mHelpSobre
            // 
            this.mHelpSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.mHelpSobre.Name = "mHelpSobre";
            this.mHelpSobre.Size = new System.Drawing.Size(44, 23);
            this.mHelpSobre.Text = "Help";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpSobreDesenvolvedor,
            this.mHelpSobreVersao});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // mHelpSobreDesenvolvedor
            // 
            this.mHelpSobreDesenvolvedor.Name = "mHelpSobreDesenvolvedor";
            this.mHelpSobreDesenvolvedor.Size = new System.Drawing.Size(152, 22);
            this.mHelpSobreDesenvolvedor.Text = "Desenvolvedor";
            this.mHelpSobreDesenvolvedor.Click += new System.EventHandler(this.mHelpSobreDesenvolvedor_Click);
            // 
            // mHelpSobreVersao
            // 
            this.mHelpSobreVersao.Name = "mHelpSobreVersao";
            this.mHelpSobreVersao.Size = new System.Drawing.Size(152, 22);
            this.mHelpSobreVersao.Text = "Versão";
            this.mHelpSobreVersao.Click += new System.EventHandler(this.mHelpSobreVersao_Click);
            // 
            // comboNew
            // 
            this.comboNew.Items.AddRange(new object[] {
            "Ingles",
            "Portugues"});
            this.comboNew.Name = "comboNew";
            this.comboNew.Size = new System.Drawing.Size(121, 23);
            this.comboNew.SelectedIndexChanged += new System.EventHandler(this.comboNew_SelectedIndexChanged);
            this.comboNew.Click += new System.EventHandler(this.comboNew_Click);
            // 
            // mPesquisar
            // 
            this.mPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mPesquisar.Name = "mPesquisar";
            this.mPesquisar.Size = new System.Drawing.Size(100, 23);
            this.mPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mPesquisar_KeyUp);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSegundaFormThread);
            this.Controls.Add(this.btnSegunda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "FormMain";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSegunda;
        private System.Windows.Forms.Button btnSegundaFormThread;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem mFileNovo;
        private System.Windows.Forms.ToolStripMenuItem mFileAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mFileSair;
        private System.Windows.Forms.ToolStripMenuItem mHelpSobre;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mHelpSobreDesenvolvedor;
        private System.Windows.Forms.ToolStripMenuItem mHelpSobreVersao;
        private System.Windows.Forms.ToolStripComboBox comboNew;
        private System.Windows.Forms.ToolStripTextBox mPesquisar;
    }
}

