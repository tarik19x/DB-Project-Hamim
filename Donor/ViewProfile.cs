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
    public partial class ViewProfile : Form
    {
        public ViewProfile()
        {
            InitializeComponent();
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(
    @"Data Source=DESKTOP-LOHKJJT\SQLEXPRESS;
    Initial Catalog=donorDb;
    Integrated Security=True;
    TrustServerCertificate=True;");

            conn.Open();

            string query = "SELECT * FROM Registration WHERE ID = @id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", UserSassion.Id);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                resultlbl.Text =
                    "ID: " + dr["ID"] + "\n" + 
                      "Username: " + dr["Username"] + "\n" +

                    "Name: " + dr["Name"] + "\n"  +
                    "Location: " + dr["Address"] + "\n" +
                    "Blood Group: " + dr["Blood Group"] + "\n"  +
                    "Date of Birth: " + dr["Date of Birth"] + "\n"  +
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Dashbord ds= new Dashbord();
            ds.Show();
            this.Hide();
        }
    }
}
