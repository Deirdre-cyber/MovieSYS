
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
            this.mnuAdd = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpStatementDetails = new System.Windows.Forms.GroupBox();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Button();
            this.lblDVDsOut = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblStatementTo = new System.Windows.Forms.Label();
            this.dtpStatementTo = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cboMemID = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStatementFrom = new System.Windows.Forms.Label();
            this.dtpStatementFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFinesDue = new System.Windows.Forms.Label();
            this.txtFineAmount = new System.Windows.Forms.TextBox();
            this.lblMemebershipStart = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.dtpDueBack = new System.Windows.Forms.DateTimePicker();
            this.grpSearchResults = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.grpMemCheck = new System.Windows.Forms.GroupBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblMemberSearch = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.mnuAdd.SuspendLayout();
            this.grpStatementDetails.SuspendLayout();
            this.grpSearchResults.SuspendLayout();
            this.grpMemCheck.SuspendLayout();
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
            this.mnuAdd.TabIndex = 11;
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
            this.grpStatementDetails.Controls.Add(this.txtMemId);
            this.grpStatementDetails.Controls.Add(this.lblMemberId);
            this.grpStatementDetails.Controls.Add(this.btnEmail);
            this.grpStatementDetails.Controls.Add(this.lblDVDsOut);
            this.grpStatementDetails.Controls.Add(this.btnPrint);
            this.grpStatementDetails.Controls.Add(this.textBox2);
            this.grpStatementDetails.Controls.Add(this.lblStatementTo);
            this.grpStatementDetails.Controls.Add(this.dtpStatementTo);
            this.grpStatementDetails.Controls.Add(this.txtEmail);
            this.grpStatementDetails.Controls.Add(this.lblEmail);
            this.grpStatementDetails.Controls.Add(this.cboMemID);
            this.grpStatementDetails.Controls.Add(this.txtLastName);
            this.grpStatementDetails.Controls.Add(this.dateTimePicker2);
            this.grpStatementDetails.Controls.Add(this.txtFirstName);
            this.grpStatementDetails.Controls.Add(this.lblMemberType);
            this.grpStatementDetails.Controls.Add(this.lblDateOfBirth);
            this.grpStatementDetails.Controls.Add(this.lblLastName);
            this.grpStatementDetails.Controls.Add(this.lblFirstName);
            this.grpStatementDetails.Controls.Add(this.lblStatementFrom);
            this.grpStatementDetails.Controls.Add(this.dtpStatementFrom);
            this.grpStatementDetails.Controls.Add(this.lblFinesDue);
            this.grpStatementDetails.Controls.Add(this.txtFineAmount);
            this.grpStatementDetails.Controls.Add(this.lblMemebershipStart);
            this.grpStatementDetails.Controls.Add(this.lblMember);
            this.grpStatementDetails.Controls.Add(this.lblCart);
            this.grpStatementDetails.Controls.Add(this.dtpDueBack);
            this.grpStatementDetails.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpStatementDetails.ForeColor = System.Drawing.Color.GhostWhite;
            this.grpStatementDetails.Location = new System.Drawing.Point(79, 219);
            this.grpStatementDetails.Name = "grpStatementDetails";
            this.grpStatementDetails.Size = new System.Drawing.Size(833, 404);
            this.grpStatementDetails.TabIndex = 18;
            this.grpStatementDetails.TabStop = false;
            this.grpStatementDetails.Text = "Statement Details";
            this.grpStatementDetails.Enter += new System.EventHandler(this.grpStatementDetails_Enter);
            // 
            // txtMemId
            // 
            this.txtMemId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId.Location = new System.Drawing.Point(212, 50);
            this.txtMemId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemId.MaxLength = 8;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.PlaceholderText = "00001";
            this.txtMemId.Size = new System.Drawing.Size(180, 30);
            this.txtMemId.TabIndex = 48;
            this.txtMemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMemId.TextChanged += new System.EventHandler(this.txtMemId_TextChanged_1);
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberId.Location = new System.Drawing.Point(81, 52);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(123, 28);
            this.lblMemberId.TabIndex = 47;
            this.lblMemberId.Text = "Member ID:";
            this.lblMemberId.Click += new System.EventHandler(this.lblMemberId_Click_1);
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEmail.Location = new System.Drawing.Point(694, 338);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(100, 35);
            this.btnEmail.TabIndex = 45;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = false;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // lblDVDsOut
            // 
            this.lblDVDsOut.AutoSize = true;
            this.lblDVDsOut.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDVDsOut.Location = new System.Drawing.Point(514, 262);
            this.lblDVDsOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDVDsOut.Name = "lblDVDsOut";
            this.lblDVDsOut.Size = new System.Drawing.Size(177, 28);
            this.lblDVDsOut.TabIndex = 44;
            this.lblDVDsOut.Text = "Currently Rented:";
            this.lblDVDsOut.Click += new System.EventHandler(this.lblDVDsOut_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrint.Location = new System.Drawing.Point(582, 338);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 35);
            this.btnPrint.TabIndex = 46;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBox2.Location = new System.Drawing.Point(699, 258);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.MaxLength = 6;
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "3";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(95, 30);
            this.textBox2.TabIndex = 43;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblStatementTo
            // 
            this.lblStatementTo.AutoSize = true;
            this.lblStatementTo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatementTo.Location = new System.Drawing.Point(533, 94);
            this.lblStatementTo.Name = "lblStatementTo";
            this.lblStatementTo.Size = new System.Drawing.Size(142, 28);
            this.lblStatementTo.TabIndex = 42;
            this.lblStatementTo.Text = "Statement To:";
            this.lblStatementTo.Click += new System.EventHandler(this.lblStatementTo_Click);
            // 
            // dtpStatementTo
            // 
            this.dtpStatementTo.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStatementTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStatementTo.Location = new System.Drawing.Point(681, 93);
            this.dtpStatementTo.Name = "dtpStatementTo";
            this.dtpStatementTo.Size = new System.Drawing.Size(110, 30);
            this.dtpStatementTo.TabIndex = 41;
            this.dtpStatementTo.ValueChanged += new System.EventHandler(this.dtpStatementTo_ValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(212, 298);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 30);
            this.txtEmail.TabIndex = 40;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(135, 301);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 28);
            this.lblEmail.TabIndex = 37;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // cboMemID
            // 
            this.cboMemID.DropDownWidth = 60;
            this.cboMemID.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMemID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboMemID.FormattingEnabled = true;
            this.cboMemID.Location = new System.Drawing.Point(213, 135);
            this.cboMemID.Margin = new System.Windows.Forms.Padding(4);
            this.cboMemID.Name = "cboMemID";
            this.cboMemID.Size = new System.Drawing.Size(180, 31);
            this.cboMemID.TabIndex = 33;
            this.cboMemID.Text = "ST - Standard";
            this.cboMemID.SelectedIndexChanged += new System.EventHandler(this.cboMemID_SelectedIndexChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(213, 218);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 30);
            this.txtLastName.TabIndex = 35;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
            this.dateTimePicker2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(212, 259);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(180, 30);
            this.dateTimePicker2.TabIndex = 36;
            this.dateTimePicker2.Value = new System.DateTime(1990, 7, 12, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(212, 177);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 30);
            this.txtFirstName.TabIndex = 34;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // lblMemberType
            // 
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberType.Location = new System.Drawing.Point(19, 133);
            this.lblMemberType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Size = new System.Drawing.Size(186, 28);
            this.lblMemberType.TabIndex = 29;
            this.lblMemberType.Text = "Membership Type:";
            this.lblMemberType.Click += new System.EventHandler(this.lblMemberType_Click);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfBirth.Location = new System.Drawing.Point(144, 259);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(60, 28);
            this.lblDateOfBirth.TabIndex = 30;
            this.lblDateOfBirth.Text = "DOB:";
            this.lblDateOfBirth.Click += new System.EventHandler(this.lblDateOfBirth_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(88, 218);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(117, 28);
            this.lblLastName.TabIndex = 31;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(84, 177);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(120, 28);
            this.lblFirstName.TabIndex = 32;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // lblStatementFrom
            // 
            this.lblStatementFrom.AutoSize = true;
            this.lblStatementFrom.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatementFrom.Location = new System.Drawing.Point(508, 53);
            this.lblStatementFrom.Name = "lblStatementFrom";
            this.lblStatementFrom.Size = new System.Drawing.Size(168, 28);
            this.lblStatementFrom.TabIndex = 28;
            this.lblStatementFrom.Text = "Statement From:";
            this.lblStatementFrom.Click += new System.EventHandler(this.lblStatementFrom_Click);
            // 
            // dtpStatementFrom
            // 
            this.dtpStatementFrom.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStatementFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStatementFrom.Location = new System.Drawing.Point(681, 52);
            this.dtpStatementFrom.Name = "dtpStatementFrom";
            this.dtpStatementFrom.Size = new System.Drawing.Size(110, 30);
            this.dtpStatementFrom.TabIndex = 27;
            this.dtpStatementFrom.Value = new System.DateTime(2021, 10, 29, 0, 0, 0, 0);
            this.dtpStatementFrom.ValueChanged += new System.EventHandler(this.dtpStatementFrom_ValueChanged);
            // 
            // lblFinesDue
            // 
            this.lblFinesDue.AutoSize = true;
            this.lblFinesDue.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinesDue.Location = new System.Drawing.Point(582, 220);
            this.lblFinesDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinesDue.Name = "lblFinesDue";
            this.lblFinesDue.Size = new System.Drawing.Size(109, 28);
            this.lblFinesDue.TabIndex = 23;
            this.lblFinesDue.Text = "Fines Due:";
            this.lblFinesDue.Click += new System.EventHandler(this.lblFinesDue_Click);
            // 
            // txtFineAmount
            // 
            this.txtFineAmount.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFineAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtFineAmount.Location = new System.Drawing.Point(699, 218);
            this.txtFineAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFineAmount.MaxLength = 6;
            this.txtFineAmount.Name = "txtFineAmount";
            this.txtFineAmount.PlaceholderText = "0.00";
            this.txtFineAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFineAmount.Size = new System.Drawing.Size(95, 30);
            this.txtFineAmount.TabIndex = 22;
            this.txtFineAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFineAmount.TextChanged += new System.EventHandler(this.txtFineAmount_TextChanged);
            // 
            // lblMemebershipStart
            // 
            this.lblMemebershipStart.AutoSize = true;
            this.lblMemebershipStart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemebershipStart.Location = new System.Drawing.Point(52, 93);
            this.lblMemebershipStart.Name = "lblMemebershipStart";
            this.lblMemebershipStart.Size = new System.Drawing.Size(152, 28);
            this.lblMemebershipStart.TabIndex = 20;
            this.lblMemebershipStart.Text = "Member Since:";
            this.lblMemebershipStart.Click += new System.EventHandler(this.lblMemebershipStart_Click);
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMember.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMember.Location = new System.Drawing.Point(152, 273);
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
            // dtpDueBack
            // 
            this.dtpDueBack.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDueBack.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueBack.Location = new System.Drawing.Point(212, 93);
            this.dtpDueBack.Name = "dtpDueBack";
            this.dtpDueBack.Size = new System.Drawing.Size(181, 30);
            this.dtpDueBack.TabIndex = 12;
            this.dtpDueBack.Value = new System.DateTime(2019, 7, 18, 0, 0, 0, 0);
            this.dtpDueBack.ValueChanged += new System.EventHandler(this.dtpDueBack_ValueChanged);
            // 
            // grpSearchResults
            // 
            this.grpSearchResults.Controls.Add(this.btnSelect);
            this.grpSearchResults.Controls.Add(this.lstResults);
            this.grpSearchResults.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpSearchResults.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpSearchResults.Location = new System.Drawing.Point(530, 58);
            this.grpSearchResults.Name = "grpSearchResults";
            this.grpSearchResults.Size = new System.Drawing.Size(382, 155);
            this.grpSearchResults.TabIndex = 20;
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
            this.btnSelect.TabIndex = 4;
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
            this.lstResults.TabIndex = 0;
            this.lstResults.SelectedIndexChanged += new System.EventHandler(this.lstResults_SelectedIndexChanged);
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
            this.grpMemCheck.TabIndex = 19;
            this.grpMemCheck.TabStop = false;
            this.grpMemCheck.Enter += new System.EventHandler(this.grpMemCheck_Enter_1);
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
            this.txtMemberName.TabIndex = 5;
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
            this.lblMemberSearch.TabIndex = 4;
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
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check Account";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click_1);
            // 
            // frmCustomerStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.grpSearchResults);
            this.Controls.Add(this.grpMemCheck);
            this.Controls.Add(this.grpStatementDetails);
            this.Controls.Add(this.mnuAdd);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomerStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomerStatement";
            this.mnuAdd.ResumeLayout(false);
            this.mnuAdd.PerformLayout();
            this.grpStatementDetails.ResumeLayout(false);
            this.grpStatementDetails.PerformLayout();
            this.grpSearchResults.ResumeLayout(false);
            this.grpMemCheck.ResumeLayout(false);
            this.grpMemCheck.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dtpDueBack;
        private System.Windows.Forms.Label lblFinesDue;
        private System.Windows.Forms.TextBox txtFineAmount;
        private System.Windows.Forms.Label lblStatementFrom;
        private System.Windows.Forms.DateTimePicker dtpStatementFrom;
        private System.Windows.Forms.ComboBox cboMemID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStatementTo;
        private System.Windows.Forms.DateTimePicker dtpStatementTo;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Label lblDVDsOut;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox grpSearchResults;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.GroupBox grpMemCheck;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblMemberSearch;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.Label lblMemberId;
    }
}