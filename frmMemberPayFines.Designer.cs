
namespace MovieSYS
{
    partial class frmPayFines
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
            this.grpMemCheck = new System.Windows.Forms.GroupBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.grpMemDetails = new System.Windows.Forms.GroupBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblPayAmount = new System.Windows.Forms.Label();
            this.lblFineAmount = new System.Windows.Forms.Label();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.txtFineAmount = new System.Windows.Forms.TextBox();
            this.mnuAdd.SuspendLayout();
            this.grpMemCheck.SuspendLayout();
            this.grpMemDetails.SuspendLayout();
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
            this.mnuAdd.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
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
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click_1);
            // 
            // grpMemCheck
            // 
            this.grpMemCheck.Controls.Add(this.lblMemberId);
            this.grpMemCheck.Controls.Add(this.btnCheck);
            this.grpMemCheck.Controls.Add(this.txtMemId);
            this.grpMemCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.grpMemCheck.Location = new System.Drawing.Point(310, 51);
            this.grpMemCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpMemCheck.Name = "grpMemCheck";
            this.grpMemCheck.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpMemCheck.Size = new System.Drawing.Size(350, 155);
            this.grpMemCheck.TabIndex = 1;
            this.grpMemCheck.TabStop = false;
            this.grpMemCheck.Enter += new System.EventHandler(this.grpMemCheck_Enter);
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMemberId.Location = new System.Drawing.Point(60, 49);
            this.lblMemberId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(123, 28);
            this.lblMemberId.TabIndex = 4;
            this.lblMemberId.Text = "Member ID:";
            this.lblMemberId.Click += new System.EventHandler(this.lblMemberId_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCheck.Location = new System.Drawing.Point(109, 100);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(145, 35);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check Account";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtMemId
            // 
            this.txtMemId.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId.ForeColor = System.Drawing.Color.LightSlateGray;
            this.txtMemId.Location = new System.Drawing.Point(191, 49);
            this.txtMemId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMemId.MaxLength = 8;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.PlaceholderText = "00000001";
            this.txtMemId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemId.Size = new System.Drawing.Size(110, 30);
            this.txtMemId.TabIndex = 2;
            this.txtMemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMemId.TextChanged += new System.EventHandler(this.txtMemId_TextChanged);
            // 
            // grpMemDetails
            // 
            this.grpMemDetails.Controls.Add(this.btnPay);
            this.grpMemDetails.Controls.Add(this.lblPayAmount);
            this.grpMemDetails.Controls.Add(this.lblFineAmount);
            this.grpMemDetails.Controls.Add(this.txtPayAmount);
            this.grpMemDetails.Controls.Add(this.txtFineAmount);
            this.grpMemDetails.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpMemDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpMemDetails.Location = new System.Drawing.Point(124, 239);
            this.grpMemDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpMemDetails.Name = "grpMemDetails";
            this.grpMemDetails.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpMemDetails.Size = new System.Drawing.Size(703, 287);
            this.grpMemDetails.TabIndex = 4;
            this.grpMemDetails.TabStop = false;
            this.grpMemDetails.Text = "Member Rental Details";
            this.grpMemDetails.Enter += new System.EventHandler(this.grpMemDetails_Enter);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPay.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPay.Location = new System.Drawing.Point(563, 211);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(70, 35);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblPayAmount
            // 
            this.lblPayAmount.AutoSize = true;
            this.lblPayAmount.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPayAmount.Location = new System.Drawing.Point(150, 132);
            this.lblPayAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayAmount.Name = "lblPayAmount";
            this.lblPayAmount.Size = new System.Drawing.Size(187, 28);
            this.lblPayAmount.TabIndex = 9;
            this.lblPayAmount.Text = "Payment Amount: ";
            this.lblPayAmount.Click += new System.EventHandler(this.lblPayAmount_Click);
            // 
            // lblFineAmount
            // 
            this.lblFineAmount.AutoSize = true;
            this.lblFineAmount.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFineAmount.Location = new System.Drawing.Point(199, 77);
            this.lblFineAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFineAmount.Name = "lblFineAmount";
            this.lblFineAmount.Size = new System.Drawing.Size(138, 28);
            this.lblFineAmount.TabIndex = 8;
            this.lblFineAmount.Text = "Fine Amount:";
            this.lblFineAmount.Click += new System.EventHandler(this.lblFineAmount_Click);
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPayAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtPayAmount.Location = new System.Drawing.Point(345, 134);
            this.txtPayAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPayAmount.MaxLength = 6;
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.PlaceholderText = "10.00";
            this.txtPayAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPayAmount.Size = new System.Drawing.Size(95, 30);
            this.txtPayAmount.TabIndex = 7;
            this.txtPayAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPayAmount.TextChanged += new System.EventHandler(this.txtPayAmount_TextChanged);
            // 
            // txtFineAmount
            // 
            this.txtFineAmount.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFineAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtFineAmount.Location = new System.Drawing.Point(345, 75);
            this.txtFineAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFineAmount.MaxLength = 6;
            this.txtFineAmount.Name = "txtFineAmount";
            this.txtFineAmount.PlaceholderText = "10.00";
            this.txtFineAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFineAmount.Size = new System.Drawing.Size(95, 30);
            this.txtFineAmount.TabIndex = 4;
            this.txtFineAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFineAmount.TextChanged += new System.EventHandler(this.txtFineAmount_TextChanged);
            // 
            // frmPayFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.grpMemDetails);
            this.Controls.Add(this.grpMemCheck);
            this.Controls.Add(this.mnuAdd);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPayFines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFines";
            this.mnuAdd.ResumeLayout(false);
            this.mnuAdd.PerformLayout();
            this.grpMemCheck.ResumeLayout(false);
            this.grpMemCheck.PerformLayout();
            this.grpMemDetails.ResumeLayout(false);
            this.grpMemDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAdd;
        private System.Windows.Forms.GroupBox grpMemCheck;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.GroupBox grpMemDetails;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.TextBox txtFineAmount;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblFineAmount;
        private System.Windows.Forms.Label lblPayAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}