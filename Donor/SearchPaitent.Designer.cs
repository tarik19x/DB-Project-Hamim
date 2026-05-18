namespace Donor
{
    partial class SearchPaitent
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
            this.bldgrplbl = new System.Windows.Forms.Label();
            this.searchlbl = new System.Windows.Forms.Button();
            this.bloodgroupcombo = new System.Windows.Forms.ComboBox();
            this.locationlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.locationtxt = new System.Windows.Forms.TextBox();
            this.errorbloodlbl = new System.Windows.Forms.Label();
            this.errorlocationlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bldgrplbl
            // 
            this.bldgrplbl.AutoSize = true;
            this.bldgrplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bldgrplbl.Location = new System.Drawing.Point(195, 91);
            this.bldgrplbl.Name = "bldgrplbl";
            this.bldgrplbl.Size = new System.Drawing.Size(180, 31);
            this.bldgrplbl.TabIndex = 0;
            this.bldgrplbl.Text = "Blood Group :";
            this.bldgrplbl.Click += new System.EventHandler(this.bldgrplbl_Click);
            // 
            // searchlbl
            // 
            this.searchlbl.Location = new System.Drawing.Point(338, 224);
            this.searchlbl.Name = "searchlbl";
            this.searchlbl.Size = new System.Drawing.Size(121, 48);
            this.searchlbl.TabIndex = 1;
            this.searchlbl.Text = "Search";
            this.searchlbl.UseVisualStyleBackColor = true;
            this.searchlbl.Click += new System.EventHandler(this.searchlbl_Click);
            // 
            // bloodgroupcombo
            // 
            this.bloodgroupcombo.FormattingEnabled = true;
            this.bloodgroupcombo.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.bloodgroupcombo.Location = new System.Drawing.Point(417, 89);
            this.bloodgroupcombo.Name = "bloodgroupcombo";
            this.bloodgroupcombo.Size = new System.Drawing.Size(259, 33);
            this.bloodgroupcombo.TabIndex = 2;
            this.bloodgroupcombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // locationlbl
            // 
            this.locationlbl.AutoSize = true;
            this.locationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationlbl.Location = new System.Drawing.Point(243, 150);
            this.locationlbl.Name = "locationlbl";
            this.locationlbl.Size = new System.Drawing.Size(132, 31);
            this.locationlbl.TabIndex = 3;
            this.locationlbl.Text = "Location :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search nearby paitent in your area";
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(505, 224);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(121, 48);
            this.backbtn.TabIndex = 6;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(775, 357);
            this.dataGridView1.TabIndex = 7;
            // 
            // locationtxt
            // 
            this.locationtxt.Location = new System.Drawing.Point(417, 153);
            this.locationtxt.Name = "locationtxt";
            this.locationtxt.Size = new System.Drawing.Size(259, 31);
            this.locationtxt.TabIndex = 8;
            // 
            // errorbloodlbl
            // 
            this.errorbloodlbl.AutoSize = true;
            this.errorbloodlbl.ForeColor = System.Drawing.Color.Red;
            this.errorbloodlbl.Location = new System.Drawing.Point(412, 125);
            this.errorbloodlbl.Name = "errorbloodlbl";
            this.errorbloodlbl.Size = new System.Drawing.Size(0, 25);
            this.errorbloodlbl.TabIndex = 9;
            // 
            // errorlocationlbl
            // 
            this.errorlocationlbl.AutoSize = true;
            this.errorlocationlbl.ForeColor = System.Drawing.Color.Red;
            this.errorlocationlbl.Location = new System.Drawing.Point(412, 187);
            this.errorlocationlbl.Name = "errorlocationlbl";
            this.errorlocationlbl.Size = new System.Drawing.Size(0, 25);
            this.errorlocationlbl.TabIndex = 10;
            // 
            // SearchPaitent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(946, 829);
            this.Controls.Add(this.errorlocationlbl);
            this.Controls.Add(this.errorbloodlbl);
            this.Controls.Add(this.locationtxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locationlbl);
            this.Controls.Add(this.bloodgroupcombo);
            this.Controls.Add(this.searchlbl);
            this.Controls.Add(this.bldgrplbl);
            this.Name = "SearchPaitent";
            this.Text = "SearchPaitent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bldgrplbl;
        private System.Windows.Forms.Button searchlbl;
        private System.Windows.Forms.ComboBox bloodgroupcombo;
        private System.Windows.Forms.Label locationlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox locationtxt;
        private System.Windows.Forms.Label errorbloodlbl;
        private System.Windows.Forms.Label errorlocationlbl;
    }
}