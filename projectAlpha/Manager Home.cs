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
    public partial class Manager_Home : Form
    {
        public Manager_Home()
        {
            InitializeComponent();
        }

        private void btnproducts_Click(object sender, EventArgs e)
        {

            Product_Form obj = new Product_Form();
            obj.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
           Customer_Form obj = new Customer_Form();
            obj.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order obj = new Order();
            obj.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            AdminLogin login = new AdminLogin();
            login.Show();
            this.Hide();
        }

        private void Manager_Home_Load(object sender, EventArgs e)
        {
            lblManagerDetails.BackColor = Color.Transparent;
            lblManagerHome.BackColor = Color.Transparent;
            btnCustomer.BackColor = Color.Transparent;
            btnOrder.BackColor = Color.Transparent;
            btnproducts.BackColor = Color.Transparent;
            btnLogOut.BackColor = Color.Transparent;
        }
    }
}
