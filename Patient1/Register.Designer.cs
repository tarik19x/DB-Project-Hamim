namespace Patient1
{
    partial class Register
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
            this.lblname = new System.Windows.Forms.Label();
            this.lbluname = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblblood = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.btnbackl = new System.Windows.Forms.Button();
            this.errorlbl1 = new System.Windows.Forms.Label();
            this.errorlbl2 = new System.Windows.Forms.Label();
            this.errorlbl6 = new System.Windows.Forms.Label();
            this.errorlbl5 = new System.Windows.Forms.Label();
            this.errorlbl4 = new System.Windows.Forms.Label();
            this.errorlbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(183, 102);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(52, 16);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name:";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluname.Location = new System.Drawing.Point(153, 147);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(82, 16);
            this.lbluname.TabIndex = 2;
            this.lbluname.Text = "Username:";
            this.lbluname.Click += new System.EventHandler(this.txtuname_Click);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(156, 198);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(79, 16);
            this.lblpass.TabIndex = 3;
            this.lblpass.Text = "Password:";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(173, 249);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(62, 16);
            this.lblgender.TabIndex = 4;
            this.lblgender.Text = "Gender:";
            // 
            // lblblood
            // 
            this.lblblood.AutoSize = true;
            this.lblblood.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblblood.Location = new System.Drawing.Point(137, 288);
            this.lblblood.Name = "lblblood";
            this.lblblood.Size = new System.Drawing.Size(98, 16);
            this.lblblood.TabIndex = 5;
            this.lblblood.Text = "Blood Group:";
            this.lblblood.Click += new System.EventHandler(this.lblblood_Click);
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(139, 348);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(96, 16);
            this.lbldob.TabIndex = 6;
            this.lbldob.Text = "Date of Birth:";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(166, 399);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(69, 16);
            this.lbladdress.TabIndex = 7;
            this.lbladdress.Text = "Address:";
            this.lbladdress.Click += new System.EventHandler(this.lbladdress_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(241, 96);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(224, 22);
            this.txtname.TabIndex = 8;
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(241, 141);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(224, 22);
            this.txtuname.TabIndex = 9;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(241, 192);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(224, 22);
            this.txtpass.TabIndex = 10;
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
            this.comboBox1.Location = new System.Drawing.Point(241, 285);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(241, 343);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(241, 396);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(218, 66);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(579, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(258, 247);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(58, 20);
            this.rbmale.TabIndex = 16;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(345, 247);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(74, 20);
            this.rbfemale.TabIndex = 17;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // btnbackl
            // 
            this.btnbackl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnbackl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbackl.Location = new System.Drawing.Point(292, 494);
            this.btnbackl.Name = "btnbackl";
            this.btnbackl.Size = new System.Drawing.Size(167, 46);
            this.btnbackl.TabIndex = 18;
            this.btnbackl.Text = "Back to Login";
            this.btnbackl.UseVisualStyleBackColor = false;
            this.btnbackl.Click += new System.EventHandler(this.btnbackl_Click);
            // 
            // errorlbl1
            // 
            this.errorlbl1.AutoSize = true;
            this.errorlbl1.ForeColor = System.Drawing.Color.Red;
            this.errorlbl1.Location = new System.Drawing.Point(255, 122);
            this.errorlbl1.Name = "errorlbl1";
            this.errorlbl1.Size = new System.Drawing.Size(44, 16);
            this.errorlbl1.TabIndex = 19;
            this.errorlbl1.Text = "label2";
            // 
            // errorlbl2
            // 
            this.errorlbl2.AutoSize = true;
            this.errorlbl2.ForeColor = System.Drawing.Color.Red;
            this.errorlbl2.Location = new System.Drawing.Point(255, 173);
            this.errorlbl2.Name = "errorlbl2";
            this.errorlbl2.Size = new System.Drawing.Size(44, 16);
            this.errorlbl2.TabIndex = 20;
            this.errorlbl2.Text = "label2";
            // 
            // errorlbl6
            // 
            this.errorlbl6.AutoSize = true;
            this.errorlbl6.ForeColor = System.Drawing.Color.Red;
            this.errorlbl6.Location = new System.Drawing.Point(255, 465);
            this.errorlbl6.Name = "errorlbl6";
            this.errorlbl6.Size = new System.Drawing.Size(44, 16);
            this.errorlbl6.TabIndex = 22;
            this.errorlbl6.Text = "label2";
            // 
            // errorlbl5
            // 
            this.errorlbl5.AutoSize = true;
            this.errorlbl5.ForeColor = System.Drawing.Color.Red;
            this.errorlbl5.Location = new System.Drawing.Point(255, 312);
            this.errorlbl5.Name = "errorlbl5";
            this.errorlbl5.Size = new System.Drawing.Size(44, 16);
            this.errorlbl5.TabIndex = 23;
            this.errorlbl5.Text = "label2";
            // 
            // errorlbl4
            // 
            this.errorlbl4.AutoSize = true;
            this.errorlbl4.ForeColor = System.Drawing.Color.Red;
            this.errorlbl4.Location = new System.Drawing.Point(255, 268);
            this.errorlbl4.Name = "errorlbl4";
            this.errorlbl4.Size = new System.Drawing.Size(44, 16);
            this.errorlbl4.TabIndex = 24;
            this.errorlbl4.Text = "label2";
            // 
            // errorlbl3
            // 
            this.errorlbl3.AutoSize = true;
            this.errorlbl3.ForeColor = System.Drawing.Color.Red;
            this.errorlbl3.Location = new System.Drawing.Point(255, 226);
            this.errorlbl3.Name = "errorlbl3";
            this.errorlbl3.Size = new System.Drawing.Size(44, 16);
            this.errorlbl3.TabIndex = 25;
            this.errorlbl3.Text = "label2";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Patient1.Properties.Resources._11;
            this.ClientSize = new System.Drawing.Size(963, 571);
            this.Controls.Add(this.errorlbl3);
            this.Controls.Add(this.errorlbl4);
            this.Controls.Add(this.errorlbl5);
            this.Controls.Add(this.errorlbl6);
            this.Controls.Add(this.errorlbl2);
            this.Controls.Add(this.errorlbl1);
            this.Controls.Add(this.btnbackl);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.lblblood);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblblood;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.Button btnbackl;
        private System.Windows.Forms.Label errorlbl1;
        private System.Windows.Forms.Label errorlbl2;
        private System.Windows.Forms.Label errorlbl6;
        private System.Windows.Forms.Label errorlbl5;
        private System.Windows.Forms.Label errorlbl4;
        private System.Windows.Forms.Label errorlbl3;
    }
}