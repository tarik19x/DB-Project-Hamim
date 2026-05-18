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
    public partial class DeleteProfile : Form
    {
        public DeleteProfile()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-R3232UKD\SQLEXPRESS;Initial Catalog=PatientDB;Integrated Security=True;");

            conn.Open();

            string query = "Delete from Patient where PatientID=" + txtid.Text;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully");
            conn.Close();
        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }
    }
}
