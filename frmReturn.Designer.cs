
namespace MovieSYS
{
    partial class frmReturn
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpReturnDVD = new System.Windows.Forms.GroupBox();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.cboRentedAll = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lstReturnList = new System.Windows.Forms.ListBox();
            this.txtFines = new System.Windows.Forms.TextBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.grpSearchMembers = new System.Windows.Forms.GroupBox();
            this.btnSelectMem = new System.Windows.Forms.Button();
            this.cboMemList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mnuAdd.SuspendLayout();
            this.grpReturnDVD.SuspendLayout();
            this.grpSearchMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAdd
            // 
            this.mnuAdd.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.mnuAdd.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuAdd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mnuAdd.Location = new System.Drawing.Point(0, 0);
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(901, 38);
            this.mnuAdd.TabIndex = 12;
            this.mnuAdd.Text = "menuStrip1";
            this.mnuAdd.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuAdd_ItemClicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Azure;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 34);
            this.exitToolStripMenuItem.Text = "X";
            // 
            // grpReturnDVD
            // 
            this.grpReturnDVD.Controls.Add(this.btnAddAll);
            this.grpReturnDVD.Controls.Add(this.cboRentedAll);
            this.grpReturnDVD.Controls.Add(this.btnSelect);
            this.grpReturnDVD.Controls.Add(this.btnReturn);
            this.grpReturnDVD.Controls.Add(this.lstReturnList);
            this.grpReturnDVD.Controls.Add(this.txtFines);
            this.grpReturnDVD.Controls.Add(this.dtpReturnDate);
            this.grpReturnDVD.Controls.Add(this.label7);
            this.grpReturnDVD.Controls.Add(this.label4);
            this.grpReturnDVD.Controls.Add(this.label2);
            this.grpReturnDVD.Controls.Add(this.txtMemId);
            this.grpReturnDVD.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpReturnDVD.ForeColor = System.Drawing.Color.GhostWhite;
            this.grpReturnDVD.Location = new System.Drawing.Point(31, 217);
            this.grpReturnDVD.Name = "grpReturnDVD";
            this.grpReturnDVD.Size = new System.Drawing.Size(843, 365);
            this.grpReturnDVD.TabIndex = 3;
            this.grpReturnDVD.TabStop = false;
            this.grpReturnDVD.Text = "Return DVD";
            this.grpReturnDVD.Enter += new System.EventHandler(this.grpReturnDVD_Enter);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddAll.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddAll.Location = new System.Drawing.Point(177, 110);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(114, 35);
            this.btnAddAll.TabIndex = 6;
            this.btnAddAll.Text = "Return All";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // cboRentedAll
            // 
            this.cboRentedAll.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboRentedAll.FormattingEnabled = true;
            this.cboRentedAll.Location = new System.Drawing.Point(76, 59);
            this.cboRentedAll.Name = "cboRentedAll";
            this.cboRentedAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboRentedAll.Size = new System.Drawing.Size(215, 31);
            this.cboRentedAll.TabIndex = 4;
            this.cboRentedAll.Text = "Hocus Pocus - 31/10/21";
            this.cboRentedAll.SelectedIndexChanged += new System.EventHandler(this.cboRentedAll_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSelect.Location = new System.Drawing.Point(76, 110);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(73, 35);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Add";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnReturn.Location = new System.Drawing.Point(668, 286);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(86, 35);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lstReturnList
            // 
            this.lstReturnList.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstReturnList.FormattingEnabled = true;
            this.lstReturnList.ItemHeight = 23;
            this.lstReturnList.Location = new System.Drawing.Point(76, 175);
            this.lstReturnList.Name = "lstReturnList";
            this.lstReturnList.Size = new System.Drawing.Size(215, 165);
            this.lstReturnList.TabIndex = 7;
            this.lstReturnList.SelectedIndexChanged += new System.EventHandler(this.lstReturnList_SelectedIndexChanged);
            // 
            // txtFines
            // 
            this.txtFines.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFines.Location = new System.Drawing.Point(622, 175);
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
            this.dtpReturnDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(622, 131);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(132, 30);
            this.dtpReturnDate.TabIndex = 9;
            this.dtpReturnDate.ValueChanged += new System.EventHandler(this.dtpReturnDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(458, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 41);
            this.label7.TabIndex = 0;
            this.label7.Text = "Returned on:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(487, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fines due:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(469, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Member ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMemId
            // 
            this.txtMemId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId.Location = new System.Drawing.Point(622, 52);
            this.txtMemId.MaxLength = 8;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.PlaceholderText = "00000001";
            this.txtMemId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemId.Size = new System.Drawing.Size(132, 30);
            this.txtMemId.TabIndex = 8;
            this.txtMemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMemId.TextChanged += new System.EventHandler(this.txtMemId_TextChanged);
            // 
            // grpSearchMembers
            // 
            this.grpSearchMembers.Controls.Add(this.btnSelectMem);
            this.grpSearchMembers.Controls.Add(this.cboMemList);
            this.grpSearchMembers.Controls.Add(this.label6);
            this.grpSearchMembers.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpSearchMembers.ForeColor = System.Drawing.Color.Azure;
            this.grpSearchMembers.Location = new System.Drawing.Point(223, 41);
            this.grpSearchMembers.Name = "grpSearchMembers";
            this.grpSearchMembers.Size = new System.Drawing.Size(464, 167);
            this.grpSearchMembers.TabIndex = 1;
            this.grpSearchMembers.TabStop = false;
            this.grpSearchMembers.Enter += new System.EventHandler(this.grpSearchMembers_Enter);
            // 
            // btnSelectMem
            // 
            this.btnSelectMem.BackColor = System.Drawing.Color.Azure;
            this.btnSelectMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectMem.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectMem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSelectMem.Location = new System.Drawing.Point(276, 104);
            this.btnSelectMem.Name = "btnSelectMem";
            this.btnSelectMem.Size = new System.Drawing.Size(95, 34);
            this.btnSelectMem.TabIndex = 2;
            this.btnSelectMem.Text = "Search";
            this.btnSelectMem.UseVisualStyleBackColor = false;
            this.btnSelectMem.Click += new System.EventHandler(this.btnSelectMem_Click);
            // 
            // cboMemList
            // 
            this.cboMemList.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMemList.FormattingEnabled = true;
            this.cboMemList.Location = new System.Drawing.Point(241, 52);
            this.cboMemList.Name = "cboMemList";
            this.cboMemList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboMemList.Size = new System.Drawing.Size(130, 31);
            this.cboMemList.TabIndex = 1;
            this.cboMemList.Text = "00000001";
            this.cboMemList.SelectedIndexChanged += new System.EventHandler(this.cboMemList_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(89, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 41);
            this.label6.TabIndex = 0;
            this.label6.Text = "Member ID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // frmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(901, 615);
            this.Controls.Add(this.grpSearchMembers);
            this.Controls.Add(this.grpReturnDVD);
            this.Controls.Add(this.mnuAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReturn";
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
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpReturnDVD;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lstReturnList;
        private System.Windows.Forms.TextBox txtFines;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.GroupBox grpSearchMembers;
        private System.Windows.Forms.Button btnSelectMem;
        private System.Windows.Forms.ComboBox cboMemList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cboRentedAll;
        private System.Windows.Forms.Button btnAddAll;
    }
}