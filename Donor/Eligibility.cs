using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donor
{
    public partial class Eligibility : Form
    {
        public Eligibility()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            string bloodGroup = comboBox1.Text;
            string result = "";

            switch (bloodGroup)
            {
                case "A+":
                    result = "Can donate to: A+, AB+";
                    break;

                case "A-":
                    result = "Can donate to: A+, A-, AB+, AB-";
                    break;

                case "B+":
                    result = "Can donate to: B+, AB+";
                    break;

                case "B-":
                    result = "Can donate to: B+, B-, AB+, AB-";
                    break;

                case "AB+":
                    result = "Can donate to: AB+";
                    break;

                case "AB-":
                    result = "Can donate to: AB+, AB-";
                    break;

                case "O+":
                    result = "Can donate to: O+, A+, B+, AB+";
                    break;

                case "O-":
                    result = "Can donate to all blood groups";
                    break;

                default:
                    result = "Please select a blood group";
                    break;
            }

            MessageBox.Show(result);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Dashbord db = new Dashbord();
            db.Show();
            this.Hide();
        }
    }
}
