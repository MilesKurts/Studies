﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            string[] days = new string[7];
            days[0] = "Sunday";
            days[1] = "Monday";
            days[2] = "Tuesday";
            days[3] = "Wednesday";
            days[4] = "Thursday";
            days[5] = "Friday";
            days[6] = "Saturday";
            for (int i = 0; i < days.Length; i++)
            {
                string rowtext = days[i];
                dataGridView1.Rows.Add(rowtext);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] rows = new string[,]
            {
                {"1","Sunday" },
                {"2","Monday" },
                {"3","Tuesday" },
                {"4","Wednesday" },
                {"5","Thursday" },
                {"6","Friday" },
                {"7","Saturday" },
            };
            for (int i = 0;i< rows.GetLength(0
                ); i++)
            {
                string[] row = new string[rows.GetLength(1)];
                for (int k = 0; k < rows.GetLength(1); k++)
                {
                    row[k] = rows[i,k];
                }
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
