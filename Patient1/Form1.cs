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

namespace Patient1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
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




            string username = txtuname.Text;
            string password = txtpass.Text;

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-R3232UKD\SQLEXPRESS;Initial Catalog=PatientDB;Integrated Security=True;");
            con.Open();

            string query = "SELECT PatientID, Username FROM Patient WHERE Username=@user AND Password=@pass";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                UserSas.ID = Convert.ToInt32(reader["PatientID"]);
                UserSas.Username = reader["Username"].ToString();

                MessageBox.Show("Logged in ID = " + UserSas.ID);

                Dashboard d = new Dashboard();
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void btnforget_Click(object sender, EventArgs e)
        {
            ResetPass rs = new ResetPass();
            rs.Show();
            this.Hide();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblpass_Click(object sender, EventArgs e)
        {

        }

        private void lbluname_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void errorlbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
