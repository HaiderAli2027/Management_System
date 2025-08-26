using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectAlpha
{
    internal class sqlConnect
    {
        public static SqlConnection cnct = null;
         public void DBConnection()
        {

            try
            {
                cnct = new SqlConnection("Data Source=DESKTOP-U5AHBN7;Initial Catalog=ShowroomSystem;Integrated Security=True");
                cnct.Open();
                if (cnct.State == ConnectionState.Closed || cnct.State == ConnectionState.Broken)
                {
                    MessageBox.Show("Fail to open database");
                }
                //else
                //{
                //    MessageBox.Show("open database");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }
        public static void CloseConnection()
        {
            if (cnct != null && cnct.State == System.Data.ConnectionState.Open)
            {
                cnct.Close();
            }
        }

    }
}
