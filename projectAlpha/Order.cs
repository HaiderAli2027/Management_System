using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectAlpha
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void dgvinvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect obj = new sqlConnect();
                obj.DBConnection();
                string Cnic = (txtCustomerCnic.Text);


                if (String.IsNullOrEmpty(Cnic) )
                {
                    MessageBox.Show("Enter the Cnic");
                }

                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlConnect.cnct;
                    cmd.CommandType = CommandType.Text;
                    

                    string Query1 = "Select * From Customer Where cnic = @Cnic";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter (Query1,sqlConnect.cnct);


                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Cnic", Cnic);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count >0)
                    {
                    
                        dgvinvoice.DataSource = dataTable;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnect.CloseConnection();
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            sqlConnect obj = new sqlConnect();
            obj.DBConnection();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = sqlConnect.cnct;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " Select product_line_id From ProductLine";
                SqlDataReader reader = cmd.ExecuteReader();




                while (reader.Read())
                {
                    ComBoxProductLineid.Items.Add(reader["product_line_id"].ToString());

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect obj = new sqlConnect();
                obj.DBConnection();
                string ProductType = txtProducttype.Text;
                int quantity = 0;


                if (String.IsNullOrEmpty(ProductType))
                {
                    MessageBox.Show("Enter the Product Type");
                }

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlConnect.cnct;
                    cmd.CommandType = CommandType.Text;


                    string Query1 = "Select * From Product Where Product_Type = @ProductType AND quantity > @available";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(Query1, sqlConnect.cnct);

                    dataAdapter.SelectCommand.Parameters.AddWithValue("@available", quantity);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@ProductType", ProductType);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {

                        dgvinvoice.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Product Not Available");
                    }

                }



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnect.CloseConnection();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect obj = new sqlConnect();
                obj.DBConnection();

                //******* All Attributes Of Order Form *************
                string ProductLineID = ComBoxProductLineid.Text;
                string Customerid = txtCustomerid.Text;
                string Productid = txtProductid.Text;
                string SalePrice = txtSalePrice.Text;
                string Quantity = ( txtQuantity.Text);
               

                //**************************************************

                if (String.IsNullOrWhiteSpace(ProductLineID) || string.IsNullOrWhiteSpace(Customerid) ||
               String.IsNullOrWhiteSpace(Productid) || string.IsNullOrWhiteSpace(SalePrice) ||
               string.IsNullOrWhiteSpace(Quantity))
                {
                    MessageBox.Show("Fill the necessary Information", "Alert", MessageBoxButtons.OKCancel);
                }
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlConnect.cnct;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO PlaceOrder (product_line_id, product_id, Customer_id, Order_price, quantity) VALUES (@ProductLineID,@Productid,@Customerid,@SalePrice,@Quantity) ";
                    cmd.CommandText = " UPDATE Product SET quantity = quantity - @Quantity WHERE product_id = @ProductID";
                    cmd.Parameters.AddWithValue("@Productid", Productid);
                    cmd.Parameters.AddWithValue("@ProductLineID", ProductLineID);
                    cmd.Parameters.AddWithValue("@Customerid", Customerid);
                    cmd.Parameters.AddWithValue("@SalePrice", SalePrice);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        
                        MessageBox.Show("Order Placed successfully.");
                        txtProducttype.Text = null;
                        txtCustomerCnic.Text = null;
                        ComBoxProductLineid.Text = null;
                        txtCustomerid.Text= null;
                        txtProductid.Text = null;
                        txtSalePrice.Text = null;
                        txtQuantity.Text =null;
                    }
                    else
                    {
                        MessageBox.Show("Failed to Place order");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                sqlConnect.CloseConnection();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home_Form home_Form = new Home_Form();
            home_Form.Show();
            this.Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer_Form customer_Form = new Customer_Form();
            customer_Form.Show();
            this.Close();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product_Form product_Form = new Product_Form();
            product_Form.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            AdminLogin login = new AdminLogin();
            login.Show();
            this.Hide();
        }

        private void txtCustomerCnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }

            else if (e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtProducttype_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }

            else if (e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCustomerid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }

            else if (e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtProductid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }

            else if (e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }

            else if (e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }

            else if (e.KeyChar == (char)Keys.Tab || e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect obj = new sqlConnect();
                obj.DBConnection();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlConnect.cnct;
                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter("Select * From PlaceOrder", sqlConnect.cnct);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        dgvinvoice.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error Occured");
            }
            finally
            {
                sqlConnect.CloseConnection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvinvoice.DataSource = "";
        }
    }
}
