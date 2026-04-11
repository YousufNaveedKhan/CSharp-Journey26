using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lec07_studentapp
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAge.Text == "" || txtMarks.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Student stdOne = new Student();

            stdOne.name = txtName.Text;
            stdOne.age = Convert.ToInt32(txtAge.Text);
            stdOne.marks = Convert.ToDouble(txtMarks.Text);

            string res = stdOne.GetResult();
            MessageBox.Show($"Name: {stdOne.name}\nAge: {stdOne.age}\nMarks: {stdOne.marks}\nResult: {res}", "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtAge.Text == "" && txtMarks.Text == "")
            {
                MessageBox.Show("Fields are already empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtName.Clear();
            txtAge.Clear();
            txtMarks.Clear();
            result.Text = "";
        }
    }
}
