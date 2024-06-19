using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //#region
            //            int num;
            //            bool res = int.TryParse("1985a", out num);
            //            if (res)
            //            {
            //                lblResultado.Text = num.ToString();
            //            }
            //            else
            //            {
            //                lblResultado.Text = "Erro na conversão";
            //            }
            //            #endregion


            //double num = 120.5524;
            //lblResultado.Text = num.ToString("#.00");

            int num = 10;
            //lblResultado.Text = num.ToString("x"); // Hex
            lblResultado.Text = num.ToString("D"); // Dec
        }
    }
}
