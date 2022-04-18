
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
            this.components = new System.ComponentModel.Container();
            this.mnuAdd = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpReceipt = new System.Windows.Forms.GroupBox();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAddMem = new System.Windows.Forms.Button();
            this.cboMemID = new System.Windows.Forms.ComboBox();
            this.lblMemStartDate = new System.Windows.Forms.Label();
            this.dtpMemStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.grpAddMem = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mnuAdd.SuspendLayout();
            this.grpReceipt.SuspendLayout();
            this.grpAddMem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.mnuAdd.TabIndex = 22;
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
            // grpReceipt
            // 
            this.grpReceipt.Controls.Add(this.lblReceipt);
            this.grpReceipt.Controls.Add(this.btnEmail);
            this.grpReceipt.Controls.Add(this.btnPrint);
            this.grpReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpReceipt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpReceipt.Location = new System.Drawing.Point(316, 591);
            this.grpReceipt.Name = "grpReceipt";
            this.grpReceipt.Size = new System.Drawing.Size(367, 122);
            this.grpReceipt.TabIndex = 22;
            this.grpReceipt.TabStop = false;
            this.grpReceipt.Text = "Receipt";
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.Location = new System.Drawing.Point(80, 23);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(206, 28);
            this.lblReceipt.TabIndex = 29;
            this.lblReceipt.Text = "Print or email Receipt?";
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEmail.Location = new System.Drawing.Point(194, 65);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(92, 35);
            this.btnEmail.TabIndex = 28;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = false;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click_1);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrint.Location = new System.Drawing.Point(80, 65);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 35);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
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
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(247, 224);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.MaxLength = 35;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 30);
            this.txtFirstName.TabIndex = 7;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtFirstName_Validating);
            // 
            // txtEircode
            // 
            this.txtEircode.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEircode.Location = new System.Drawing.Point(633, 222);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(4);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(114, 30);
            this.txtEircode.TabIndex = 17;
            this.txtEircode.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEircode_Validating);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContactNo.Location = new System.Drawing.Point(633, 115);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNo.MaxLength = 10;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(180, 30);
            this.txtContactNo.TabIndex = 13;
            this.txtContactNo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtContactNo_Validating);
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dtpDOB.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.dtpDOB.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(247, 337);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDOB.MaxDate = new System.DateTime(2999, 1, 27, 13, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(117, 30);
            this.dtpDOB.TabIndex = 11;
            this.dtpDOB.Value = new System.DateTime(2021, 10, 25, 23, 59, 59, 0);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(247, 282);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.MaxLength = 35;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 30);
            this.txtLastName.TabIndex = 9;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLastName_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(633, 168);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 70;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 30);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            // 
            // btnAddMem
            // 
            this.btnAddMem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMem.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddMem.Location = new System.Drawing.Point(684, 428);
            this.btnAddMem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMem.Name = "btnAddMem";
            this.btnAddMem.Size = new System.Drawing.Size(141, 35);
            this.btnAddMem.TabIndex = 21;
            this.btnAddMem.Text = "Add Member";
            this.btnAddMem.UseVisualStyleBackColor = false;
            this.btnAddMem.Click += new System.EventHandler(this.btnAddMem_Click);
            // 
            // cboMemID
            // 
            this.cboMemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemID.DropDownWidth = 60;
            this.cboMemID.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMemID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboMemID.FormattingEnabled = true;
            this.cboMemID.Location = new System.Drawing.Point(247, 168);
            this.cboMemID.Margin = new System.Windows.Forms.Padding(4);
            this.cboMemID.Name = "cboMemID";
            this.cboMemID.Size = new System.Drawing.Size(180, 31);
            this.cboMemID.TabIndex = 5;
            this.cboMemID.Validating += new System.ComponentModel.CancelEventHandler(this.CboMemID_Validating);
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
            // 
            // dtpMemStartDate
            // 
            this.dtpMemStartDate.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dtpMemStartDate.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.dtpMemStartDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpMemStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMemStartDate.Location = new System.Drawing.Point(633, 279);
            this.dtpMemStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMemStartDate.MinDate = new System.DateTime(2022, 1, 27, 0, 0, 0, 0);
            this.dtpMemStartDate.Name = "dtpMemStartDate";
            this.dtpMemStartDate.Size = new System.Drawing.Size(114, 30);
            this.dtpMemStartDate.TabIndex = 19;
            this.dtpMemStartDate.Value = new System.DateTime(2022, 1, 27, 0, 0, 0, 0);
            this.dtpMemStartDate.Validating += new System.ComponentModel.CancelEventHandler(this.DtpMemStartDate_Validating);
            // 
            // txtMemId
            // 
            this.txtMemId.Enabled = false;
            this.txtMemId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId.Location = new System.Drawing.Point(247, 115);
            this.txtMemId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemId.MaxLength = 5;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.Size = new System.Drawing.Size(69, 30);
            this.txtMemId.TabIndex = 3;
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
            this.grpAddMem.Controls.Add(this.dtpDOB);
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
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMemberAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.grpReceipt);
            this.Controls.Add(this.mnuAdd);
            this.Controls.Add(this.grpAddMem);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMemberAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMemberAdd";
            this.Load += new System.EventHandler(this.frmMemberAdd_Load);
            this.mnuAdd.ResumeLayout(false);
            this.mnuAdd.PerformLayout();
            this.grpReceipt.ResumeLayout(false);
            this.grpReceipt.PerformLayout();
            this.grpAddMem.ResumeLayout(false);
            this.grpAddMem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpReceipt;
        private System.Windows.Forms.Label lblReceipt;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAddMem;
        private System.Windows.Forms.ComboBox cboMemID;
        private System.Windows.Forms.Label lblMemStartDate;
        private System.Windows.Forms.DateTimePicker dtpMemStartDate;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.GroupBox grpAddMem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}