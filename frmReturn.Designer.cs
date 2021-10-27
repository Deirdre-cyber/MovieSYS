
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.lstRented = new System.Windows.Forms.ListBox();
            this.txtFines = new System.Windows.Forms.TextBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.grpSearchMembers = new System.Windows.Forms.GroupBox();
            this.btnSelectMem = new System.Windows.Forms.Button();
            this.cboMemList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
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
            this.mnuAdd.TabIndex = 11;
            this.mnuAdd.Text = "menuStrip1";
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
            this.grpReturnDVD.Controls.Add(this.btnSelect);
            this.grpReturnDVD.Controls.Add(this.btnReturn);
            this.grpReturnDVD.Controls.Add(this.lstRented);
            this.grpReturnDVD.Controls.Add(this.txtFines);
            this.grpReturnDVD.Controls.Add(this.dtpReturnDate);
            this.grpReturnDVD.Controls.Add(this.dtpDueDate);
            this.grpReturnDVD.Controls.Add(this.label8);
            this.grpReturnDVD.Controls.Add(this.label7);
            this.grpReturnDVD.Controls.Add(this.label4);
            this.grpReturnDVD.Controls.Add(this.label2);
            this.grpReturnDVD.Controls.Add(this.txtMemId);
            this.grpReturnDVD.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpReturnDVD.ForeColor = System.Drawing.Color.GhostWhite;
            this.grpReturnDVD.Location = new System.Drawing.Point(73, 217);
            this.grpReturnDVD.Name = "grpReturnDVD";
            this.grpReturnDVD.Size = new System.Drawing.Size(718, 325);
            this.grpReturnDVD.TabIndex = 24;
            this.grpReturnDVD.TabStop = false;
            this.grpReturnDVD.Text = "Return DVD";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnReturn.Location = new System.Drawing.Point(534, 249);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(86, 35);
            this.btnReturn.TabIndex = 39;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // lstRented
            // 
            this.lstRented.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstRented.FormattingEnabled = true;
            this.lstRented.ItemHeight = 23;
            this.lstRented.Location = new System.Drawing.Point(26, 52);
            this.lstRented.Name = "lstRented";
            this.lstRented.Size = new System.Drawing.Size(248, 165);
            this.lstRented.TabIndex = 38;
            // 
            // txtFines
            // 
            this.txtFines.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFines.Location = new System.Drawing.Point(488, 175);
            this.txtFines.MaxLength = 8;
            this.txtFines.Name = "txtFines";
            this.txtFines.PlaceholderText = "0.00";
            this.txtFines.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFines.Size = new System.Drawing.Size(132, 30);
            this.txtFines.TabIndex = 37;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(488, 131);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(132, 30);
            this.dtpReturnDate.TabIndex = 36;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(488, 90);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(132, 30);
            this.dtpDueDate.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(355, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 41);
            this.label8.TabIndex = 34;
            this.label8.Text = "Due back:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(350, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 41);
            this.label7.TabIndex = 33;
            this.label7.Text = "Return on:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(353, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 41);
            this.label4.TabIndex = 32;
            this.label4.Text = "Fines due:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(335, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 41);
            this.label2.TabIndex = 29;
            this.label2.Text = "Member ID:";
            // 
            // txtMemId
            // 
            this.txtMemId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId.Location = new System.Drawing.Point(488, 52);
            this.txtMemId.MaxLength = 8;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.PlaceholderText = "00000001";
            this.txtMemId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemId.Size = new System.Drawing.Size(132, 30);
            this.txtMemId.TabIndex = 28;
            this.txtMemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpSearchMembers
            // 
            this.grpSearchMembers.Controls.Add(this.btnSelectMem);
            this.grpSearchMembers.Controls.Add(this.cboMemList);
            this.grpSearchMembers.Controls.Add(this.label6);
            this.grpSearchMembers.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpSearchMembers.ForeColor = System.Drawing.Color.Azure;
            this.grpSearchMembers.Location = new System.Drawing.Point(73, 41);
            this.grpSearchMembers.Name = "grpSearchMembers";
            this.grpSearchMembers.Size = new System.Drawing.Size(443, 167);
            this.grpSearchMembers.TabIndex = 25;
            this.grpSearchMembers.TabStop = false;
            this.grpSearchMembers.Text = "Search";
            // 
            // btnSelectMem
            // 
            this.btnSelectMem.BackColor = System.Drawing.Color.Azure;
            this.btnSelectMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectMem.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectMem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSelectMem.Location = new System.Drawing.Point(349, 104);
            this.btnSelectMem.Name = "btnSelectMem";
            this.btnSelectMem.Size = new System.Drawing.Size(52, 34);
            this.btnSelectMem.TabIndex = 32;
            this.btnSelectMem.Text = "OK";
            this.btnSelectMem.UseVisualStyleBackColor = false;
            // 
            // cboMemList
            // 
            this.cboMemList.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMemList.FormattingEnabled = true;
            this.cboMemList.Location = new System.Drawing.Point(225, 52);
            this.cboMemList.Name = "cboMemList";
            this.cboMemList.Size = new System.Drawing.Size(176, 31);
            this.cboMemList.TabIndex = 31;
            this.cboMemList.Text = "00000001";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(26, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 41);
            this.label6.TabIndex = 30;
            this.label6.Text = "Search Member:";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSelect.Location = new System.Drawing.Point(26, 249);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(86, 35);
            this.btnSelect.TabIndex = 40;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // frmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(901, 569);
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
        private System.Windows.Forms.ListBox lstRented;
        private System.Windows.Forms.TextBox txtFines;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.GroupBox grpSearchMembers;
        private System.Windows.Forms.Button btnSelectMem;
        private System.Windows.Forms.ComboBox cboMemList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelect;
    }
}