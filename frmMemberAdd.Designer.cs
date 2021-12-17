
namespace MovieSYS
{
    partial class frmMemberAdd
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
            this.mnuAdd = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAddMem = new System.Windows.Forms.GroupBox();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.dtpMemStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblMemStartDate = new System.Windows.Forms.Label();
            this.cboMemID = new System.Windows.Forms.ComboBox();
            this.btnAddMem = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.mnuAdd.SuspendLayout();
            this.grpAddMem.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAdd
            // 
            this.mnuAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuAdd.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuAdd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuAdd.Location = new System.Drawing.Point(0, 0);
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.mnuAdd.Size = new System.Drawing.Size(1000, 35);
            this.mnuAdd.TabIndex = 21;
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
            // grpAddMem
            // 
            this.grpAddMem.Controls.Add(this.txtMemId);
            this.grpAddMem.Controls.Add(this.dtpMemStartDate);
            this.grpAddMem.Controls.Add(this.lblMemStartDate);
            this.grpAddMem.Controls.Add(this.cboMemID);
            this.grpAddMem.Controls.Add(this.btnAddMem);
            this.grpAddMem.Controls.Add(this.txtEmail);
            this.grpAddMem.Controls.Add(this.txtLastName);
            this.grpAddMem.Controls.Add(this.dateTimePicker1);
            this.grpAddMem.Controls.Add(this.txtContactNo);
            this.grpAddMem.Controls.Add(this.txtEircode);
            this.grpAddMem.Controls.Add(this.txtFirstName);
            this.grpAddMem.Controls.Add(this.lblMemberType);
            this.grpAddMem.Controls.Add(this.lblEmail);
            this.grpAddMem.Controls.Add(this.lblContactNo);
            this.grpAddMem.Controls.Add(this.lblEircode);
            this.grpAddMem.Controls.Add(this.lblDateOfBirth);
            this.grpAddMem.Controls.Add(this.lblLastName);
            this.grpAddMem.Controls.Add(this.lblFirstName);
            this.grpAddMem.Controls.Add(this.lblMemberId);
            this.grpAddMem.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpAddMem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpAddMem.Location = new System.Drawing.Point(50, 65);
            this.grpAddMem.Margin = new System.Windows.Forms.Padding(4);
            this.grpAddMem.Name = "grpAddMem";
            this.grpAddMem.Padding = new System.Windows.Forms.Padding(4);
            this.grpAddMem.Size = new System.Drawing.Size(882, 504);
            this.grpAddMem.TabIndex = 1;
            this.grpAddMem.TabStop = false;
            this.grpAddMem.Text = "Add New Member";
            this.grpAddMem.Enter += new System.EventHandler(this.grpAddMem_Enter);
            // 
            // txtMemId
            // 
            this.txtMemId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId.Location = new System.Drawing.Point(247, 115);
            this.txtMemId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemId.MaxLength = 8;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.PlaceholderText = "000001";
            this.txtMemId.Size = new System.Drawing.Size(180, 30);
            this.txtMemId.TabIndex = 3;
            this.txtMemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMemId.TextChanged += new System.EventHandler(this.txtMemId_TextChanged);
            // 
            // dtpMemStartDate
            // 
            this.dtpMemStartDate.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dtpMemStartDate.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.dtpMemStartDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpMemStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMemStartDate.Location = new System.Drawing.Point(633, 279);
            this.dtpMemStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMemStartDate.Name = "dtpMemStartDate";
            this.dtpMemStartDate.Size = new System.Drawing.Size(180, 30);
            this.dtpMemStartDate.TabIndex = 19;
            this.dtpMemStartDate.Value = new System.DateTime(2021, 10, 25, 23, 59, 59, 0);
            this.dtpMemStartDate.ValueChanged += new System.EventHandler(this.dtpMemStartDate_ValueChanged);
            // 
            // lblMemStartDate
            // 
            this.lblMemStartDate.AutoSize = true;
            this.lblMemStartDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemStartDate.Location = new System.Drawing.Point(511, 281);
            this.lblMemStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemStartDate.Name = "lblMemStartDate";
            this.lblMemStartDate.Size = new System.Drawing.Size(114, 28);
            this.lblMemStartDate.TabIndex = 18;
            this.lblMemStartDate.Text = "Start Date:";
            this.lblMemStartDate.Click += new System.EventHandler(this.lblMemStartDate_Click);
            // 
            // cboMemID
            // 
            this.cboMemID.DropDownWidth = 60;
            this.cboMemID.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMemID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboMemID.FormattingEnabled = true;
            this.cboMemID.Location = new System.Drawing.Point(247, 168);
            this.cboMemID.Margin = new System.Windows.Forms.Padding(4);
            this.cboMemID.Name = "cboMemID";
            this.cboMemID.Size = new System.Drawing.Size(180, 31);
            this.cboMemID.TabIndex = 5;
            this.cboMemID.Text = "CH - Childrens";
            this.cboMemID.SelectedIndexChanged += new System.EventHandler(this.cboMemID_SelectedIndexChanged);
            // 
            // btnAddMem
            // 
            this.btnAddMem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMem.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddMem.Location = new System.Drawing.Point(725, 428);
            this.btnAddMem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMem.Name = "btnAddMem";
            this.btnAddMem.Size = new System.Drawing.Size(100, 35);
            this.btnAddMem.TabIndex = 20;
            this.btnAddMem.Text = "Add Member";
            this.btnAddMem.UseVisualStyleBackColor = false;
            this.btnAddMem.Click += new System.EventHandler(this.btnAddMem_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(633, 168);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 30);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(247, 282);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 30);
            this.txtLastName.TabIndex = 9;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.dateTimePicker1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(247, 337);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 30);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2021, 10, 25, 23, 59, 59, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContactNo.Location = new System.Drawing.Point(633, 115);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNo.MaxLength = 15;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(180, 30);
            this.txtContactNo.TabIndex = 13;
            this.txtContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            // 
            // txtEircode
            // 
            this.txtEircode.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEircode.Location = new System.Drawing.Point(633, 222);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(4);
            this.txtEircode.MaxLength = 6;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(180, 30);
            this.txtEircode.TabIndex = 17;
            this.txtEircode.TextChanged += new System.EventHandler(this.txtEircode_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(247, 224);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 30);
            this.txtFirstName.TabIndex = 7;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // lblMemberType
            // 
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberType.Location = new System.Drawing.Point(53, 171);
            this.lblMemberType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Size = new System.Drawing.Size(186, 28);
            this.lblMemberType.TabIndex = 4;
            this.lblMemberType.Text = "Membership Type:";
            this.lblMemberType.Click += new System.EventHandler(this.lblMemberType_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(556, 171);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 28);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContactNo.Location = new System.Drawing.Point(501, 117);
            this.lblContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(124, 28);
            this.lblContactNo.TabIndex = 12;
            this.lblContactNo.Text = "Contact No:";
            this.lblContactNo.Click += new System.EventHandler(this.lblContactNo_Click);
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEircode.Location = new System.Drawing.Point(538, 222);
            this.lblEircode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(87, 28);
            this.lblEircode.TabIndex = 16;
            this.lblEircode.Text = "Eircode:";
            this.lblEircode.Click += new System.EventHandler(this.lblEircode_Click);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfBirth.Location = new System.Drawing.Point(179, 337);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(60, 28);
            this.lblDateOfBirth.TabIndex = 10;
            this.lblDateOfBirth.Text = "DOB:";
            this.lblDateOfBirth.Click += new System.EventHandler(this.lblDateOfBirth_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(122, 282);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(117, 28);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(119, 224);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(120, 28);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberId.Location = new System.Drawing.Point(116, 117);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(123, 28);
            this.lblMemberId.TabIndex = 2;
            this.lblMemberId.Text = "Member ID:";
            this.lblMemberId.Click += new System.EventHandler(this.lblMemberId_Click);
            // 
            // frmMemberAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.mnuAdd);
            this.Controls.Add(this.grpAddMem);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMemberAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMemberAdd";
            this.mnuAdd.ResumeLayout(false);
            this.mnuAdd.PerformLayout();
            this.grpAddMem.ResumeLayout(false);
            this.grpAddMem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpAddMem;
        private System.Windows.Forms.ComboBox cboMemID;
        private System.Windows.Forms.Button btnAddMem;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.DateTimePicker dtpMemStartDate;
        private System.Windows.Forms.Label lblMemStartDate;
        private System.Windows.Forms.TextBox txtMemId;
    }
}