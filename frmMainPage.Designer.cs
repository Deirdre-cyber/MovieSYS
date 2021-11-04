
namespace MovieSYS
{
    partial class frmMainPage
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuDVD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatalogue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListOverdue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRentals = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRentDVD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturnDVD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPayFine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearlyRev = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerStatement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.mnuMain.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDVD,
            this.mnuExit,
            this.mnuMembers,
            this.mnuRentals,
            this.mnuAdmin});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(8);
            this.mnuMain.Size = new System.Drawing.Size(831, 49);
            this.mnuMain.TabIndex = 0;
            // 
            // mnuDVD
            // 
            this.mnuDVD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCatalogue,
            this.mnuRemove,
            this.mnuListOverdue});
            this.mnuDVD.ForeColor = System.Drawing.Color.Azure;
            this.mnuDVD.Name = "mnuDVD";
            this.mnuDVD.Size = new System.Drawing.Size(67, 33);
            this.mnuDVD.Text = "DVDs";
            this.mnuDVD.Click += new System.EventHandler(this.dVDsToolStripMenuItem_Click);
            // 
            // mnuCatalogue
            // 
            this.mnuCatalogue.Name = "mnuCatalogue";
            this.mnuCatalogue.Size = new System.Drawing.Size(203, 34);
            this.mnuCatalogue.Text = "Catalogue DVD";
            this.mnuCatalogue.Click += new System.EventHandler(this.mnuCatalogue_Click);
            // 
            // mnuRemove
            // 
            this.mnuRemove.Name = "mnuRemove";
            this.mnuRemove.Size = new System.Drawing.Size(203, 34);
            this.mnuRemove.Text = "Remove DVD";
            this.mnuRemove.Click += new System.EventHandler(this.mnuRemove_Click);
            // 
            // mnuListOverdue
            // 
            this.mnuListOverdue.Name = "mnuListOverdue";
            this.mnuListOverdue.Size = new System.Drawing.Size(203, 34);
            this.mnuListOverdue.Text = "List Overdue";
            this.mnuListOverdue.Click += new System.EventHandler(this.mnuListOverdue_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuExit.ForeColor = System.Drawing.Color.Azure;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(32, 33);
            this.mnuExit.Text = "X";
            this.mnuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuMembers
            // 
            this.mnuMembers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddMember,
            this.mnuEditMember});
            this.mnuMembers.ForeColor = System.Drawing.Color.Azure;
            this.mnuMembers.Name = "mnuMembers";
            this.mnuMembers.Size = new System.Drawing.Size(96, 33);
            this.mnuMembers.Text = "Members";
            this.mnuMembers.Click += new System.EventHandler(this.mnuMembers_Click);
            // 
            // mnuAddMember
            // 
            this.mnuAddMember.Name = "mnuAddMember";
            this.mnuAddMember.Size = new System.Drawing.Size(185, 34);
            this.mnuAddMember.Text = "Add Member";
            this.mnuAddMember.Click += new System.EventHandler(this.addMemberToolStripMenuItem_Click);
            // 
            // mnuEditMember
            // 
            this.mnuEditMember.Name = "mnuEditMember";
            this.mnuEditMember.Size = new System.Drawing.Size(185, 34);
            this.mnuEditMember.Text = "Edit Member";
            this.mnuEditMember.Click += new System.EventHandler(this.mnuEditMember_Click);
            // 
            // mnuRentals
            // 
            this.mnuRentals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRentDVD,
            this.mnuReturnDVD,
            this.mnuPayFine});
            this.mnuRentals.ForeColor = System.Drawing.Color.Azure;
            this.mnuRentals.Name = "mnuRentals";
            this.mnuRentals.Size = new System.Drawing.Size(81, 33);
            this.mnuRentals.Text = "Rentals";
            this.mnuRentals.Click += new System.EventHandler(this.mnuRentals_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYearlyRev,
            this.mnuCustomerStatement});
            this.mnuAdmin.ForeColor = System.Drawing.Color.Azure;
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(76, 33);
            this.mnuAdmin.Text = "Admin";
            this.mnuAdmin.Click += new System.EventHandler(this.mnuAdmin_Click);
            // 
            // mnuRentDVD
            // 
            this.mnuRentDVD.Name = "mnuRentDVD";
            this.mnuRentDVD.Size = new System.Drawing.Size(180, 34);
            this.mnuRentDVD.Text = "Rent DVDs";
            this.mnuRentDVD.Click += new System.EventHandler(this.mnuRentDVD_Click);
            // 
            // mnuReturnDVD
            // 
            this.mnuReturnDVD.Name = "mnuReturnDVD";
            this.mnuReturnDVD.Size = new System.Drawing.Size(180, 34);
            this.mnuReturnDVD.Text = "Return DVD";
            this.mnuReturnDVD.Click += new System.EventHandler(this.mnuReturnDVD_Click);
            // 
            // mnuPayFine
            // 
            this.mnuPayFine.Name = "mnuPayFine";
            this.mnuPayFine.Size = new System.Drawing.Size(180, 34);
            this.mnuPayFine.Text = "Pay Fine";
            this.mnuPayFine.Click += new System.EventHandler(this.mnuPayFine_Click);
            // 
            // mnuYearlyRev
            // 
            this.mnuYearlyRev.Name = "mnuYearlyRev";
            this.mnuYearlyRev.Size = new System.Drawing.Size(284, 34);
            this.mnuYearlyRev.Text = "Yearly Revenue Analysis";
            this.mnuYearlyRev.Click += new System.EventHandler(this.mnuYearlyRev_Click);
            // 
            // mnuCustomerStatement
            // 
            this.mnuCustomerStatement.Name = "mnuCustomerStatement";
            this.mnuCustomerStatement.Size = new System.Drawing.Size(284, 34);
            this.mnuCustomerStatement.Text = "Issue Customer Statement";
            this.mnuCustomerStatement.Click += new System.EventHandler(this.mnuCustomerStatement_Click);
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(831, 538);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMainPage";
            this.Text = "Movie System - Welcome";
            this.Load += new System.EventHandler(this.frmMainPage_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuMembers;
        private System.Windows.Forms.ToolStripMenuItem mnuRentals;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuDVD;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalogue;
        private System.Windows.Forms.ToolStripMenuItem mnuRemove;
        private System.Windows.Forms.ToolStripMenuItem mnuListOverdue;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMember;
        private System.Windows.Forms.ToolStripMenuItem mnuEditMember;
        private System.Windows.Forms.ToolStripMenuItem mnuRentDVD;
        private System.Windows.Forms.ToolStripMenuItem mnuReturnDVD;
        private System.Windows.Forms.ToolStripMenuItem mnuPayFine;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyRev;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerStatement;
    }
}