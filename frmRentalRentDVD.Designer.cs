
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
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMemberDetails = new System.Windows.Forms.GroupBox();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.grpRentDetails = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grdDvdResults = new System.Windows.Forms.DataGridView();
            this.lblReturn = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.txtDVDSearch = new System.Windows.Forms.TextBox();
            this.lblSearchDVD = new System.Windows.Forms.Label();
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.lblRentId = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpMemCheck = new System.Windows.Forms.GroupBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblMemberSearch = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.grdMemberResults = new System.Windows.Forms.DataGridView();
            this.grpMemberResults = new System.Windows.Forms.GroupBox();
            this.grpReceipt = new System.Windows.Forms.GroupBox();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.mnuAdd.SuspendLayout();
            this.grpMemberDetails.SuspendLayout();
            this.grpRentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDvdResults)).BeginInit();
            this.grpMemCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMemberResults)).BeginInit();
            this.grpMemberResults.SuspendLayout();
            this.grpReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAdd
            // 
            this.mnuAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuAdd.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuAdd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.mnuAdd.Location = new System.Drawing.Point(0, 0);
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.mnuAdd.Size = new System.Drawing.Size(1000, 42);
            this.mnuAdd.TabIndex = 33;
            this.mnuAdd.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(35, 34);
            this.mnuExit.Text = "X";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(62, 34);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // grpMemberDetails
            // 
            this.grpMemberDetails.Controls.Add(this.txtMemId);
            this.grpMemberDetails.Controls.Add(this.lblMemberId);
            this.grpMemberDetails.Controls.Add(this.lblName);
            this.grpMemberDetails.Controls.Add(this.txtFirstName);
            this.grpMemberDetails.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpMemberDetails.ForeColor = System.Drawing.Color.Azure;
            this.grpMemberDetails.Location = new System.Drawing.Point(173, 212);
            this.grpMemberDetails.Name = "grpMemberDetails";
            this.grpMemberDetails.Size = new System.Drawing.Size(690, 95);
            this.grpMemberDetails.TabIndex = 8;
            this.grpMemberDetails.TabStop = false;
            this.grpMemberDetails.Text = "Member Details";
            // 
            // txtMemId
            // 
            this.txtMemId.Enabled = false;
            this.txtMemId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId.Location = new System.Drawing.Point(188, 37);
            this.txtMemId.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemId.MaxLength = 6;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.Size = new System.Drawing.Size(66, 30);
            this.txtMemId.TabIndex = 10;
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberId.Location = new System.Drawing.Point(57, 37);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(123, 28);
            this.lblMemberId.TabIndex = 9;
            this.lblMemberId.Text = "Member ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(367, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 28);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(448, 37);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "Mary Bloggs";
            this.txtFirstName.Size = new System.Drawing.Size(178, 30);
            this.txtFirstName.TabIndex = 12;
            // 
            // grpRentDetails
            // 
            this.grpRentDetails.Controls.Add(this.btnSearch);
            this.grpRentDetails.Controls.Add(this.lstCart);
            this.grpRentDetails.Controls.Add(this.btnCancel);
            this.grpRentDetails.Controls.Add(this.grdDvdResults);
            this.grpRentDetails.Controls.Add(this.lblReturn);
            this.grpRentDetails.Controls.Add(this.dtpReturnDate);
            this.grpRentDetails.Controls.Add(this.txtDVDSearch);
            this.grpRentDetails.Controls.Add(this.lblSearchDVD);
            this.grpRentDetails.Controls.Add(this.txtRentID);
            this.grpRentDetails.Controls.Add(this.lblRentId);
            this.grpRentDetails.Controls.Add(this.lblCart);
            this.grpRentDetails.Controls.Add(this.btnRemove);
            this.grpRentDetails.Controls.Add(this.lblTotal);
            this.grpRentDetails.Controls.Add(this.btnClearAll);
            this.grpRentDetails.Controls.Add(this.btnCheckOut);
            this.grpRentDetails.Controls.Add(this.txtPrice);
            this.grpRentDetails.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpRentDetails.ForeColor = System.Drawing.Color.GhostWhite;
            this.grpRentDetails.Location = new System.Drawing.Point(12, 313);
            this.grpRentDetails.Name = "grpRentDetails";
            this.grpRentDetails.Size = new System.Drawing.Size(976, 395);
            this.grpRentDetails.TabIndex = 17;
            this.grpRentDetails.TabStop = false;
            this.grpRentDetails.Text = "Order Details";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.Location = new System.Drawing.Point(374, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 35);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstCart
            // 
            this.lstCart.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 17;
            this.lstCart.Location = new System.Drawing.Point(498, 75);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(353, 106);
            this.lstCart.TabIndex = 36;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancel.Location = new System.Drawing.Point(860, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // grdDvdResults
            // 
            this.grdDvdResults.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdDvdResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDvdResults.Location = new System.Drawing.Point(27, 137);
            this.grdDvdResults.Name = "grdDvdResults";
            this.grdDvdResults.RowHeadersVisible = false;
            this.grdDvdResults.RowHeadersWidth = 51;
            this.grdDvdResults.RowTemplate.Height = 25;
            this.grdDvdResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDvdResults.Size = new System.Drawing.Size(440, 185);
            this.grdDvdResults.TabIndex = 33;
            this.grdDvdResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDvdSearch_CellClick);
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReturn.Location = new System.Drawing.Point(620, 284);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(106, 28);
            this.lblReturn.TabIndex = 29;
            this.lblReturn.Text = "Due back:";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Enabled = false;
            this.dtpReturnDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(732, 284);
            this.dtpReturnDate.MinDate = new System.DateTime(2022, 2, 8, 0, 0, 0, 0);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(119, 30);
            this.dtpReturnDate.TabIndex = 30;
            // 
            // txtDVDSearch
            // 
            this.txtDVDSearch.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDVDSearch.Location = new System.Drawing.Point(113, 91);
            this.txtDVDSearch.MaxLength = 30;
            this.txtDVDSearch.Name = "txtDVDSearch";
            this.txtDVDSearch.Size = new System.Drawing.Size(255, 30);
            this.txtDVDSearch.TabIndex = 21;
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
            // 
            // txtRentID
            // 
            this.txtRentID.Enabled = false;
            this.txtRentID.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRentID.Location = new System.Drawing.Point(113, 47);
            this.txtRentID.MaxLength = 6;
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRentID.Size = new System.Drawing.Size(62, 30);
            this.txtRentID.TabIndex = 19;
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
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCart.Location = new System.Drawing.Point(510, 36);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(57, 28);
            this.lblCart.TabIndex = 24;
            this.lblCart.Text = "Cart:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRemove.Location = new System.Drawing.Point(870, 88);
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
            this.lblTotal.Location = new System.Drawing.Point(714, 240);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 28);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "Total:";
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearAll.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnClearAll.Location = new System.Drawing.Point(870, 139);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(90, 35);
            this.btnClearAll.TabIndex = 32;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOut.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCheckOut.Location = new System.Drawing.Point(751, 347);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(100, 35);
            this.btnCheckOut.TabIndex = 31;
            this.btnCheckOut.Text = "Checkout";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(784, 240);
            this.txtPrice.MaxLength = 8;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "0.00";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(67, 30);
            this.txtPrice.TabIndex = 28;
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
            // grdMemberResults
            // 
            this.grdMemberResults.AllowUserToAddRows = false;
            this.grdMemberResults.AllowUserToDeleteRows = false;
            this.grdMemberResults.AllowUserToResizeColumns = false;
            this.grdMemberResults.AllowUserToResizeRows = false;
            this.grdMemberResults.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdMemberResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMemberResults.Location = new System.Drawing.Point(12, 32);
            this.grdMemberResults.Name = "grdMemberResults";
            this.grdMemberResults.RowHeadersVisible = false;
            this.grdMemberResults.RowHeadersWidth = 51;
            this.grdMemberResults.RowTemplate.Height = 25;
            this.grdMemberResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMemberResults.Size = new System.Drawing.Size(421, 111);
            this.grdMemberResults.TabIndex = 0;
            this.grdMemberResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSearchResults_CellClick);
            // 
            // grpMemberResults
            // 
            this.grpMemberResults.Controls.Add(this.grdMemberResults);
            this.grpMemberResults.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpMemberResults.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpMemberResults.Location = new System.Drawing.Point(549, 51);
            this.grpMemberResults.Name = "grpMemberResults";
            this.grpMemberResults.Size = new System.Drawing.Size(439, 155);
            this.grpMemberResults.TabIndex = 5;
            this.grpMemberResults.TabStop = false;
            this.grpMemberResults.Text = "Member Result";
            // 
            // grpReceipt
            // 
            this.grpReceipt.Controls.Add(this.lblReceipt);
            this.grpReceipt.Controls.Add(this.btnEmail);
            this.grpReceipt.Controls.Add(this.btnPrint);
            this.grpReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpReceipt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpReceipt.Location = new System.Drawing.Point(319, 720);
            this.grpReceipt.Name = "grpReceipt";
            this.grpReceipt.Size = new System.Drawing.Size(367, 122);
            this.grpReceipt.TabIndex = 34;
            this.grpReceipt.TabStop = false;
            this.grpReceipt.Text = "Receipt";
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.Location = new System.Drawing.Point(55, 31);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(248, 41);
            this.lblReceipt.TabIndex = 29;
            this.lblReceipt.Text = "Print or email Receipt?";
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEmail.Location = new System.Drawing.Point(191, 76);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(92, 35);
            this.btnEmail.TabIndex = 28;
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
            this.btnPrint.Location = new System.Drawing.Point(77, 76);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 35);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmRentalRentDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 854);
            this.Controls.Add(this.grpReceipt);
            this.Controls.Add(this.grpMemberResults);
            this.Controls.Add(this.grpMemCheck);
            this.Controls.Add(this.grpRentDetails);
            this.Controls.Add(this.grpMemberDetails);
            this.Controls.Add(this.mnuAdd);
            this.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmRentalRentDVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRent_Load);
            this.mnuAdd.ResumeLayout(false);
            this.mnuAdd.PerformLayout();
            this.grpMemberDetails.ResumeLayout(false);
            this.grpMemberDetails.PerformLayout();
            this.grpRentDetails.ResumeLayout(false);
            this.grpRentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDvdResults)).EndInit();
            this.grpMemCheck.ResumeLayout(false);
            this.grpMemCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMemberResults)).EndInit();
            this.grpMemberResults.ResumeLayout(false);
            this.grpReceipt.ResumeLayout(false);
            this.grpReceipt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpMemberDetails;
        private System.Windows.Forms.GroupBox grpRentDetails;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnRemove;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grpMemCheck;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblMemberSearch;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtRentID;
        private System.Windows.Forms.Label lblRentId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblSearchDVD;
        private System.Windows.Forms.TextBox txtDVDSearch;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DataGridView grdDvdResults;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grdMemberResults;
        private System.Windows.Forms.GroupBox grpMemberResults;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpReceipt;
        private System.Windows.Forms.Label lblReceipt;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnPrint;
    }
}