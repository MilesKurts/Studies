using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControle
{
    public partial class Form1 : Form
    {
        Label lbl1;
        Button btn1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl1 = new Label();
            lbl1.AutoSize = false;
            lbl1.Location = new Point(100, 50);
            lbl1.Size = new Size(500, 100);
            lbl1.BackColor = Color.White;
            lbl1.ForeColor = Color.Black;
            lbl1.Font = new Font("Arial", 28, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.Text = "Miles Kurts";

            Button btn1 = new Button();
            btn1.Location = new Point(250, 285);
            btn1.Size = new Size(200, 60);
            btn1.Font = new Font("Arial", 25,FontStyle.Bold,GraphicsUnit.Point);
            btn1.Text = "New";

            btn1.Click += Btn1_Click;

            this.Controls.Add(btn1); 
            this.Controls.Add(lbl1);

        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Clicou no Botão";
        }
    }
}
