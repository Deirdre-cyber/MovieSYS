
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
            this.grpReturnDVD = new System.Windows.Forms.GroupBox();
            this.lblFineDue = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.cboRentedAll = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lstReturnList = new System.Windows.Forms.ListBox();
            this.txtFines = new System.Windows.Forms.TextBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.grpMemCheck = new System.Windows.Forms.GroupBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblMemberSearch = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.grpSearchResults = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.mnuAdd.SuspendLayout();
            this.grpReturnDVD.SuspendLayout();
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
            this.mnuAdd.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.mnuAdd.Size = new System.Drawing.Size(1000, 33);
            this.mnuAdd.TabIndex = 19;
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
            // grpReturnDVD
            // 
            this.grpReturnDVD.Controls.Add(this.lblDueDate);
            this.grpReturnDVD.Controls.Add(this.dtpDueDate);
            this.grpReturnDVD.Controls.Add(this.lblFineDue);
            this.grpReturnDVD.Controls.Add(this.lblReturnDate);
            this.grpReturnDVD.Controls.Add(this.btnAddAll);
            this.grpReturnDVD.Controls.Add(this.cboRentedAll);
            this.grpReturnDVD.Controls.Add(this.btnSelect);
            this.grpReturnDVD.Controls.Add(this.btnReturn);
            this.grpReturnDVD.Controls.Add(this.lstReturnList);
            this.grpReturnDVD.Controls.Add(this.txtFines);
            this.grpReturnDVD.Controls.Add(this.dtpReturnDate);
            this.grpReturnDVD.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpReturnDVD.ForeColor = System.Drawing.Color.GhostWhite;
            this.grpReturnDVD.Location = new System.Drawing.Point(65, 266);
            this.grpReturnDVD.Name = "grpReturnDVD";
            this.grpReturnDVD.Size = new System.Drawing.Size(843, 354);
            this.grpReturnDVD.TabIndex = 7;
            this.grpReturnDVD.TabStop = false;
            this.grpReturnDVD.Text = "Return DVD";
            this.grpReturnDVD.Enter += new System.EventHandler(this.grpReturnDVD_Enter);
            // 
            // lblFineDue
            // 
            this.lblFineDue.AutoSize = true;
            this.lblFineDue.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFineDue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFineDue.Location = new System.Drawing.Point(523, 152);
            this.lblFineDue.Name = "lblFineDue";
            this.lblFineDue.Size = new System.Drawing.Size(106, 28);
            this.lblFineDue.TabIndex = 16;
            this.lblFineDue.Text = "Fines due:";
            this.lblFineDue.Click += new System.EventHandler(this.lblFineDue_Click);
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblReturnDate.Location = new System.Drawing.Point(496, 105);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(133, 28);
            this.lblReturnDate.TabIndex = 14;
            this.lblReturnDate.Text = "Returned on:";
            this.lblReturnDate.Click += new System.EventHandler(this.lblReturnDate_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAll.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddAll.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddAll.Location = new System.Drawing.Point(177, 109);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(110, 35);
            this.btnAddAll.TabIndex = 10;
            this.btnAddAll.Text = "Return All";
            this.btnAddAll.UseVisualStyleBackColor = false;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // cboRentedAll
            // 
            this.cboRentedAll.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboRentedAll.FormattingEnabled = true;
            this.cboRentedAll.Location = new System.Drawing.Point(75, 59);
            this.cboRentedAll.Name = "cboRentedAll";
            this.cboRentedAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboRentedAll.Size = new System.Drawing.Size(210, 31);
            this.cboRentedAll.TabIndex = 8;
            this.cboRentedAll.Text = "Hocus Pocus - 31/10/21";
            this.cboRentedAll.SelectedIndexChanged += new System.EventHandler(this.cboRentedAll_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSelect.Location = new System.Drawing.Point(75, 109);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 35);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "Add";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnReturn.Location = new System.Drawing.Point(707, 282);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(80, 35);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lstReturnList
            // 
            this.lstReturnList.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstReturnList.FormattingEnabled = true;
            this.lstReturnList.ItemHeight = 23;
            this.lstReturnList.Location = new System.Drawing.Point(75, 175);
            this.lstReturnList.Name = "lstReturnList";
            this.lstReturnList.Size = new System.Drawing.Size(215, 142);
            this.lstReturnList.TabIndex = 11;
            this.lstReturnList.SelectedIndexChanged += new System.EventHandler(this.lstReturnList_SelectedIndexChanged);
            // 
            // txtFines
            // 
            this.txtFines.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFines.Location = new System.Drawing.Point(635, 152);
            this.txtFines.MaxLength = 8;
            this.txtFines.Name = "txtFines";
            this.txtFines.PlaceholderText = "0.00";
            this.txtFines.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFines.Size = new System.Drawing.Size(58, 30);
            this.txtFines.TabIndex = 17;
            this.txtFines.TextChanged += new System.EventHandler(this.txtFines_TextChanged);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dtpReturnDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(635, 105);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(130, 30);
            this.dtpReturnDate.TabIndex = 15;
            this.dtpReturnDate.Value = new System.DateTime(2021, 12, 24, 0, 0, 0, 0);
            this.dtpReturnDate.ValueChanged += new System.EventHandler(this.dtpReturnDate_ValueChanged);
            // 
            // grpMemCheck
            // 
            this.grpMemCheck.Controls.Add(this.txtMemberName);
            this.grpMemCheck.Controls.Add(this.lblMemberSearch);
            this.grpMemCheck.Controls.Add(this.btnCheck);
            this.grpMemCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.grpMemCheck.Location = new System.Drawing.Point(65, 72);
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
            this.grpSearchResults.Controls.Add(this.button1);
            this.grpSearchResults.Controls.Add(this.lstResults);
            this.grpSearchResults.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpSearchResults.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpSearchResults.Location = new System.Drawing.Point(526, 72);
            this.grpSearchResults.Name = "grpSearchResults";
            this.grpSearchResults.Size = new System.Drawing.Size(382, 155);
            this.grpSearchResults.TabIndex = 4;
            this.grpSearchResults.TabStop = false;
            this.grpSearchResults.Text = "Member Result";
            this.grpSearchResults.Enter += new System.EventHandler(this.grpSearchResults_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(271, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstResults
            // 
            this.lstResults.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 23;
            this.lstResults.Location = new System.Drawing.Point(21, 37);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(211, 96);
            this.lstResults.TabIndex = 5;
            this.lstResults.SelectedIndexChanged += new System.EventHandler(this.lstResults_SelectedIndexChanged);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDueDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDueDate.Location = new System.Drawing.Point(523, 59);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(106, 28);
            this.lblDueDate.TabIndex = 12;
            this.lblDueDate.Text = "Due Date:";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dtpDueDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(635, 59);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(130, 30);
            this.dtpDueDate.TabIndex = 13;
            // 
            // frmReturnDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.grpSearchResults);
            this.Controls.Add(this.grpMemCheck);
            this.Controls.Add(this.grpReturnDVD);
            this.Controls.Add(this.mnuAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReturnDVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReturn";
            this.mnuAdd.ResumeLayout(false);
            this.mnuAdd.PerformLayout();
            this.grpReturnDVD.ResumeLayout(false);
            this.grpReturnDVD.PerformLayout();
            this.grpMemCheck.ResumeLayout(false);
            this.grpMemCheck.PerformLayout();
            this.grpSearchResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAdd;
        private System.Windows.Forms.GroupBox grpReturnDVD;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lstReturnList;
        private System.Windows.Forms.TextBox txtFines;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cboRentedAll;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblFineDue;
        private System.Windows.Forms.GroupBox grpMemCheck;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblMemberSearch;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox grpSearchResults;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
    }
}