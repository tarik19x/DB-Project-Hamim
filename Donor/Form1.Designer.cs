namespace Donor
{
    partial class Form1
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
            this.userlbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.lgnbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.registerlinklbl = new System.Windows.Forms.LinkLabel();
            this.erroruserlbl = new System.Windows.Forms.Label();
            this.errorpasslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(518, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donor LogIn";
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.Location = new System.Drawing.Point(237, 362);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(210, 42);
            this.userlbl.TabIndex = 1;
            this.userlbl.Text = "Username :";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(244, 521);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(203, 42);
            this.passlbl.TabIndex = 2;
            this.passlbl.Text = "Password :";
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(529, 362);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(396, 31);
            this.usertxt.TabIndex = 3;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(529, 533);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(396, 31);
            this.passtxt.TabIndex = 4;
            // 
            // lgnbtn
            // 
            this.lgnbtn.BackColor = System.Drawing.Color.White;
            this.lgnbtn.Location = new System.Drawing.Point(619, 653);
            this.lgnbtn.Name = "lgnbtn";
            this.lgnbtn.Size = new System.Drawing.Size(155, 57);
            this.lgnbtn.TabIndex = 5;
            this.lgnbtn.Text = "Login ";
            this.lgnbtn.UseVisualStyleBackColor = false;
            this.lgnbtn.Click += new System.EventHandler(this.lgnbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 759);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dont have any account?";
            // 
            // registerlinklbl
            // 
            this.registerlinklbl.AutoSize = true;
            this.registerlinklbl.Location = new System.Drawing.Point(749, 759);
            this.registerlinklbl.Name = "registerlinklbl";
            this.registerlinklbl.Size = new System.Drawing.Size(84, 25);
            this.registerlinklbl.TabIndex = 7;
            this.registerlinklbl.TabStop = true;
            this.registerlinklbl.Text = "register";
            this.registerlinklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerlinklbl_LinkClicked);
            // 
            // erroruserlbl
            // 
            this.erroruserlbl.AutoSize = true;
            this.erroruserlbl.ForeColor = System.Drawing.Color.Red;
            this.erroruserlbl.Location = new System.Drawing.Point(524, 412);
            this.erroruserlbl.Name = "erroruserlbl";
            this.erroruserlbl.Size = new System.Drawing.Size(0, 25);
            this.erroruserlbl.TabIndex = 8;
            // 
            // errorpasslbl
            // 
            this.errorpasslbl.AutoSize = true;
            this.errorpasslbl.ForeColor = System.Drawing.Color.Red;
            this.errorpasslbl.Location = new System.Drawing.Point(524, 582);
            this.errorpasslbl.Name = "errorpasslbl";
            this.errorpasslbl.Size = new System.Drawing.Size(0, 25);
            this.errorpasslbl.TabIndex = 9;
            this.errorpasslbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1453, 829);
            this.Controls.Add(this.errorpasslbl);
            this.Controls.Add(this.erroruserlbl);
            this.Controls.Add(this.registerlinklbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lgnbtn);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button lgnbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel registerlinklbl;
        private System.Windows.Forms.Label erroruserlbl;
        private System.Windows.Forms.Label errorpasslbl;
    }
}

