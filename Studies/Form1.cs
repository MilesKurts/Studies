using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ListViewItem item1 = new ListViewItem("Miles");
            item1.SubItems.Add("199999999");
            item1.SubItems.Add("hjsjahsh@gusa.com");

            ListViewItem item2 = new ListViewItem("Grazi");
            item2.SubItems.Add("199999999");
            item2.SubItems.Add("hjsjahsh@gusa.com");

            ListViewItem item3 = new ListViewItem("Yuno");
            item3.SubItems.Add("199999999");
            item3.SubItems.Add("hjsjahsh@gusa.com");

            ListViewItem item4 = new ListViewItem(new string[] {"Paula", "19999999999", "kljhdsjahkldjsa@hofjoads.com"});

            lista.Items.Add(item1);
            lista.Items.Add(item2);
            lista.Items.Add(item3);
            lista.Items.Add(item4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Items.Remove(lista.SelectedItems[0]);
        }
    }
}
