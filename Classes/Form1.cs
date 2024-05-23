using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Employee personelDetail = new Employee();
        private void button2_Click(object sender, EventArgs e)
        {
            
            personelDetail.EmployeeID = Convert.ToInt32(txtEmployeeId.Text);
            personelDetail.Name = txtName.Text;
            personelDetail.Age = Convert.ToInt32(txtAge.Text);
            MessageBox.Show("All Data Received");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            personelDetail.EmployeeID = Convert.ToInt32(txtEmployeeId.Text);
            personelDetail.Name = txtName.Text;
            personelDetail.Age = Convert.ToInt32(txtAge.Text);
            Form2 frm = new Form2();
            frm.personelDetail = personelDetail;
            frm.ShowDialog();
                }
    }
}
