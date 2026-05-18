namespace Donor
{
    partial class Dashbord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Eligibilitytxt = new System.Windows.Forms.Button();
            this.Srcpaitenttxt = new System.Windows.Forms.Button();
            this.dltacctxt = new System.Windows.Forms.Button();
            this.showbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Eligibilitytxt
            // 
            this.Eligibilitytxt.Location = new System.Drawing.Point(3, 241);
            this.Eligibilitytxt.Name = "Eligibilitytxt";
            this.Eligibilitytxt.Size = new System.Drawing.Size(362, 109);
            this.Eligibilitytxt.TabIndex = 0;
            this.Eligibilitytxt.Text = "Eligibility";
            this.Eligibilitytxt.UseVisualStyleBackColor = true;
            this.Eligibilitytxt.Click += new System.EventHandler(this.Eligibilitytxt_Click);
            // 
            // Srcpaitenttxt
            // 
            this.Srcpaitenttxt.Location = new System.Drawing.Point(3, 472);
            this.Srcpaitenttxt.Name = "Srcpaitenttxt";
            this.Srcpaitenttxt.Size = new System.Drawing.Size(359, 109);
            this.Srcpaitenttxt.TabIndex = 0;
            this.Srcpaitenttxt.Text = "Search Paitent";
            this.Srcpaitenttxt.UseVisualStyleBackColor = true;
            this.Srcpaitenttxt.Click += new System.EventHandler(this.Srcpaitenttxt_Click);
            // 
            // dltacctxt
            // 
            this.dltacctxt.Location = new System.Drawing.Point(3, 587);
            this.dltacctxt.Name = "dltacctxt";
            this.dltacctxt.Size = new System.Drawing.Size(359, 109);
            this.dltacctxt.TabIndex = 0;
            this.dltacctxt.Text = "Delete Account";
            this.dltacctxt.UseVisualStyleBackColor = true;
            this.dltacctxt.Click += new System.EventHandler(this.dltacctxt_Click);
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(3, 11);
            this.showbtn.Name = "showbtn";
            this.showbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.showbtn.Size = new System.Drawing.Size(362, 109);
            this.showbtn.TabIndex = 0;
            this.showbtn.Text = "View Profile";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(362, 109);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(3, 702);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(359, 109);
            this.logoutbtn.TabIndex = 5;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(36)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.dltacctxt);
            this.panel1.Controls.Add(this.Srcpaitenttxt);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Eligibilitytxt);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.showbtn);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 823);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(695, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 61);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(359, 110);
            this.button2.TabIndex = 10;
            this.button2.Text = "Paitent Request";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(26)))), ((int)(((byte)(55)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1441, 906);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Dashbord";
            this.Text = "Dashbord";
            this.Load += new System.EventHandler(this.Dashbord_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Eligibilitytxt;
        private System.Windows.Forms.Button Srcpaitenttxt;
        private System.Windows.Forms.Button dltacctxt;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}