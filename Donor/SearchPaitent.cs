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
    public partial class SearchPaitent : Form
    {
        public SearchPaitent()
        {
            InitializeComponent();
        }

        private void bldgrplbl_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchlbl_Click(object sender, EventArgs e)
        {
            errorbloodlbl.Text = "";
            errorlocationlbl.Text = "";
            if (locationtxt.Text == "")
            {
                errorlocationlbl.Text = "Please input address";
            }

            // Blood group validation
            if (bloodgroupcombo.Text == "")
            {
                errorbloodlbl.Text = "Please select blood group";
            }





            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LOHKJJT\sqlexpress;Initial Catalog=BloodDb;Integrated Security=True;");

            conn.Open();

            string query = "SELECT * FROM Registertab WHERE Location='"
            + locationtxt.Text + "' AND BloodGroup='"
            + bloodgroupcombo.Text + "'";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            dataGridView1.DataSource = dt;

            dataGridView1.AutoGenerateColumns = true;

            conn.Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Dashbord ds = new Dashbord();
            ds.Show();
            this.Hide();
        }
    }
}
