namespace Patient1
{
    partial class Dashboard
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
            this.dashboardlbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlog = new System.Windows.Forms.Button();
            this.btnhistory = new System.Windows.Forms.Button();
            this.btnrd = new System.Windows.Forms.Button();
            this.btneli = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnviewp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardlbl
            // 
            this.dashboardlbl.AutoSize = true;
            this.dashboardlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dashboardlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboardlbl.Location = new System.Drawing.Point(541, 29);
            this.dashboardlbl.Name = "dashboardlbl";
            this.dashboardlbl.Size = new System.Drawing.Size(228, 29);
            this.dashboardlbl.TabIndex = 0;
            this.dashboardlbl.Text = "Patient Dashboard";
            this.dashboardlbl.Click += new System.EventHandler(this.dashboardlbl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnlog);
            this.panel1.Controls.Add(this.btnhistory);
            this.panel1.Controls.Add(this.btnrd);
            this.panel1.Controls.Add(this.btneli);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnviewp);
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 543);
            this.panel1.TabIndex = 1;
            // 
            // btnlog
            // 
            this.btnlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlog.Location = new System.Drawing.Point(22, 405);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(128, 41);
            this.btnlog.TabIndex = 9;
            this.btnlog.Text = "Log Out";
            this.btnlog.UseVisualStyleBackColor = false;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // btnhistory
            // 
            this.btnhistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhistory.Location = new System.Drawing.Point(22, 358);
            this.btnhistory.Name = "btnhistory";
            this.btnhistory.Size = new System.Drawing.Size(128, 41);
            this.btnhistory.TabIndex = 8;
            this.btnhistory.Text = "History";
            this.btnhistory.UseVisualStyleBackColor = false;
            this.btnhistory.Click += new System.EventHandler(this.btnhistory_Click);
            // 
            // btnrd
            // 
            this.btnrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnrd.Location = new System.Drawing.Point(22, 311);
            this.btnrd.Name = "btnrd";
            this.btnrd.Size = new System.Drawing.Size(128, 41);
            this.btnrd.TabIndex = 7;
            this.btnrd.Text = "Request Donor";
            this.btnrd.UseVisualStyleBackColor = false;
            this.btnrd.Click += new System.EventHandler(this.btnrd_Click);
            // 
            // btneli
            // 
            this.btneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btneli.Location = new System.Drawing.Point(22, 264);
            this.btneli.Name = "btneli";
            this.btneli.Size = new System.Drawing.Size(128, 41);
            this.btneli.TabIndex = 6;
            this.btneli.Text = "Eligibilty";
            this.btneli.UseVisualStyleBackColor = false;
            this.btneli.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsearch.Location = new System.Drawing.Point(22, 217);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(128, 41);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search Donor";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(22, 170);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(128, 41);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete Profile";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(22, 123);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(128, 41);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "Update Profile";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnviewp
            // 
            this.btnviewp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnviewp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnviewp.Location = new System.Drawing.Point(22, 76);
            this.btnviewp.Name = "btnviewp";
            this.btnviewp.Size = new System.Drawing.Size(128, 41);
            this.btnviewp.TabIndex = 0;
            this.btnviewp.Text = "View Profile";
            this.btnviewp.UseVisualStyleBackColor = false;
            this.btnviewp.Click += new System.EventHandler(this.btnview_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Patient1.Properties.Resources.Dash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dashboardlbl);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashboardlbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnviewp;
        private System.Windows.Forms.Button btneli;
        private System.Windows.Forms.Button btnhistory;
        private System.Windows.Forms.Button btnrd;
        private System.Windows.Forms.Button btnlog;
    }
}