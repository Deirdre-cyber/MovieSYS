
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
            this.cboEnterYear = new System.Windows.Forms.ComboBox();
            this.rbFourthQuart = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.rbSelectAll = new System.Windows.Forms.RadioButton();
            this.rbThirdQuart = new System.Windows.Forms.RadioButton();
            this.rbSecQuart = new System.Windows.Forms.RadioButton();
            this.rbFirstQuart = new System.Windows.Forms.RadioButton();
            this.lblYear = new System.Windows.Forms.Label();
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
            this.mnuAdd.Size = new System.Drawing.Size(1000, 31);
            this.mnuAdd.TabIndex = 11;
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
            this.grpRevenue.Controls.Add(this.cboEnterYear);
            this.grpRevenue.Controls.Add(this.rbFourthQuart);
            this.grpRevenue.Controls.Add(this.btnGenerate);
            this.grpRevenue.Controls.Add(this.rbSelectAll);
            this.grpRevenue.Controls.Add(this.rbThirdQuart);
            this.grpRevenue.Controls.Add(this.rbSecQuart);
            this.grpRevenue.Controls.Add(this.rbFirstQuart);
            this.grpRevenue.Controls.Add(this.lblYear);
            this.grpRevenue.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpRevenue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpRevenue.Location = new System.Drawing.Point(162, 137);
            this.grpRevenue.Name = "grpRevenue";
            this.grpRevenue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpRevenue.Size = new System.Drawing.Size(656, 355);
            this.grpRevenue.TabIndex = 23;
            this.grpRevenue.TabStop = false;
            this.grpRevenue.Text = "Revenue Analysis";
            this.grpRevenue.Enter += new System.EventHandler(this.grpRevenue_Enter);
            // 
            // cboEnterYear
            // 
            this.cboEnterYear.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboEnterYear.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboEnterYear.FormattingEnabled = true;
            this.cboEnterYear.Location = new System.Drawing.Point(83, 89);
            this.cboEnterYear.Name = "cboEnterYear";
            this.cboEnterYear.Size = new System.Drawing.Size(70, 31);
            this.cboEnterYear.TabIndex = 27;
            this.cboEnterYear.Text = "2020";
            this.cboEnterYear.SelectedIndexChanged += new System.EventHandler(this.cboEnterYear_SelectedIndexChanged);
            // 
            // rbFourthQuart
            // 
            this.rbFourthQuart.AutoSize = true;
            this.rbFourthQuart.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbFourthQuart.Location = new System.Drawing.Point(200, 220);
            this.rbFourthQuart.Name = "rbFourthQuart";
            this.rbFourthQuart.Size = new System.Drawing.Size(106, 27);
            this.rbFourthQuart.TabIndex = 26;
            this.rbFourthQuart.Text = "Oct - Dec";
            this.rbFourthQuart.UseVisualStyleBackColor = true;
            this.rbFourthQuart.CheckedChanged += new System.EventHandler(this.rbFourthQuart_CheckedChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGenerate.Location = new System.Drawing.Point(535, 296);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(94, 35);
            this.btnGenerate.TabIndex = 22;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // rbSelectAll
            // 
            this.rbSelectAll.AutoSize = true;
            this.rbSelectAll.Checked = true;
            this.rbSelectAll.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbSelectAll.Location = new System.Drawing.Point(200, 263);
            this.rbSelectAll.Name = "rbSelectAll";
            this.rbSelectAll.Size = new System.Drawing.Size(106, 27);
            this.rbSelectAll.TabIndex = 20;
            this.rbSelectAll.TabStop = true;
            this.rbSelectAll.Text = "Select All";
            this.rbSelectAll.UseVisualStyleBackColor = true;
            this.rbSelectAll.CheckedChanged += new System.EventHandler(this.rbSelectAll_CheckedChanged);
            // 
            // rbThirdQuart
            // 
            this.rbThirdQuart.AutoSize = true;
            this.rbThirdQuart.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbThirdQuart.Location = new System.Drawing.Point(200, 176);
            this.rbThirdQuart.Name = "rbThirdQuart";
            this.rbThirdQuart.Size = new System.Drawing.Size(101, 27);
            this.rbThirdQuart.TabIndex = 17;
            this.rbThirdQuart.Text = "Jul - Sep";
            this.rbThirdQuart.UseVisualStyleBackColor = true;
            this.rbThirdQuart.CheckedChanged += new System.EventHandler(this.rbThirdQuart_CheckedChanged);
            // 
            // rbSecQuart
            // 
            this.rbSecQuart.AutoSize = true;
            this.rbSecQuart.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbSecQuart.Location = new System.Drawing.Point(200, 132);
            this.rbSecQuart.Name = "rbSecQuart";
            this.rbSecQuart.Size = new System.Drawing.Size(106, 27);
            this.rbSecQuart.TabIndex = 16;
            this.rbSecQuart.Text = "Apr - Jun";
            this.rbSecQuart.UseVisualStyleBackColor = true;
            this.rbSecQuart.CheckedChanged += new System.EventHandler(this.rbSecQuart_CheckedChanged);
            // 
            // rbFirstQuart
            // 
            this.rbFirstQuart.AutoSize = true;
            this.rbFirstQuart.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbFirstQuart.Location = new System.Drawing.Point(200, 90);
            this.rbFirstQuart.Name = "rbFirstQuart";
            this.rbFirstQuart.Size = new System.Drawing.Size(107, 27);
            this.rbFirstQuart.TabIndex = 15;
            this.rbFirstQuart.Text = "Jan - Mar";
            this.rbFirstQuart.UseVisualStyleBackColor = true;
            this.rbFirstQuart.CheckedChanged += new System.EventHandler(this.rbFirstQuart_CheckedChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(19, 87);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(58, 28);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Year:";
            this.lblYear.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // frmYearlyRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.grpRevenue);
            this.Controls.Add(this.mnuAdd);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmYearlyRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmYearlyRevenue";
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
        private System.Windows.Forms.RadioButton rbFourthQuart;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RadioButton rbSelectAll;
        private System.Windows.Forms.RadioButton rbThirdQuart;
        private System.Windows.Forms.RadioButton rbSecQuart;
        private System.Windows.Forms.RadioButton rbFirstQuart;
        private System.Windows.Forms.Label lblYear;
    }
}