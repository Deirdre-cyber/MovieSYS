
namespace MovieSYS
{
    partial class frmCustomerStatement
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbFirstQuart = new System.Windows.Forms.RadioButton();
            this.rbSecQuart = new System.Windows.Forms.RadioButton();
            this.rbThirdQuart = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.grpRevenue = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbFourthQuart = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.mnuAdd.SuspendLayout();
            this.grpRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAdd
            // 
            this.mnuAdd.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.mnuAdd.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuAdd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuAdd.Location = new System.Drawing.Point(0, 0);
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(733, 38);
            this.mnuAdd.TabIndex = 11;
            this.mnuAdd.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuExit.ForeColor = System.Drawing.Color.Azure;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 34);
            this.mnuExit.Text = "X";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Year:";
            // 
            // rbFirstQuart
            // 
            this.rbFirstQuart.AutoSize = true;
            this.rbFirstQuart.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbFirstQuart.Location = new System.Drawing.Point(200, 90);
            this.rbFirstQuart.Name = "rbFirstQuart";
            this.rbFirstQuart.Size = new System.Drawing.Size(103, 27);
            this.rbFirstQuart.TabIndex = 15;
            this.rbFirstQuart.Text = "Jan - Mar";
            this.rbFirstQuart.UseVisualStyleBackColor = true;
            // 
            // rbSecQuart
            // 
            this.rbSecQuart.AutoSize = true;
            this.rbSecQuart.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbSecQuart.Location = new System.Drawing.Point(200, 132);
            this.rbSecQuart.Name = "rbSecQuart";
            this.rbSecQuart.Size = new System.Drawing.Size(101, 27);
            this.rbSecQuart.TabIndex = 16;
            this.rbSecQuart.Text = "Apr - Jun";
            this.rbSecQuart.UseVisualStyleBackColor = true;
            // 
            // rbThirdQuart
            // 
            this.rbThirdQuart.AutoSize = true;
            this.rbThirdQuart.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbThirdQuart.Location = new System.Drawing.Point(200, 176);
            this.rbThirdQuart.Name = "rbThirdQuart";
            this.rbThirdQuart.Size = new System.Drawing.Size(96, 27);
            this.rbThirdQuart.TabIndex = 17;
            this.rbThirdQuart.Text = "Jul - Sep";
            this.rbThirdQuart.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAll.Location = new System.Drawing.Point(200, 263);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(100, 27);
            this.rbAll.TabIndex = 20;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Select All";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // grpRevenue
            // 
            this.grpRevenue.Controls.Add(this.comboBox1);
            this.grpRevenue.Controls.Add(this.rbFourthQuart);
            this.grpRevenue.Controls.Add(this.btnGenerate);
            this.grpRevenue.Controls.Add(this.rbAll);
            this.grpRevenue.Controls.Add(this.rbThirdQuart);
            this.grpRevenue.Controls.Add(this.rbSecQuart);
            this.grpRevenue.Controls.Add(this.rbFirstQuart);
            this.grpRevenue.Controls.Add(this.label1);
            this.grpRevenue.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpRevenue.Location = new System.Drawing.Point(40, 57);
            this.grpRevenue.Name = "grpRevenue";
            this.grpRevenue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpRevenue.Size = new System.Drawing.Size(656, 355);
            this.grpRevenue.TabIndex = 22;
            this.grpRevenue.TabStop = false;
            this.grpRevenue.Text = "Revenue Analysis";
            this.grpRevenue.Enter += new System.EventHandler(this.grpRevenue_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 31);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.Text = "2020";
            // 
            // rbFourthQuart
            // 
            this.rbFourthQuart.AutoSize = true;
            this.rbFourthQuart.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbFourthQuart.Location = new System.Drawing.Point(200, 220);
            this.rbFourthQuart.Name = "rbFourthQuart";
            this.rbFourthQuart.Size = new System.Drawing.Size(104, 27);
            this.rbFourthQuart.TabIndex = 26;
            this.rbFourthQuart.Text = "Oct - Dec";
            this.rbFourthQuart.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.Location = new System.Drawing.Point(542, 302);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(94, 35);
            this.btnGenerate.TabIndex = 22;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // frmCustomerStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.grpRevenue);
            this.Controls.Add(this.mnuAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomerStatement";
            this.Text = "frmCustomerStatement";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFirstQuart;
        private System.Windows.Forms.RadioButton rbSecQuart;
        private System.Windows.Forms.RadioButton rbThirdQuart;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.GroupBox grpRevenue;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RadioButton rbFourthQuart;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}