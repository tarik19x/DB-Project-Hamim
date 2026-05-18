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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Donor
{
    
    
    public partial class Registration : Form
    {
        string name, uname, pass, gender, bloodgrp,add;
        DateTime dob;
        

        public Registration()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            errornamelbl.Text = erroruserlbl.Text = errorpasslbl.Text =
errorbloodlbl.Text = erroraddresslbl.Text = "";

            // Name validation
            if (nametxt.Text == "")
            {
                errornamelbl.Text = "Please input name";
            }

            // Username validation
            if (unametxt.Text == "")
            {
                erroruserlbl.Text = "Please input username";
            }

            // Password validation
            if (passwordtxt.Text == "")
            {
                errorpasslbl.Text = "Please input password";
            }

            // Blood group validation
            if (bldgrpcomb.Text == "")
            {
                errorbloodlbl.Text = "Please select blood group";
            }

            // Address validation
            if (addresstxt.Text == "")
            {
                erroraddresslbl.Text = "Please input address";
            }

            // Stop if any field is empty
            if (errornamelbl.Text != "" ||
                erroruserlbl.Text != "" ||
                errorpasslbl.Text != "" ||
                errorbloodlbl.Text != "" ||
                erroraddresslbl.Text != "")
            {
                return;
            }






            name = nametxt.Text;
            uname = unametxt.Text;
            pass=passwordtxt.Text;
            bloodgrp = bldgrpcomb.Text;
            gender = "";

            if (malerd.Checked)
            {
                gender = "Male";
            }
            else if (femalerd.Checked)
            {
                gender = "Female";
            }
            add= addresstxt.Text;
            dob=Convert.ToDateTime(dateTimePicker1.Text);
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LOHKJJT\SQLEXPRESS;Initial Catalog=donorDb;Integrated Security=True;");
            conn.Open();
            string query = "INSERT INTO Registration (Name, Username, Password, Gender, [Blood Group], [Date of Birth], Address) VALUES ('" + name + "', '" + uname + "', '" + pass + "', '" + gender + "', '" + bloodgrp + "', '" + dob + "', '" + add + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery(); 
            conn.Close();

            Form1 fr = new Form1();
            fr.Show();
            this.Hide();






                



        }
    }
}
