
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
            this.mnuAdd = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpRevenue = new System.Windows.Forms.GroupBox();
            this.chkAllQuart = new System.Windows.Forms.CheckBox();
            this.chkFourthQuart = new System.Windows.Forms.CheckBox();
            this.chkThirdQuart = new System.Windows.Forms.CheckBox();
            this.chkSecondQuart = new System.Windows.Forms.CheckBox();
            this.chkFirstQuart = new System.Windows.Forms.CheckBox();
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
            this.mnuAdd.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuAdd.Size = new System.Drawing.Size(875, 27);
            this.mnuAdd.TabIndex = 12;
            this.mnuAdd.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(30, 23);
            this.mnuExit.Text = "X";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // grpRevenue
            // 
            this.grpRevenue.Controls.Add(this.chkAllQuart);
            this.grpRevenue.Controls.Add(this.chkFourthQuart);
            this.grpRevenue.Controls.Add(this.chkThirdQuart);
            this.grpRevenue.Controls.Add(this.chkSecondQuart);
            this.grpRevenue.Controls.Add(this.chkFirstQuart);
            this.grpRevenue.Controls.Add(this.cboYear);
            this.grpRevenue.Controls.Add(this.btnGenerate);
            this.grpRevenue.Controls.Add(this.lblYear);
            this.grpRevenue.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpRevenue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpRevenue.Location = new System.Drawing.Point(171, 43);
            this.grpRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRevenue.Name = "grpRevenue";
            this.grpRevenue.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRevenue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpRevenue.Size = new System.Drawing.Size(516, 175);
            this.grpRevenue.TabIndex = 1;
            this.grpRevenue.TabStop = false;
            this.grpRevenue.Text = "Revenue Analysis";
            // 
            // chkAllQuart
            // 
            this.chkAllQuart.AutoSize = true;
            this.chkAllQuart.Checked = true;
            this.chkAllQuart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllQuart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkAllQuart.Location = new System.Drawing.Point(383, 70);
            this.chkAllQuart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAllQuart.Name = "chkAllQuart";
            this.chkAllQuart.Size = new System.Drawing.Size(100, 25);
            this.chkAllQuart.TabIndex = 9;
            this.chkAllQuart.Text = "Select All";
            this.chkAllQuart.UseVisualStyleBackColor = true;
            // 
            // chkFourthQuart
            // 
            this.chkFourthQuart.AutoSize = true;
            this.chkFourthQuart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkFourthQuart.Location = new System.Drawing.Point(383, 39);
            this.chkFourthQuart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFourthQuart.Name = "chkFourthQuart";
            this.chkFourthQuart.Size = new System.Drawing.Size(98, 25);
            this.chkFourthQuart.TabIndex = 8;
            this.chkFourthQuart.Text = "Oct - Dec";
            this.chkFourthQuart.UseVisualStyleBackColor = true;
            // 
            // chkThirdQuart
            // 
            this.chkThirdQuart.AutoSize = true;
            this.chkThirdQuart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkThirdQuart.Location = new System.Drawing.Point(252, 100);
            this.chkThirdQuart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkThirdQuart.Name = "chkThirdQuart";
            this.chkThirdQuart.Size = new System.Drawing.Size(93, 25);
            this.chkThirdQuart.TabIndex = 7;
            this.chkThirdQuart.Text = "Jul - Sep";
            this.chkThirdQuart.UseVisualStyleBackColor = true;
            // 
            // chkSecondQuart
            // 
            this.chkSecondQuart.AutoSize = true;
            this.chkSecondQuart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkSecondQuart.Location = new System.Drawing.Point(252, 70);
            this.chkSecondQuart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSecondQuart.Name = "chkSecondQuart";
            this.chkSecondQuart.Size = new System.Drawing.Size(97, 25);
            this.chkSecondQuart.TabIndex = 6;
            this.chkSecondQuart.Text = "Apr - Jun";
            this.chkSecondQuart.UseVisualStyleBackColor = true;
            // 
            // chkFirstQuart
            // 
            this.chkFirstQuart.AutoSize = true;
            this.chkFirstQuart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkFirstQuart.Location = new System.Drawing.Point(252, 39);
            this.chkFirstQuart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFirstQuart.Name = "chkFirstQuart";
            this.chkFirstQuart.Size = new System.Drawing.Size(99, 25);
            this.chkFirstQuart.TabIndex = 5;
            this.chkFirstQuart.Text = "Jan - Mar";
            this.chkFirstQuart.UseVisualStyleBackColor = true;
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboYear.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(69, 42);
            this.cboYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(62, 27);
            this.cboYear.TabIndex = 4;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGenerate.Location = new System.Drawing.Point(400, 131);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(83, 27);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(13, 43);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(48, 21);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year:";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrint.Location = new System.Drawing.Point(334, 503);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 26);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDownload.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDownload.Location = new System.Drawing.Point(445, 503);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(96, 26);
            this.btnDownload.TabIndex = 32;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            // 
            // grpRevenueDetails
            // 
            this.grpRevenueDetails.Controls.Add(this.lblTitle);
            this.grpRevenueDetails.Controls.Add(this.grdRevenue);
            this.grpRevenueDetails.Controls.Add(this.btnClose);
            this.grpRevenueDetails.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpRevenueDetails.ForeColor = System.Drawing.Color.White;
            this.grpRevenueDetails.Location = new System.Drawing.Point(171, 223);
            this.grpRevenueDetails.Name = "grpRevenueDetails";
            this.grpRevenueDetails.Size = new System.Drawing.Size(516, 257);
            this.grpRevenueDetails.TabIndex = 33;
            this.grpRevenueDetails.TabStop = false;
            this.grpRevenueDetails.Text = "Revenue Details";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(130, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 25);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Revenue Analysis";
            // 
            // grdRevenue
            // 
            this.grdRevenue.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRevenue.Location = new System.Drawing.Point(13, 69);
            this.grdRevenue.Name = "grdRevenue";
            this.grdRevenue.RowTemplate.Height = 25;
            this.grdRevenue.Size = new System.Drawing.Size(486, 145);
            this.grdRevenue.TabIndex = 12;
            this.grdRevenue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRevenue_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.Location = new System.Drawing.Point(439, 219);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 28);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmYearlyRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(875, 540);
            this.Controls.Add(this.grpRevenueDetails);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grpRevenue);
            this.Controls.Add(this.mnuAdd);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.CheckBox chkAllQuart;
        private System.Windows.Forms.CheckBox chkFourthQuart;
        private System.Windows.Forms.CheckBox chkThirdQuart;
        private System.Windows.Forms.CheckBox chkSecondQuart;
        private System.Windows.Forms.CheckBox chkFirstQuart;
        private System.Windows.Forms.GroupBox grpRevenueDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView grdRevenue;
        private System.Windows.Forms.Label lblTitle;
    }
}