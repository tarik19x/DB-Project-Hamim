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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Patient1
{
    public partial class ResetPass : Form
    {
        public ResetPass()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            errorlbl1.Text = errorlbl2.Text = "";
            if (txtuname.Text == "")
            {
                errorlbl1.Text = "Please input username";
            }

            if (txtpass.Text == "")
            {
                errorlbl2.Text = "Please input password";
            }

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-R3232UKD\SQLEXPRESS;Initial Catalog=PatientDB;Integrated Security=True;");

            conn.Open();

            string query = "UPDATE Registertable SET Password=@pass WHERE Username=@uname";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@pass", txtpass.Text);

            cmd.Parameters.AddWithValue("@uname", txtuname.Text);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Password Updated Successfully");
            }
            else
            {
                MessageBox.Show("Username Not Found");
            }

            conn.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
