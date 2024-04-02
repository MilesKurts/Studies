namespace M01E04
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.pan_res = new System.Windows.Forms.Panel();
            this.lbl_msg_1 = new System.Windows.Forms.Label();
            this.lbl_msg_2 = new System.Windows.Forms.Label();
            this.lbl_msg_3 = new System.Windows.Forms.Label();
            this.pan_res.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE UM NUMERO REAL";
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num.Location = new System.Drawing.Point(254, 12);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(84, 29);
            this.txt_num.TabIndex = 1;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(135, 60);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(99, 31);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // pan_res
            // 
            this.pan_res.Controls.Add(this.lbl_msg_3);
            this.pan_res.Controls.Add(this.lbl_msg_2);
            this.pan_res.Controls.Add(this.lbl_msg_1);
            this.pan_res.Location = new System.Drawing.Point(30, 120);
            this.pan_res.Name = "pan_res";
            this.pan_res.Size = new System.Drawing.Size(250, 165);
            this.pan_res.TabIndex = 3;
            this.pan_res.Visible = false;
            this.pan_res.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_msg_1
            // 
            this.lbl_msg_1.AutoSize = true;
            this.lbl_msg_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg_1.Location = new System.Drawing.Point(3, 32);
            this.lbl_msg_1.Name = "lbl_msg_1";
            this.lbl_msg_1.Size = new System.Drawing.Size(60, 24);
            this.lbl_msg_1.TabIndex = 0;
            this.lbl_msg_1.Text = "label2";
            this.lbl_msg_1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_msg_2
            // 
            this.lbl_msg_2.AutoSize = true;
            this.lbl_msg_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg_2.Location = new System.Drawing.Point(3, 73);
            this.lbl_msg_2.Name = "lbl_msg_2";
            this.lbl_msg_2.Size = new System.Drawing.Size(60, 24);
            this.lbl_msg_2.TabIndex = 1;
            this.lbl_msg_2.Text = "label3";
            // 
            // lbl_msg_3
            // 
            this.lbl_msg_3.AutoSize = true;
            this.lbl_msg_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg_3.Location = new System.Drawing.Point(3, 113);
            this.lbl_msg_3.Name = "lbl_msg_3";
            this.lbl_msg_3.Size = new System.Drawing.Size(60, 24);
            this.lbl_msg_3.TabIndex = 2;
            this.lbl_msg_3.Text = "label4";
            this.lbl_msg_3.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 321);
            this.Controls.Add(this.pan_res);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pan_res.ResumeLayout(false);
            this.pan_res.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Panel pan_res;
        private System.Windows.Forms.Label lbl_msg_3;
        private System.Windows.Forms.Label lbl_msg_2;
        private System.Windows.Forms.Label lbl_msg_1;
    }
}

