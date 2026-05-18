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
using static System.Collections.Specialized.BitVector32;

namespace Patient1
{
    public partial class ViewProfile : Form
    {
        public ViewProfile()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {

            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
           
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-R3232UKD\SQLEXPRESS;Initial Catalog=PatientDB;Integrated Security=True;");

            conn.Open();

            string query = "SELECT * FROM Patient WHERE PatientID = @id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", UserSas.ID);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                resultlbl.Text =
                    "ID: " + dr["PatientID"] + "\n" + "\n" +

                    "Username: " + dr["Username"] + "\n" + "\n" +

                    "Name: " + dr["Name"] + "\n" + "\n" +

                    "Location: " + dr["Address"] + "\n" + "\n" +

                    "Blood Group: " + dr["BloodGroup"] + "\n" + "\n" +

                    "Date of Birth: " + dr["DateOfBirth"] + "\n" + "\n" +

                    "Gender :" + dr["Gender"];
            }
            else
            {
                MessageBox.Show("No record found");
            }

            conn.Close();
        }

        private void resultlbl_Click(object sender, EventArgs e)
        {
           
        }

        private void btndash_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
    }
}