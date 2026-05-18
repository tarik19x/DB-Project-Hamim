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
    public partial class RequestDonor : Form
    {
        int patientId, donorId;
        string bloodGroup;
        public RequestDonor()
        {
            InitializeComponent();
        }

        private void lbldonor_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void btnreq_Click(object sender, EventArgs e)
        {
            //bool isValid = true;

            /* errorlbl1.Text = "";
             errorlbl2.Text = "";
             errorlbl3.Text = "";

             // Example textbox and combobox names
             // Change these names according to your form controls

             if (txtpatientid.Text == "")
             {
                 errorlbl1.Text = "Please Enter Patient ID";
                 isValid = false;
             }

             if (txtdonorid.Text == "")
             {
                 errorlbl2.Text = "Please Enter Donor ID";
                 isValid = false;
             }

             if (comboBox1.Text == "")
             {
                 errorlbl3.Text = "Please Select Blood Group";
                 isValid = false;
             }

             if (!isValid)
             {
                 MessageBox.Show("Invalid Input");
                 return;
             }*/

            //patientId = Convert.ToInt32(txtid.Text);
            donorId = Convert.ToInt32(txtdid.Text);

            bloodGroup = comboBox1.Text;

            // getting patient id from UserSas class
            patientId = UserSas.ID;

            SqlConnection conn = new SqlConnection(
                @"Data Source=LAPTOP-R3232UKD\SQLEXPRESS;Initial Catalog=PatientDB;Integrated Security=True;"
            );

            conn.Open();

            string query = "INSERT INTO BloodReq " +
                           "(PatientID, DonorID, BloodGroup, RequestDate, Status) " +
                           "VALUES ('" + patientId + "','" + donorId + "','" +
                           bloodGroup + "','" + DateTime.Now.ToString("yyyy-MM-dd") +
                           "','Pending')";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Request Sent Successfully");
        }
    }
}
