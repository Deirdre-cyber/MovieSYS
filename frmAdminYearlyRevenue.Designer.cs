
namespace MovieSYS
{
    partial class frmYearlyRevenue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnuAdd = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRevenue = new System.Windows.Forms.GroupBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.grpRevenueDetails = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdRevenue = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.mnuAdd.SuspendLayout();
            this.grpRevenue.SuspendLayout();
            this.grpRevenueDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuAdd
            // 
            this.mnuAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuAdd.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuAdd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuAdd.Location = new System.Drawing.Point(0, 0);
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.mnuAdd.Size = new System.Drawing.Size(1000, 33);
            this.mnuAdd.TabIndex = 12;
            this.mnuAdd.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(35, 27);
            this.mnuExit.Text = "X";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // grpRevenue
            // 
            this.grpRevenue.Controls.Add(this.cboYear);
            this.grpRevenue.Controls.Add(this.btnGenerate);
            this.grpRevenue.Controls.Add(this.lblYear);
            this.grpRevenue.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpRevenue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpRevenue.Location = new System.Drawing.Point(285, 70);
            this.grpRevenue.Name = "grpRevenue";
            this.grpRevenue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpRevenue.Size = new System.Drawing.Size(424, 137);
            this.grpRevenue.TabIndex = 1;
            this.grpRevenue.TabStop = false;
            this.grpRevenue.Text = "Revenue Analysis";
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboYear.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(114, 54);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(70, 31);
            this.cboYear.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGenerate.Location = new System.Drawing.Point(241, 53);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(95, 36);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(50, 55);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(58, 28);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year:";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrint.Location = new System.Drawing.Point(399, 682);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 35);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDownload.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDownload.Location = new System.Drawing.Point(526, 682);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(110, 35);
            this.btnDownload.TabIndex = 32;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // grpRevenueDetails
            // 
            this.grpRevenueDetails.Controls.Add(this.lblTitle);
            this.grpRevenueDetails.Controls.Add(this.grdRevenue);
            this.grpRevenueDetails.Controls.Add(this.btnClose);
            this.grpRevenueDetails.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpRevenueDetails.ForeColor = System.Drawing.Color.White;
            this.grpRevenueDetails.Location = new System.Drawing.Point(43, 247);
            this.grpRevenueDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRevenueDetails.Name = "grpRevenueDetails";
            this.grpRevenueDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRevenueDetails.Size = new System.Drawing.Size(914, 393);
            this.grpRevenueDetails.TabIndex = 33;
            this.grpRevenueDetails.TabStop = false;
            this.grpRevenueDetails.Text = "Revenue Details";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(330, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(198, 32);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Revenue Analysis";
            // 
            // grdRevenue
            // 
            this.grdRevenue.AllowUserToAddRows = false;
            this.grdRevenue.AllowUserToDeleteRows = false;
            this.grdRevenue.AllowUserToResizeColumns = false;
            this.grdRevenue.AllowUserToResizeRows = false;
            this.grdRevenue.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdRevenue.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdRevenue.Enabled = false;
            this.grdRevenue.EnableHeadersVisualStyles = false;
            this.grdRevenue.Location = new System.Drawing.Point(15, 92);
            this.grdRevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdRevenue.MultiSelect = false;
            this.grdRevenue.Name = "grdRevenue";
            this.grdRevenue.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRevenue.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdRevenue.RowHeadersWidth = 51;
            this.grdRevenue.RowTemplate.Height = 25;
            this.grdRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdRevenue.ShowCellToolTips = false;
            this.grdRevenue.ShowEditingIcon = false;
            this.grdRevenue.Size = new System.Drawing.Size(880, 193);
            this.grdRevenue.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.Location = new System.Drawing.Point(440, 292);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 37);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmYearlyRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 771);
            this.Controls.Add(this.grpRevenueDetails);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grpRevenue);
            this.Controls.Add(this.mnuAdd);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmYearlyRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmYearlyRevenue";
            this.Load += new System.EventHandler(this.frmYearlyRevenue_Load);
            this.mnuAdd.ResumeLayout(false);
            this.mnuAdd.PerformLayout();
            this.grpRevenue.ResumeLayout(false);
            this.grpRevenue.PerformLayout();
            this.grpRevenueDetails.ResumeLayout(false);
            this.grpRevenueDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpRevenue;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.GroupBox grpRevenueDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView grdRevenue;
        private System.Windows.Forms.Label lblTitle;
    }
}