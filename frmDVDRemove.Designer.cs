﻿
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
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmDel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstDVDs = new System.Windows.Forms.ListBox();
            this.mnuRemove = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRemove.SuspendLayout();
            this.mnuRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRemove
            // 
            this.grpRemove.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.grpRemove.Controls.Add(this.cboCategory);
            this.grpRemove.Controls.Add(this.label1);
            this.grpRemove.Controls.Add(this.btnConfirmDel);
            this.grpRemove.Controls.Add(this.label3);
            this.grpRemove.Controls.Add(this.lstDVDs);
            this.grpRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRemove.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpRemove.ForeColor = System.Drawing.Color.AliceBlue;
            this.grpRemove.Location = new System.Drawing.Point(0, 33);
            this.grpRemove.Name = "grpRemove";
            this.grpRemove.Size = new System.Drawing.Size(722, 304);
            this.grpRemove.TabIndex = 2;
            this.grpRemove.TabStop = false;
            this.grpRemove.Text = "Remove DVD";
            this.grpRemove.Enter += new System.EventHandler(this.grpRemove_Enter);
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(382, 65);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(174, 27);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.Text = "Children\'s Titles";
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(232, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Refine list:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConfirmDel
            // 
            this.btnConfirmDel.BackColor = System.Drawing.Color.Azure;
            this.btnConfirmDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmDel.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmDel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnConfirmDel.Location = new System.Drawing.Point(325, 218);
            this.btnConfirmDel.Name = "btnConfirmDel";
            this.btnConfirmDel.Size = new System.Drawing.Size(88, 31);
            this.btnConfirmDel.TabIndex = 3;
            this.btnConfirmDel.Text = "Remove";
            this.btnConfirmDel.UseVisualStyleBackColor = false;
            this.btnConfirmDel.Click += new System.EventHandler(this.btnConfirmDel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(208, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose DVD:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lstDVDs
            // 
            this.lstDVDs.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstDVDs.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstDVDs.FormattingEnabled = true;
            this.lstDVDs.ItemHeight = 25;
            this.lstDVDs.Location = new System.Drawing.Point(382, 116);
            this.lstDVDs.Name = "lstDVDs";
            this.lstDVDs.Size = new System.Drawing.Size(174, 79);
            this.lstDVDs.TabIndex = 2;
            this.lstDVDs.SelectedIndexChanged += new System.EventHandler(this.lstDVDs_SelectedIndexChanged);
            // 
            // mnuRemove
            // 
            this.mnuRemove.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.mnuRemove.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuRemove.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuRemove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mnuRemove.Location = new System.Drawing.Point(0, 0);
            this.mnuRemove.Name = "mnuRemove";
            this.mnuRemove.Size = new System.Drawing.Size(722, 33);
            this.mnuRemove.TabIndex = 4;
            this.mnuRemove.Text = "Exit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Azure;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(33, 29);
            this.exitToolStripMenuItem.Text = "X";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(722, 337);
            this.Controls.Add(this.grpRemove);
            this.Controls.Add(this.mnuRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnuRemove;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRemove";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstDVDs;
        private System.Windows.Forms.Button btnConfirmDel;
        private System.Windows.Forms.MenuStrip mnuRemove;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label1;
    }
}