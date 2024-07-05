using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace newFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List.Items.Clear();
            FileInfo info = new FileInfo(@"D:\Download\teste.txt");



            List.Items.Add(info.FullName);
            List.Items.Add(info.Name);
            List.Items.Add(info.Extension);
            List.Items.Add(info.Directory.FullName);
            List.Items.Add(info.DirectoryName);
            List.Items.Add(info.CreationTime);
            List.Items.Add(info.Exists);


        }
    }
}
