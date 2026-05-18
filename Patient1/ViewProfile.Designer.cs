namespace Patient1
{
    partial class ViewProfile
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
            this.btndash = new System.Windows.Forms.Button();
            this.resultlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "View Profile";
            // 
            // btndash
            // 
            this.btndash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btndash.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndash.Location = new System.Drawing.Point(258, 503);
            this.btndash.Name = "btndash";
            this.btndash.Size = new System.Drawing.Size(167, 46);
            this.btndash.TabIndex = 20;
            this.btndash.Text = "Back to Dashboard";
            this.btndash.UseVisualStyleBackColor = false;
            this.btndash.Click += new System.EventHandler(this.btndash_Click);
            // 
            // resultlbl
            // 
            this.resultlbl.AutoSize = true;
            this.resultlbl.Location = new System.Drawing.Point(289, 137);
            this.resultlbl.Name = "resultlbl";
            this.resultlbl.Size = new System.Drawing.Size(44, 16);
            this.resultlbl.TabIndex = 21;
            this.resultlbl.Text = "label2";
            // 
            // ViewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(661, 591);
            this.Controls.Add(this.resultlbl);
            this.Controls.Add(this.btndash);
            this.Controls.Add(this.label1);
            this.Name = "ViewProfile";
            this.Text = "ViewProfile";
            this.Load += new System.EventHandler(this.ViewProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndash;
        private System.Windows.Forms.Label resultlbl;
    }
}