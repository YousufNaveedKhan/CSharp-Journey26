using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace lec09_POSAPP
{
    public partial class Form1 : Form
    {
        List<Product> cart = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }
        void CalculateTotal()
        {
            double total = 0;
            foreach (var item in cart)
            {
                total += item.TotalPrice();
            }
            lblTotal.Text = "Total: " + total.ToString("C", CultureInfo.CreateSpecificCulture("ur-PK"));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.name = txtName.Text;
                p.price = Convert.ToDouble(txtPrice.Text);
                p.quantity = Convert.ToInt32(txtQty.Text);
                cart.Add(p);

                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=POSAPP;Integrated Security=True");
                con.Open();
                String query = "INSERT INTO Products (Name, Price, Quantity) VALUES (@name, @price, @quantity)";
                
                SqlCommand cmd = new SqlCommand(query, con);
                
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@price", p.price);
                cmd.Parameters.AddWithValue("@quantity", p.quantity);

                cmd.ExecuteNonQuery();
                con.Close();

                listBox1.Items.Add(p.name + " - " + p.price + " x " + p.quantity);

                CalculateTotal();

                MessageBox.Show("Product added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total amount: " + lblTotal.Text);
        }
    }
}
