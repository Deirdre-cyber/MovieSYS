
namespace MovieSYS
{
    partial class frmMainMenu
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
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDVD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatalogue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRentals = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRentDVD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturnDVD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPayFine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListOverdue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearlyRev = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerStatement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.mnuMain.SuspendLayout();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuMain.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuDVD,
            this.mnuMembers,
            this.mnuRentals,
            this.mnuAdmin,
            this.mnuLogout});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(8);
            this.mnuMain.Size = new System.Drawing.Size(1000, 41);
            this.mnuMain.TabIndex = 0;
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(29, 25);
            this.mnuExit.Text = "X";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuDVD
            // 
            this.mnuDVD.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuDVD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCatalogue,
            this.mnuRemove});
            this.mnuDVD.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuDVD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuDVD.Name = "mnuDVD";
            this.mnuDVD.Size = new System.Drawing.Size(61, 25);
            this.mnuDVD.Text = "DVDs";
            // 
            // mnuCatalogue
            // 
            this.mnuCatalogue.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuCatalogue.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuCatalogue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuCatalogue.Name = "mnuCatalogue";
            this.mnuCatalogue.Size = new System.Drawing.Size(174, 24);
            this.mnuCatalogue.Text = "Catalogue DVD";
            this.mnuCatalogue.Click += new System.EventHandler(this.mnuCatalogue_Click_1);
            // 
            // mnuRemove
            // 
            this.mnuRemove.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuRemove.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuRemove.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuRemove.Name = "mnuRemove";
            this.mnuRemove.Size = new System.Drawing.Size(174, 24);
            this.mnuRemove.Text = "Remove DVD";
            this.mnuRemove.Click += new System.EventHandler(this.mnuRemove_Click_1);
            // 
            // mnuMembers
            // 
            this.mnuMembers.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuMembers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditMember,
            this.mnuAddMember});
            this.mnuMembers.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuMembers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuMembers.Name = "mnuMembers";
            this.mnuMembers.Size = new System.Drawing.Size(88, 25);
            this.mnuMembers.Text = "Members";
            // 
            // mnuEditMember
            // 
            this.mnuEditMember.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuEditMember.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuEditMember.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuEditMember.Name = "mnuEditMember";
            this.mnuEditMember.Size = new System.Drawing.Size(160, 24);
            this.mnuEditMember.Text = "Edit Member";
            this.mnuEditMember.Click += new System.EventHandler(this.mnuEditMember_Click_1);
            // 
            // mnuAddMember
            // 
            this.mnuAddMember.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuAddMember.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuAddMember.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuAddMember.Name = "mnuAddMember";
            this.mnuAddMember.Size = new System.Drawing.Size(160, 24);
            this.mnuAddMember.Text = "Add Member";
            this.mnuAddMember.Click += new System.EventHandler(this.mnuAddMember_Click);
            // 
            // mnuRentals
            // 
            this.mnuRentals.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuRentals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRentDVD,
            this.mnuReturnDVD,
            this.mnuPayFine,
            this.mnuListOverdue});
            this.mnuRentals.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuRentals.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuRentals.Name = "mnuRentals";
            this.mnuRentals.Size = new System.Drawing.Size(73, 25);
            this.mnuRentals.Text = "Rentals";
            // 
            // mnuRentDVD
            // 
            this.mnuRentDVD.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuRentDVD.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuRentDVD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuRentDVD.Name = "mnuRentDVD";
            this.mnuRentDVD.Size = new System.Drawing.Size(202, 24);
            this.mnuRentDVD.Text = "Rent DVDs";
            this.mnuRentDVD.Click += new System.EventHandler(this.mnuRentDVD_Click);
            // 
            // mnuReturnDVD
            // 
            this.mnuReturnDVD.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuReturnDVD.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuReturnDVD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuReturnDVD.Name = "mnuReturnDVD";
            this.mnuReturnDVD.Size = new System.Drawing.Size(202, 24);
            this.mnuReturnDVD.Text = "Return DVD";
            this.mnuReturnDVD.Click += new System.EventHandler(this.mnuReturnDVD_Click);
            // 
            // mnuPayFine
            // 
            this.mnuPayFine.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuPayFine.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuPayFine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuPayFine.Name = "mnuPayFine";
            this.mnuPayFine.Size = new System.Drawing.Size(202, 24);
            this.mnuPayFine.Text = "Pay Fine";
            this.mnuPayFine.Click += new System.EventHandler(this.mnuPayFine_Click);
            // 
            // mnuListOverdue
            // 
            this.mnuListOverdue.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuListOverdue.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuListOverdue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuListOverdue.Name = "mnuListOverdue";
            this.mnuListOverdue.Size = new System.Drawing.Size(202, 24);
            this.mnuListOverdue.Text = "List Overdue DVDs";
            this.mnuListOverdue.Click += new System.EventHandler(this.mnuListOverdue_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYearlyRev,
            this.mnuCustomerStatement});
            this.mnuAdmin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(68, 25);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuYearlyRev
            // 
            this.mnuYearlyRev.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuYearlyRev.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuYearlyRev.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuYearlyRev.Name = "mnuYearlyRev";
            this.mnuYearlyRev.Size = new System.Drawing.Size(241, 24);
            this.mnuYearlyRev.Text = "Yearly Revenue Analysis";
            this.mnuYearlyRev.Click += new System.EventHandler(this.mnuYearlyRev_Click);
            // 
            // mnuCustomerStatement
            // 
            this.mnuCustomerStatement.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuCustomerStatement.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuCustomerStatement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuCustomerStatement.Name = "mnuCustomerStatement";
            this.mnuCustomerStatement.Size = new System.Drawing.Size(241, 24);
            this.mnuCustomerStatement.Text = "Issue Customer Statement";
            this.mnuCustomerStatement.Click += new System.EventHandler(this.mnuCustomerStatement_Click);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuLogout.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(71, 25);
            this.mnuLogout.Text = "Logout";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.Color.LightSlateGray;
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.lblUsername);
            this.grpLogin.Controls.Add(this.btnConfirm);
            this.grpLogin.Controls.Add(this.txtPass);
            this.grpLogin.Controls.Add(this.txtUser);
            this.grpLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpLogin.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpLogin.Location = new System.Drawing.Point(176, 194);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(628, 342);
            this.grpLogin.TabIndex = 2;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login Details";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPassword.Location = new System.Drawing.Point(186, 156);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(85, 21);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsername.Location = new System.Drawing.Point(180, 114);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 21);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnConfirm.Location = new System.Drawing.Point(275, 244);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 35);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Azure;
            this.txtPass.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.ForeColor = System.Drawing.Color.LightSlateGray;
            this.txtPass.Location = new System.Drawing.Point(297, 158);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderText = "********";
            this.txtPass.Size = new System.Drawing.Size(180, 26);
            this.txtPass.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Azure;
            this.txtUser.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUser.ForeColor = System.Drawing.Color.LightSlateGray;
            this.txtUser.Location = new System.Drawing.Point(297, 116);
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceholderText = "Username";
            this.txtUser.Size = new System.Drawing.Size(180, 26);
            this.txtUser.TabIndex = 1;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie System - Welcome";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMembers;
        private System.Windows.Forms.ToolStripMenuItem mnuRentals;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuRentDVD;
        private System.Windows.Forms.ToolStripMenuItem mnuReturnDVD;
        private System.Windows.Forms.ToolStripMenuItem mnuPayFine;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyRev;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomerStatement;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMember;
        private System.Windows.Forms.ToolStripMenuItem mnuEditMember;
        private System.Windows.Forms.ToolStripMenuItem mnuDVD;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalogue;
        private System.Windows.Forms.ToolStripMenuItem mnuRemove;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuListOverdue;
    }
}