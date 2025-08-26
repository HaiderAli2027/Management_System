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
using System.Xml.Linq;

namespace projectAlpha
{
    public partial class Product_Form : Form
    {
        public Product_Form()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer_Form customer_Form = new Customer_Form();
            customer_Form.Show();
            this.Hide();
        }

        private void ComBoxProductLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComBoxProductLine.Text == "VEH02")
            {
                panelForVehicles.Visible = true;
                panelForElectronics.Visible = false;
            }
            else if (ComBoxProductLine.Text == "ELE01")
            {
                panelForElectronics.Visible = true;
                panelForVehicles.Visible = false;
            }
            else
            {
                MessageBox.Show("Select The Product Line ");

                panelForElectronics.Visible = false;
                panelForVehicles.Visible = false;

            }


        }

        private void Product_Form_Load(object sender, EventArgs e)
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
                    ComBoxProductLine.Items.Add(reader["product_line_id"].ToString());

                }
            }
        

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect obj = new sqlConnect();
                obj.DBConnection();

                //******* All Attributes Of Customer Form *************
                string ProductLineID = ComBoxProductLine.Text;
                string name = txtProductName.Text;
                string Price = txtProductPrice.Text;
                string Quantity = txtProductQuantity.Text;
                string Product_Type = txtProductType.Text;
                String Colour = txtProduct_E_Colour.Text;
                String Model = txtProduct_E_Model.Text;
                String Size = txtProduct_E_Size.Text;
                String Warrenty = txtProduct_E_Warrenty.Text;
                String ChasisNo = txtProduct_V_ChasisNo.Text;
                String EngineNo = txtProduct_V_EngineNo.Text;
                
                //**************************************************

                if (String.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(Quantity) ||
               String.IsNullOrWhiteSpace(Price) || string.IsNullOrWhiteSpace(Product_Type) ||
               string.IsNullOrWhiteSpace(Model))
                {
                    MessageBox.Show("Fill the necessary Information", "Alert", MessageBoxButtons.OKCancel);
                }
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlConnect.cnct;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Product (product_line_id, product_name, price, Product_Type, quantity, engine_number, chasis_number, colour, model, size, warranty) VALUES (@ProductLineID,@name,@Price,@Product_Type,@Quantity,@EngineNo,@ChasisNo,@Colour,@Model,@Size,@Warrenty) ";

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@ProductLineID", ProductLineID);
                    cmd.Parameters.AddWithValue("@Price", Price);
                    cmd.Parameters.AddWithValue("@Product_Type", Product_Type);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@EngineNo", EngineNo);
                    cmd.Parameters.AddWithValue("@ChasisNo", ChasisNo);
                    cmd.Parameters.AddWithValue("@Colour", Colour);
                    cmd.Parameters.AddWithValue("@Size", Size);
                    cmd.Parameters.AddWithValue("@Model", Model);
                    cmd.Parameters.AddWithValue("@Warrenty", Warrenty);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Product data added successfully.");
                        ComBoxProductLine.Text = "";
                        txtProductName.Text = "";
                        txtProductPrice.Text = "";
                        txtProductQuantity.Text = "";
                        txtProductType.Text = "";
                        txtProduct_E_Colour.Text = "";
                        txtProduct_E_Model.Text = "";
                        txtProduct_E_Size.Text = "";
                        txtProduct_E_Warrenty.Text = "";
                        txtProduct_V_ChasisNo.Text = "";
                        txtProduct_V_EngineNo.Text = "";
                    }

                    else
                    {
                        MessageBox.Show("Failed to add Product data.");
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect obj = new sqlConnect();
                obj.DBConnection();

                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlConnect.cnct;
                    cmd.CommandType = CommandType.Text;
                    
                    SqlDataAdapter da = new SqlDataAdapter("Select * From Product",sqlConnect.cnct);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("An error Occured");
            }
            finally
            {
                sqlConnect.CloseConnection();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect obj = new sqlConnect();
                obj.DBConnection();
                string ProductLineID = ComBoxProductLine.Text;
                string name = txtProductName.Text;
                string Price = txtProductPrice.Text;
                string Quantity = txtProductQuantity.Text;
                string Product_Type = txtProductType.Text;
                String Colour = txtProduct_E_Colour.Text;
                String Model = txtProduct_E_Model.Text;
                String Size = txtProduct_E_Size.Text;
                String Warrenty = txtProduct_E_Warrenty.Text;
                String ChasisNo = txtProduct_V_ChasisNo.Text;
                String EngineNo = txtProduct_V_EngineNo.Text;

                if (string.IsNullOrEmpty(name)  ||
                   string.IsNullOrWhiteSpace(Product_Type)
                   || string.IsNullOrWhiteSpace(Model))
                {
                    MessageBox.Show("Write the Name,Model and Product Type ", "Alert", MessageBoxButtons.OKCancel);
                }

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlConnect.cnct;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "UPDATE  Product SET  product_line_id = @ProductLine, product_name = @ProductName, price = @ProductPrice, Product_Type = @ProductType, quantity = @Quantity, engine_number = @EngineNo, chasis_number = @ChasisNo, Colour = @Colour, model = @Model, size = @Size, warranty= @Warrenty  Where  product_name = @ProductName And  Product_Type = @ProductType And  model = @Model";

                    cmd.Parameters.AddWithValue("@ProductLine", ProductLineID);
                    cmd.Parameters.AddWithValue("@ProductName", name);
                    cmd.Parameters.AddWithValue("@ProductPrice", Price);
                    cmd.Parameters.AddWithValue("@ProductType", Product_Type);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@EngineNo", EngineNo);
                    cmd.Parameters.AddWithValue("@ChasisNo", ChasisNo);
                    cmd.Parameters.AddWithValue("@Colour", Colour);
                    cmd.Parameters.AddWithValue("@Model", Model);
                    cmd.Parameters.AddWithValue("@Warrenty", Warrenty);
                    cmd.Parameters.AddWithValue("@Size", Size);


                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data is Updated Successfully ");
                        
                    }
                    else
                    {
                        MessageBox.Show("Data is Not Updated ", "Alert", MessageBoxButtons.OK);
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect obj = new sqlConnect();
                obj.DBConnection();
                string ProductLineID = ComBoxProductLine.Text;
                string name = txtProductName.Text;
                string Price = txtProductPrice.Text;
                string Quantity = txtProductQuantity.Text;
                string Product_Type = txtProductType.Text;
                String Colour = txtProduct_E_Colour.Text;
                String Model = txtProduct_E_Model.Text;
                String Size = txtProduct_E_Size.Text;
                String Warrenty = txtProduct_E_Warrenty.Text;
                String ChasisNo = txtProduct_V_ChasisNo.Text;
                String EngineNo = txtProduct_V_EngineNo.Text;

                if (string.IsNullOrEmpty(name) ||
                   string.IsNullOrWhiteSpace(Product_Type)
                   || string.IsNullOrWhiteSpace(Model))
                {
                    MessageBox.Show("Write the Name,Model and Product Type ", "Alert", MessageBoxButtons.OKCancel);
                }

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlConnect.cnct;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "Delete From  Product   Where  product_name = @ProductName And  Product_Type = @ProductType And  model = @Model";

                    cmd.Parameters.AddWithValue("@ProductName", name);
                    cmd.Parameters.AddWithValue("@ProductType", Product_Type);
                    cmd.Parameters.AddWithValue("@Model", Model);
                    
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data is Deleted Successfully ");

                    }
                    else
                    {
                        MessageBox.Show("Data is Not Deleted ", "Alert", MessageBoxButtons.OK);
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home_Form home_Form = new Home_Form();
            home_Form.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            AdminLogin login = new AdminLogin();
            login.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
            this.Hide();
        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtProductQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtProductType_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtProduct_E_Model_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtProduct_E_Colour_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtProduct_V_EngineNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtProduct_V_ChasisNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtProduct_E_Size_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtProduct_E_Warrenty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
