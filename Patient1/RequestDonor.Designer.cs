namespace Patient1
{
    partial class RequestDonor
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbldonor = new System.Windows.Forms.Label();
            this.lblblood = new System.Windows.Forms.Label();
            this.lblrequest = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdid = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtstat = new System.Windows.Forms.TextBox();
            this.btnreq = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(471, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Send Request to Donor";
            // 
            // lbldonor
            // 
            this.lbldonor.AutoSize = true;
            this.lbldonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldonor.Location = new System.Drawing.Point(273, 202);
            this.lbldonor.Name = "lbldonor";
            this.lbldonor.Size = new System.Drawing.Size(72, 16);
            this.lbldonor.TabIndex = 3;
            this.lbldonor.Text = "Donor ID:";
            this.lbldonor.Click += new System.EventHandler(this.lbldonor_Click);
            // 
            // lblblood
            // 
            this.lblblood.AutoSize = true;
            this.lblblood.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblblood.Location = new System.Drawing.Point(247, 264);
            this.lblblood.Name = "lblblood";
            this.lblblood.Size = new System.Drawing.Size(98, 16);
            this.lblblood.TabIndex = 4;
            this.lblblood.Text = "Blood Group:";
            // 
            // lblrequest
            // 
            this.lblrequest.AutoSize = true;
            this.lblrequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrequest.Location = new System.Drawing.Point(239, 337);
            this.lblrequest.Name = "lblrequest";
            this.lblrequest.Size = new System.Drawing.Size(106, 16);
            this.lblrequest.TabIndex = 5;
            this.lblrequest.Text = "Request Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Status:";
            // 
            // txtdid
            // 
            this.txtdid.Location = new System.Drawing.Point(351, 202);
            this.txtdid.Name = "txtdid";
            this.txtdid.Size = new System.Drawing.Size(224, 22);
            this.txtdid.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.comboBox1.Location = new System.Drawing.Point(351, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(351, 332);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // txtstat
            // 
            this.txtstat.Location = new System.Drawing.Point(351, 397);
            this.txtstat.Name = "txtstat";
            this.txtstat.Size = new System.Drawing.Size(224, 22);
            this.txtstat.TabIndex = 15;
            // 
            // btnreq
            // 
            this.btnreq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreq.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreq.Location = new System.Drawing.Point(604, 467);
            this.btnreq.Name = "btnreq";
            this.btnreq.Size = new System.Drawing.Size(141, 40);
            this.btnreq.TabIndex = 16;
            this.btnreq.Text = "Request";
            this.btnreq.UseVisualStyleBackColor = false;
            this.btnreq.Click += new System.EventHandler(this.btnreq_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Location = new System.Drawing.Point(365, 467);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(141, 40);
            this.btnback.TabIndex = 17;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // RequestDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Patient1.Properties.Resources.Check2;
            this.ClientSize = new System.Drawing.Size(1174, 577);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnreq);
            this.Controls.Add(this.txtstat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtdid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblrequest);
            this.Controls.Add(this.lblblood);
            this.Controls.Add(this.lbldonor);
            this.Controls.Add(this.label1);
            this.Name = "RequestDonor";
            this.Text = "RequestDonor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldonor;
        private System.Windows.Forms.Label lblblood;
        private System.Windows.Forms.Label lblrequest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdid;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtstat;
        private System.Windows.Forms.Button btnreq;
        private System.Windows.Forms.Button btnback;
    }
}