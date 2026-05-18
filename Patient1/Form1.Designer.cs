namespace Patient1
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
            this.lbluname = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnforget = new System.Windows.Forms.Button();
            this.errorlbl1 = new System.Windows.Forms.Label();
            this.errorlbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbluname
            // 
            this.lbluname.AutoSize = true;
            this.lbluname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluname.Location = new System.Drawing.Point(220, 136);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(82, 16);
            this.lbluname.TabIndex = 1;
            this.lbluname.Text = "Username:";
            this.lbluname.Click += new System.EventHandler(this.lbluname_Click);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(220, 219);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(79, 16);
            this.lblpass.TabIndex = 2;
            this.lblpass.Text = "Password:";
            this.lblpass.Click += new System.EventHandler(this.lblpass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Don\'t have an account?";
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(299, 133);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(202, 22);
            this.txtuname.TabIndex = 4;
            this.txtuname.TextChanged += new System.EventHandler(this.txtuname_TextChanged);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(299, 219);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(202, 22);
            this.txtpass.TabIndex = 5;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogin.Location = new System.Drawing.Point(409, 289);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(137, 34);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(410, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Register,here";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnback.Location = new System.Drawing.Point(241, 289);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(137, 34);
            this.btnback.TabIndex = 8;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnforget
            // 
            this.btnforget.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnforget.Location = new System.Drawing.Point(507, 218);
            this.btnforget.Name = "btnforget";
            this.btnforget.Size = new System.Drawing.Size(126, 25);
            this.btnforget.TabIndex = 9;
            this.btnforget.Text = "Forget Password";
            this.btnforget.UseVisualStyleBackColor = false;
            this.btnforget.Click += new System.EventHandler(this.btnforget_Click);
            // 
            // errorlbl1
            // 
            this.errorlbl1.AutoSize = true;
            this.errorlbl1.ForeColor = System.Drawing.Color.Red;
            this.errorlbl1.Location = new System.Drawing.Point(310, 158);
            this.errorlbl1.Name = "errorlbl1";
            this.errorlbl1.Size = new System.Drawing.Size(44, 16);
            this.errorlbl1.TabIndex = 10;
            this.errorlbl1.Text = "label3";
            this.errorlbl1.Click += new System.EventHandler(this.errorlbl1_Click);
            // 
            // errorlbl2
            // 
            this.errorlbl2.AutoSize = true;
            this.errorlbl2.ForeColor = System.Drawing.Color.Red;
            this.errorlbl2.Location = new System.Drawing.Point(310, 244);
            this.errorlbl2.Name = "errorlbl2";
            this.errorlbl2.Size = new System.Drawing.Size(44, 16);
            this.errorlbl2.TabIndex = 11;
            this.errorlbl2.Text = "label4";
            this.errorlbl2.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorlbl2);
            this.Controls.Add(this.errorlbl1);
            this.Controls.Add(this.btnforget);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnforget;
        private System.Windows.Forms.Label errorlbl1;
        private System.Windows.Forms.Label errorlbl2;
    }
}

