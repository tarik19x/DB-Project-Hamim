using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Donor
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lgnbtn_Click(object sender, EventArgs e)
        {
            errorpasslbl.Text= erroruserlbl.Text = "";
            if (usertxt.Text == "")
            {
                erroruserlbl.Text = "Please input username";
            }

            if (passtxt.Text == "")
            {
                errorpasslbl.Text = "Please input password";
            }

            


            string username = usertxt.Text;
            string password = passtxt.Text;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LOHKJJT\SQLEXPRESS;Initial Catalog=donorDb;Integrated Security=True;");
            con.Open();

            string query = "SELECT ID, Username FROM Registration WHERE Username=@user AND Password=@pass";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                UserSassion.Id = Convert.ToInt32(reader["ID"]);
                UserSassion.Username = reader["Username"].ToString();

                MessageBox.Show("Logged in ID = " + UserSassion.Id);

                Dashbord db = new Dashbord();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

            con.Close();


        }

        private void registerlinklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }
    }
}
