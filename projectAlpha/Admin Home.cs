using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectAlpha
{
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Product_Form pform = new Product_Form();

            pform.FormClosed += FormClosed;

            pform.Show();

            this.Hide();

        }
        private void FormClosed(object sender, FormClosedEventArgs e)
        {

            this.Close();
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer_Form obj = new Customer_Form();
            obj.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            AdminLogin  obj = new AdminLogin();
            obj.Show();
            this.Hide();
        }

        private void btnProductQuantity_Click(object sender, EventArgs e)
        {
            ProductReports prep = new ProductReports();
            prep.Show();
            this.Hide();

        }

        private void btnSalesReports_Click(object sender, EventArgs e)
        {
            OrderReports orep = new OrderReports();
            orep.Show();
            this.Hide();
        }

        private void btnCustomerReports_Click(object sender, EventArgs e)
        {
            CustomerReports crep = new CustomerReports();
            crep.Show();
            this.Hide();
        }

        private void Admin_Home_Load(object sender, EventArgs e)
        {
            lblAdminDetails.BackColor = Color.Transparent;
            lblAdminHome.BackColor = Color.Transparent;
            lblAdminReports.BackColor = Color.Transparent;
            btnCustomer.BackColor = Color.Transparent;
            btnCustomerReports.BackColor = Color.Transparent;
            btnLogOut.BackColor = Color.Transparent;
            btnOrder.BackColor = Color.Transparent;
            btnProductQuantity.BackColor = Color.Transparent;
            btnProducts.BackColor = Color.Transparent;
            btnSalesReports.BackColor = Color.Transparent;
            
        }
    }
}
