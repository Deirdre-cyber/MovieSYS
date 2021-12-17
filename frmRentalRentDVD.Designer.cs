
namespace MovieSYS
{
    partial class frmRentalRentDVD
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
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblFines = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFines = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnAddtoCart1 = new System.Windows.Forms.Button();
            this.grpRentDetails = new System.Windows.Forms.GroupBox();
            this.lblReturn = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.txtDVDSearch = new System.Windows.Forms.TextBox();
            this.lblSearchDVD = new System.Windows.Forms.Label();
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.lstSearchRes = new System.Windows.Forms.ListBox();
            this.lblRentId = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpMemCheck = new System.Windows.Forms.GroupBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblMemberSearch = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.grpSearchResults = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblOverDue = new System.Windows.Forms.Label();
            this.txtOverdue = new System.Windows.Forms.TextBox();
            this.mnuAdd.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpRentDetails.SuspendLayout();
            this.grpMemCheck.SuspendLayout();
            this.grpSearchResults.SuspendLayout();
            this.SuspendLayout();
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
            this.mnuAdd.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.mnuAdd.Size = new System.Drawing.Size(1000, 35);
            this.mnuAdd.TabIndex = 33;
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
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtOverdue);
            this.grpSearch.Controls.Add(this.lblOverDue);
            this.grpSearch.Controls.Add(this.txtMemId);
            this.grpSearch.Controls.Add(this.lblMemberId);
            this.grpSearch.Controls.Add(this.lblFines);
            this.grpSearch.Controls.Add(this.lblName);
            this.grpSearch.Controls.Add(this.txtFines);
            this.grpSearch.Controls.Add(this.txtFirstName);
            this.grpSearch.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpSearch.ForeColor = System.Drawing.Color.Azure;
            this.grpSearch.Location = new System.Drawing.Point(173, 212);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(690, 139);
            this.grpSearch.TabIndex = 8;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Member Details";
            this.grpSearch.Enter += new System.EventHandler(this.grpSearchRes_Enter);
            // 
            // txtMemId
            // 
            this.txtMemId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId.Location = new System.Drawing.Point(192, 53);
            this.txtMemId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemId.MaxLength = 8;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.PlaceholderText = "000001";
            this.txtMemId.Size = new System.Drawing.Size(178, 30);
            this.txtMemId.TabIndex = 10;
            this.txtMemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMemId.TextChanged += new System.EventHandler(this.txtMemId_TextChanged);
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberId.Location = new System.Drawing.Point(61, 55);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(123, 28);
            this.lblMemberId.TabIndex = 9;
            this.lblMemberId.Text = "Member ID:";
            this.lblMemberId.Click += new System.EventHandler(this.lblMemberId_Click);
            // 
            // lblFines
            // 
            this.lblFines.AutoSize = true;
            this.lblFines.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFines.Location = new System.Drawing.Point(425, 53);
            this.lblFines.Name = "lblFines";
            this.lblFines.Size = new System.Drawing.Size(125, 28);
            this.lblFines.TabIndex = 13;
            this.lblFines.Text = "Fines Owed:";
            this.lblFines.Click += new System.EventHandler(this.lblFines_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(111, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 28);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtFines
            // 
            this.txtFines.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFines.Location = new System.Drawing.Point(556, 53);
            this.txtFines.MaxLength = 8;
            this.txtFines.Name = "txtFines";
            this.txtFines.PlaceholderText = "0.00";
            this.txtFines.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFines.Size = new System.Drawing.Size(67, 30);
            this.txtFines.TabIndex = 14;
            this.txtFines.TextChanged += new System.EventHandler(this.txtFines_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(192, 90);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "Mary Bloggs";
            this.txtFirstName.Size = new System.Drawing.Size(178, 30);
            this.txtFirstName.TabIndex = 12;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // btnAddtoCart1
            // 
            this.btnAddtoCart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddtoCart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtoCart1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddtoCart1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddtoCart1.Location = new System.Drawing.Point(113, 259);
            this.btnAddtoCart1.Name = "btnAddtoCart1";
            this.btnAddtoCart1.Size = new System.Drawing.Size(130, 35);
            this.btnAddtoCart1.TabIndex = 23;
            this.btnAddtoCart1.Text = "Add to Cart";
            this.btnAddtoCart1.UseVisualStyleBackColor = false;
            this.btnAddtoCart1.Click += new System.EventHandler(this.btnAddtoCart1_Click);
            // 
            // grpRentDetails
            // 
            this.grpRentDetails.Controls.Add(this.lblReturn);
            this.grpRentDetails.Controls.Add(this.dtpReturnDate);
            this.grpRentDetails.Controls.Add(this.txtDVDSearch);
            this.grpRentDetails.Controls.Add(this.lblSearchDVD);
            this.grpRentDetails.Controls.Add(this.btnAddtoCart1);
            this.grpRentDetails.Controls.Add(this.txtRentID);
            this.grpRentDetails.Controls.Add(this.lstSearchRes);
            this.grpRentDetails.Controls.Add(this.lblRentId);
            this.grpRentDetails.Controls.Add(this.lblCart);
            this.grpRentDetails.Controls.Add(this.btnRemove);
            this.grpRentDetails.Controls.Add(this.lblTotal);
            this.grpRentDetails.Controls.Add(this.btnCancel);
            this.grpRentDetails.Controls.Add(this.btnBuy);
            this.grpRentDetails.Controls.Add(this.lstCart);
            this.grpRentDetails.Controls.Add(this.txtPrice);
            this.grpRentDetails.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpRentDetails.ForeColor = System.Drawing.Color.GhostWhite;
            this.grpRentDetails.Location = new System.Drawing.Point(78, 357);
            this.grpRentDetails.Name = "grpRentDetails";
            this.grpRentDetails.Size = new System.Drawing.Size(838, 351);
            this.grpRentDetails.TabIndex = 17;
            this.grpRentDetails.TabStop = false;
            this.grpRentDetails.Text = "Order Details";
            this.grpRentDetails.Enter += new System.EventHandler(this.grpRentDetails_Enter);
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturn.Location = new System.Drawing.Point(480, 229);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(106, 28);
            this.lblReturn.TabIndex = 29;
            this.lblReturn.Text = "Due back:";
            this.lblReturn.Click += new System.EventHandler(this.lblReturn_Click);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(592, 229);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(119, 30);
            this.dtpReturnDate.TabIndex = 30;
            this.dtpReturnDate.ValueChanged += new System.EventHandler(this.dtpReturnDate_ValueChanged);
            // 
            // txtDVDSearch
            // 
            this.txtDVDSearch.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDVDSearch.Location = new System.Drawing.Point(113, 91);
            this.txtDVDSearch.MaxLength = 30;
            this.txtDVDSearch.Name = "txtDVDSearch";
            this.txtDVDSearch.PlaceholderText = "Frankenstein";
            this.txtDVDSearch.Size = new System.Drawing.Size(240, 30);
            this.txtDVDSearch.TabIndex = 21;
            this.txtDVDSearch.TextChanged += new System.EventHandler(this.txtDVDSearch_TextChanged);
            // 
            // lblSearchDVD
            // 
            this.lblSearchDVD.AutoSize = true;
            this.lblSearchDVD.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchDVD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSearchDVD.Location = new System.Drawing.Point(27, 89);
            this.lblSearchDVD.Name = "lblSearchDVD";
            this.lblSearchDVD.Size = new System.Drawing.Size(80, 28);
            this.lblSearchDVD.TabIndex = 20;
            this.lblSearchDVD.Text = "Search:";
            this.lblSearchDVD.Click += new System.EventHandler(this.lblSearchDVD_Click);
            // 
            // txtRentID
            // 
            this.txtRentID.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRentID.Location = new System.Drawing.Point(113, 47);
            this.txtRentID.MaxLength = 8;
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.PlaceholderText = "0000001";
            this.txtRentID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRentID.Size = new System.Drawing.Size(80, 30);
            this.txtRentID.TabIndex = 19;
            this.txtRentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRentID.TextChanged += new System.EventHandler(this.txtRentID_TextChanged);
            // 
            // lstSearchRes
            // 
            this.lstSearchRes.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstSearchRes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lstSearchRes.FormattingEnabled = true;
            this.lstSearchRes.ItemHeight = 23;
            this.lstSearchRes.Location = new System.Drawing.Point(113, 142);
            this.lstSearchRes.Name = "lstSearchRes";
            this.lstSearchRes.Size = new System.Drawing.Size(240, 96);
            this.lstSearchRes.TabIndex = 22;
            this.lstSearchRes.SelectedIndexChanged += new System.EventHandler(this.lstSearchRes_SelectedIndexChanged);
            // 
            // lblRentId
            // 
            this.lblRentId.AutoSize = true;
            this.lblRentId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRentId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRentId.Location = new System.Drawing.Point(20, 49);
            this.lblRentId.Name = "lblRentId";
            this.lblRentId.Size = new System.Drawing.Size(87, 28);
            this.lblRentId.TabIndex = 18;
            this.lblRentId.Text = "Rent ID:";
            this.lblRentId.Click += new System.EventHandler(this.lblRentId_Click);
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCart.Location = new System.Drawing.Point(408, 49);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(57, 28);
            this.lblCart.TabIndex = 24;
            this.lblCart.Text = "Cart:";
            this.lblCart.Click += new System.EventHandler(this.lblCar);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRemove.Location = new System.Drawing.Point(725, 47);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 35);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(574, 182);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 28);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancel.Location = new System.Drawing.Point(725, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuy.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuy.Location = new System.Drawing.Point(611, 287);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(100, 35);
            this.btnBuy.TabIndex = 31;
            this.btnBuy.Text = "Checkout";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lstCart
            // 
            this.lstCart.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstCart.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 23;
            this.lstCart.Location = new System.Drawing.Point(471, 47);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(240, 119);
            this.lstCart.TabIndex = 25;
            this.lstCart.SelectedIndexChanged += new System.EventHandler(this.lstCart_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(644, 182);
            this.txtPrice.MaxLength = 8;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "10.00";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(67, 30);
            this.txtPrice.TabIndex = 28;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // grpMemCheck
            // 
            this.grpMemCheck.Controls.Add(this.txtMemberName);
            this.grpMemCheck.Controls.Add(this.lblMemberSearch);
            this.grpMemCheck.Controls.Add(this.btnCheck);
            this.grpMemCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.grpMemCheck.Location = new System.Drawing.Point(93, 51);
            this.grpMemCheck.Name = "grpMemCheck";
            this.grpMemCheck.Size = new System.Drawing.Size(386, 155);
            this.grpMemCheck.TabIndex = 1;
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
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click_1);
            // 
            // grpSearchResults
            // 
            this.grpSearchResults.Controls.Add(this.btnSelect);
            this.grpSearchResults.Controls.Add(this.lstResults);
            this.grpSearchResults.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpSearchResults.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpSearchResults.Location = new System.Drawing.Point(549, 51);
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
            this.btnSelect.Location = new System.Drawing.Point(297, 63);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 35);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Select";
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
            this.lstResults.Size = new System.Drawing.Size(239, 96);
            this.lstResults.TabIndex = 6;
            this.lstResults.SelectedIndexChanged += new System.EventHandler(this.lstResults_SelectedIndexChanged);
            // 
            // lblOverDue
            // 
            this.lblOverDue.AutoSize = true;
            this.lblOverDue.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOverDue.Location = new System.Drawing.Point(453, 90);
            this.lblOverDue.Name = "lblOverDue";
            this.lblOverDue.Size = new System.Drawing.Size(97, 28);
            this.lblOverDue.TabIndex = 15;
            this.lblOverDue.Text = "Overdue:";
            // 
            // txtOverdue
            // 
            this.txtOverdue.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOverdue.Location = new System.Drawing.Point(556, 92);
            this.txtOverdue.MaxLength = 8;
            this.txtOverdue.Name = "txtOverdue";
            this.txtOverdue.PlaceholderText = "0";
            this.txtOverdue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOverdue.Size = new System.Drawing.Size(67, 30);
            this.txtOverdue.TabIndex = 16;
            // 
            // frmRentalRentDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.grpSearchResults);
            this.Controls.Add(this.grpMemCheck);
            this.Controls.Add(this.grpRentDetails);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.mnuAdd);
            this.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmRentalRentDVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRent_Load);
            this.mnuAdd.ResumeLayout(false);
            this.mnuAdd.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpRentDetails.ResumeLayout(false);
            this.grpRentDetails.PerformLayout();
            this.grpMemCheck.ResumeLayout(false);
            this.grpMemCheck.PerformLayout();
            this.grpSearchResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.GroupBox grpRentDetails;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAddtoCart1;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grpMemCheck;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblMemberSearch;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ListBox lstSearchRes;
        private System.Windows.Forms.TextBox txtRentID;
        private System.Windows.Forms.Label lblRentId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFines;
        private System.Windows.Forms.TextBox txtFines;
        private System.Windows.Forms.GroupBox grpSearchResults;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblSearchDVD;
        private System.Windows.Forms.TextBox txtDVDSearch;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.TextBox txtOverdue;
        private System.Windows.Forms.Label lblOverDue;
    }
}