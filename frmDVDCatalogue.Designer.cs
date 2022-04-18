
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
            this.components = new System.ComponentModel.Container();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.lblCopies = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.txtDVDId = new System.Windows.Forms.TextBox();
            this.lblDvdId = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblDateAdd = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cboAge = new System.Windows.Forms.ComboBox();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.btnConfirmInfo = new System.Windows.Forms.Button();
            this.lblMins = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtDVDName = new System.Windows.Forms.TextBox();
            this.mnuAdd = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpDetails.SuspendLayout();
            this.mnuAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.Color.LightSlateGray;
            this.grpDetails.Controls.Add(this.txtCopies);
            this.grpDetails.Controls.Add(this.lblCopies);
            this.grpDetails.Controls.Add(this.lblGenre);
            this.grpDetails.Controls.Add(this.cboGenre);
            this.grpDetails.Controls.Add(this.txtDVDId);
            this.grpDetails.Controls.Add(this.lblDvdId);
            this.grpDetails.Controls.Add(this.dtpDate);
            this.grpDetails.Controls.Add(this.lblAgeRating);
            this.grpDetails.Controls.Add(this.lblCountry);
            this.grpDetails.Controls.Add(this.lblDateAdd);
            this.grpDetails.Controls.Add(this.lblDuration);
            this.grpDetails.Controls.Add(this.lblYear);
            this.grpDetails.Controls.Add(this.lblCategory);
            this.grpDetails.Controls.Add(this.lblTitle);
            this.grpDetails.Controls.Add(this.txtYear);
            this.grpDetails.Controls.Add(this.cboAge);
            this.grpDetails.Controls.Add(this.cboCat);
            this.grpDetails.Controls.Add(this.cboCountry);
            this.grpDetails.Controls.Add(this.btnConfirmInfo);
            this.grpDetails.Controls.Add(this.lblMins);
            this.grpDetails.Controls.Add(this.txtDuration);
            this.grpDetails.Controls.Add(this.txtDVDName);
            this.grpDetails.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpDetails.Location = new System.Drawing.Point(98, 46);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(792, 507);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "DVD Details";
            // 
            // txtCopies
            // 
            this.txtCopies.BackColor = System.Drawing.SystemColors.Window;
            this.txtCopies.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCopies.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCopies.Location = new System.Drawing.Point(615, 249);
            this.txtCopies.MaxLength = 2;
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.PlaceholderText = "0";
            this.txtCopies.Size = new System.Drawing.Size(50, 30);
            this.txtCopies.TabIndex = 10;
            this.txtCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCopies.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCopies_Validating);
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCopies.Location = new System.Drawing.Point(530, 249);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(79, 28);
            this.lblCopies.TabIndex = 24;
            this.lblCopies.Text = "Copies:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenre.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblGenre.Location = new System.Drawing.Point(142, 252);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(73, 28);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "Genre:";
            // 
            // cboGenre
            // 
            this.cboGenre.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboGenre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(221, 249);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(180, 31);
            this.cboGenre.TabIndex = 4;
            this.cboGenre.Validating += new System.ComponentModel.CancelEventHandler(this.CboGenre_Validating);
            // 
            // txtDVDId
            // 
            this.txtDVDId.Enabled = false;
            this.txtDVDId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDVDId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDVDId.Location = new System.Drawing.Point(221, 93);
            this.txtDVDId.MaxLength = 4;
            this.txtDVDId.Name = "txtDVDId";
            this.txtDVDId.Size = new System.Drawing.Size(58, 30);
            this.txtDVDId.TabIndex = 1;
            // 
            // lblDvdId
            // 
            this.lblDvdId.AutoSize = true;
            this.lblDvdId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDvdId.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblDvdId.Location = new System.Drawing.Point(135, 94);
            this.lblDvdId.Name = "lblDvdId";
            this.lblDvdId.Size = new System.Drawing.Size(87, 28);
            this.lblDvdId.TabIndex = 2;
            this.lblDvdId.Text = "DVD ID:";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.dtpDate.CalendarTitleBackColor = System.Drawing.Color.LightSlateGray;
            this.dtpDate.CalendarTitleForeColor = System.Drawing.Color.LightSlateGray;
            this.dtpDate.Enabled = false;
            this.dtpDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.Location = new System.Drawing.Point(615, 195);
            this.dtpDate.MaxDate = new System.DateTime(2099, 2, 4, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(2020, 12, 25, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(140, 30);
            this.dtpDate.TabIndex = 9;
            this.dtpDate.Value = new System.DateTime(2022, 1, 27, 0, 0, 0, 0);
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.AutoSize = true;
            this.lblAgeRating.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAgeRating.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblAgeRating.Location = new System.Drawing.Point(90, 354);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(122, 28);
            this.lblAgeRating.TabIndex = 20;
            this.lblAgeRating.Text = "Age Rating:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountry.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblCountry.Location = new System.Drawing.Point(122, 305);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(93, 28);
            this.lblCountry.TabIndex = 18;
            this.lblCountry.Text = "Country:";
            // 
            // lblDateAdd
            // 
            this.lblDateAdd.AutoSize = true;
            this.lblDateAdd.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateAdd.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblDateAdd.Location = new System.Drawing.Point(477, 199);
            this.lblDateAdd.Name = "lblDateAdd";
            this.lblDateAdd.Size = new System.Drawing.Size(129, 28);
            this.lblDateAdd.TabIndex = 16;
            this.lblDateAdd.Text = "Date Added:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDuration.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblDuration.Location = new System.Drawing.Point(499, 146);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(101, 28);
            this.lblDuration.TabIndex = 14;
            this.lblDuration.Text = "Duration:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(551, 94);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(58, 28);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Year:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(112, 198);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(103, 28);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTitle.Location = new System.Drawing.Point(155, 143);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(60, 28);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title:";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtYear.Location = new System.Drawing.Point(615, 96);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(50, 30);
            this.txtYear.TabIndex = 7;
            this.txtYear.Validating += new System.ComponentModel.CancelEventHandler(this.TxtYear_Validating);
            // 
            // cboAge
            // 
            this.cboAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAge.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboAge.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboAge.FormattingEnabled = true;
            this.cboAge.Location = new System.Drawing.Point(221, 351);
            this.cboAge.Name = "cboAge";
            this.cboAge.Size = new System.Drawing.Size(50, 31);
            this.cboAge.TabIndex = 6;
            this.cboAge.Validating += new System.ComponentModel.CancelEventHandler(this.CboAge_Validating);
            // 
            // cboCat
            // 
            this.cboCat.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCat.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(221, 195);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(180, 31);
            this.cboCat.TabIndex = 3;
            this.cboCat.Validating += new System.ComponentModel.CancelEventHandler(this.CboCat_Validating);
            // 
            // cboCountry
            // 
            this.cboCountry.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCountry.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(221, 302);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(180, 31);
            this.cboCountry.TabIndex = 5;
            this.cboCountry.Validating += new System.ComponentModel.CancelEventHandler(this.CboCountry_Validating);
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
            this.btnConfirmInfo.TabIndex = 11;
            this.btnConfirmInfo.Text = "Add";
            this.btnConfirmInfo.UseVisualStyleBackColor = false;
            this.btnConfirmInfo.Click += new System.EventHandler(this.btnConfirmInfo_Click);
            // 
            // lblMins
            // 
            this.lblMins.AutoSize = true;
            this.lblMins.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMins.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblMins.Location = new System.Drawing.Point(671, 146);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(54, 25);
            this.lblMins.TabIndex = 0;
            this.lblMins.Text = "mins";
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.SystemColors.Window;
            this.txtDuration.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDuration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDuration.Location = new System.Drawing.Point(615, 144);
            this.txtDuration.MaxLength = 3;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.PlaceholderText = "0";
            this.txtDuration.Size = new System.Drawing.Size(50, 30);
            this.txtDuration.TabIndex = 8;
            this.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDuration.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDuration_Validating);
            // 
            // txtDVDName
            // 
            this.txtDVDName.BackColor = System.Drawing.SystemColors.Window;
            this.txtDVDName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDVDName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDVDName.Location = new System.Drawing.Point(221, 143);
            this.txtDVDName.MaxLength = 50;
            this.txtDVDName.Name = "txtDVDName";
            this.txtDVDName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDVDName.Size = new System.Drawing.Size(180, 30);
            this.txtDVDName.TabIndex = 2;
            this.txtDVDName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDVDName_Validating_1);
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
            this.mnuAdd.TabIndex = 13;
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
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDVDCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 731);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.mnuAdd);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDVDCatalogue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogue A DVD";
            this.Load += new System.EventHandler(this.frmDVDCatalogue_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.mnuAdd.ResumeLayout(false);
            this.mnuAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.ComboBox cboAge;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblDateAdd;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtDVDId;
        private System.Windows.Forms.Label lblDvdId;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

