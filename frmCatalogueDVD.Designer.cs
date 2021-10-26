
namespace MovieSYS
{
    partial class frmCatalogueDVD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmInfo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtDVDName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuAdd = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cboLang = new System.Windows.Forms.ComboBox();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.cboAge = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.grpDetails.SuspendLayout();
            this.mnuAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.grpDetails.Controls.Add(this.txtYear);
            this.grpDetails.Controls.Add(this.cboAge);
            this.grpDetails.Controls.Add(this.cboCat);
            this.grpDetails.Controls.Add(this.cboLang);
            this.grpDetails.Controls.Add(this.cboCountry);
            this.grpDetails.Controls.Add(this.cboGenre);
            this.grpDetails.Controls.Add(this.dtpDate);
            this.grpDetails.Controls.Add(this.label3);
            this.grpDetails.Controls.Add(this.label5);
            this.grpDetails.Controls.Add(this.btnConfirmInfo);
            this.grpDetails.Controls.Add(this.label11);
            this.grpDetails.Controls.Add(this.txtDuration);
            this.grpDetails.Controls.Add(this.txtDVDName);
            this.grpDetails.Controls.Add(this.label9);
            this.grpDetails.Controls.Add(this.label8);
            this.grpDetails.Controls.Add(this.label7);
            this.grpDetails.Controls.Add(this.label6);
            this.grpDetails.Controls.Add(this.label4);
            this.grpDetails.Controls.Add(this.label2);
            this.grpDetails.Controls.Add(this.label1);
            this.grpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetails.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpDetails.ForeColor = System.Drawing.Color.Azure;
            this.grpDetails.Location = new System.Drawing.Point(0, 38);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(820, 500);
            this.grpDetails.TabIndex = 11;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "DVD Details";
            this.grpDetails.Enter += new System.EventHandler(this.grpDetails_Enter);
            // 
            // cboCountry
            // 
            this.cboCountry.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(601, 194);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(116, 31);
            this.cboCountry.TabIndex = 8;
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            // 
            // cboGenre
            // 
            this.cboGenre.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(223, 144);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(146, 31);
            this.cboGenre.TabIndex = 2;
            this.cboGenre.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.dtpDate.CalendarTitleBackColor = System.Drawing.Color.SlateBlue;
            this.dtpDate.CalendarTitleForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dtpDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.Location = new System.Drawing.Point(601, 137);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(116, 30);
            this.dtpDate.TabIndex = 7;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(102, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Category:";
            this.label3.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(149, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 41);
            this.label5.TabIndex = 0;
            this.label5.Text = "Year:";
            this.label5.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnConfirmInfo
            // 
            this.btnConfirmInfo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnConfirmInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmInfo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnConfirmInfo.Location = new System.Drawing.Point(638, 414);
            this.btnConfirmInfo.Name = "btnConfirmInfo";
            this.btnConfirmInfo.Size = new System.Drawing.Size(74, 39);
            this.btnConfirmInfo.TabIndex = 10;
            this.btnConfirmInfo.Text = "Add";
            this.btnConfirmInfo.UseVisualStyleBackColor = false;
            this.btnConfirmInfo.Click += new System.EventHandler(this.btnConfirmInfo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.AliceBlue;
            this.label11.Location = new System.Drawing.Point(658, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "mins";
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.SystemColors.Window;
            this.txtDuration.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDuration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDuration.Location = new System.Drawing.Point(601, 85);
            this.txtDuration.MaxLength = 3;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.PlaceholderText = "0";
            this.txtDuration.Size = new System.Drawing.Size(43, 30);
            this.txtDuration.TabIndex = 6;
            this.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDuration.TextChanged += new System.EventHandler(this.txtDuration_TextChanged);
            // 
            // txtDVDName
            // 
            this.txtDVDName.BackColor = System.Drawing.SystemColors.Window;
            this.txtDVDName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDVDName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDVDName.Location = new System.Drawing.Point(223, 89);
            this.txtDVDName.MaxLength = 30;
            this.txtDVDName.Name = "txtDVDName";
            this.txtDVDName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDVDName.Size = new System.Drawing.Size(146, 30);
            this.txtDVDName.TabIndex = 1;
            this.txtDVDName.TextChanged += new System.EventHandler(this.txtDVDName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.AliceBlue;
            this.label9.Location = new System.Drawing.Point(458, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 41);
            this.label9.TabIndex = 0;
            this.label9.Text = "Age Rating:";
            this.label9.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(492, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 41);
            this.label8.TabIndex = 0;
            this.label8.Text = "Country:";
            this.label8.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(449, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 41);
            this.label7.TabIndex = 0;
            this.label7.Text = "Date Added:";
            this.label7.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(483, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 41);
            this.label6.TabIndex = 0;
            this.label6.Text = "Duration:";
            this.label6.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(93, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Language:";
            this.label4.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(133, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Genre:";
            this.label2.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(150, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            this.label1.Click += new System.EventHandler(this.label3_Click);
            // 
            // mnuAdd
            // 
            this.mnuAdd.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.mnuAdd.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuAdd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mnuAdd.Location = new System.Drawing.Point(0, 0);
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(820, 38);
            this.mnuAdd.TabIndex = 2;
            this.mnuAdd.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Azure;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 34);
            this.exitToolStripMenuItem.Text = "X";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cboLang
            // 
            this.cboLang.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboLang.FormattingEnabled = true;
            this.cboLang.Location = new System.Drawing.Point(223, 251);
            this.cboLang.Name = "cboLang";
            this.cboLang.Size = new System.Drawing.Size(146, 31);
            this.cboLang.TabIndex = 4;
            this.cboLang.SelectedIndexChanged += new System.EventHandler(this.cboLang_SelectedIndexChanged);
            // 
            // cboCat
            // 
            this.cboCat.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(223, 198);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(146, 31);
            this.cboCat.TabIndex = 3;
            this.cboCat.SelectedIndexChanged += new System.EventHandler(this.cboCat_SelectedIndexChanged);
            // 
            // cboAge
            // 
            this.cboAge.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboAge.FormattingEnabled = true;
            this.cboAge.Location = new System.Drawing.Point(601, 250);
            this.cboAge.Name = "cboAge";
            this.cboAge.Size = new System.Drawing.Size(43, 31);
            this.cboAge.TabIndex = 9;
            this.cboAge.SelectedIndexChanged += new System.EventHandler(this.cboAge_SelectedIndexChanged);
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtYear.Location = new System.Drawing.Point(223, 307);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.PlaceholderText = "YYYY";
            this.txtYear.Size = new System.Drawing.Size(47, 30);
            this.txtYear.TabIndex = 5;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // frmCatalogueDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(820, 538);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.mnuAdd);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCatalogueDVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogue A DVD";
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.mnuAdd.ResumeLayout(false);
            this.mnuAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtDVDName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirmInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.ComboBox cboLang;
        private System.Windows.Forms.ComboBox cboAge;
        private System.Windows.Forms.TextBox txtYear;
    }
}

