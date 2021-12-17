
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
            this.cboEnterYear = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.mnuAdd.SuspendLayout();
            this.grpRevenue.SuspendLayout();
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
            this.mnuAdd.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuAdd_ItemClicked);
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
            this.grpRevenue.Controls.Add(this.chkAllQuart);
            this.grpRevenue.Controls.Add(this.chkFourthQuart);
            this.grpRevenue.Controls.Add(this.chkThirdQuart);
            this.grpRevenue.Controls.Add(this.chkSecondQuart);
            this.grpRevenue.Controls.Add(this.chkFirstQuart);
            this.grpRevenue.Controls.Add(this.cboEnterYear);
            this.grpRevenue.Controls.Add(this.btnGenerate);
            this.grpRevenue.Controls.Add(this.lblYear);
            this.grpRevenue.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpRevenue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpRevenue.Location = new System.Drawing.Point(48, 89);
            this.grpRevenue.Name = "grpRevenue";
            this.grpRevenue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpRevenue.Size = new System.Drawing.Size(469, 235);
            this.grpRevenue.TabIndex = 1;
            this.grpRevenue.TabStop = false;
            this.grpRevenue.Text = "Revenue Analysis";
            this.grpRevenue.Enter += new System.EventHandler(this.grpRevenue_Enter);
            // 
            // chkAllQuart
            // 
            this.chkAllQuart.AutoSize = true;
            this.chkAllQuart.Checked = true;
            this.chkAllQuart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllQuart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkAllQuart.Location = new System.Drawing.Point(333, 97);
            this.chkAllQuart.Name = "chkAllQuart";
            this.chkAllQuart.Size = new System.Drawing.Size(123, 32);
            this.chkAllQuart.TabIndex = 9;
            this.chkAllQuart.Text = "Select All";
            this.chkAllQuart.UseVisualStyleBackColor = true;
            this.chkAllQuart.CheckedChanged += new System.EventHandler(this.chkAllQuart_CheckedChanged);
            // 
            // chkFourthQuart
            // 
            this.chkFourthQuart.AutoSize = true;
            this.chkFourthQuart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkFourthQuart.Location = new System.Drawing.Point(333, 56);
            this.chkFourthQuart.Name = "chkFourthQuart";
            this.chkFourthQuart.Size = new System.Drawing.Size(123, 32);
            this.chkFourthQuart.TabIndex = 8;
            this.chkFourthQuart.Text = "Oct - Dec";
            this.chkFourthQuart.UseVisualStyleBackColor = true;
            this.chkFourthQuart.CheckedChanged += new System.EventHandler(this.chkFourthQuart_CheckedChanged);
            // 
            // chkThirdQuart
            // 
            this.chkThirdQuart.AutoSize = true;
            this.chkThirdQuart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkThirdQuart.Location = new System.Drawing.Point(183, 137);
            this.chkThirdQuart.Name = "chkThirdQuart";
            this.chkThirdQuart.Size = new System.Drawing.Size(115, 32);
            this.chkThirdQuart.TabIndex = 7;
            this.chkThirdQuart.Text = "Jul - Sep";
            this.chkThirdQuart.UseVisualStyleBackColor = true;
            this.chkThirdQuart.CheckedChanged += new System.EventHandler(this.chkThirdQuart_CheckedChanged);
            // 
            // chkSecondQuart
            // 
            this.chkSecondQuart.AutoSize = true;
            this.chkSecondQuart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkSecondQuart.Location = new System.Drawing.Point(183, 97);
            this.chkSecondQuart.Name = "chkSecondQuart";
            this.chkSecondQuart.Size = new System.Drawing.Size(121, 32);
            this.chkSecondQuart.TabIndex = 6;
            this.chkSecondQuart.Text = "Apr - Jun";
            this.chkSecondQuart.UseVisualStyleBackColor = true;
            this.chkSecondQuart.CheckedChanged += new System.EventHandler(this.chkSecondQuart_CheckedChanged);
            // 
            // chkFirstQuart
            // 
            this.chkFirstQuart.AutoSize = true;
            this.chkFirstQuart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkFirstQuart.Location = new System.Drawing.Point(183, 56);
            this.chkFirstQuart.Name = "chkFirstQuart";
            this.chkFirstQuart.Size = new System.Drawing.Size(124, 32);
            this.chkFirstQuart.TabIndex = 5;
            this.chkFirstQuart.Text = "Jan - Mar";
            this.chkFirstQuart.UseVisualStyleBackColor = true;
            this.chkFirstQuart.CheckedChanged += new System.EventHandler(this.chkFirstQuart_CheckedChanged);
            // 
            // cboEnterYear
            // 
            this.cboEnterYear.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboEnterYear.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboEnterYear.FormattingEnabled = true;
            this.cboEnterYear.Location = new System.Drawing.Point(79, 56);
            this.cboEnterYear.Name = "cboEnterYear";
            this.cboEnterYear.Size = new System.Drawing.Size(70, 31);
            this.cboEnterYear.TabIndex = 4;
            this.cboEnterYear.Text = "2021";
            this.cboEnterYear.SelectedIndexChanged += new System.EventHandler(this.cboEnterYear_SelectedIndexChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGenerate.Location = new System.Drawing.Point(352, 179);
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
            this.lblYear.Location = new System.Drawing.Point(15, 57);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(58, 28);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year:";
            this.lblYear.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrint.Location = new System.Drawing.Point(733, 659);
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
            this.btnDownload.Location = new System.Drawing.Point(859, 659);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(110, 35);
            this.btnDownload.TabIndex = 32;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // frmYearlyRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 720);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpRevenue;
        private System.Windows.Forms.ComboBox cboEnterYear;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.CheckBox chkAllQuart;
        private System.Windows.Forms.CheckBox chkFourthQuart;
        private System.Windows.Forms.CheckBox chkThirdQuart;
        private System.Windows.Forms.CheckBox chkSecondQuart;
        private System.Windows.Forms.CheckBox chkFirstQuart;
    }
}