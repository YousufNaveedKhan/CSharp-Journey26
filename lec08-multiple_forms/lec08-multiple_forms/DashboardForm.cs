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
    public partial class DashboardForm : Form
    {
        public string userName;
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPrName.Text == "" ||  txtPrice.Text == "" || txtQty.Text == "")
            {
                MessageBox.Show("Please fill all required fields!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string name = txtPrName.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQty.Text);

            double total = price * quantity;

            lstItems.Items.Add(name + " - " + price + " - " + quantity + " - " + total);
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + userName;
        }
    }
}
