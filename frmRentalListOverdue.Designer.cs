
namespace MovieSYS
{
    partial class frmListOverdue
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
            this.grpListOverDue = new System.Windows.Forms.GroupBox();
            this.lblReminderDate = new System.Windows.Forms.Label();
            this.grdOverdueDVDs = new System.Windows.Forms.DataGridView();
            this.grpOverdueDetails = new System.Windows.Forms.GroupBox();
            this.lblDVDTitle = new System.Windows.Forms.Label();
            this.txtDVDTitle = new System.Windows.Forms.TextBox();
            this.txtFineAmount = new System.Windows.Forms.TextBox();
            this.lblFineDue = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.lblDueBack = new System.Windows.Forms.Label();
            this.dtpDueBack = new System.Windows.Forms.DateTimePicker();
            this.lblRentedon = new System.Windows.Forms.Label();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.btnSendReminder = new System.Windows.Forms.Button();
            this.mnuCloseLogin = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpListOverDue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOverdueDVDs)).BeginInit();
            this.grpOverdueDetails.SuspendLayout();
            this.mnuCloseLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpListOverDue
            // 
            this.grpListOverDue.BackColor = System.Drawing.Color.LightSlateGray;
            this.grpListOverDue.Controls.Add(this.lblReminderDate);
            this.grpListOverDue.Controls.Add(this.grdOverdueDVDs);
            this.grpListOverDue.Controls.Add(this.grpOverdueDetails);
            this.grpListOverDue.Controls.Add(this.btnSendReminder);
            this.grpListOverDue.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpListOverDue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpListOverDue.Location = new System.Drawing.Point(91, 53);
            this.grpListOverDue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpListOverDue.Name = "grpListOverDue";
            this.grpListOverDue.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpListOverDue.Size = new System.Drawing.Size(783, 651);
            this.grpListOverDue.TabIndex = 1;
            this.grpListOverDue.TabStop = false;
            this.grpListOverDue.Text = "Overdue DVD Titles";
            // 
            // lblReminderDate
            // 
            this.lblReminderDate.AutoSize = true;
            this.lblReminderDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReminderDate.Location = new System.Drawing.Point(90, 587);
            this.lblReminderDate.Name = "lblReminderDate";
            this.lblReminderDate.Size = new System.Drawing.Size(0, 28);
            this.lblReminderDate.TabIndex = 18;
            // 
            // grdOverdueDVDs
            // 
            this.grdOverdueDVDs.AllowDrop = true;
            this.grdOverdueDVDs.AllowUserToAddRows = false;
            this.grdOverdueDVDs.AllowUserToDeleteRows = false;
            this.grdOverdueDVDs.AllowUserToResizeColumns = false;
            this.grdOverdueDVDs.AllowUserToResizeRows = false;
            this.grdOverdueDVDs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdOverdueDVDs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdOverdueDVDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOverdueDVDs.GridColor = System.Drawing.SystemColors.Control;
            this.grdOverdueDVDs.Location = new System.Drawing.Point(42, 64);
            this.grdOverdueDVDs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdOverdueDVDs.Name = "grdOverdueDVDs";
            this.grdOverdueDVDs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdOverdueDVDs.RowTemplate.Height = 25;
            this.grdOverdueDVDs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdOverdueDVDs.Size = new System.Drawing.Size(678, 201);
            this.grdOverdueDVDs.TabIndex = 5;
            this.grdOverdueDVDs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOverdueDVDs_CellClick);
            // 
            // grpOverdueDetails
            // 
            this.grpOverdueDetails.Controls.Add(this.lblDVDTitle);
            this.grpOverdueDetails.Controls.Add(this.txtDVDTitle);
            this.grpOverdueDetails.Controls.Add(this.txtFineAmount);
            this.grpOverdueDetails.Controls.Add(this.lblFineDue);
            this.grpOverdueDetails.Controls.Add(this.lblMember);
            this.grpOverdueDetails.Controls.Add(this.txtMemId);
            this.grpOverdueDetails.Controls.Add(this.lblDueBack);
            this.grpOverdueDetails.Controls.Add(this.dtpDueBack);
            this.grpOverdueDetails.Controls.Add(this.lblRentedon);
            this.grpOverdueDetails.Controls.Add(this.dtpRentDate);
            this.grpOverdueDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpOverdueDetails.Location = new System.Drawing.Point(42, 284);
            this.grpOverdueDetails.Name = "grpOverdueDetails";
            this.grpOverdueDetails.Size = new System.Drawing.Size(677, 247);
            this.grpOverdueDetails.TabIndex = 4;
            this.grpOverdueDetails.TabStop = false;
            this.grpOverdueDetails.Text = "Details";
            // 
            // lblDVDTitle
            // 
            this.lblDVDTitle.AutoSize = true;
            this.lblDVDTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDVDTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDVDTitle.Location = new System.Drawing.Point(87, 67);
            this.lblDVDTitle.Name = "lblDVDTitle";
            this.lblDVDTitle.Size = new System.Drawing.Size(109, 28);
            this.lblDVDTitle.TabIndex = 7;
            this.lblDVDTitle.Text = "DVD Title:";
            // 
            // txtDVDTitle
            // 
            this.txtDVDTitle.Enabled = false;
            this.txtDVDTitle.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDVDTitle.Location = new System.Drawing.Point(202, 68);
            this.txtDVDTitle.MaxLength = 8;
            this.txtDVDTitle.Name = "txtDVDTitle";
            this.txtDVDTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDVDTitle.Size = new System.Drawing.Size(281, 30);
            this.txtDVDTitle.TabIndex = 8;
            // 
            // txtFineAmount
            // 
            this.txtFineAmount.Enabled = false;
            this.txtFineAmount.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFineAmount.Location = new System.Drawing.Point(533, 148);
            this.txtFineAmount.MaxLength = 6;
            this.txtFineAmount.Name = "txtFineAmount";
            this.txtFineAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFineAmount.Size = new System.Drawing.Size(70, 30);
            this.txtFineAmount.TabIndex = 16;
            this.txtFineAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFineDue
            // 
            this.lblFineDue.AutoSize = true;
            this.lblFineDue.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFineDue.Location = new System.Drawing.Point(430, 147);
            this.lblFineDue.Name = "lblFineDue";
            this.lblFineDue.Size = new System.Drawing.Size(100, 28);
            this.lblFineDue.TabIndex = 15;
            this.lblFineDue.Text = "Fine Due:";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMember.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMember.Location = new System.Drawing.Point(73, 29);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(123, 28);
            this.lblMember.TabIndex = 5;
            this.lblMember.Text = "Member ID:";
            // 
            // txtMemId
            // 
            this.txtMemId.Enabled = false;
            this.txtMemId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId.Location = new System.Drawing.Point(202, 32);
            this.txtMemId.MaxLength = 8;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemId.Size = new System.Drawing.Size(62, 30);
            this.txtMemId.TabIndex = 6;
            this.txtMemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDueBack
            // 
            this.lblDueBack.AutoSize = true;
            this.lblDueBack.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDueBack.Location = new System.Drawing.Point(90, 180);
            this.lblDueBack.Name = "lblDueBack";
            this.lblDueBack.Size = new System.Drawing.Size(106, 28);
            this.lblDueBack.TabIndex = 11;
            this.lblDueBack.Text = "Due back:";
            // 
            // dtpDueBack
            // 
            this.dtpDueBack.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dtpDueBack.Enabled = false;
            this.dtpDueBack.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDueBack.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueBack.Location = new System.Drawing.Point(202, 183);
            this.dtpDueBack.Name = "dtpDueBack";
            this.dtpDueBack.Size = new System.Drawing.Size(140, 30);
            this.dtpDueBack.TabIndex = 12;
            this.dtpDueBack.Value = new System.DateTime(2021, 11, 18, 0, 0, 0, 0);
            // 
            // lblRentedon
            // 
            this.lblRentedon.AutoSize = true;
            this.lblRentedon.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRentedon.Location = new System.Drawing.Point(83, 139);
            this.lblRentedon.Name = "lblRentedon";
            this.lblRentedon.Size = new System.Drawing.Size(113, 28);
            this.lblRentedon.TabIndex = 9;
            this.lblRentedon.Text = "Rented on:";
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dtpRentDate.Enabled = false;
            this.dtpRentDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentDate.Location = new System.Drawing.Point(202, 141);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(140, 30);
            this.dtpRentDate.TabIndex = 10;
            // 
            // btnSendReminder
            // 
            this.btnSendReminder.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSendReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendReminder.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSendReminder.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSendReminder.Location = new System.Drawing.Point(575, 583);
            this.btnSendReminder.Margin = new System.Windows.Forms.Padding(0);
            this.btnSendReminder.Name = "btnSendReminder";
            this.btnSendReminder.Size = new System.Drawing.Size(171, 40);
            this.btnSendReminder.TabIndex = 17;
            this.btnSendReminder.Text = "Send Reminders";
            this.btnSendReminder.UseVisualStyleBackColor = false;
            this.btnSendReminder.Click += new System.EventHandler(this.btnSendReminder_Click);
            // 
            // mnuCloseLogin
            // 
            this.mnuCloseLogin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuCloseLogin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCloseLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuCloseLogin.Location = new System.Drawing.Point(0, 0);
            this.mnuCloseLogin.Name = "mnuCloseLogin";
            this.mnuCloseLogin.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.mnuCloseLogin.Size = new System.Drawing.Size(1000, 33);
            this.mnuCloseLogin.TabIndex = 18;
            this.mnuCloseLogin.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.BackColor = System.Drawing.Color.Transparent;
            this.mnuExit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(35, 27);
            this.mnuExit.Text = "X";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmListOverdue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.mnuCloseLogin);
            this.Controls.Add(this.grpListOverDue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListOverdue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overdue DVD List";
            this.TransparencyKey = System.Drawing.Color.LightCyan;
            this.Load += new System.EventHandler(this.frmListOverdue_Load);
            this.grpListOverDue.ResumeLayout(false);
            this.grpListOverDue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOverdueDVDs)).EndInit();
            this.grpOverdueDetails.ResumeLayout(false);
            this.grpOverdueDetails.PerformLayout();
            this.mnuCloseLogin.ResumeLayout(false);
            this.mnuCloseLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpListOverDue;
        private System.Windows.Forms.MenuStrip mnuCloseLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpOverdueDetails;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.Label lblDueBack;
        private System.Windows.Forms.DateTimePicker dtpDueBack;
        private System.Windows.Forms.Label lblRentedon;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.TextBox txtFineAmount;
        private System.Windows.Forms.Label lblFineDue;
        private System.Windows.Forms.Button btnSendReminder;
        private System.Windows.Forms.Label lblDVDTitle;
        private System.Windows.Forms.TextBox txtDVDTitle;
        private System.Windows.Forms.DataGridView grdOverdueDVDs;
        private System.Windows.Forms.Label lblReminderDate;
    }
}