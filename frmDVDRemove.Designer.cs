
namespace MovieSYS
{
    partial class frmDVDRemove
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
            this.grpRemove = new System.Windows.Forms.GroupBox();
            this.txtDVDTitle = new System.Windows.Forms.TextBox();
            this.lblEnterTitle = new System.Windows.Forms.Label();
            this.lblChooseDVD = new System.Windows.Forms.Label();
            this.btnConfirmDel = new System.Windows.Forms.Button();
            this.lstDVDs = new System.Windows.Forms.ListBox();
            this.mnuRemove = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpRemove.SuspendLayout();
            this.mnuRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRemove
            // 
            this.grpRemove.BackColor = System.Drawing.Color.LightSlateGray;
            this.grpRemove.Controls.Add(this.btnSearch);
            this.grpRemove.Controls.Add(this.txtDVDTitle);
            this.grpRemove.Controls.Add(this.lblEnterTitle);
            this.grpRemove.Controls.Add(this.lblChooseDVD);
            this.grpRemove.Controls.Add(this.btnConfirmDel);
            this.grpRemove.Controls.Add(this.lstDVDs);
            this.grpRemove.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpRemove.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpRemove.Location = new System.Drawing.Point(133, 100);
            this.grpRemove.Name = "grpRemove";
            this.grpRemove.Size = new System.Drawing.Size(625, 267);
            this.grpRemove.TabIndex = 2;
            this.grpRemove.TabStop = false;
            this.grpRemove.Text = "Remove DVD";
            this.grpRemove.Enter += new System.EventHandler(this.grpRemove_Enter);
            // 
            // txtDVDTitle
            // 
            this.txtDVDTitle.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDVDTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtDVDTitle.Location = new System.Drawing.Point(139, 57);
            this.txtDVDTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDVDTitle.Name = "txtDVDTitle";
            this.txtDVDTitle.PlaceholderText = "Paw Patrol The Movie";
            this.txtDVDTitle.Size = new System.Drawing.Size(158, 26);
            this.txtDVDTitle.TabIndex = 1;
            this.txtDVDTitle.TextChanged += new System.EventHandler(this.txtDVDTitle_TextChanged);
            // 
            // lblEnterTitle
            // 
            this.lblEnterTitle.AutoSize = true;
            this.lblEnterTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnterTitle.Location = new System.Drawing.Point(23, 58);
            this.lblEnterTitle.Name = "lblEnterTitle";
            this.lblEnterTitle.Size = new System.Drawing.Size(103, 21);
            this.lblEnterTitle.TabIndex = 0;
            this.lblEnterTitle.Text = "Search Title:";
            this.lblEnterTitle.Click += new System.EventHandler(this.lblEnterTitle_Click);
            // 
            // lblChooseDVD
            // 
            this.lblChooseDVD.AutoSize = true;
            this.lblChooseDVD.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChooseDVD.Location = new System.Drawing.Point(17, 109);
            this.lblChooseDVD.Name = "lblChooseDVD";
            this.lblChooseDVD.Size = new System.Drawing.Size(109, 21);
            this.lblChooseDVD.TabIndex = 0;
            this.lblChooseDVD.Text = "Choose DVD:";
            this.lblChooseDVD.Click += new System.EventHandler(this.lblChooseDVD_Click);
            // 
            // btnConfirmDel
            // 
            this.btnConfirmDel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmDel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmDel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnConfirmDel.Location = new System.Drawing.Point(494, 217);
            this.btnConfirmDel.Name = "btnConfirmDel";
            this.btnConfirmDel.Size = new System.Drawing.Size(88, 31);
            this.btnConfirmDel.TabIndex = 4;
            this.btnConfirmDel.Text = "Remove";
            this.btnConfirmDel.UseVisualStyleBackColor = false;
            this.btnConfirmDel.Click += new System.EventHandler(this.btnConfirmDel_Click);
            // 
            // lstDVDs
            // 
            this.lstDVDs.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstDVDs.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstDVDs.FormattingEnabled = true;
            this.lstDVDs.ItemHeight = 25;
            this.lstDVDs.Location = new System.Drawing.Point(139, 109);
            this.lstDVDs.Name = "lstDVDs";
            this.lstDVDs.Size = new System.Drawing.Size(158, 104);
            this.lstDVDs.TabIndex = 3;
            this.lstDVDs.SelectedIndexChanged += new System.EventHandler(this.lstDVDs_SelectedIndexChanged);
            // 
            // mnuRemove
            // 
            this.mnuRemove.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuRemove.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuRemove.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuRemove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuRemove.Location = new System.Drawing.Point(0, 0);
            this.mnuRemove.Name = "mnuRemove";
            this.mnuRemove.Size = new System.Drawing.Size(875, 27);
            this.mnuRemove.TabIndex = 4;
            this.mnuRemove.Text = "Exit";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.BackColor = System.Drawing.Color.Transparent;
            this.mnuExit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(30, 23);
            this.mnuExit.Text = "X";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.Location = new System.Drawing.Point(329, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmDVDRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(875, 540);
            this.Controls.Add(this.grpRemove);
            this.Controls.Add(this.mnuRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnuRemove;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDVDRemove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove a DVD";
            this.grpRemove.ResumeLayout(false);
            this.grpRemove.PerformLayout();
            this.mnuRemove.ResumeLayout(false);
            this.mnuRemove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpRemove;
        private System.Windows.Forms.ListBox lstDVDs;
        private System.Windows.Forms.Button btnConfirmDel;
        private System.Windows.Forms.MenuStrip mnuRemove;
        private System.Windows.Forms.Label lblChooseDVD;
        private System.Windows.Forms.TextBox txtDVDTitle;
        private System.Windows.Forms.Label lblEnterTitle;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnSearch;
    }
}