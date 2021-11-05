
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
            this.lblRefine = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnConfirmDel = new System.Windows.Forms.Button();
            this.lstDVDs = new System.Windows.Forms.ListBox();
            this.mnuRemove = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRemove.SuspendLayout();
            this.mnuRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRemove
            // 
            this.grpRemove.BackColor = System.Drawing.Color.LightSlateGray;
            this.grpRemove.Controls.Add(this.txtDVDTitle);
            this.grpRemove.Controls.Add(this.lblEnterTitle);
            this.grpRemove.Controls.Add(this.lblChooseDVD);
            this.grpRemove.Controls.Add(this.lblRefine);
            this.grpRemove.Controls.Add(this.cboCategory);
            this.grpRemove.Controls.Add(this.btnConfirmDel);
            this.grpRemove.Controls.Add(this.lstDVDs);
            this.grpRemove.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpRemove.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpRemove.Location = new System.Drawing.Point(152, 134);
            this.grpRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRemove.Name = "grpRemove";
            this.grpRemove.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRemove.Size = new System.Drawing.Size(714, 356);
            this.grpRemove.TabIndex = 2;
            this.grpRemove.TabStop = false;
            this.grpRemove.Text = "Remove DVD";
            this.grpRemove.Enter += new System.EventHandler(this.grpRemove_Enter);
            // 
            // txtDVDTitle
            // 
            this.txtDVDTitle.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDVDTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtDVDTitle.Location = new System.Drawing.Point(485, 76);
            this.txtDVDTitle.Name = "txtDVDTitle";
            this.txtDVDTitle.PlaceholderText = "Paw Patrol The Movie";
            this.txtDVDTitle.Size = new System.Drawing.Size(180, 30);
            this.txtDVDTitle.TabIndex = 7;
            this.txtDVDTitle.TextChanged += new System.EventHandler(this.txtDVDTitle_TextChanged);
            // 
            // lblEnterTitle
            // 
            this.lblEnterTitle.AutoSize = true;
            this.lblEnterTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnterTitle.Location = new System.Drawing.Point(363, 78);
            this.lblEnterTitle.Name = "lblEnterTitle";
            this.lblEnterTitle.Size = new System.Drawing.Size(116, 28);
            this.lblEnterTitle.TabIndex = 6;
            this.lblEnterTitle.Text = "Enter Title:";
            this.lblEnterTitle.Click += new System.EventHandler(this.lblEnterTitle_Click);
            // 
            // lblChooseDVD
            // 
            this.lblChooseDVD.AutoSize = true;
            this.lblChooseDVD.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChooseDVD.Location = new System.Drawing.Point(19, 145);
            this.lblChooseDVD.Name = "lblChooseDVD";
            this.lblChooseDVD.Size = new System.Drawing.Size(134, 28);
            this.lblChooseDVD.TabIndex = 5;
            this.lblChooseDVD.Text = "Choose DVD:";
            this.lblChooseDVD.Click += new System.EventHandler(this.lblChooseDVD_Click);
            // 
            // lblRefine
            // 
            this.lblRefine.AutoSize = true;
            this.lblRefine.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRefine.Location = new System.Drawing.Point(41, 78);
            this.lblRefine.Name = "lblRefine";
            this.lblRefine.Size = new System.Drawing.Size(112, 28);
            this.lblRefine.TabIndex = 4;
            this.lblRefine.Text = "Refine list:";
            this.lblRefine.Click += new System.EventHandler(this.lblRefine_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCategory.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(159, 80);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(180, 31);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.Text = "Children\'s Titles";
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCat_SelectedIndexChanged);
            // 
            // btnConfirmDel
            // 
            this.btnConfirmDel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmDel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmDel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnConfirmDel.Location = new System.Drawing.Point(565, 289);
            this.btnConfirmDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmDel.Name = "btnConfirmDel";
            this.btnConfirmDel.Size = new System.Drawing.Size(100, 35);
            this.btnConfirmDel.TabIndex = 3;
            this.btnConfirmDel.Text = "Remove";
            this.btnConfirmDel.UseVisualStyleBackColor = false;
            this.btnConfirmDel.Click += new System.EventHandler(this.btnConfirmDel_Click);
            // 
            // lstDVDs
            // 
            this.lstDVDs.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstDVDs.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstDVDs.FormattingEnabled = true;
            this.lstDVDs.ItemHeight = 30;
            this.lstDVDs.Location = new System.Drawing.Point(159, 145);
            this.lstDVDs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstDVDs.Name = "lstDVDs";
            this.lstDVDs.Size = new System.Drawing.Size(180, 154);
            this.lstDVDs.TabIndex = 2;
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
            this.mnuRemove.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnuRemove.Size = new System.Drawing.Size(1000, 33);
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
            this.mnuExit.Size = new System.Drawing.Size(35, 27);
            this.mnuExit.Text = "X";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // frmDVDRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.grpRemove);
            this.Controls.Add(this.mnuRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnuRemove;
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
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblRefine;
        private System.Windows.Forms.Label lblChooseDVD;
        private System.Windows.Forms.TextBox txtDVDTitle;
        private System.Windows.Forms.Label lblEnterTitle;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}