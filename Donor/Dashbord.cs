using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Donor
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            ViewProfile vw= new ViewProfile();
            vw.Show();
            this.Hide();


        }

        private void dltacctxt_Click(object sender, EventArgs e)
        {
            Delete dlt = new Delete();
            dlt.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Logout lo =new Logout();
            lo.Show();
            this.Hide();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }

        private void Eligibilitytxt_Click(object sender, EventArgs e)
        {
            Eligibility eb= new Eligibility();
            eb.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update up= new Update();
            up.Show();
            this.Hide();
        }

        private void Srcpaitenttxt_Click(object sender, EventArgs e)
        {
            SearchPaitent sp = new SearchPaitent();
            sp.Show();
            this.Hide();
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaitentRequest ps = new PaitentRequest();
            ps.Show();
            this.Hide();
        }
    }
}
