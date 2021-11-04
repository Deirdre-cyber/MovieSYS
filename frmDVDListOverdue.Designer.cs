
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.lstOverDue = new System.Windows.Forms.ListBox();
            this.mnuCloseLogin = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpListOverDue.SuspendLayout();
            this.mnuCloseLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpListOverDue
            // 
            this.grpListOverDue.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.grpListOverDue.Controls.Add(this.btnPrint);
            this.grpListOverDue.Controls.Add(this.lstOverDue);
            this.grpListOverDue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpListOverDue.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpListOverDue.ForeColor = System.Drawing.Color.Azure;
            this.grpListOverDue.Location = new System.Drawing.Point(0, 37);
            this.grpListOverDue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpListOverDue.Name = "grpListOverDue";
            this.grpListOverDue.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpListOverDue.Size = new System.Drawing.Size(782, 516);
            this.grpListOverDue.TabIndex = 3;
            this.grpListOverDue.TabStop = false;
            this.grpListOverDue.Text = "List of Overdue DVDs";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.Azure;
            this.btnPrint.Location = new System.Drawing.Point(359, 421);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 40);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lstOverDue
            // 
            this.lstOverDue.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOverDue.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lstOverDue.FormattingEnabled = true;
            this.lstOverDue.ItemHeight = 30;
            this.lstOverDue.Location = new System.Drawing.Point(276, 154);
            this.lstOverDue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstOverDue.Name = "lstOverDue";
            this.lstOverDue.Size = new System.Drawing.Size(262, 244);
            this.lstOverDue.TabIndex = 1;
            this.lstOverDue.SelectedIndexChanged += new System.EventHandler(this.lstOverDue_SelectedIndexChanged);
            // 
            // mnuCloseLogin
            // 
            this.mnuCloseLogin.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.mnuCloseLogin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuCloseLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.mnuCloseLogin.Location = new System.Drawing.Point(0, 0);
            this.mnuCloseLogin.Name = "mnuCloseLogin";
            this.mnuCloseLogin.Size = new System.Drawing.Size(782, 38);
            this.mnuCloseLogin.TabIndex = 3;
            this.mnuCloseLogin.Text = "menuStrip1";
            this.mnuCloseLogin.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuCloseLogin_ItemClicked);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.closeToolStripMenuItem.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.Azure;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(38, 34);
            this.closeToolStripMenuItem.Text = "X";
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
            this.Text = "Overdue DVD List";
            this.TransparencyKey = System.Drawing.Color.LightCyan;
            this.Load += new System.EventHandler(this.frmListOverdue_Load);
            this.grpListOverDue.ResumeLayout(false);
            this.mnuCloseLogin.ResumeLayout(false);
            this.mnuCloseLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpListOverDue;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ListBox lstOverDue;
        private System.Windows.Forms.MenuStrip mnuCloseLogin;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}