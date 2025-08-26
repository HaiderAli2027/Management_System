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
    public partial class Home_Form : Form
    {
        public Home_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Home_Form_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin AdminLogin = new AdminLogin();
            AdminLogin.FormClosed +=FormClosed ;

            AdminLogin.Show();
            this.Hide();

        }
        private void FormClosed(object sender, FormClosedEventArgs e)
        {

            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AdminLogin login = new AdminLogin();
            login.FormClosed += FormClosed;
            login.Show();
            this.Hide();
        }
    }
}
