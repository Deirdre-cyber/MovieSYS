
namespace MovieSYS
{
    partial class frmReturnDVD
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
            this.grpDvdDetails = new System.Windows.Forms.GroupBox();
            this.lblFine = new System.Windows.Forms.Label();
            this.txtFines = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReturnAll = new System.Windows.Forms.Button();
            this.grdRentedDvdList = new System.Windows.Forms.DataGridView();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotFineDue = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.txtTotalFines = new System.Windows.Forms.TextBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblMemberSearch = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.grpSearchResults = new System.Windows.Forms.GroupBox();
            this.grdSearchResults = new System.Windows.Forms.DataGridView();
            this.grpMemDetails = new System.Windows.Forms.GroupBox();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.mnuAdd.SuspendLayout();
            this.grpDvdDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRentedDvdList)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpSearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchResults)).BeginInit();
            this.grpMemDetails.SuspendLayout();
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
            this.mnuAdd.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.mnuAdd.Size = new System.Drawing.Size(1000, 33);
            this.mnuAdd.TabIndex = 19;
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
            // mnuBack
            // 
            this.mnuBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(59, 27);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // grpDvdDetails
            // 
            this.grpDvdDetails.Controls.Add(this.lblFine);
            this.grpDvdDetails.Controls.Add(this.txtFines);
            this.grpDvdDetails.Controls.Add(this.btnReturn);
            this.grpDvdDetails.Controls.Add(this.btnReturnAll);
            this.grpDvdDetails.Controls.Add(this.grdRentedDvdList);
            this.grpDvdDetails.Controls.Add(this.lblDueDate);
            this.grpDvdDetails.Controls.Add(this.dtpDueDate);
            this.grpDvdDetails.Controls.Add(this.lblTotFineDue);
            this.grpDvdDetails.Controls.Add(this.lblReturnDate);
            this.grpDvdDetails.Controls.Add(this.txtTotalFines);
            this.grpDvdDetails.Controls.Add(this.dtpReturnDate);
            this.grpDvdDetails.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpDvdDetails.ForeColor = System.Drawing.Color.GhostWhite;
            this.grpDvdDetails.Location = new System.Drawing.Point(65, 351);
            this.grpDvdDetails.Name = "grpDvdDetails";
            this.grpDvdDetails.Size = new System.Drawing.Size(843, 417);
            this.grpDvdDetails.TabIndex = 7;
            this.grpDvdDetails.TabStop = false;
            this.grpDvdDetails.Text = "Return DVD";
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFine.Location = new System.Drawing.Point(583, 146);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(97, 28);
            this.lblFine.TabIndex = 18;
            this.lblFine.Text = "Fine due:";
            // 
            // txtFines
            // 
            this.txtFines.Enabled = false;
            this.txtFines.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFines.Location = new System.Drawing.Point(686, 144);
            this.txtFines.MaxLength = 8;
            this.txtFines.Name = "txtFines";
            this.txtFines.PlaceholderText = "0.00";
            this.txtFines.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFines.Size = new System.Drawing.Size(58, 30);
            this.txtFines.TabIndex = 17;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnReturn.Location = new System.Drawing.Point(686, 251);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(80, 35);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // btnReturnAll
            // 
            this.btnReturnAll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnAll.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturnAll.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnReturnAll.Location = new System.Drawing.Point(549, 251);
            this.btnReturnAll.Name = "btnReturnAll";
            this.btnReturnAll.Size = new System.Drawing.Size(110, 35);
            this.btnReturnAll.TabIndex = 9;
            this.btnReturnAll.Text = "Return All";
            this.btnReturnAll.UseVisualStyleBackColor = false;
            this.btnReturnAll.Click += new System.EventHandler(this.btnReturnAll_Click);
            // 
            // grdRentedDvdList
            // 
            this.grdRentedDvdList.AllowUserToAddRows = false;
            this.grdRentedDvdList.AllowUserToDeleteRows = false;
            this.grdRentedDvdList.AllowUserToResizeColumns = false;
            this.grdRentedDvdList.AllowUserToResizeRows = false;
            this.grdRentedDvdList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdRentedDvdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRentedDvdList.Location = new System.Drawing.Point(42, 59);
            this.grdRentedDvdList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdRentedDvdList.Name = "grdRentedDvdList";
            this.grdRentedDvdList.RowHeadersVisible = false;
            this.grdRentedDvdList.RowHeadersWidth = 51;
            this.grdRentedDvdList.RowTemplate.Height = 25;
            this.grdRentedDvdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRentedDvdList.Size = new System.Drawing.Size(386, 227);
            this.grdRentedDvdList.TabIndex = 7;
            this.grdRentedDvdList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRentedDvdList_CellClick);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDueDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDueDate.Location = new System.Drawing.Point(574, 59);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(106, 28);
            this.lblDueDate.TabIndex = 12;
            this.lblDueDate.Text = "Due Date:";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dtpDueDate.Enabled = false;
            this.dtpDueDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(686, 59);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(130, 30);
            this.dtpDueDate.TabIndex = 10;
            // 
            // lblTotFineDue
            // 
            this.lblTotFineDue.AutoSize = true;
            this.lblTotFineDue.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotFineDue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotFineDue.Location = new System.Drawing.Point(562, 183);
            this.lblTotFineDue.Name = "lblTotFineDue";
            this.lblTotFineDue.Size = new System.Drawing.Size(118, 28);
            this.lblTotFineDue.TabIndex = 16;
            this.lblTotFineDue.Text = "Total Fines:";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblReturnDate.Location = new System.Drawing.Point(547, 105);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(133, 28);
            this.lblReturnDate.TabIndex = 14;
            this.lblReturnDate.Text = "Returned on:";
            // 
            // txtTotalFines
            // 
            this.txtTotalFines.Enabled = false;
            this.txtTotalFines.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalFines.Location = new System.Drawing.Point(686, 183);
            this.txtTotalFines.MaxLength = 8;
            this.txtTotalFines.Name = "txtTotalFines";
            this.txtTotalFines.PlaceholderText = "0.00";
            this.txtTotalFines.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalFines.Size = new System.Drawing.Size(58, 30);
            this.txtTotalFines.TabIndex = 12;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dtpReturnDate.Enabled = false;
            this.dtpReturnDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(686, 105);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(130, 30);
            this.dtpReturnDate.TabIndex = 11;
            this.dtpReturnDate.Value = new System.DateTime(2021, 12, 24, 0, 0, 0, 0);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtMemberName);
            this.grpSearch.Controls.Add(this.lblMemberSearch);
            this.grpSearch.Controls.Add(this.btnCheck);
            this.grpSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.grpSearch.Location = new System.Drawing.Point(65, 65);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(386, 155);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemberName.Location = new System.Drawing.Point(193, 49);
            this.txtMemberName.MaxLength = 8;
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemberName.Size = new System.Drawing.Size(159, 30);
            this.txtMemberName.TabIndex = 1;
            this.txtMemberName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.btnCheck.Location = new System.Drawing.Point(136, 99);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(145, 35);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check Account";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // grpSearchResults
            // 
            this.grpSearchResults.Controls.Add(this.grdSearchResults);
            this.grpSearchResults.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpSearchResults.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpSearchResults.Location = new System.Drawing.Point(527, 65);
            this.grpSearchResults.Name = "grpSearchResults";
            this.grpSearchResults.Size = new System.Drawing.Size(382, 155);
            this.grpSearchResults.TabIndex = 4;
            this.grpSearchResults.TabStop = false;
            this.grpSearchResults.Text = "Member Result";
            // 
            // grdSearchResults
            // 
            this.grdSearchResults.AllowUserToAddRows = false;
            this.grdSearchResults.AllowUserToDeleteRows = false;
            this.grdSearchResults.AllowUserToResizeColumns = false;
            this.grdSearchResults.AllowUserToResizeRows = false;
            this.grdSearchResults.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearchResults.Location = new System.Drawing.Point(8, 35);
            this.grdSearchResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdSearchResults.Name = "grdSearchResults";
            this.grdSearchResults.RowHeadersVisible = false;
            this.grdSearchResults.RowHeadersWidth = 51;
            this.grdSearchResults.RowTemplate.Height = 25;
            this.grdSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSearchResults.Size = new System.Drawing.Size(368, 113);
            this.grdSearchResults.TabIndex = 3;
            this.grdSearchResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSearchResults_CellClick);
            // 
            // grpMemDetails
            // 
            this.grpMemDetails.Controls.Add(this.txtMemId);
            this.grpMemDetails.Controls.Add(this.lblMemberId);
            this.grpMemDetails.Controls.Add(this.lblName);
            this.grpMemDetails.Controls.Add(this.txtFirstName);
            this.grpMemDetails.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpMemDetails.ForeColor = System.Drawing.Color.Azure;
            this.grpMemDetails.Location = new System.Drawing.Point(102, 227);
            this.grpMemDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpMemDetails.Name = "grpMemDetails";
            this.grpMemDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpMemDetails.Size = new System.Drawing.Size(789, 127);
            this.grpMemDetails.TabIndex = 20;
            this.grpMemDetails.TabStop = false;
            this.grpMemDetails.Text = "Member Details";
            // 
            // txtMemId
            // 
            this.txtMemId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId.Location = new System.Drawing.Point(215, 49);
            this.txtMemId.Margin = new System.Windows.Forms.Padding(5);
            this.txtMemId.MaxLength = 6;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.Size = new System.Drawing.Size(75, 30);
            this.txtMemId.TabIndex = 5;
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberId.Location = new System.Drawing.Point(65, 49);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(123, 28);
            this.lblMemberId.TabIndex = 9;
            this.lblMemberId.Text = "Member ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(419, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 28);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(512, 49);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(203, 30);
            this.txtFirstName.TabIndex = 6;
            // 
            // frmReturnDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 801);
            this.Controls.Add(this.grpMemDetails);
            this.Controls.Add(this.grpSearchResults);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpDvdDetails);
            this.Controls.Add(this.mnuAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReturnDVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReturn";
            this.Load += new System.EventHandler(this.frmReturnDVD_Load);
            this.mnuAdd.ResumeLayout(false);
            this.mnuAdd.PerformLayout();
            this.grpDvdDetails.ResumeLayout(false);
            this.grpDvdDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRentedDvdList)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpSearchResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchResults)).EndInit();
            this.grpMemDetails.ResumeLayout(false);
            this.grpMemDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAdd;
        private System.Windows.Forms.GroupBox grpDvdDetails;
        private System.Windows.Forms.TextBox txtTotalFines;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblTotFineDue;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblMemberSearch;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox grpSearchResults;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DataGridView grdSearchResults;
        private System.Windows.Forms.DataGridView grdRentedDvdList;
        private System.Windows.Forms.GroupBox grpMemDetails;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnReturnAll;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.TextBox txtFines;
    }
}