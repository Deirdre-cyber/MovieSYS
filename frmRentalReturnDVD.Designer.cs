
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
            this.grpSearchMembers = new System.Windows.Forms.GroupBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.btnSelectMem = new System.Windows.Forms.Button();
            this.mnuAdd.SuspendLayout();
            this.grpReturnDVD.SuspendLayout();
            this.grpSearchMembers.SuspendLayout();
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
            this.mnuAdd.TabIndex = 12;
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
            this.grpReturnDVD.Location = new System.Drawing.Point(65, 233);
            this.grpReturnDVD.Name = "grpReturnDVD";
            this.grpReturnDVD.Size = new System.Drawing.Size(843, 354);
            this.grpReturnDVD.TabIndex = 3;
            this.grpReturnDVD.TabStop = false;
            this.grpReturnDVD.Text = "Return DVD";
            this.grpReturnDVD.Enter += new System.EventHandler(this.grpReturnDVD_Enter);
            // 
            // lblFineDue
            // 
            this.lblFineDue.AutoSize = true;
            this.lblFineDue.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFineDue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFineDue.Location = new System.Drawing.Point(515, 103);
            this.lblFineDue.Name = "lblFineDue";
            this.lblFineDue.Size = new System.Drawing.Size(106, 28);
            this.lblFineDue.TabIndex = 13;
            this.lblFineDue.Text = "Fines due:";
            this.lblFineDue.Click += new System.EventHandler(this.lblFineDue_Click);
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblReturnDate.Location = new System.Drawing.Point(488, 59);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(133, 28);
            this.lblReturnDate.TabIndex = 12;
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
            this.btnAddAll.TabIndex = 6;
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
            this.cboRentedAll.TabIndex = 4;
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
            this.btnSelect.TabIndex = 5;
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
            this.btnReturn.TabIndex = 11;
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
            this.lstReturnList.TabIndex = 7;
            this.lstReturnList.SelectedIndexChanged += new System.EventHandler(this.lstReturnList_SelectedIndexChanged);
            // 
            // txtFines
            // 
            this.txtFines.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFines.Location = new System.Drawing.Point(627, 103);
            this.txtFines.MaxLength = 8;
            this.txtFines.Name = "txtFines";
            this.txtFines.PlaceholderText = "0.00";
            this.txtFines.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFines.Size = new System.Drawing.Size(58, 30);
            this.txtFines.TabIndex = 10;
            this.txtFines.TextChanged += new System.EventHandler(this.txtFines_TextChanged);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dtpReturnDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(627, 59);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(130, 30);
            this.dtpReturnDate.TabIndex = 9;
            this.dtpReturnDate.ValueChanged += new System.EventHandler(this.dtpReturnDate_ValueChanged);
            // 
            // grpSearchMembers
            // 
            this.grpSearchMembers.Controls.Add(this.lblMemberId);
            this.grpSearchMembers.Controls.Add(this.txtMemberId);
            this.grpSearchMembers.Controls.Add(this.btnSelectMem);
            this.grpSearchMembers.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpSearchMembers.ForeColor = System.Drawing.Color.Azure;
            this.grpSearchMembers.Location = new System.Drawing.Point(311, 72);
            this.grpSearchMembers.Name = "grpSearchMembers";
            this.grpSearchMembers.Size = new System.Drawing.Size(350, 155);
            this.grpSearchMembers.TabIndex = 1;
            this.grpSearchMembers.TabStop = false;
            this.grpSearchMembers.Enter += new System.EventHandler(this.grpSearchMembers_Enter);
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberId.ForeColor = System.Drawing.Color.Azure;
            this.lblMemberId.Location = new System.Drawing.Point(60, 55);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(123, 28);
            this.lblMemberId.TabIndex = 3;
            this.lblMemberId.Text = "Member ID:";
            this.lblMemberId.Click += new System.EventHandler(this.lblMemberId_Click);
            // 
            // txtMemberId
            // 
            this.txtMemberId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemberId.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtMemberId.Location = new System.Drawing.Point(191, 55);
            this.txtMemberId.MaxLength = 8;
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.PlaceholderText = "00000001";
            this.txtMemberId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemberId.Size = new System.Drawing.Size(114, 30);
            this.txtMemberId.TabIndex = 1;
            this.txtMemberId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMemberId.TextChanged += new System.EventHandler(this.txtMemberId_TextChanged);
            // 
            // btnSelectMem
            // 
            this.btnSelectMem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelectMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectMem.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectMem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSelectMem.Location = new System.Drawing.Point(108, 104);
            this.btnSelectMem.Name = "btnSelectMem";
            this.btnSelectMem.Size = new System.Drawing.Size(145, 35);
            this.btnSelectMem.TabIndex = 2;
            this.btnSelectMem.Text = "Check Account";
            this.btnSelectMem.UseVisualStyleBackColor = false;
            this.btnSelectMem.Click += new System.EventHandler(this.btnSelectMem_Click);
            // 
            // frmReturnDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.grpSearchMembers);
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
            this.grpSearchMembers.ResumeLayout(false);
            this.grpSearchMembers.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpSearchMembers;
        private System.Windows.Forms.Button btnSelectMem;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cboRentedAll;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblFineDue;
    }
}