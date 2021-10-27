
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
            this.btnConfirmSO = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSearchOpt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSearchRes = new System.Windows.Forms.GroupBox();
            this.cboSearchList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.cboSearchResults = new System.Windows.Forms.ComboBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.grpRentDetails = new System.Windows.Forms.GroupBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dtpDueBack = new System.Windows.Forms.DateTimePicker();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.btnConfirmSearch = new System.Windows.Forms.Button();
            this.cboMemID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mnuAdd.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpSearchRes.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.grpRentDetails.SuspendLayout();
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
            this.mnuAdd.TabIndex = 14;
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
            this.grpSearch.Controls.Add(this.btnConfirmSO);
            this.grpSearch.Controls.Add(this.label5);
            this.grpSearch.Controls.Add(this.cboSearchOpt);
            this.grpSearch.Controls.Add(this.label1);
            this.grpSearch.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpSearch.ForeColor = System.Drawing.Color.Azure;
            this.grpSearch.Location = new System.Drawing.Point(33, 45);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(318, 166);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Options";
            this.grpSearch.Enter += new System.EventHandler(this.grpSearch_Enter);
            // 
            // btnConfirmSO
            // 
            this.btnConfirmSO.BackColor = System.Drawing.Color.Azure;
            this.btnConfirmSO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmSO.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmSO.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnConfirmSO.Location = new System.Drawing.Point(256, 103);
            this.btnConfirmSO.Name = "btnConfirmSO";
            this.btnConfirmSO.Size = new System.Drawing.Size(52, 34);
            this.btnConfirmSO.TabIndex = 2;
            this.btnConfirmSO.Text = "OK";
            this.btnConfirmSO.UseVisualStyleBackColor = false;
            this.btnConfirmSO.Click += new System.EventHandler(this.btnConfirm_Click);
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
            this.cboSearchOpt.Location = new System.Drawing.Point(132, 54);
            this.cboSearchOpt.Name = "cboSearchOpt";
            this.cboSearchOpt.Size = new System.Drawing.Size(176, 31);
            this.cboSearchOpt.TabIndex = 1;
            this.cboSearchOpt.Text = "Titles";
            this.cboSearchOpt.SelectedIndexChanged += new System.EventHandler(this.cboSearchOpt_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // grpSearchRes
            // 
            this.grpSearchRes.Controls.Add(this.btnConfirmSearch);
            this.grpSearchRes.Controls.Add(this.cboSearchList);
            this.grpSearchRes.Controls.Add(this.label6);
            this.grpSearchRes.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpSearchRes.ForeColor = System.Drawing.Color.Azure;
            this.grpSearchRes.Location = new System.Drawing.Point(386, 45);
            this.grpSearchRes.Name = "grpSearchRes";
            this.grpSearchRes.Size = new System.Drawing.Size(368, 167);
            this.grpSearchRes.TabIndex = 0;
            this.grpSearchRes.TabStop = false;
            this.grpSearchRes.Text = "Results";
            this.grpSearchRes.Enter += new System.EventHandler(this.grpSearchRes_Enter);
            // 
            // cboSearchList
            // 
            this.cboSearchList.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSearchList.FormattingEnabled = true;
            this.cboSearchList.Location = new System.Drawing.Point(183, 52);
            this.cboSearchList.Name = "cboSearchList";
            this.cboSearchList.Size = new System.Drawing.Size(176, 31);
            this.cboSearchList.TabIndex = 3;
            this.cboSearchList.Text = "DVD Titles";
            this.cboSearchList.SelectedIndexChanged += new System.EventHandler(this.cboList_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(26, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 41);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search Title:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.cboSearchResults);
            this.grpResults.Controls.Add(this.btnAddToCart);
            this.grpResults.ForeColor = System.Drawing.Color.Azure;
            this.grpResults.Location = new System.Drawing.Point(178, 218);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(417, 121);
            this.grpResults.TabIndex = 0;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            this.grpResults.Enter += new System.EventHandler(this.grpResults_Enter);
            // 
            // cboSearchResults
            // 
            this.cboSearchResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchResults.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSearchResults.FormattingEnabled = true;
            this.cboSearchResults.Location = new System.Drawing.Point(19, 49);
            this.cboSearchResults.Name = "cboSearchResults";
            this.cboSearchResults.Size = new System.Drawing.Size(217, 36);
            this.cboSearchResults.TabIndex = 5;
            this.cboSearchResults.SelectedIndexChanged += new System.EventHandler(this.cboSearchResults_SelectedIndexChanged);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddToCart.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddToCart.Location = new System.Drawing.Point(272, 51);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(128, 34);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // grpRentDetails
            // 
            this.grpRentDetails.Controls.Add(this.cboMemID);
            this.grpRentDetails.Controls.Add(this.label9);
            this.grpRentDetails.Controls.Add(this.btnBuy);
            this.grpRentDetails.Controls.Add(this.lstCart);
            this.grpRentDetails.Controls.Add(this.txtPrice);
            this.grpRentDetails.Controls.Add(this.dtpDueBack);
            this.grpRentDetails.Controls.Add(this.dtpRentDate);
            this.grpRentDetails.Controls.Add(this.label8);
            this.grpRentDetails.Controls.Add(this.label7);
            this.grpRentDetails.Controls.Add(this.label4);
            this.grpRentDetails.Controls.Add(this.label3);
            this.grpRentDetails.Controls.Add(this.label2);
            this.grpRentDetails.Controls.Add(this.txtMemId);
            this.grpRentDetails.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpRentDetails.ForeColor = System.Drawing.Color.GhostWhite;
            this.grpRentDetails.Location = new System.Drawing.Point(65, 345);
            this.grpRentDetails.Name = "grpRentDetails";
            this.grpRentDetails.Size = new System.Drawing.Size(663, 343);
            this.grpRentDetails.TabIndex = 0;
            this.grpRentDetails.TabStop = false;
            this.grpRentDetails.Text = "Details";
            this.grpRentDetails.Enter += new System.EventHandler(this.grpRentDetails_Enter);
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuy.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBuy.Location = new System.Drawing.Point(526, 278);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(94, 33);
            this.btnBuy.TabIndex = 13;
            this.btnBuy.Text = "Purchase";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lstCart
            // 
            this.lstCart.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 23;
            this.lstCart.Location = new System.Drawing.Point(113, 52);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(132, 188);
            this.lstCart.TabIndex = 7;
            this.lstCart.SelectedIndexChanged += new System.EventHandler(this.lstCart_SelectedIndexChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(488, 212);
            this.txtPrice.MaxLength = 8;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "0.00";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(132, 30);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // dtpDueBack
            // 
            this.dtpDueBack.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDueBack.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueBack.Location = new System.Drawing.Point(488, 171);
            this.dtpDueBack.Name = "dtpDueBack";
            this.dtpDueBack.Size = new System.Drawing.Size(132, 30);
            this.dtpDueBack.TabIndex = 11;
            this.dtpDueBack.ValueChanged += new System.EventHandler(this.dtpDueBack_ValueChanged);
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentDate.Location = new System.Drawing.Point(488, 130);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(132, 30);
            this.dtpRentDate.TabIndex = 10;
            this.dtpRentDate.ValueChanged += new System.EventHandler(this.dtpRentDate_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(345, 130);
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
            this.label7.Location = new System.Drawing.Point(355, 171);
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
            this.label4.Location = new System.Drawing.Point(400, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cart:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(335, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Member ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMemId
            // 
            this.txtMemId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId.Location = new System.Drawing.Point(488, 52);
            this.txtMemId.MaxLength = 8;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.PlaceholderText = "00000001";
            this.txtMemId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemId.Size = new System.Drawing.Size(132, 30);
            this.txtMemId.TabIndex = 8;
            this.txtMemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMemId.TextChanged += new System.EventHandler(this.txtMemId_TextChanged);
            // 
            // btnConfirmSearch
            // 
            this.btnConfirmSearch.BackColor = System.Drawing.Color.Azure;
            this.btnConfirmSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmSearch.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmSearch.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnConfirmSearch.Location = new System.Drawing.Point(307, 104);
            this.btnConfirmSearch.Name = "btnConfirmSearch";
            this.btnConfirmSearch.Size = new System.Drawing.Size(52, 34);
            this.btnConfirmSearch.TabIndex = 4;
            this.btnConfirmSearch.Text = "OK";
            this.btnConfirmSearch.UseVisualStyleBackColor = false;
            this.btnConfirmSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboMemID
            // 
            this.cboMemID.DropDownWidth = 60;
            this.cboMemID.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMemID.FormattingEnabled = true;
            this.cboMemID.Location = new System.Drawing.Point(488, 93);
            this.cboMemID.Name = "cboMemID";
            this.cboMemID.Size = new System.Drawing.Size(132, 31);
            this.cboMemID.TabIndex = 9;
            this.cboMemID.SelectedIndexChanged += new System.EventHandler(this.cboMemID_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(265, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 41);
            this.label9.TabIndex = 13;
            this.label9.Text = "Membership Type:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // frmRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(804, 731);
            this.Controls.Add(this.grpRentDetails);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpSearchRes);
            this.Controls.Add(this.grpSearch);
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
            this.grpResults.ResumeLayout(false);
            this.grpRentDetails.ResumeLayout(false);
            this.grpRentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnConfirmSO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSearchOpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSearchRes;
        private System.Windows.Forms.ComboBox cboSearchList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.ComboBox cboSearchResults;
        private System.Windows.Forms.Button btnAddToCart;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.Button btnConfirmSearch;
        private System.Windows.Forms.ComboBox cboMemID;
        private System.Windows.Forms.Label label9;
    }
}