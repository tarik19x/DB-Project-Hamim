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
using Donor;

namespace Donor
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        public object GetLoginInfo { get; private set; }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Dashbord ds = new Dashbord();
            ds.Show();
            this.Hide();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LOHKJJT\SQLEXPRESS;Initial Catalog=donorDb;Integrated Security=True;");

            con.Open();

            // check id and password
            string query = "SELECT * FROM Registration WHERE ID=@id AND Password=@pass";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", UserSassion.Id);
            cmd.Parameters.AddWithValue("@pass", password);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete your account?",
                    "Delete Account",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM Registration WHERE Id=@id";

                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);

                    deleteCmd.Parameters.AddWithValue("@id", UserSassion.Id);

                    deleteCmd.ExecuteNonQuery();

                    MessageBox.Show("Account Deleted Successfully");

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }

            con.Close();
        }

        private void passlbl_Click(object sender, EventArgs e)
        {

        }
    }

}
