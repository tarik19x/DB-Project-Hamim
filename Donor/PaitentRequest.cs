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
    public partial class PaitentRequest : Form
    {
        public PaitentRequest()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LOHKJJT\sqlexpress;Initial Catalog=PatientDB;Integrated Security=True;");

            conn.Open();

            string query = "SELECT * FROM BloodReq ";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            dataGridView1.DataSource = dt;

            dataGridView1.AutoGenerateColumns = true;

            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashbord ds = new Dashbord();
            ds.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a request first.");
                return;
            }

            int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["RequestID"].Value);

            SqlConnection conn = new SqlConnection(
                @"Data Source=DESKTOP-LOHKJJT\sqlexpress;
        Initial Catalog=PatientDB;
        Integrated Security=True;
        ");

            conn.Open();

            string query = "UPDATE BloodReq SET Status = 'Accepted' WHERE RequestId = @id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", selectedId);

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("Request Accepted Successfully!");
                LoadRequests(); // refresh grid
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }





        private void LoadRequests()
        {
            SqlConnection conn = new SqlConnection(
                @"Data Source=DESKTOP-LOHKJJT\sqlexpress;
        Initial Catalog=PatientDB;
        Integrated Security=True;
       ");

            conn.Open();

            string query = "SELECT * FROM BloodReq";

            SqlDataAdapter adp = new SqlDataAdapter(query, conn);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a request first.");
                return;
            }

            int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["RequestId"].Value);

            SqlConnection conn = new SqlConnection(
                @"Data Source=DESKTOP-LOHKJJT\sqlexpress;
        Initial Catalog=PatientDB;
        Integrated Security=True;
       ");

            conn.Open();

            string query = "UPDATE BloodReq SET Status = 'Rejected' WHERE RequestId = @id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", selectedId);

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("Request Rejected!");
                LoadRequests(); // refresh DataGridView
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }

        private void PaitentRequest_Load(object sender, EventArgs e)
        {

        }
    }
}
