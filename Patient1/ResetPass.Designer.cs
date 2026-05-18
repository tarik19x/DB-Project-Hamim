namespace Patient1
{
    partial class ResetPass
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
            this.btnreset = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lbluname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.errorlbl1 = new System.Windows.Forms.Label();
            this.errorlbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreset.Location = new System.Drawing.Point(470, 313);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(107, 45);
            this.btnreset.TabIndex = 15;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(290, 212);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(202, 22);
            this.txtpass.TabIndex = 14;
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(290, 126);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(202, 22);
            this.txtuname.TabIndex = 13;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(211, 212);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(79, 16);
            this.lblpass.TabIndex = 12;
            this.lblpass.Text = "Password:";
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluname.Location = new System.Drawing.Point(211, 129);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(82, 16);
            this.lbluname.TabIndex = 11;
            this.lbluname.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reset Password";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Location = new System.Drawing.Point(274, 313);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(111, 45);
            this.btnback.TabIndex = 16;
            this.btnback.Text = "Back to Login";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // errorlbl1
            // 
            this.errorlbl1.AutoSize = true;
            this.errorlbl1.ForeColor = System.Drawing.Color.Red;
            this.errorlbl1.Location = new System.Drawing.Point(306, 151);
            this.errorlbl1.Name = "errorlbl1";
            this.errorlbl1.Size = new System.Drawing.Size(44, 16);
            this.errorlbl1.TabIndex = 17;
            this.errorlbl1.Text = "label3";
            // 
            // errorlbl2
            // 
            this.errorlbl2.AutoSize = true;
            this.errorlbl2.ForeColor = System.Drawing.Color.Red;
            this.errorlbl2.Location = new System.Drawing.Point(306, 237);
            this.errorlbl2.Name = "errorlbl2";
            this.errorlbl2.Size = new System.Drawing.Size(44, 16);
            this.errorlbl2.TabIndex = 18;
            this.errorlbl2.Text = "label3";
            // 
            // ResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(816, 467);
            this.Controls.Add(this.errorlbl2);
            this.Controls.Add(this.errorlbl1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluname);
            this.Controls.Add(this.label1);
            this.Name = "ResetPass";
            this.Text = "ResetPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label errorlbl1;
        private System.Windows.Forms.Label errorlbl2;
    }
}