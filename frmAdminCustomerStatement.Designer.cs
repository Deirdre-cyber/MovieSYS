
namespace MovieSYS
{
    partial class frmCustomerStatement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnuAdd = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpStatementDetails = new System.Windows.Forms.GroupBox();
            this.lstRented = new System.Windows.Forms.ListBox();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblDVDsRented = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cboMemID = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMemebershipStart = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpMemCheck = new System.Windows.Forms.GroupBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblMemberSearch = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.grpStatementPeriod = new System.Windows.Forms.GroupBox();
            this.btnViewStatement = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpStatementTo = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpStatementFrom = new System.Windows.Forms.DateTimePicker();
            this.grpSearchResults = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.grdSearchRes = new System.Windows.Forms.DataGridView();
            this.lblFinesDue = new System.Windows.Forms.Label();
            this.txtFinesUnpaid = new System.Windows.Forms.TextBox();
            this.lblTotalFines = new System.Windows.Forms.Label();
            this.txtFinesPaid = new System.Windows.Forms.TextBox();
            this.lblTotalDvds = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mnuAdd.SuspendLayout();
            this.grpStatementDetails.SuspendLayout();
            this.grpMemCheck.SuspendLayout();
            this.grpStatementPeriod.SuspendLayout();
            this.grpSearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchRes)).BeginInit();
            this.SuspendLayout();
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
            this.mnuAdd.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.mnuAdd.Size = new System.Drawing.Size(1000, 40);
            this.mnuAdd.TabIndex = 33;
            this.mnuAdd.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuExit.ForeColor = System.Drawing.Color.Azure;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 34);
            this.mnuExit.Text = "X";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // grpStatementDetails
            // 
            this.grpStatementDetails.Controls.Add(this.lblTotalDvds);
            this.grpStatementDetails.Controls.Add(this.textBox1);
            this.grpStatementDetails.Controls.Add(this.lblFinesDue);
            this.grpStatementDetails.Controls.Add(this.txtFinesUnpaid);
            this.grpStatementDetails.Controls.Add(this.lblTotalFines);
            this.grpStatementDetails.Controls.Add(this.txtFinesPaid);
            this.grpStatementDetails.Controls.Add(this.lstRented);
            this.grpStatementDetails.Controls.Add(this.txtMemId);
            this.grpStatementDetails.Controls.Add(this.lblMemberId);
            this.grpStatementDetails.Controls.Add(this.lblDVDsRented);
            this.grpStatementDetails.Controls.Add(this.txtEmail);
            this.grpStatementDetails.Controls.Add(this.lblEmail);
            this.grpStatementDetails.Controls.Add(this.cboMemID);
            this.grpStatementDetails.Controls.Add(this.txtLastName);
            this.grpStatementDetails.Controls.Add(this.dtpDOB);
            this.grpStatementDetails.Controls.Add(this.txtFirstName);
            this.grpStatementDetails.Controls.Add(this.lblMemberType);
            this.grpStatementDetails.Controls.Add(this.lblDateOfBirth);
            this.grpStatementDetails.Controls.Add(this.lblLastName);
            this.grpStatementDetails.Controls.Add(this.lblFirstName);
            this.grpStatementDetails.Controls.Add(this.lblMemebershipStart);
            this.grpStatementDetails.Controls.Add(this.lblMember);
            this.grpStatementDetails.Controls.Add(this.lblCart);
            this.grpStatementDetails.Controls.Add(this.dtpStartDate);
            this.grpStatementDetails.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpStatementDetails.ForeColor = System.Drawing.Color.GhostWhite;
            this.grpStatementDetails.Location = new System.Drawing.Point(58, 316);
            this.grpStatementDetails.Name = "grpStatementDetails";
            this.grpStatementDetails.Size = new System.Drawing.Size(888, 341);
            this.grpStatementDetails.TabIndex = 8;
            this.grpStatementDetails.TabStop = false;
            this.grpStatementDetails.Text = "Statement Details";
            // 
            // lstRented
            // 
            this.lstRented.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstRented.FormattingEnabled = true;
            this.lstRented.ItemHeight = 20;
            this.lstRented.Location = new System.Drawing.Point(594, 29);
            this.lstRented.Name = "lstRented";
            this.lstRented.Size = new System.Drawing.Size(266, 164);
            this.lstRented.TabIndex = 36;
            // 
            // txtMemId
            // 
            this.txtMemId.Enabled = false;
            this.txtMemId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId.Location = new System.Drawing.Point(215, 42);
            this.txtMemId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMemId.MaxLength = 8;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.Size = new System.Drawing.Size(62, 30);
            this.txtMemId.TabIndex = 33;
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberId.Location = new System.Drawing.Point(83, 40);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(123, 28);
            this.lblMemberId.TabIndex = 9;
            this.lblMemberId.Text = "Member ID:";
            // 
            // lblDVDsRented
            // 
            this.lblDVDsRented.AutoSize = true;
            this.lblDVDsRented.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDVDsRented.Location = new System.Drawing.Point(445, 29);
            this.lblDVDsRented.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDVDsRented.Name = "lblDVDsRented";
            this.lblDVDsRented.Size = new System.Drawing.Size(141, 28);
            this.lblDVDsRented.TabIndex = 29;
            this.lblDVDsRented.Text = "DVDs Rented:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(214, 286);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 30);
            this.txtEmail.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(137, 289);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 28);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email:";
            // 
            // cboMemID
            // 
            this.cboMemID.DropDownWidth = 60;
            this.cboMemID.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMemID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboMemID.FormattingEnabled = true;
            this.cboMemID.Location = new System.Drawing.Point(215, 123);
            this.cboMemID.Margin = new System.Windows.Forms.Padding(4);
            this.cboMemID.Name = "cboMemID";
            this.cboMemID.Size = new System.Drawing.Size(180, 31);
            this.cboMemID.TabIndex = 14;
            this.cboMemID.Text = "ST - Standard";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(215, 206);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 30);
            this.txtLastName.TabIndex = 18;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dtpDOB.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.dtpDOB.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(214, 247);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(180, 30);
            this.dtpDOB.TabIndex = 20;
            this.dtpDOB.Value = new System.DateTime(1990, 7, 12, 0, 0, 0, 0);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(214, 165);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 30);
            this.txtFirstName.TabIndex = 16;
            // 
            // lblMemberType
            // 
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberType.Location = new System.Drawing.Point(21, 121);
            this.lblMemberType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Size = new System.Drawing.Size(186, 28);
            this.lblMemberType.TabIndex = 13;
            this.lblMemberType.Text = "Membership Type:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfBirth.Location = new System.Drawing.Point(146, 247);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(60, 28);
            this.lblDateOfBirth.TabIndex = 19;
            this.lblDateOfBirth.Text = "DOB:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(90, 206);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(117, 28);
            this.lblLastName.TabIndex = 17;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(86, 165);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(120, 28);
            this.lblFirstName.TabIndex = 15;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblMemebershipStart
            // 
            this.lblMemebershipStart.AutoSize = true;
            this.lblMemebershipStart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemebershipStart.Location = new System.Drawing.Point(54, 81);
            this.lblMemebershipStart.Name = "lblMemebershipStart";
            this.lblMemebershipStart.Size = new System.Drawing.Size(152, 28);
            this.lblMemebershipStart.TabIndex = 11;
            this.lblMemebershipStart.Text = "Member Since:";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMember.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMember.Location = new System.Drawing.Point(154, 261);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(0, 28);
            this.lblMember.TabIndex = 17;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCart.Location = new System.Drawing.Point(32, 66);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(0, 28);
            this.lblCart.TabIndex = 16;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(214, 81);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(181, 30);
            this.dtpStartDate.TabIndex = 12;
            this.dtpStartDate.Value = new System.DateTime(2019, 7, 18, 0, 0, 0, 0);
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEmail.Location = new System.Drawing.Point(536, 663);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(100, 35);
            this.btnEmail.TabIndex = 32;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = false;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrint.Location = new System.Drawing.Point(424, 663);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 35);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grpMemCheck
            // 
            this.grpMemCheck.Controls.Add(this.txtMemberName);
            this.grpMemCheck.Controls.Add(this.lblMemberSearch);
            this.grpMemCheck.Controls.Add(this.btnCheck);
            this.grpMemCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.grpMemCheck.Location = new System.Drawing.Point(79, 58);
            this.grpMemCheck.Name = "grpMemCheck";
            this.grpMemCheck.Size = new System.Drawing.Size(386, 155);
            this.grpMemCheck.TabIndex = 1;
            this.grpMemCheck.TabStop = false;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemberName.Location = new System.Drawing.Point(193, 49);
            this.txtMemberName.MaxLength = 8;
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemberName.Size = new System.Drawing.Size(160, 30);
            this.txtMemberName.TabIndex = 3;
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
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click_1);
            // 
            // grpStatementPeriod
            // 
            this.grpStatementPeriod.Controls.Add(this.btnViewStatement);
            this.grpStatementPeriod.Controls.Add(this.lblTo);
            this.grpStatementPeriod.Controls.Add(this.dtpStatementTo);
            this.grpStatementPeriod.Controls.Add(this.lblFrom);
            this.grpStatementPeriod.Controls.Add(this.dtpStatementFrom);
            this.grpStatementPeriod.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpStatementPeriod.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpStatementPeriod.Location = new System.Drawing.Point(160, 219);
            this.grpStatementPeriod.Name = "grpStatementPeriod";
            this.grpStatementPeriod.Size = new System.Drawing.Size(700, 91);
            this.grpStatementPeriod.TabIndex = 34;
            this.grpStatementPeriod.TabStop = false;
            this.grpStatementPeriod.Text = "Statement Period";
            // 
            // btnViewStatement
            // 
            this.btnViewStatement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStatement.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewStatement.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnViewStatement.Location = new System.Drawing.Point(624, 34);
            this.btnViewStatement.Name = "btnViewStatement";
            this.btnViewStatement.Size = new System.Drawing.Size(52, 35);
            this.btnViewStatement.TabIndex = 42;
            this.btnViewStatement.Text = "View";
            this.btnViewStatement.UseVisualStyleBackColor = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTo.Location = new System.Drawing.Point(417, 35);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(39, 28);
            this.lblTo.TabIndex = 40;
            this.lblTo.Text = "To:";
            // 
            // dtpStatementTo
            // 
            this.dtpStatementTo.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStatementTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStatementTo.Location = new System.Drawing.Point(462, 35);
            this.dtpStatementTo.Name = "dtpStatementTo";
            this.dtpStatementTo.Size = new System.Drawing.Size(110, 30);
            this.dtpStatementTo.TabIndex = 41;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFrom.Location = new System.Drawing.Point(135, 35);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(65, 28);
            this.lblFrom.TabIndex = 38;
            this.lblFrom.Text = "From:";
            // 
            // dtpStatementFrom
            // 
            this.dtpStatementFrom.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStatementFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStatementFrom.Location = new System.Drawing.Point(204, 36);
            this.dtpStatementFrom.Name = "dtpStatementFrom";
            this.dtpStatementFrom.Size = new System.Drawing.Size(110, 30);
            this.dtpStatementFrom.TabIndex = 39;
            this.dtpStatementFrom.Value = new System.DateTime(2021, 10, 29, 0, 0, 0, 0);
            // 
            // grpSearchResults
            // 
            this.grpSearchResults.Controls.Add(this.btnReturn);
            this.grpSearchResults.Controls.Add(this.grdSearchRes);
            this.grpSearchResults.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpSearchResults.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpSearchResults.Location = new System.Drawing.Point(487, 58);
            this.grpSearchResults.Name = "grpSearchResults";
            this.grpSearchResults.Size = new System.Drawing.Size(477, 155);
            this.grpSearchResults.TabIndex = 35;
            this.grpSearchResults.TabStop = false;
            this.grpSearchResults.Text = "Member Result";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnReturn.Location = new System.Drawing.Point(379, 68);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(52, 35);
            this.btnReturn.TabIndex = 28;
            this.btnReturn.Text = "Exit";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // grdSearchRes
            // 
            this.grdSearchRes.AllowUserToAddRows = false;
            this.grdSearchRes.AllowUserToDeleteRows = false;
            this.grdSearchRes.AllowUserToResizeColumns = false;
            this.grdSearchRes.AllowUserToResizeRows = false;
            this.grdSearchRes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdSearchRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdSearchRes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSearchRes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdSearchRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearchRes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSearchRes.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdSearchRes.GridColor = System.Drawing.Color.DarkSlateGray;
            this.grdSearchRes.Location = new System.Drawing.Point(3, 34);
            this.grdSearchRes.Name = "grdSearchRes";
            this.grdSearchRes.RowHeadersVisible = false;
            this.grdSearchRes.RowHeadersWidth = 45;
            this.grdSearchRes.RowTemplate.Height = 29;
            this.grdSearchRes.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.grdSearchRes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSearchRes.Size = new System.Drawing.Size(370, 100);
            this.grdSearchRes.TabIndex = 8;
            this.grdSearchRes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSearchRes_CellClick_1);
            // 
            // lblFinesDue
            // 
            this.lblFinesDue.AutoSize = true;
            this.lblFinesDue.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinesDue.Location = new System.Drawing.Point(476, 296);
            this.lblFinesDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinesDue.Name = "lblFinesDue";
            this.lblFinesDue.Size = new System.Drawing.Size(109, 28);
            this.lblFinesDue.TabIndex = 41;
            this.lblFinesDue.Text = "Fines Due:";
            // 
            // txtFinesUnpaid
            // 
            this.txtFinesUnpaid.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFinesUnpaid.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtFinesUnpaid.Location = new System.Drawing.Point(592, 294);
            this.txtFinesUnpaid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFinesUnpaid.MaxLength = 6;
            this.txtFinesUnpaid.Name = "txtFinesUnpaid";
            this.txtFinesUnpaid.PlaceholderText = "0.00";
            this.txtFinesUnpaid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFinesUnpaid.Size = new System.Drawing.Size(95, 30);
            this.txtFinesUnpaid.TabIndex = 42;
            this.txtFinesUnpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalFines
            // 
            this.lblTotalFines.AutoSize = true;
            this.lblTotalFines.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalFines.Location = new System.Drawing.Point(467, 253);
            this.lblTotalFines.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalFines.Name = "lblTotalFines";
            this.lblTotalFines.Size = new System.Drawing.Size(118, 28);
            this.lblTotalFines.TabIndex = 39;
            this.lblTotalFines.Text = "Total Fines:";
            // 
            // txtFinesPaid
            // 
            this.txtFinesPaid.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFinesPaid.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtFinesPaid.Location = new System.Drawing.Point(593, 251);
            this.txtFinesPaid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFinesPaid.MaxLength = 6;
            this.txtFinesPaid.Name = "txtFinesPaid";
            this.txtFinesPaid.PlaceholderText = "0.00";
            this.txtFinesPaid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFinesPaid.Size = new System.Drawing.Size(95, 30);
            this.txtFinesPaid.TabIndex = 40;
            this.txtFinesPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalDvds
            // 
            this.lblTotalDvds.AutoSize = true;
            this.lblTotalDvds.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDvds.Location = new System.Drawing.Point(476, 208);
            this.lblTotalDvds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDvds.Name = "lblTotalDvds";
            this.lblTotalDvds.Size = new System.Drawing.Size(110, 28);
            this.lblTotalDvds.TabIndex = 43;
            this.lblTotalDvds.Text = "Total Paid:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.Location = new System.Drawing.Point(592, 206);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "0.00";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(95, 30);
            this.textBox1.TabIndex = 44;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmCustomerStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.grpSearchResults);
            this.Controls.Add(this.grpStatementPeriod);
            this.Controls.Add(this.grpMemCheck);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.grpStatementDetails);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.mnuAdd);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomerStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomerStatement";
            this.Load += new System.EventHandler(this.frmCustomerStatement_Load);
            this.mnuAdd.ResumeLayout(false);
            this.mnuAdd.PerformLayout();
            this.grpStatementDetails.ResumeLayout(false);
            this.grpStatementDetails.PerformLayout();
            this.grpMemCheck.ResumeLayout(false);
            this.grpMemCheck.PerformLayout();
            this.grpStatementPeriod.ResumeLayout(false);
            this.grpStatementPeriod.PerformLayout();
            this.grpSearchResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpStatementDetails;
        private System.Windows.Forms.Label lblMemebershipStart;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cboMemID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Label lblDVDsRented;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox grpMemCheck;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblMemberSearch;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.ListBox lstRented;
        private System.Windows.Forms.GroupBox grpStatementPeriod;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpStatementTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpStatementFrom;
        private System.Windows.Forms.GroupBox grpSearchResults;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView grdSearchRes;
        private System.Windows.Forms.Button btnViewStatement;
        private System.Windows.Forms.Label lblFinesDue;
        private System.Windows.Forms.TextBox txtFinesUnpaid;
        private System.Windows.Forms.Label lblTotalFines;
        private System.Windows.Forms.TextBox txtFinesPaid;
        private System.Windows.Forms.Label lblTotalDvds;
        private System.Windows.Forms.TextBox textBox1;
    }
}