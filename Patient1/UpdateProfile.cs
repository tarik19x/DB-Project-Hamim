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
    public partial class UpdateProfile : Form
    {
        public UpdateProfile()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string name, pass,  address;
            DateTime dob;

            name = txtname.Text;
          
            pass = txtpass.Text;
          
            address = richTextBox1.Text;

            dob = dateTimePicker1.Value;



            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-R3232UKD\SQLEXPRESS;Initial Catalog=PatientDB;Integrated Security=True;");
            con.Open();


            string selectQuery = "SELECT Name, DateOfBirth, Address, Password FROM Patient WHERE PatientID=@id";

            SqlCommand selectCmd = new SqlCommand(selectQuery, con);
            selectCmd.Parameters.AddWithValue("@id", UserSas.ID);

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
                oldDob = Convert.ToDateTime(reader["DateOfBirth"]);
            }

            reader.Close();


            string newName = string.IsNullOrWhiteSpace(txtname.Text) ? oldName : txtname.Text;
            string newAddress = string.IsNullOrWhiteSpace(richTextBox1.Text) ? oldAddress : richTextBox1.Text;
            string newPassword = string.IsNullOrWhiteSpace(txtpass.Text) ? oldPassword : txtpass.Text;

           DateTime newDob = dateTimePicker1.Checked ? dateTimePicker1.Value : oldDob;


            string updateQuery = @"UPDATE Patient
                SET Name=@name,
                    Address=@address,
                    Password=@pass,
                    DateOfBirth=@dob
                WHERE PatientID=@id";

            SqlCommand updateCmd = new SqlCommand(updateQuery, con);

            updateCmd.Parameters.AddWithValue("@name", newName);
            updateCmd.Parameters.AddWithValue("@address", newAddress);
            updateCmd.Parameters.AddWithValue("@pass", newPassword);
            updateCmd.Parameters.AddWithValue("@dob", newDob);
            updateCmd.Parameters.AddWithValue("@id", UserSas.ID);

            updateCmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Profile Updated Successfully");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
