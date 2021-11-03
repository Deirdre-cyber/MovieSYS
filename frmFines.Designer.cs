
namespace MovieSYS
{
    partial class frmFines
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMemCheck = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.grpMemDetails = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFineAmount = new System.Windows.Forms.TextBox();
            this.btnPayPart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.mnuAdd.SuspendLayout();
            this.grpMemCheck.SuspendLayout();
            this.grpMemDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAdd
            // 
            this.mnuAdd.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.mnuAdd.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuAdd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mnuAdd.Location = new System.Drawing.Point(0, 0);
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(725, 38);
            this.mnuAdd.TabIndex = 11;
            this.mnuAdd.Text = "menuStrip1";
            this.mnuAdd.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuAdd_ItemClicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Azure;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 34);
            this.exitToolStripMenuItem.Text = "X";
            // 
            // grpMemCheck
            // 
            this.grpMemCheck.Controls.Add(this.btnCheck);
            this.grpMemCheck.Controls.Add(this.label2);
            this.grpMemCheck.Controls.Add(this.txtMemId);
            this.grpMemCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.grpMemCheck.Location = new System.Drawing.Point(193, 41);
            this.grpMemCheck.Name = "grpMemCheck";
            this.grpMemCheck.Size = new System.Drawing.Size(346, 154);
            this.grpMemCheck.TabIndex = 1;
            this.grpMemCheck.TabStop = false;
            this.grpMemCheck.Enter += new System.EventHandler(this.grpMemCheck_Enter);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCheck.Location = new System.Drawing.Point(103, 105);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(146, 33);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check Account";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(39, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Member ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMemId
            // 
            this.txtMemId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId.Location = new System.Drawing.Point(183, 49);
            this.txtMemId.MaxLength = 8;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.PlaceholderText = "00000001";
            this.txtMemId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemId.Size = new System.Drawing.Size(114, 30);
            this.txtMemId.TabIndex = 2;
            this.txtMemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMemId.TextChanged += new System.EventHandler(this.txtMemId_TextChanged);
            // 
            // grpMemDetails
            // 
            this.grpMemDetails.Controls.Add(this.txtPayAmount);
            this.grpMemDetails.Controls.Add(this.label3);
            this.grpMemDetails.Controls.Add(this.btnPayPart);
            this.grpMemDetails.Controls.Add(this.txtFineAmount);
            this.grpMemDetails.Controls.Add(this.label1);
            this.grpMemDetails.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpMemDetails.ForeColor = System.Drawing.Color.White;
            this.grpMemDetails.Location = new System.Drawing.Point(75, 201);
            this.grpMemDetails.Name = "grpMemDetails";
            this.grpMemDetails.Size = new System.Drawing.Size(586, 271);
            this.grpMemDetails.TabIndex = 4;
            this.grpMemDetails.TabStop = false;
            this.grpMemDetails.Text = "Member Rental Details";
            this.grpMemDetails.Enter += new System.EventHandler(this.grpMemDetails_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(157, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fine Amount:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFineAmount
            // 
            this.txtFineAmount.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFineAmount.Location = new System.Drawing.Point(316, 65);
            this.txtFineAmount.MaxLength = 6;
            this.txtFineAmount.Name = "txtFineAmount";
            this.txtFineAmount.PlaceholderText = "10.00";
            this.txtFineAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFineAmount.Size = new System.Drawing.Size(77, 30);
            this.txtFineAmount.TabIndex = 4;
            this.txtFineAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFineAmount.TextChanged += new System.EventHandler(this.txtFineAmount_TextChanged);
            // 
            // btnPayPart
            // 
            this.btnPayPart.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPayPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayPart.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPayPart.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPayPart.Location = new System.Drawing.Point(456, 154);
            this.btnPayPart.Name = "btnPayPart";
            this.btnPayPart.Size = new System.Drawing.Size(60, 35);
            this.btnPayPart.TabIndex = 5;
            this.btnPayPart.Text = "Pay";
            this.btnPayPart.UseVisualStyleBackColor = false;
            this.btnPayPart.Click += new System.EventHandler(this.btnPayPart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(104, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Payment Amount: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPayAmount.Location = new System.Drawing.Point(316, 157);
            this.txtPayAmount.MaxLength = 6;
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.PlaceholderText = "10.00";
            this.txtPayAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPayAmount.Size = new System.Drawing.Size(77, 30);
            this.txtPayAmount.TabIndex = 7;
            this.txtPayAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPayAmount.TextChanged += new System.EventHandler(this.txtPayAmount_TextChanged);
            // 
            // frmFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(725, 509);
            this.Controls.Add(this.grpMemDetails);
            this.Controls.Add(this.grpMemCheck);
            this.Controls.Add(this.mnuAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFines";
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
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpMemCheck;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.GroupBox grpMemDetails;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPayPart;
        private System.Windows.Forms.TextBox txtFineAmount;
        private System.Windows.Forms.Label label1;
    }
}