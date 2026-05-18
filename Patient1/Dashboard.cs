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

namespace Patient1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            dashboardlbl.Text = "Patient Dashboard ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBlood c = new CheckBlood();
            c.Show();
            this.Hide();
        }

        private void dashboardlbl_Click(object sender, EventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {

            ViewProfile v = new ViewProfile();
            v.Show();
            this.Hide();

            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            UpdateProfile u = new UpdateProfile();
            u.Show();
            this.Hide();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DeleteProfile u = new DeleteProfile();
            u.Show();
            this.Hide();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnrd_Click(object sender, EventArgs e)
        {
            RequestDonor re = new RequestDonor();
            re.Show();
            this.Hide();
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            CheckHistory ch = new CheckHistory();
            ch.Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
           SearchDonor s = new SearchDonor();
            s.Show();
            this.Hide();
        }

        private void btnvd_Click(object sender, EventArgs e)
        {

        }
    }
}
