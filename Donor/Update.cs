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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LOHKJJT\SQLEXPRESS;Initial Catalog=donorDb;Integrated Security=True;");
            con.Open();

         
            string selectQuery = "SELECT Name, [Date of Birth], Address, Password FROM Registration WHERE ID=@id";

            SqlCommand selectCmd = new SqlCommand(selectQuery, con);
            selectCmd.Parameters.AddWithValue("@id", UserSassion.Id);

            SqlDataReader reader = selectCmd.ExecuteReader();

            string oldName = "";
            string oldAddress = "";
            string oldPassword = "";
            DateTime oldDob = DateTime.Now;

            if (reader.Read())
            {
                oldName = reader["Name"].ToString();
                oldAddress = reader["Address"].ToString();
                oldPassword = reader["Password"].ToString();
                oldDob = Convert.ToDateTime(reader["Date of Birth"]);
            }

            reader.Close();

           
            string newName = string.IsNullOrWhiteSpace(nametxt.Text) ? oldName : nametxt.Text;
            string newAddress = string.IsNullOrWhiteSpace(addresstxt.Text) ? oldAddress : addresstxt.Text;
            string newPassword = string.IsNullOrWhiteSpace(passtxt.Text) ? oldPassword : passtxt.Text;

            DateTime newDob = dobpicker.Checked ? dobpicker.Value : oldDob;

          
            string updateQuery = @"UPDATE Registration 
                           SET Name=@name,
                               Address=@address,
                               Password=@pass,
                               [Date of Birth]=@dob
                           WHERE ID=@id";

            SqlCommand updateCmd = new SqlCommand(updateQuery, con);

            updateCmd.Parameters.AddWithValue("@name", newName);
            updateCmd.Parameters.AddWithValue("@address", newAddress);
            updateCmd.Parameters.AddWithValue("@pass", newPassword);
            updateCmd.Parameters.AddWithValue("@dob", newDob);
            updateCmd.Parameters.AddWithValue("@id", UserSassion.Id);

            updateCmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Profile Updated Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashbord ds =new Dashbord();
            ds.Show();
            this.Hide();
        }
    }
}
