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
    public partial class Register : Form
    {
        string name, uname, pass, gender,bloodgroup, address;

        private void btnbackl_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void lblblood_Click(object sender, EventArgs e)
        {

        }

        private void lbladdress_Click(object sender, EventArgs e)
        {

        }

        DateTime dob;
        public Register()
        {
            InitializeComponent();
        }

        private void txtuname_Click(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = txtname.Text;
            uname = txtuname.Text;
            pass = txtpass.Text;
            bloodgroup = comboBox1.Text;
            gender = "";

            if (rbmale.Checked)
            {
                gender = "Male";
            }
            else if (rbfemale.Checked)
            {
                gender = "Female";
            }
            address = richTextBox1.Text;
            dob = dateTimePicker1.Value;
            bool isValid = true;

            errorlbl1.Text = "";
            errorlbl2.Text = "";
            errorlbl3.Text = "";
            errorlbl4.Text = "";
            errorlbl5.Text = "";
            errorlbl6.Text = "";

            if (txtname.Text == "")
            {
                errorlbl1.Text = "Please enter Name";
                isValid = false;
            }

            if (txtuname.Text == "")
            {
                errorlbl2.Text = "Please enter username";
                isValid = false;
            }

            if (txtpass.Text == "")
            {
                errorlbl3.Text = "Please enter Password";
                isValid = false;
            }

            if (!rbmale.Checked && !rbfemale.Checked)
            {
                errorlbl4.Text = " Please Select Gender";
                isValid = false;
            }


            if (comboBox1.Text == "")
            {
                errorlbl5.Text = " Please Select Blood Group";
                isValid = false;
            }


            if (richTextBox1.Text == "")
            {
                errorlbl6.Text = "Please Enter Address";
                isValid = false;
            }
            if (!isValid)
            {
                MessageBox.Show("Invalid Input");
                return;
            }
          

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-R3232UKD\SQLEXPRESS;Initial Catalog=PatientDB;Integrated Security=True;");
            conn.Open();
            string query = "INSERT INTO Patient (Name, Username, Password, Gender, BloodGroup, DateOfBirth, Address) VALUES ('" + name + "', '" + uname + "', '" + pass + "', '" + gender + "', '" + bloodgroup + "', '" + dob.ToString("yyyy-MM-dd") + "', '" + address + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Profile Registered Successfully");
        }
    }
}
