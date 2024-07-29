using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            Func<int, int> square = x => x * x;
            //Func<int, int> square = quadrado;

            //label1.Text = $"O resultado é... {square(5)}";

            Expression<Func<int,int>> ex = x => x + x;

            //label1.Text = ex.ToString();

            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x*x);
           label1.Text = string.Join(" ", squaredNumbers);
        }
  //      int quadrado(int x)
    //    {
      //      return x * x;
        //}
    }
}
