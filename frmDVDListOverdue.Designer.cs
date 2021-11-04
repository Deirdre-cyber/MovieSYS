﻿
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
            this.grpOverdueDetails = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtFineAmount = new System.Windows.Forms.TextBox();
            this.lblFineDue = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.txtMemId2 = new System.Windows.Forms.TextBox();
            this.lblDueBack = new System.Windows.Forms.Label();
            this.dtpDueBack = new System.Windows.Forms.DateTimePicker();
            this.lblRentedon = new System.Windows.Forms.Label();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cboOverdue = new System.Windows.Forms.ComboBox();
            this.mnuCloseLogin = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpListOverDue.SuspendLayout();
            this.grpOverdueDetails.SuspendLayout();
            this.mnuCloseLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpListOverDue
            // 
            this.grpListOverDue.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.grpListOverDue.Controls.Add(this.grpOverdueDetails);
            this.grpListOverDue.Controls.Add(this.btnSelect);
            this.grpListOverDue.Controls.Add(this.cboOverdue);
            this.grpListOverDue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpListOverDue.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpListOverDue.ForeColor = System.Drawing.Color.Azure;
            this.grpListOverDue.Location = new System.Drawing.Point(0, 37);
            this.grpListOverDue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpListOverDue.Name = "grpListOverDue";
            this.grpListOverDue.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpListOverDue.Size = new System.Drawing.Size(782, 516);
            this.grpListOverDue.TabIndex = 0;
            this.grpListOverDue.TabStop = false;
            this.grpListOverDue.Text = "Overdue DVD Titles";
            this.grpListOverDue.Enter += new System.EventHandler(this.grpListOverDue_Enter);
            // 
            // grpOverdueDetails
            // 
            this.grpOverdueDetails.Controls.Add(this.btnClose);
            this.grpOverdueDetails.Controls.Add(this.txtFineAmount);
            this.grpOverdueDetails.Controls.Add(this.lblFineDue);
            this.grpOverdueDetails.Controls.Add(this.lblMember);
            this.grpOverdueDetails.Controls.Add(this.txtMemId2);
            this.grpOverdueDetails.Controls.Add(this.lblDueBack);
            this.grpOverdueDetails.Controls.Add(this.dtpDueBack);
            this.grpOverdueDetails.Controls.Add(this.lblRentedon);
            this.grpOverdueDetails.Controls.Add(this.dtpRentDate);
            this.grpOverdueDetails.ForeColor = System.Drawing.Color.White;
            this.grpOverdueDetails.Location = new System.Drawing.Point(42, 155);
            this.grpOverdueDetails.Name = "grpOverdueDetails";
            this.grpOverdueDetails.Size = new System.Drawing.Size(676, 306);
            this.grpOverdueDetails.TabIndex = 0;
            this.grpOverdueDetails.TabStop = false;
            this.grpOverdueDetails.Text = "Details";
            this.grpOverdueDetails.Enter += new System.EventHandler(this.grpOverdueDetails_Enter);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Azure;
            this.btnClose.Location = new System.Drawing.Point(566, 237);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtFineAmount
            // 
            this.txtFineAmount.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFineAmount.Location = new System.Drawing.Point(483, 90);
            this.txtFineAmount.MaxLength = 6;
            this.txtFineAmount.Name = "txtFineAmount";
            this.txtFineAmount.PlaceholderText = "2.50";
            this.txtFineAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFineAmount.Size = new System.Drawing.Size(77, 30);
            this.txtFineAmount.TabIndex = 6;
            this.txtFineAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFineAmount.TextChanged += new System.EventHandler(this.txtFineAmount_TextChanged);
            // 
            // lblFineDue
            // 
            this.lblFineDue.AutoSize = true;
            this.lblFineDue.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFineDue.Location = new System.Drawing.Point(365, 87);
            this.lblFineDue.Name = "lblFineDue";
            this.lblFineDue.Size = new System.Drawing.Size(112, 41);
            this.lblFineDue.TabIndex = 0;
            this.lblFineDue.Text = "Fine Due:";
            this.lblFineDue.Click += new System.EventHandler(this.lblFineDue_Click);
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMember.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMember.Location = new System.Drawing.Point(50, 87);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(138, 41);
            this.lblMember.TabIndex = 0;
            this.lblMember.Text = "Member ID:";
            this.lblMember.Click += new System.EventHandler(this.lblMember_Click);
            // 
            // txtMemId2
            // 
            this.txtMemId2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId2.Location = new System.Drawing.Point(202, 90);
            this.txtMemId2.MaxLength = 8;
            this.txtMemId2.Name = "txtMemId2";
            this.txtMemId2.PlaceholderText = "00000001";
            this.txtMemId2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemId2.Size = new System.Drawing.Size(132, 30);
            this.txtMemId2.TabIndex = 3;
            this.txtMemId2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMemId2.TextChanged += new System.EventHandler(this.txtMemId2_TextChanged);
            // 
            // lblDueBack
            // 
            this.lblDueBack.AutoSize = true;
            this.lblDueBack.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDueBack.Location = new System.Drawing.Point(69, 169);
            this.lblDueBack.Name = "lblDueBack";
            this.lblDueBack.Size = new System.Drawing.Size(118, 41);
            this.lblDueBack.TabIndex = 0;
            this.lblDueBack.Text = "Due back:";
            this.lblDueBack.Click += new System.EventHandler(this.lblDueBack_Click);
            // 
            // dtpDueBack
            // 
            this.dtpDueBack.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDueBack.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueBack.Location = new System.Drawing.Point(202, 169);
            this.dtpDueBack.Name = "dtpDueBack";
            this.dtpDueBack.Size = new System.Drawing.Size(132, 30);
            this.dtpDueBack.TabIndex = 5;
            this.dtpDueBack.Value = new System.DateTime(2021, 11, 18, 0, 0, 0, 0);
            this.dtpDueBack.ValueChanged += new System.EventHandler(this.dtpDueBack_ValueChanged);
            // 
            // lblRentedon
            // 
            this.lblRentedon.AutoSize = true;
            this.lblRentedon.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRentedon.Location = new System.Drawing.Point(59, 128);
            this.lblRentedon.Name = "lblRentedon";
            this.lblRentedon.Size = new System.Drawing.Size(128, 41);
            this.lblRentedon.TabIndex = 0;
            this.lblRentedon.Text = "Rented on:";
            this.lblRentedon.Click += new System.EventHandler(this.lblRentedon_Click);
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentDate.Location = new System.Drawing.Point(202, 128);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(132, 30);
            this.dtpRentDate.TabIndex = 4;
            this.dtpRentDate.ValueChanged += new System.EventHandler(this.dtpRentDate_ValueChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.ForeColor = System.Drawing.Color.Azure;
            this.btnSelect.Location = new System.Drawing.Point(348, 83);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(64, 31);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "View";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cboOverdue
            // 
            this.cboOverdue.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboOverdue.FormattingEnabled = true;
            this.cboOverdue.Location = new System.Drawing.Point(42, 83);
            this.cboOverdue.Name = "cboOverdue";
            this.cboOverdue.Size = new System.Drawing.Size(282, 31);
            this.cboOverdue.TabIndex = 1;
            this.cboOverdue.Text = "The Nightmare Before Christmas";
            this.cboOverdue.SelectedIndexChanged += new System.EventHandler(this.cboOverdue_SelectedIndexChanged);
            // 
            // mnuCloseLogin
            // 
            this.mnuCloseLogin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.mnuCloseLogin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCloseLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuCloseLogin.Location = new System.Drawing.Point(0, 0);
            this.mnuCloseLogin.Name = "mnuCloseLogin";
            this.mnuCloseLogin.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.mnuCloseLogin.Size = new System.Drawing.Size(782, 40);
            this.mnuCloseLogin.TabIndex = 8;
            this.mnuCloseLogin.Text = "menuStrip1";
            this.mnuCloseLogin.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuCloseLogin_ItemClicked);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.mnuExit.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuExit.ForeColor = System.Drawing.Color.Azure;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 34);
            this.mnuExit.Text = "X";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmListOverdue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.mnuCloseLogin);
            this.Controls.Add(this.grpListOverDue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListOverdue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overdue DVD List";
            this.TransparencyKey = System.Drawing.Color.LightCyan;
            this.Load += new System.EventHandler(this.frmListOverdue_Load);
            this.grpListOverDue.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cboOverdue;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.TextBox txtMemId2;
        private System.Windows.Forms.Label lblDueBack;
        private System.Windows.Forms.DateTimePicker dtpDueBack;
        private System.Windows.Forms.Label lblRentedon;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.TextBox txtFineAmount;
        private System.Windows.Forms.Label lblFineDue;
        private System.Windows.Forms.Button btnClose;
    }
}