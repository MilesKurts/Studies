using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graficos
{
    public partial class Form1 : Form
    {
        Dictionary<double, double> valores;
        public Form1()
        {
            InitializeComponent();
        
                valores = new Dictionary<double, double>();
        }

        

        private void btnInserirValores_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void tipoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void palleteCor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grafico3D_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAleatório_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xValor.Focus();
            for (int i = 0; i < 35; i++)
            {
                tipoGrafico.Items.Add((SeriesChartType)i);
            }
            for (int i = 0;i < 13; i++)
            {
                palleteCor.Items.Add((ChartColorPalette)i);
            }
        }

        private void xValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)&& e.KeyChar !=(char)8&& e.KeyChar != (char)13&& e.KeyChar != (char)44)|| (xValor.Text.Contains((char)44))&& e.KeyChar == (char)44)
            {
                e.Handled = true;
            }
        }

        private void Yvalor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
