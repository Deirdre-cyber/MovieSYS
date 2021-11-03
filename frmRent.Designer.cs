
namespace MovieSYS
{
    partial class frmRent
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
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnConfirmRefine = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSearchOpt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSearchRes = new System.Windows.Forms.GroupBox();
            this.btnRefine = new System.Windows.Forms.Button();
            this.btnAddtoCart1 = new System.Windows.Forms.Button();
            this.cboSearchList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpRentDetails = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMemId2 = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dtpDueBack = new System.Windows.Forms.DateTimePicker();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpMemCheck = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.mnuAdd.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpSearchRes.SuspendLayout();
            this.grpRentDetails.SuspendLayout();
            this.grpMemCheck.SuspendLayout();
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
            this.mnuAdd.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.mnuAdd.Size = new System.Drawing.Size(804, 42);
            this.mnuAdd.TabIndex = 16;
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
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnConfirmRefine);
            this.grpSearch.Controls.Add(this.label5);
            this.grpSearch.Controls.Add(this.cboSearchOpt);
            this.grpSearch.Controls.Add(this.label1);
            this.grpSearch.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpSearch.ForeColor = System.Drawing.Color.Azure;
            this.grpSearch.Location = new System.Drawing.Point(413, 45);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(362, 167);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Refine Options";
            this.grpSearch.Enter += new System.EventHandler(this.grpSearch_Enter);
            // 
            // btnConfirmRefine
            // 
            this.btnConfirmRefine.BackColor = System.Drawing.Color.GhostWhite;
            this.btnConfirmRefine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmRefine.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmRefine.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnConfirmRefine.Location = new System.Drawing.Point(245, 104);
            this.btnConfirmRefine.Name = "btnConfirmRefine";
            this.btnConfirmRefine.Size = new System.Drawing.Size(97, 34);
            this.btnConfirmRefine.TabIndex = 7;
            this.btnConfirmRefine.Text = "Refine";
            this.btnConfirmRefine.UseVisualStyleBackColor = false;
            this.btnConfirmRefine.Click += new System.EventHandler(this.btnConfirmRefine_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(261, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 41);
            this.label5.TabIndex = 25;
            // 
            // cboSearchOpt
            // 
            this.cboSearchOpt.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSearchOpt.FormattingEnabled = true;
            this.cboSearchOpt.Location = new System.Drawing.Point(166, 54);
            this.cboSearchOpt.Name = "cboSearchOpt";
            this.cboSearchOpt.Size = new System.Drawing.Size(176, 31);
            this.cboSearchOpt.TabIndex = 6;
            this.cboSearchOpt.Text = "Titles";
            this.cboSearchOpt.SelectedIndexChanged += new System.EventHandler(this.cboSearchOpt_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // grpSearchRes
            // 
            this.grpSearchRes.Controls.Add(this.btnRefine);
            this.grpSearchRes.Controls.Add(this.btnAddtoCart1);
            this.grpSearchRes.Controls.Add(this.cboSearchList);
            this.grpSearchRes.Controls.Add(this.label6);
            this.grpSearchRes.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpSearchRes.ForeColor = System.Drawing.Color.Azure;
            this.grpSearchRes.Location = new System.Drawing.Point(29, 45);
            this.grpSearchRes.Name = "grpSearchRes";
            this.grpSearchRes.Size = new System.Drawing.Size(357, 167);
            this.grpSearchRes.TabIndex = 0;
            this.grpSearchRes.TabStop = false;
            this.grpSearchRes.Text = "Search";
            this.grpSearchRes.Enter += new System.EventHandler(this.grpSearchRes_Enter);
            // 
            // btnRefine
            // 
            this.btnRefine.BackColor = System.Drawing.Color.Azure;
            this.btnRefine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefine.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefine.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRefine.Location = new System.Drawing.Point(25, 104);
            this.btnRefine.Name = "btnRefine";
            this.btnRefine.Size = new System.Drawing.Size(137, 34);
            this.btnRefine.TabIndex = 4;
            this.btnRefine.Text = "Refine Search";
            this.btnRefine.UseVisualStyleBackColor = false;
            this.btnRefine.Click += new System.EventHandler(this.btnRefine_Click);
            // 
            // btnAddtoCart1
            // 
            this.btnAddtoCart1.BackColor = System.Drawing.Color.Azure;
            this.btnAddtoCart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtoCart1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddtoCart1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddtoCart1.Location = new System.Drawing.Point(210, 104);
            this.btnAddtoCart1.Name = "btnAddtoCart1";
            this.btnAddtoCart1.Size = new System.Drawing.Size(129, 34);
            this.btnAddtoCart1.TabIndex = 5;
            this.btnAddtoCart1.Text = "Add to Cart";
            this.btnAddtoCart1.UseVisualStyleBackColor = false;
            this.btnAddtoCart1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboSearchList
            // 
            this.cboSearchList.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSearchList.FormattingEnabled = true;
            this.cboSearchList.Location = new System.Drawing.Point(163, 54);
            this.cboSearchList.Name = "cboSearchList";
            this.cboSearchList.Size = new System.Drawing.Size(176, 31);
            this.cboSearchList.TabIndex = 3;
            this.cboSearchList.Text = "DVD Titles";
            this.cboSearchList.SelectedIndexChanged += new System.EventHandler(this.cboList_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(71, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 41);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // grpRentDetails
            // 
            this.grpRentDetails.Controls.Add(this.label9);
            this.grpRentDetails.Controls.Add(this.txtMemId2);
            this.grpRentDetails.Controls.Add(this.btnRemove);
            this.grpRentDetails.Controls.Add(this.btnCancel);
            this.grpRentDetails.Controls.Add(this.btnBuy);
            this.grpRentDetails.Controls.Add(this.lstCart);
            this.grpRentDetails.Controls.Add(this.txtPrice);
            this.grpRentDetails.Controls.Add(this.dtpDueBack);
            this.grpRentDetails.Controls.Add(this.dtpRentDate);
            this.grpRentDetails.Controls.Add(this.label8);
            this.grpRentDetails.Controls.Add(this.label7);
            this.grpRentDetails.Controls.Add(this.label4);
            this.grpRentDetails.Controls.Add(this.label3);
            this.grpRentDetails.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpRentDetails.ForeColor = System.Drawing.Color.GhostWhite;
            this.grpRentDetails.Location = new System.Drawing.Point(29, 378);
            this.grpRentDetails.Name = "grpRentDetails";
            this.grpRentDetails.Size = new System.Drawing.Size(746, 334);
            this.grpRentDetails.TabIndex = 0;
            this.grpRentDetails.TabStop = false;
            this.grpRentDetails.Text = "Order Details";
            this.grpRentDetails.Enter += new System.EventHandler(this.grpRentDetails_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(411, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 41);
            this.label9.TabIndex = 0;
            this.label9.Text = "Member ID:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtMemId2
            // 
            this.txtMemId2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId2.Location = new System.Drawing.Point(563, 64);
            this.txtMemId2.MaxLength = 8;
            this.txtMemId2.Name = "txtMemId2";
            this.txtMemId2.PlaceholderText = "00000001";
            this.txtMemId2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemId2.Size = new System.Drawing.Size(132, 30);
            this.txtMemId2.TabIndex = 10;
            this.txtMemId2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMemId2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRemove.Location = new System.Drawing.Point(112, 276);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 33);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCancel.Location = new System.Drawing.Point(466, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 33);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuy.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBuy.Location = new System.Drawing.Point(601, 277);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(94, 33);
            this.btnBuy.TabIndex = 15;
            this.btnBuy.Text = "Purchase";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lstCart
            // 
            this.lstCart.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 23;
            this.lstCart.Location = new System.Drawing.Point(112, 64);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(198, 188);
            this.lstCart.TabIndex = 8;
            this.lstCart.SelectedIndexChanged += new System.EventHandler(this.lstCart_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(563, 209);
            this.txtPrice.MaxLength = 8;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "0.00";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(67, 30);
            this.txtPrice.TabIndex = 13;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // dtpDueBack
            // 
            this.dtpDueBack.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDueBack.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueBack.Location = new System.Drawing.Point(563, 143);
            this.dtpDueBack.Name = "dtpDueBack";
            this.dtpDueBack.Size = new System.Drawing.Size(132, 30);
            this.dtpDueBack.TabIndex = 12;
            this.dtpDueBack.ValueChanged += new System.EventHandler(this.dtpDueBack_ValueChanged);
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentDate.Location = new System.Drawing.Point(563, 102);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(132, 30);
            this.dtpRentDate.TabIndex = 11;
            this.dtpRentDate.ValueChanged += new System.EventHandler(this.dtpRentDate_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(420, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 41);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rented on:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(430, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 41);
            this.label7.TabIndex = 0;
            this.label7.Text = "Due back:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(475, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cart:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // grpMemCheck
            // 
            this.grpMemCheck.Controls.Add(this.btnCheck);
            this.grpMemCheck.Controls.Add(this.label2);
            this.grpMemCheck.Controls.Add(this.txtMemId);
            this.grpMemCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.grpMemCheck.Location = new System.Drawing.Point(218, 218);
            this.grpMemCheck.Name = "grpMemCheck";
            this.grpMemCheck.Size = new System.Drawing.Size(346, 154);
            this.grpMemCheck.TabIndex = 0;
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
            this.btnCheck.TabIndex = 2;
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
            this.txtMemId.TabIndex = 1;
            this.txtMemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMemId.TextChanged += new System.EventHandler(this.txtMemId_TextChanged);
            // 
            // frmRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(804, 731);
            this.Controls.Add(this.grpMemCheck);
            this.Controls.Add(this.grpRentDetails);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpSearchRes);
            this.Controls.Add(this.mnuAdd);
            this.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmRent";
            this.Load += new System.EventHandler(this.frmRent_Load);
            this.mnuAdd.ResumeLayout(false);
            this.mnuAdd.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpSearchRes.ResumeLayout(false);
            this.grpSearchRes.PerformLayout();
            this.grpRentDetails.ResumeLayout(false);
            this.grpRentDetails.PerformLayout();
            this.grpMemCheck.ResumeLayout(false);
            this.grpMemCheck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSearchOpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSearchRes;
        private System.Windows.Forms.ComboBox cboSearchList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpRentDetails;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dtpDueBack;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddtoCart1;
        private System.Windows.Forms.Button btnConfirmRefine;
        private System.Windows.Forms.Button btnRefine;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMemId2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpMemCheck;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemId;
    }
}