﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01E02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            label1.BackColor = Color.Blue;
            label1.ForeColor = Color.White;
            label1.Visible = true;

            await Task.Delay(1000);
            label2.BackColor = Color.Yellow;
            label2.ForeColor = Color.Green;
            label2.Visible = true;

            await Task.Delay(1000);
            label3.BackColor = Color.Green;
            label3.ForeColor = Color.Yellow;
            label3.Visible = true;
        }
    }
}
