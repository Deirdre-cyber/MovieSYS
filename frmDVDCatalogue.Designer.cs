
namespace MovieSYS
{
    partial class frmDVDCatalogue
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblDateAdd = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cboAge = new System.Windows.Forms.ComboBox();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.cboLang = new System.Windows.Forms.ComboBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.btnConfirmInfo = new System.Windows.Forms.Button();
            this.lblMins = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtDVDName = new System.Windows.Forms.TextBox();
            this.mnuAdd = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpDetails.SuspendLayout();
            this.mnuAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.Color.LightSlateGray;
            this.grpDetails.Controls.Add(this.dtpDate);
            this.grpDetails.Controls.Add(this.lblAgeRating);
            this.grpDetails.Controls.Add(this.lblCountry);
            this.grpDetails.Controls.Add(this.lblDateAdd);
            this.grpDetails.Controls.Add(this.lblDuration);
            this.grpDetails.Controls.Add(this.lblYear);
            this.grpDetails.Controls.Add(this.lblLanguage);
            this.grpDetails.Controls.Add(this.lblCategory);
            this.grpDetails.Controls.Add(this.lblGenre);
            this.grpDetails.Controls.Add(this.lblTitle);
            this.grpDetails.Controls.Add(this.txtYear);
            this.grpDetails.Controls.Add(this.cboAge);
            this.grpDetails.Controls.Add(this.cboCat);
            this.grpDetails.Controls.Add(this.cboLang);
            this.grpDetails.Controls.Add(this.cboCountry);
            this.grpDetails.Controls.Add(this.cboGenre);
            this.grpDetails.Controls.Add(this.btnConfirmInfo);
            this.grpDetails.Controls.Add(this.lblMins);
            this.grpDetails.Controls.Add(this.txtDuration);
            this.grpDetails.Controls.Add(this.txtDVDName);
            this.grpDetails.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpDetails.Location = new System.Drawing.Point(98, 46);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(792, 507);
            this.grpDetails.TabIndex = 11;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "DVD Details";
            this.grpDetails.Enter += new System.EventHandler(this.grpDetails_Enter);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.dtpDate.CalendarTitleBackColor = System.Drawing.Color.LightSlateGray;
            this.dtpDate.CalendarTitleForeColor = System.Drawing.Color.LightSlateGray;
            this.dtpDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.Location = new System.Drawing.Point(601, 147);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(140, 30);
            this.dtpDate.TabIndex = 26;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.AutoSize = true;
            this.lblAgeRating.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAgeRating.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblAgeRating.Location = new System.Drawing.Point(473, 253);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(122, 28);
            this.lblAgeRating.TabIndex = 25;
            this.lblAgeRating.Text = "Age Rating:";
            this.lblAgeRating.Click += new System.EventHandler(this.lblAgeRating_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountry.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblCountry.Location = new System.Drawing.Point(502, 201);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(93, 28);
            this.lblCountry.TabIndex = 24;
            this.lblCountry.Text = "Country:";
            this.lblCountry.Click += new System.EventHandler(this.lblCountry_Click);
            // 
            // lblDateAdd
            // 
            this.lblDateAdd.AutoSize = true;
            this.lblDateAdd.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateAdd.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblDateAdd.Location = new System.Drawing.Point(466, 147);
            this.lblDateAdd.Name = "lblDateAdd";
            this.lblDateAdd.Size = new System.Drawing.Size(129, 28);
            this.lblDateAdd.TabIndex = 23;
            this.lblDateAdd.Text = "Date Added:";
            this.lblDateAdd.Click += new System.EventHandler(this.lblDateAdd_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDuration.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblDuration.Location = new System.Drawing.Point(494, 91);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(101, 28);
            this.lblDuration.TabIndex = 22;
            this.lblDuration.Text = "Duration:";
            this.lblDuration.Click += new System.EventHandler(this.lblDuration_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(159, 307);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(58, 28);
            this.lblYear.TabIndex = 21;
            this.lblYear.Text = "Year:";
            this.lblYear.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLanguage.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblLanguage.Location = new System.Drawing.Point(109, 254);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(108, 28);
            this.lblLanguage.TabIndex = 20;
            this.lblLanguage.Text = "Language:";
            this.lblLanguage.Click += new System.EventHandler(this.lblLanguage_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(114, 201);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(103, 28);
            this.lblCategory.TabIndex = 19;
            this.lblCategory.Text = "Category:";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenre.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblGenre.Location = new System.Drawing.Point(144, 147);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(73, 28);
            this.lblGenre.TabIndex = 18;
            this.lblGenre.Text = "Genre:";
            this.lblGenre.Click += new System.EventHandler(this.lblGenre_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTitle.Location = new System.Drawing.Point(157, 91);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(60, 28);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Title:";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtYear.Location = new System.Drawing.Point(223, 307);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.PlaceholderText = "YYYY";
            this.txtYear.Size = new System.Drawing.Size(50, 30);
            this.txtYear.TabIndex = 5;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // cboAge
            // 
            this.cboAge.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboAge.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboAge.FormattingEnabled = true;
            this.cboAge.Location = new System.Drawing.Point(601, 250);
            this.cboAge.Name = "cboAge";
            this.cboAge.Size = new System.Drawing.Size(50, 31);
            this.cboAge.TabIndex = 9;
            this.cboAge.Text = "18";
            this.cboAge.SelectedIndexChanged += new System.EventHandler(this.cboAge_SelectedIndexChanged);
            // 
            // cboCat
            // 
            this.cboCat.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCat.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(223, 198);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(180, 31);
            this.cboCat.TabIndex = 3;
            this.cboCat.Text = "NR - New Release";
            this.cboCat.SelectedIndexChanged += new System.EventHandler(this.cboCat_SelectedIndexChanged);
            // 
            // cboLang
            // 
            this.cboLang.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboLang.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboLang.FormattingEnabled = true;
            this.cboLang.Location = new System.Drawing.Point(223, 251);
            this.cboLang.Name = "cboLang";
            this.cboLang.Size = new System.Drawing.Size(180, 31);
            this.cboLang.TabIndex = 4;
            this.cboLang.Text = "ES - Spanish";
            this.cboLang.SelectedIndexChanged += new System.EventHandler(this.cboLang_SelectedIndexChanged);
            // 
            // cboCountry
            // 
            this.cboCountry.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCountry.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(601, 198);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(140, 31);
            this.cboCountry.TabIndex = 8;
            this.cboCountry.Text = "ES - Spain";
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.cboCountry_SelectedIndexChanged);
            // 
            // cboGenre
            // 
            this.cboGenre.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboGenre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(223, 144);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(180, 31);
            this.cboGenre.TabIndex = 2;
            this.cboGenre.Text = "DF - Dark Fantasy";
            this.cboGenre.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // btnConfirmInfo
            // 
            this.btnConfirmInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmInfo.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnConfirmInfo.Location = new System.Drawing.Point(688, 414);
            this.btnConfirmInfo.Name = "btnConfirmInfo";
            this.btnConfirmInfo.Size = new System.Drawing.Size(70, 40);
            this.btnConfirmInfo.TabIndex = 10;
            this.btnConfirmInfo.Text = "Add";
            this.btnConfirmInfo.UseVisualStyleBackColor = false;
            this.btnConfirmInfo.Click += new System.EventHandler(this.btnConfirmInfo_Click);
            // 
            // lblMins
            // 
            this.lblMins.AutoSize = true;
            this.lblMins.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMins.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblMins.Location = new System.Drawing.Point(657, 94);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(54, 25);
            this.lblMins.TabIndex = 16;
            this.lblMins.Text = "mins";
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.SystemColors.Window;
            this.txtDuration.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDuration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDuration.Location = new System.Drawing.Point(601, 93);
            this.txtDuration.MaxLength = 3;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.PlaceholderText = "0";
            this.txtDuration.Size = new System.Drawing.Size(50, 30);
            this.txtDuration.TabIndex = 6;
            this.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDuration.TextChanged += new System.EventHandler(this.txtDuration_TextChanged);
            // 
            // txtDVDName
            // 
            this.txtDVDName.BackColor = System.Drawing.SystemColors.Window;
            this.txtDVDName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDVDName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDVDName.Location = new System.Drawing.Point(223, 91);
            this.txtDVDName.MaxLength = 30;
            this.txtDVDName.Name = "txtDVDName";
            this.txtDVDName.PlaceholderText = "El Laberinto Del Fauno";
            this.txtDVDName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDVDName.Size = new System.Drawing.Size(180, 30);
            this.txtDVDName.TabIndex = 1;
            this.txtDVDName.TextChanged += new System.EventHandler(this.txtDVDName_TextChanged);
            // 
            // mnuAdd
            // 
            this.mnuAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuAdd.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuAdd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuAdd.Location = new System.Drawing.Point(0, 0);
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(1000, 31);
            this.mnuAdd.TabIndex = 2;
            this.mnuAdd.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(35, 27);
            this.mnuExit.Text = "X";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmDVDCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.mnuAdd);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDVDCatalogue";
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
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtDVDName;
        private System.Windows.Forms.Button btnConfirmInfo;
        private System.Windows.Forms.MenuStrip mnuAdd;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.ComboBox cboLang;
        private System.Windows.Forms.ComboBox cboAge;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblDateAdd;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}

