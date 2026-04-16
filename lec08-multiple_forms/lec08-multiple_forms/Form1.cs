using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lec08_multiple_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter your name!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DashboardForm d = new DashboardForm();

            d.userName = txtName.Text;

            this.Hide();
            d.Show();
        }
    }
}
