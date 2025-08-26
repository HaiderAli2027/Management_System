using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace projectAlpha
{
    public partial class Customer_Form : Form
    {
        public Customer_Form()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order obj = new Order();
            obj.Show();
            this.Hide();
        }
        
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {



            try
            {
                sqlConnect obj = new sqlConnect();
                obj.DBConnection();

                //******* All Attributes Of Customer Form *************

                string name = txtCustomerName.Text;
                string FatherName = txtFatherName.Text;
                string Cnic = txtCnic.Text;
                string PhoneNo = txtPhoneNo.Text;
                String Address = txtAddress.Text;
                //**************************************************

                if (String.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(FatherName) ||
               String.IsNullOrWhiteSpace(Cnic) || string.IsNullOrWhiteSpace(PhoneNo) ||
               string.IsNullOrWhiteSpace(Address))
                {
                    MessageBox.Show("Fill All Above Information", "Alert", MessageBoxButtons.OKCancel);
                }
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlConnect.cnct;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert Into Customer(name, father_name, cnic, address, phone_number) Values (@name,@FatherName,@Cnic,@Address,@PhoneNo) ";

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@FatherName", FatherName);
                    cmd.Parameters.AddWithValue("@Cnic", Cnic);
                    cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                    cmd.Parameters.AddWithValue("@Address", Address);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Customer's data added successfully.");
                        txtCustomerName.Text = "";
                        txtFatherName.Text = "";
                        txtPhoneNo.Text = "";
                        txtCnic.Text = "";
                        txtAddress.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to add customer's data.");
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

        private void btnrRemoveCustomer_Click(object sender, EventArgs e)
        {
            try
            {

                sqlConnect obj = new sqlConnect();
                obj.DBConnection();

                string name = txtCustomerName.Text;
                string FatherName = txtFatherName.Text;
                string Address = txtAddress.Text;
                string Cnic = txtCnic.Text;
                string PhoneNo = txtPhoneNo.Text;

                if (String.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(Cnic) )
                {
                    MessageBox.Show("Fill Both Name & Cnic Fields", "Alert", MessageBoxButtons.OKCancel);
                }
                using (SqlCommand cmd =  new SqlCommand())
                {
                    cmd.Connection = sqlConnect.cnct;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete From Customer Where name = @name And cnic = @Cnic";

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@Cnic", Cnic);

                    int result = cmd.ExecuteNonQuery();
                    if(result > 0)
                    {
                        MessageBox.Show("Data is Deleted Successfully");
                        txtPhoneNo.Text = "";
                        txtAddress.Text = "";
                        txtCnic.Text = "";
                        txtCustomerName.Text = "";
                        txtFatherName.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Data is not Deleted Successfully","Alert",MessageBoxButtons.OKCancel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured", "Alert", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnect.CloseConnection();
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect obj = new sqlConnect();
                obj.DBConnection();

                string name = txtCustomerName.Text;
                string FatherName = txtFatherName.Text;
                string Address = txtAddress.Text;
                string Cnic = txtCnic.Text;
                string PhoneNo = txtPhoneNo.Text;

                if (string.IsNullOrEmpty(Cnic) || string.IsNullOrWhiteSpace(PhoneNo) ||
                     string.IsNullOrWhiteSpace(Address))
                {
                    MessageBox.Show("Fill the CNIC New Address or Phone No ", "Alert", MessageBoxButtons.OKCancel);
                }
                
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlConnect.cnct;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "UPDATE  Customer SET  address =@Address , phone_number =@PhoneNo  WHERE cnic = @Cnic ";

                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
                    cmd.Parameters.AddWithValue("cnic", Cnic);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data is Updated Successfully ");
                        txtPhoneNo.Text = "";
                        txtAddress.Text = "";
                        txtCnic.Text = "";
                        txtCustomerName.Text = "";
                        txtFatherName.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Data is Not Updated ","Alert",MessageBoxButtons.OK);
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("An Error Occured", "Alert", MessageBoxButtons.OK);
            }
            finally
            {
                sqlConnect.CloseConnection();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            Home_Form obj = new Home_Form();
            obj.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

            Product_Form obj = new Product_Form();
            obj.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            AdminLogin login = new AdminLogin();
            login.Show();
            this.Hide();
        }

        private void Customer_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtFatherName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Space)
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

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCnic_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
