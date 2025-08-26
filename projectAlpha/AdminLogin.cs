using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectAlpha
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        private void FormClosed(object sender, FormClosedEventArgs e)
        {

            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string User = null;
            string Pass = null;
            int? Admin_id = null;
            int? manager_id = null;
            try
            {
                sqlConnect obj = new sqlConnect();
                obj.DBConnection();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlConnect.cnct;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select UserName ,Password,Admin_id,manager_id From Login_ID Where (UserName = @UserName)";
                    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);

                    SqlDataReader R = cmd.ExecuteReader();
                    if (R.Read())
                    {

                        User = R["UserName"].ToString();
                        Pass = R["Password"].ToString();
                        Admin_id = R["Admin_id"] as int?;
                        manager_id = R["manager_id"] as int?;
                                              
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
            if (txtUserName.Text == User && txtPassword.Text == Pass)
            {
                if (Admin_id.HasValue)
                {
                    Admin_Home admin_Home = new Admin_Home();
                    admin_Home.FormClosed += FormClosed;
                    admin_Home.Show();
                    this.Hide();
                }
                else if(manager_id.HasValue)
                {
                    Manager_Home mhome = new Manager_Home();
                    mhome.FormClosed += FormClosed;
                    mhome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User Does not Exist");
                }

            }
            else
            {
                MessageBox.Show("Incorrect UserName or Password");
            }



        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else 
            {
                txtPassword.PasswordChar = '*';
            }
           
           
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
           if(txtUserName.Text =="User Name")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
           }
            
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.Text = "User Name";
                txtUserName.ForeColor = Color.Silver;
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace (txtPassword.Text) )
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text == "Password")
            {
                checkBox1.Checked = false;
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            txtUserName.TabStop = false;
            txtPassword.TabStop = false;
            btncancel.TabStop = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cancel Login ?", "Alert", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Home_Form home = new Home_Form();
                home.Show();
                this.Hide();
            }
        }

        private void lblName1_Click(object sender, EventArgs e)
        {

        }
    }
}
