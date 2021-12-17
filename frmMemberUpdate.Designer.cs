
namespace MovieSYS
{
    partial class frmMemberUpdate
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
            this.grpEditMem = new System.Windows.Forms.GroupBox();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cboMemID = new System.Windows.Forms.ComboBox();
            this.btnEditMem = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMembership = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.mnuAdd = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMemCheck = new System.Windows.Forms.GroupBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblMemberSearch = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.grpSearchResults = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.grpEditMem.SuspendLayout();
            this.mnuAdd.SuspendLayout();
            this.grpMemCheck.SuspendLayout();
            this.grpSearchResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEditMem
            // 
            this.grpEditMem.Controls.Add(this.txtMemId);
            this.grpEditMem.Controls.Add(this.lblLastName);
            this.grpEditMem.Controls.Add(this.lblMemberId);
            this.grpEditMem.Controls.Add(this.dtpDOB);
            this.grpEditMem.Controls.Add(this.cboMemID);
            this.grpEditMem.Controls.Add(this.btnEditMem);
            this.grpEditMem.Controls.Add(this.txtEmail);
            this.grpEditMem.Controls.Add(this.txtLastName);
            this.grpEditMem.Controls.Add(this.txtContactNo);
            this.grpEditMem.Controls.Add(this.txtEircode);
            this.grpEditMem.Controls.Add(this.txtFirstName);
            this.grpEditMem.Controls.Add(this.lblMembership);
            this.grpEditMem.Controls.Add(this.lblEmail);
            this.grpEditMem.Controls.Add(this.lblContactNo);
            this.grpEditMem.Controls.Add(this.lblEircode);
            this.grpEditMem.Controls.Add(this.lblDateOfBirth);
            this.grpEditMem.Controls.Add(this.lblFirstName);
            this.grpEditMem.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpEditMem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpEditMem.Location = new System.Drawing.Point(101, 208);
            this.grpEditMem.Name = "grpEditMem";
            this.grpEditMem.Size = new System.Drawing.Size(792, 379);
            this.grpEditMem.TabIndex = 8;
            this.grpEditMem.TabStop = false;
            this.grpEditMem.Text = "Edit Member";
            this.grpEditMem.Enter += new System.EventHandler(this.grpEditMem_Enter);
            // 
            // txtMemId
            // 
            this.txtMemId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId.Location = new System.Drawing.Point(219, 51);
            this.txtMemId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemId.MaxLength = 8;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.PlaceholderText = "000001";
            this.txtMemId.Size = new System.Drawing.Size(180, 30);
            this.txtMemId.TabIndex = 10;
            this.txtMemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMemId.TextChanged += new System.EventHandler(this.txtMemId_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(94, 175);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(117, 28);
            this.lblLastName.TabIndex = 15;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberId.Location = new System.Drawing.Point(88, 53);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(123, 28);
            this.lblMemberId.TabIndex = 9;
            this.lblMemberId.Text = "Member ID:";
            this.lblMemberId.Click += new System.EventHandler(this.lblMemberId_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(220, 213);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(180, 30);
            this.dtpDOB.TabIndex = 18;
            this.dtpDOB.Value = new System.DateTime(2021, 10, 25, 23, 59, 59, 0);
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // cboMemID
            // 
            this.cboMemID.DropDownWidth = 60;
            this.cboMemID.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMemID.FormattingEnabled = true;
            this.cboMemID.Location = new System.Drawing.Point(220, 91);
            this.cboMemID.Name = "cboMemID";
            this.cboMemID.Size = new System.Drawing.Size(180, 31);
            this.cboMemID.TabIndex = 12;
            this.cboMemID.SelectedIndexChanged += new System.EventHandler(this.cboMemID_SelectedIndexChanged);
            // 
            // btnEditMem
            // 
            this.btnEditMem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMem.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditMem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEditMem.Location = new System.Drawing.Point(611, 315);
            this.btnEditMem.Name = "btnEditMem";
            this.btnEditMem.Size = new System.Drawing.Size(140, 35);
            this.btnEditMem.TabIndex = 25;
            this.btnEditMem.Text = "Confirm Edit";
            this.btnEditMem.UseVisualStyleBackColor = false;
            this.btnEditMem.Click += new System.EventHandler(this.btnEditMem_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(571, 129);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 30);
            this.txtEmail.TabIndex = 22;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(220, 173);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 30);
            this.txtLastName.TabIndex = 16;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContactNo.Location = new System.Drawing.Point(571, 88);
            this.txtContactNo.MaxLength = 15;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(180, 30);
            this.txtContactNo.TabIndex = 20;
            this.txtContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            // 
            // txtEircode
            // 
            this.txtEircode.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEircode.Location = new System.Drawing.Point(571, 170);
            this.txtEircode.MaxLength = 6;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(180, 30);
            this.txtEircode.TabIndex = 24;
            this.txtEircode.TextChanged += new System.EventHandler(this.txtEircode_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(220, 132);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 30);
            this.txtFirstName.TabIndex = 14;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMembership.Location = new System.Drawing.Point(28, 94);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(186, 28);
            this.lblMembership.TabIndex = 11;
            this.lblMembership.Text = "Membership Type:";
            this.lblMembership.Click += new System.EventHandler(this.lblMembership_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(496, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 28);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContactNo.Location = new System.Drawing.Point(441, 89);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(124, 28);
            this.lblContactNo.TabIndex = 19;
            this.lblContactNo.Text = "Contact No:";
            this.lblContactNo.Click += new System.EventHandler(this.lblContactNo_Click);
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEircode.Location = new System.Drawing.Point(479, 172);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(87, 28);
            this.lblEircode.TabIndex = 23;
            this.lblEircode.Text = "Eircode:";
            this.lblEircode.Click += new System.EventHandler(this.lblEircode_Click);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfBirth.Location = new System.Drawing.Point(154, 212);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(60, 28);
            this.lblDateOfBirth.TabIndex = 17;
            this.lblDateOfBirth.Text = "DOB:";
            this.lblDateOfBirth.Click += new System.EventHandler(this.lblDateOfBirth_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(94, 134);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(120, 28);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // mnuAdd
            // 
            this.mnuAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuAdd.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuAdd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuAdd.Location = new System.Drawing.Point(0, 0);
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(1000, 31);
            this.mnuAdd.TabIndex = 26;
            this.mnuAdd.Text = "menuStrip1";
            this.mnuAdd.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuAdd_ItemClicked);
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
            // grpMemCheck
            // 
            this.grpMemCheck.Controls.Add(this.txtMemberName);
            this.grpMemCheck.Controls.Add(this.lblMemberSearch);
            this.grpMemCheck.Controls.Add(this.btnCheck);
            this.grpMemCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.grpMemCheck.Location = new System.Drawing.Point(101, 47);
            this.grpMemCheck.Name = "grpMemCheck";
            this.grpMemCheck.Size = new System.Drawing.Size(386, 155);
            this.grpMemCheck.TabIndex = 1;
            this.grpMemCheck.TabStop = false;
            this.grpMemCheck.Enter += new System.EventHandler(this.grpMemCheck_Enter);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemberName.Location = new System.Drawing.Point(193, 49);
            this.txtMemberName.MaxLength = 8;
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.PlaceholderText = "Mary";
            this.txtMemberName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemberName.Size = new System.Drawing.Size(160, 30);
            this.txtMemberName.TabIndex = 3;
            this.txtMemberName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMemberName.TextChanged += new System.EventHandler(this.txtMemberName_TextChanged);
            // 
            // lblMemberSearch
            // 
            this.lblMemberSearch.AutoSize = true;
            this.lblMemberSearch.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMemberSearch.Location = new System.Drawing.Point(21, 51);
            this.lblMemberSearch.Name = "lblMemberSearch";
            this.lblMemberSearch.Size = new System.Drawing.Size(166, 28);
            this.lblMemberSearch.TabIndex = 2;
            this.lblMemberSearch.Text = "Search Member:";
            this.lblMemberSearch.Click += new System.EventHandler(this.lblMemberSearch_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCheck.Location = new System.Drawing.Point(136, 98);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(145, 35);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check Account";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // grpSearchResults
            // 
            this.grpSearchResults.Controls.Add(this.btnSelect);
            this.grpSearchResults.Controls.Add(this.lstResults);
            this.grpSearchResults.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpSearchResults.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpSearchResults.Location = new System.Drawing.Point(511, 47);
            this.grpSearchResults.Name = "grpSearchResults";
            this.grpSearchResults.Size = new System.Drawing.Size(382, 155);
            this.grpSearchResults.TabIndex = 5;
            this.grpSearchResults.TabStop = false;
            this.grpSearchResults.Text = "Member Result";
            this.grpSearchResults.Enter += new System.EventHandler(this.grpSearchResults_Enter);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSelect.Location = new System.Drawing.Point(271, 66);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 35);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Edit";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lstResults
            // 
            this.lstResults.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 23;
            this.lstResults.Location = new System.Drawing.Point(21, 37);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(211, 96);
            this.lstResults.TabIndex = 6;
            this.lstResults.SelectedIndexChanged += new System.EventHandler(this.lstResults_SelectedIndexChanged);
            // 
            // frmMemberUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.grpSearchResults);
            this.Controls.Add(this.grpMemCheck);
            this.Controls.Add(this.mnuAdd);
            this.Controls.Add(this.grpEditMem);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMemberUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMemberUpdate";
            this.Load += new System.EventHandler(this.frmMemberUpdate_Load);
            this.grpEditMem.ResumeLayout(false);
            this.grpEditMem.PerformLayout();
            this.mnuAdd.ResumeLayout(false);
            this.mnuAdd.PerformLayout();
            this.grpMemCheck.ResumeLayout(false);
            this.grpMemCheck.PerformLayout();
            this.grpSearchResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpEditMem;
        private System.Windows.Forms.ComboBox cboMemID;
        private System.Windows.Forms.Button btnEditMem;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.MenuStrip mnuAdd;
        private System.Windows.Forms.GroupBox grpMemCheck;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpSearchResults;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblMemberSearch;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.Label lblMemberId;
    }
}