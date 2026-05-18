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
    public partial class CheckBlood : Form
    {
        public CheckBlood()
        {
            InitializeComponent();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-R3232UKD\SQLEXPRESS;Initial Catalog=PatientDB;Integrated Security=True;");

            conn.Open();

            string bg = comboBox1.Text;

            string query = "SELECT * FROM BloodReceive WHERE BloodGroup = @BloodGroup";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@BloodGroup", bg);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adp.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }
    }
}
