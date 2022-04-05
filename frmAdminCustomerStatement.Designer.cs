
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnuAdd = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpStatementDetails = new System.Windows.Forms.GroupBox();
            this.grdRented = new System.Windows.Forms.DataGridView();
            this.grdReturned = new System.Windows.Forms.DataGridView();
            this.txtMembership = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFinesOwed = new System.Windows.Forms.Label();
            this.txtFinesOwed = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRentals = new System.Windows.Forms.Label();
            this.txtRentals = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblFinesPaid = new System.Windows.Forms.Label();
            this.txtFinesPaid = new System.Windows.Forms.TextBox();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.grpMemCheck = new System.Windows.Forms.GroupBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblMemberSearch = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.grpStatementPeriod = new System.Windows.Forms.GroupBox();
            this.optYear = new System.Windows.Forms.RadioButton();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.optStart = new System.Windows.Forms.RadioButton();
            this.optCustom = new System.Windows.Forms.RadioButton();
            this.btnViewStatement = new System.Windows.Forms.Button();
            this.dtpStatementTo = new System.Windows.Forms.DateTimePicker();
            this.dtpStatementFrom = new System.Windows.Forms.DateTimePicker();
            this.grpSearchResults = new System.Windows.Forms.GroupBox();
            this.grdSearchRes = new System.Windows.Forms.DataGridView();
            this.mnuAdd.SuspendLayout();
            this.grpStatementDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRented)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReturned)).BeginInit();
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
            this.mnuExit,
            this.mnuBack});
            this.mnuAdd.Location = new System.Drawing.Point(0, 0);
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.mnuAdd.Size = new System.Drawing.Size(1002, 40);
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
            // mnuBack
            // 
            this.mnuBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(59, 34);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // grpStatementDetails
            // 
            this.grpStatementDetails.Controls.Add(this.grdRented);
            this.grpStatementDetails.Controls.Add(this.grdReturned);
            this.grpStatementDetails.Controls.Add(this.txtMembership);
            this.grpStatementDetails.Controls.Add(this.btnEmail);
            this.grpStatementDetails.Controls.Add(this.txtPeriod);
            this.grpStatementDetails.Controls.Add(this.lblPeriod);
            this.grpStatementDetails.Controls.Add(this.btnPrint);
            this.grpStatementDetails.Controls.Add(this.label3);
            this.grpStatementDetails.Controls.Add(this.lblFinesOwed);
            this.grpStatementDetails.Controls.Add(this.txtFinesOwed);
            this.grpStatementDetails.Controls.Add(this.txtContact);
            this.grpStatementDetails.Controls.Add(this.dtpStartDate);
            this.grpStatementDetails.Controls.Add(this.txtName);
            this.grpStatementDetails.Controls.Add(this.lblName);
            this.grpStatementDetails.Controls.Add(this.lblRentals);
            this.grpStatementDetails.Controls.Add(this.txtRentals);
            this.grpStatementDetails.Controls.Add(this.lblTotal);
            this.grpStatementDetails.Controls.Add(this.txtTotal);
            this.grpStatementDetails.Controls.Add(this.lblFinesPaid);
            this.grpStatementDetails.Controls.Add(this.txtFinesPaid);
            this.grpStatementDetails.Controls.Add(this.txtMemId);
            this.grpStatementDetails.Controls.Add(this.lblMemberId);
            this.grpStatementDetails.Controls.Add(this.txtEmail);
            this.grpStatementDetails.Controls.Add(this.lblMemberType);
            this.grpStatementDetails.Controls.Add(this.lblCart);
            this.grpStatementDetails.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpStatementDetails.ForeColor = System.Drawing.Color.GhostWhite;
            this.grpStatementDetails.Location = new System.Drawing.Point(58, 289);
            this.grpStatementDetails.Name = "grpStatementDetails";
            this.grpStatementDetails.Size = new System.Drawing.Size(888, 739);
            this.grpStatementDetails.TabIndex = 8;
            this.grpStatementDetails.TabStop = false;
            this.grpStatementDetails.Text = "STATEMENT";
            // 
            // grdRented
            // 
            this.grdRented.AllowUserToAddRows = false;
            this.grdRented.AllowUserToDeleteRows = false;
            this.grdRented.AllowUserToResizeColumns = false;
            this.grdRented.AllowUserToResizeRows = false;
            this.grdRented.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdRented.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdRented.Enabled = false;
            this.grdRented.Location = new System.Drawing.Point(172, 410);
            this.grdRented.Name = "grdRented";
            this.grdRented.RowHeadersWidth = 51;
            this.grdRented.RowTemplate.Height = 29;
            this.grdRented.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdRented.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRented.Size = new System.Drawing.Size(549, 133);
            this.grdRented.TabIndex = 59;
            // 
            // grdReturned
            // 
            this.grdReturned.AllowUserToAddRows = false;
            this.grdReturned.AllowUserToDeleteRows = false;
            this.grdReturned.AllowUserToResizeColumns = false;
            this.grdReturned.AllowUserToResizeRows = false;
            this.grdReturned.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdReturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdReturned.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdReturned.Enabled = false;
            this.grdReturned.Location = new System.Drawing.Point(172, 183);
            this.grdReturned.Name = "grdReturned";
            this.grdReturned.RowHeadersWidth = 51;
            this.grdReturned.RowTemplate.Height = 29;
            this.grdReturned.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdReturned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdReturned.Size = new System.Drawing.Size(549, 212);
            this.grdReturned.TabIndex = 58;
            // 
            // txtMembership
            // 
            this.txtMembership.Enabled = false;
            this.txtMembership.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMembership.Location = new System.Drawing.Point(712, 66);
            this.txtMembership.Margin = new System.Windows.Forms.Padding(4);
            this.txtMembership.MaxLength = 30;
            this.txtMembership.Name = "txtMembership";
            this.txtMembership.Size = new System.Drawing.Size(142, 30);
            this.txtMembership.TabIndex = 57;
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEmail.Location = new System.Drawing.Point(480, 681);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(100, 35);
            this.btnEmail.TabIndex = 32;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = false;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Enabled = false;
            this.txtPeriod.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPeriod.Location = new System.Drawing.Point(285, 66);
            this.txtPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeriod.MaxLength = 50;
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(202, 30);
            this.txtPeriod.TabIndex = 56;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPeriod.Location = new System.Drawing.Point(282, 34);
            this.lblPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(205, 28);
            this.lblPeriod.TabIndex = 55;
            this.lblPeriod.Text = "STATEMENT PERIOD";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrint.Location = new System.Drawing.Point(368, 681);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 35);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(83, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 28);
            this.label3.TabIndex = 54;
            // 
            // lblFinesOwed
            // 
            this.lblFinesOwed.AutoSize = true;
            this.lblFinesOwed.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinesOwed.Location = new System.Drawing.Point(35, 632);
            this.lblFinesOwed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinesOwed.Name = "lblFinesOwed";
            this.lblFinesOwed.Size = new System.Drawing.Size(125, 28);
            this.lblFinesOwed.TabIndex = 52;
            this.lblFinesOwed.Text = "Fines Owed:";
            // 
            // txtFinesOwed
            // 
            this.txtFinesOwed.Enabled = false;
            this.txtFinesOwed.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFinesOwed.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtFinesOwed.Location = new System.Drawing.Point(161, 630);
            this.txtFinesOwed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFinesOwed.MaxLength = 6;
            this.txtFinesOwed.Name = "txtFinesOwed";
            this.txtFinesOwed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFinesOwed.Size = new System.Drawing.Size(95, 30);
            this.txtFinesOwed.TabIndex = 53;
            this.txtFinesOwed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtContact
            // 
            this.txtContact.Enabled = false;
            this.txtContact.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContact.Location = new System.Drawing.Point(21, 103);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.MaxLength = 50;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(180, 25);
            this.txtContact.TabIndex = 51;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(712, 104);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(142, 30);
            this.dtpStartDate.TabIndex = 48;
            this.dtpStartDate.Value = new System.DateTime(2019, 7, 18, 0, 0, 0, 0);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(21, 70);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 25);
            this.txtName.TabIndex = 46;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(21, 43);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 23);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "INVOICE TO";
            // 
            // lblRentals
            // 
            this.lblRentals.AutoSize = true;
            this.lblRentals.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRentals.Location = new System.Drawing.Point(665, 546);
            this.lblRentals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentals.Name = "lblRentals";
            this.lblRentals.Size = new System.Drawing.Size(86, 28);
            this.lblRentals.TabIndex = 43;
            this.lblRentals.Text = "Rentals:";
            // 
            // txtRentals
            // 
            this.txtRentals.Enabled = false;
            this.txtRentals.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRentals.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtRentals.Location = new System.Drawing.Point(759, 544);
            this.txtRentals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRentals.MaxLength = 6;
            this.txtRentals.Name = "txtRentals";
            this.txtRentals.PlaceholderText = "0.00";
            this.txtRentals.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRentals.Size = new System.Drawing.Size(95, 30);
            this.txtRentals.TabIndex = 44;
            this.txtRentals.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(689, 634);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 28);
            this.lblTotal.TabIndex = 41;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtTotal.Location = new System.Drawing.Point(759, 632);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.MaxLength = 6;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PlaceholderText = "0.00";
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.Size = new System.Drawing.Size(95, 30);
            this.txtTotal.TabIndex = 42;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFinesPaid
            // 
            this.lblFinesPaid.AutoSize = true;
            this.lblFinesPaid.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinesPaid.Location = new System.Drawing.Point(640, 591);
            this.lblFinesPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinesPaid.Name = "lblFinesPaid";
            this.lblFinesPaid.Size = new System.Drawing.Size(111, 28);
            this.lblFinesPaid.TabIndex = 39;
            this.lblFinesPaid.Text = "Fines Paid:";
            // 
            // txtFinesPaid
            // 
            this.txtFinesPaid.Enabled = false;
            this.txtFinesPaid.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFinesPaid.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtFinesPaid.Location = new System.Drawing.Point(760, 589);
            this.txtFinesPaid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFinesPaid.MaxLength = 6;
            this.txtFinesPaid.Name = "txtFinesPaid";
            this.txtFinesPaid.PlaceholderText = "0.00";
            this.txtFinesPaid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFinesPaid.Size = new System.Drawing.Size(95, 30);
            this.txtFinesPaid.TabIndex = 40;
            this.txtFinesPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMemId
            // 
            this.txtMemId.Enabled = false;
            this.txtMemId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId.Location = new System.Drawing.Point(530, 66);
            this.txtMemId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMemId.MaxLength = 8;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.Size = new System.Drawing.Size(144, 30);
            this.txtMemId.TabIndex = 33;
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberId.Location = new System.Drawing.Point(530, 34);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(125, 28);
            this.lblMemberId.TabIndex = 9;
            this.lblMemberId.Text = "MEMBER ID";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(21, 136);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 25);
            this.txtEmail.TabIndex = 22;
            // 
            // lblMemberType
            // 
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberType.Location = new System.Drawing.Point(712, 34);
            this.lblMemberType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Size = new System.Drawing.Size(142, 28);
            this.lblMemberType.TabIndex = 13;
            this.lblMemberType.Text = "MEMBERSHIP";
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
            // grpMemCheck
            // 
            this.grpMemCheck.Controls.Add(this.txtMemberName);
            this.grpMemCheck.Controls.Add(this.lblMemberSearch);
            this.grpMemCheck.Controls.Add(this.btnCheck);
            this.grpMemCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.grpMemCheck.Location = new System.Drawing.Point(79, 43);
            this.grpMemCheck.Name = "grpMemCheck";
            this.grpMemCheck.Size = new System.Drawing.Size(386, 133);
            this.grpMemCheck.TabIndex = 1;
            this.grpMemCheck.TabStop = false;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemberName.Location = new System.Drawing.Point(186, 32);
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
            this.lblMemberSearch.Location = new System.Drawing.Point(14, 34);
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
            this.btnCheck.Location = new System.Drawing.Point(129, 81);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(145, 35);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check Account";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click_1);
            // 
            // grpStatementPeriod
            // 
            this.grpStatementPeriod.Controls.Add(this.optYear);
            this.grpStatementPeriod.Controls.Add(this.lblYear);
            this.grpStatementPeriod.Controls.Add(this.cboYear);
            this.grpStatementPeriod.Controls.Add(this.optStart);
            this.grpStatementPeriod.Controls.Add(this.optCustom);
            this.grpStatementPeriod.Controls.Add(this.btnViewStatement);
            this.grpStatementPeriod.Controls.Add(this.dtpStatementTo);
            this.grpStatementPeriod.Controls.Add(this.dtpStatementFrom);
            this.grpStatementPeriod.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpStatementPeriod.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpStatementPeriod.Location = new System.Drawing.Point(113, 182);
            this.grpStatementPeriod.Name = "grpStatementPeriod";
            this.grpStatementPeriod.Size = new System.Drawing.Size(827, 113);
            this.grpStatementPeriod.TabIndex = 34;
            this.grpStatementPeriod.TabStop = false;
            this.grpStatementPeriod.Text = "Statement Period";
            // 
            // optYear
            // 
            this.optYear.AutoSize = true;
            this.optYear.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optYear.Location = new System.Drawing.Point(216, 22);
            this.optYear.Name = "optYear";
            this.optYear.Size = new System.Drawing.Size(65, 27);
            this.optYear.TabIndex = 56;
            this.optYear.Text = "Year";
            this.optYear.UseVisualStyleBackColor = true;
            this.optYear.CheckedChanged += new System.EventHandler(this.optYear_CheckedChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(20, 52);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(44, 23);
            this.lblYear.TabIndex = 55;
            this.lblYear.Text = "Year";
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(71, 49);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(68, 31);
            this.cboYear.TabIndex = 54;
            this.cboYear.Text = "2020";
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // optStart
            // 
            this.optStart.AutoSize = true;
            this.optStart.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optStart.Location = new System.Drawing.Point(216, 80);
            this.optStart.Name = "optStart";
            this.optStart.Size = new System.Drawing.Size(53, 27);
            this.optStart.TabIndex = 53;
            this.optStart.Text = "All";
            this.optStart.UseVisualStyleBackColor = true;
            this.optStart.CheckedChanged += new System.EventHandler(this.optStart_CheckedChanged);
            // 
            // optCustom
            // 
            this.optCustom.AutoSize = true;
            this.optCustom.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optCustom.Location = new System.Drawing.Point(216, 52);
            this.optCustom.Name = "optCustom";
            this.optCustom.Size = new System.Drawing.Size(92, 27);
            this.optCustom.TabIndex = 52;
            this.optCustom.Text = "Custom";
            this.optCustom.UseVisualStyleBackColor = true;
            this.optCustom.CheckedChanged += new System.EventHandler(this.optQuarter_CheckedChanged);
            // 
            // btnViewStatement
            // 
            this.btnViewStatement.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStatement.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewStatement.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnViewStatement.Location = new System.Drawing.Point(719, 48);
            this.btnViewStatement.Name = "btnViewStatement";
            this.btnViewStatement.Size = new System.Drawing.Size(65, 35);
            this.btnViewStatement.TabIndex = 42;
            this.btnViewStatement.Text = "View";
            this.btnViewStatement.UseVisualStyleBackColor = false;
            this.btnViewStatement.Click += new System.EventHandler(this.btnViewStatement_Click);
            // 
            // dtpStatementTo
            // 
            this.dtpStatementTo.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStatementTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStatementTo.Location = new System.Drawing.Point(526, 53);
            this.dtpStatementTo.Name = "dtpStatementTo";
            this.dtpStatementTo.Size = new System.Drawing.Size(110, 30);
            this.dtpStatementTo.TabIndex = 41;
            // 
            // dtpStatementFrom
            // 
            this.dtpStatementFrom.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStatementFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStatementFrom.Location = new System.Drawing.Point(410, 53);
            this.dtpStatementFrom.Name = "dtpStatementFrom";
            this.dtpStatementFrom.Size = new System.Drawing.Size(110, 30);
            this.dtpStatementFrom.TabIndex = 39;
            this.dtpStatementFrom.Value = new System.DateTime(2021, 10, 29, 0, 0, 0, 0);
            // 
            // grpSearchResults
            // 
            this.grpSearchResults.Controls.Add(this.grdSearchRes);
            this.grpSearchResults.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpSearchResults.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpSearchResults.Location = new System.Drawing.Point(487, 43);
            this.grpSearchResults.Name = "grpSearchResults";
            this.grpSearchResults.Size = new System.Drawing.Size(477, 133);
            this.grpSearchResults.TabIndex = 35;
            this.grpSearchResults.TabStop = false;
            this.grpSearchResults.Text = "Member Result";
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
            this.grdSearchRes.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSearchRes.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdSearchRes.GridColor = System.Drawing.Color.DarkSlateGray;
            this.grdSearchRes.Location = new System.Drawing.Point(15, 32);
            this.grdSearchRes.Name = "grdSearchRes";
            this.grdSearchRes.RowHeadersVisible = false;
            this.grdSearchRes.RowHeadersWidth = 45;
            this.grdSearchRes.RowTemplate.Height = 29;
            this.grdSearchRes.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.grdSearchRes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSearchRes.Size = new System.Drawing.Size(444, 82);
            this.grdSearchRes.TabIndex = 8;
            this.grdSearchRes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSearchRes_CellClick_1);
            // 
            // frmCustomerStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1002, 1055);
            this.Controls.Add(this.grpSearchResults);
            this.Controls.Add(this.grpStatementPeriod);
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
            this.Load += new System.EventHandler(this.frmCustomerStatement_Load);
            this.mnuAdd.ResumeLayout(false);
            this.mnuAdd.PerformLayout();
            this.grpStatementDetails.ResumeLayout(false);
            this.grpStatementDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRented)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReturned)).EndInit();
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
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox grpMemCheck;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblMemberSearch;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.GroupBox grpStatementPeriod;
        private System.Windows.Forms.DateTimePicker dtpStatementTo;
        private System.Windows.Forms.DateTimePicker dtpStatementFrom;
        private System.Windows.Forms.GroupBox grpSearchResults;
        private System.Windows.Forms.DataGridView grdSearchRes;
        private System.Windows.Forms.Button btnViewStatement;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblFinesPaid;
        private System.Windows.Forms.TextBox txtFinesPaid;
        private System.Windows.Forms.Label lblRentals;
        private System.Windows.Forms.TextBox txtRentals;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFinesOwed;
        private System.Windows.Forms.TextBox txtFinesOwed;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMembership;
        private System.Windows.Forms.DataGridView grdRented;
        private System.Windows.Forms.DataGridView grdReturned;
        private System.Windows.Forms.RadioButton optYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.RadioButton optStart;
        private System.Windows.Forms.RadioButton optCustom;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
    }
}