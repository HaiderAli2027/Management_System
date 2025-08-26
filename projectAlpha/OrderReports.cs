using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectAlpha
{
    public partial class OrderReports : Form
    {
        public OrderReports()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Enter Product Name";
                textBox1.ForeColor = Color.Silver;
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)  || e.KeyChar == (char)Keys.Space)
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Product Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.Text = "Enter Product Model";
                textBox4.ForeColor = Color.Silver;
            }
          
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar)|| e.KeyChar == (char)Keys.Space)
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

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Enter Product Model")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                textBox3.Text = "Enter Customer's CNIC";
                textBox3.ForeColor = Color.Silver;
            }
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Enter Customer's CNIC")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void button4_Click(object sender, EventArgs e)
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
                        dataGridView1.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect obj = new sqlConnect();
                obj.DBConnection();
                string Name = (textBox1.Text);
                string Model = (textBox4.Text);


                if (String.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Model))
                {
                    MessageBox.Show("Enter Product Name and Model");
                }

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlConnect.cnct;
                    cmd.CommandType = CommandType.Text;


                    string Query1 = "SELECT Customer.* FROM   Customer INNER JOIN PlaceOrder ON Customer.customer_id = PlaceOrder.customer_id INNER JOIN  Product ON PlaceOrder.product_id = Product.product_id WHERE Product.product_name = @Name AND Product.model = @Model";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(Query1, sqlConnect.cnct);


                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Name", Name);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Model", Model);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {

                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Enter Appropriate Product Name and Model");
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect obj = new sqlConnect();
                obj.DBConnection();
                string Cnic = (textBox3.Text);


                if (String.IsNullOrEmpty(Cnic))
                {
                    MessageBox.Show("Enter the Cnic");
                }

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlConnect.cnct;
                    cmd.CommandType = CommandType.Text;


                    string Query1 = "SELECT Product.product_name,Product.model,PlaceOrder.order_price AS [Sale Price]FROM  Customer INNER JOIN PlaceOrder ON Customer.customer_id = PlaceOrder.customer_id INNER JOIN Product ON PlaceOrder.product_id = Product.product_id  Where Customer.cnic =@Cnic";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(Query1, sqlConnect.cnct);


                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Cnic", Cnic);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {

                        dataGridView1.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("Enter Appropriate Cnic");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Home back = new Admin_Home();
            back.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
        }
    }
}
