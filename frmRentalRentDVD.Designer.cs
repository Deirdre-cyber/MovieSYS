
namespace MovieSYS
{
    partial class frmRentalRentDVD
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
            this.grpRefine = new System.Windows.Forms.GroupBox();
            this.cboRefineOptions = new System.Windows.Forms.ComboBox();
            this.lblRefine = new System.Windows.Forms.Label();
            this.btnConfirmRefine = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnAddtoCart1 = new System.Windows.Forms.Button();
            this.btnRefine = new System.Windows.Forms.Button();
            this.cboSearchList = new System.Windows.Forms.ComboBox();
            this.grpRentDetails = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDueBack = new System.Windows.Forms.Label();
            this.lblRentedOn = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dtpDueBack = new System.Windows.Forms.DateTimePicker();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpMemCheck = new System.Windows.Forms.GroupBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.mnuAdd.SuspendLayout();
            this.grpRefine.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpRentDetails.SuspendLayout();
            this.grpMemCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAdd
            // 
            this.mnuAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuAdd.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuAdd.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuAdd.Location = new System.Drawing.Point(0, 0);
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.mnuAdd.Size = new System.Drawing.Size(1000, 35);
            this.mnuAdd.TabIndex = 16;
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
            // grpRefine
            // 
            this.grpRefine.Controls.Add(this.cboRefineOptions);
            this.grpRefine.Controls.Add(this.lblRefine);
            this.grpRefine.Controls.Add(this.btnConfirmRefine);
            this.grpRefine.Controls.Add(this.label5);
            this.grpRefine.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpRefine.ForeColor = System.Drawing.Color.Azure;
            this.grpRefine.Location = new System.Drawing.Point(474, 38);
            this.grpRefine.Name = "grpRefine";
            this.grpRefine.Size = new System.Drawing.Size(350, 155);
            this.grpRefine.TabIndex = 0;
            this.grpRefine.TabStop = false;
            this.grpRefine.Text = "Refine Options";
            this.grpRefine.Enter += new System.EventHandler(this.grpSearch_Enter);
            // 
            // cboRefineOptions
            // 
            this.cboRefineOptions.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboRefineOptions.FormattingEnabled = true;
            this.cboRefineOptions.Location = new System.Drawing.Point(128, 56);
            this.cboRefineOptions.Name = "cboRefineOptions";
            this.cboRefineOptions.Size = new System.Drawing.Size(180, 31);
            this.cboRefineOptions.TabIndex = 27;
            this.cboRefineOptions.Text = "Titles";
            this.cboRefineOptions.SelectedIndexChanged += new System.EventHandler(this.cboRefineOptions_SelectedIndexChanged);
            // 
            // lblRefine
            // 
            this.lblRefine.AutoSize = true;
            this.lblRefine.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRefine.ForeColor = System.Drawing.Color.Azure;
            this.lblRefine.Location = new System.Drawing.Point(20, 54);
            this.lblRefine.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRefine.Name = "lblRefine";
            this.lblRefine.Size = new System.Drawing.Size(109, 28);
            this.lblRefine.TabIndex = 26;
            this.lblRefine.Text = "Search by:";
            this.lblRefine.Click += new System.EventHandler(this.lblRefine_Click);
            // 
            // btnConfirmRefine
            // 
            this.btnConfirmRefine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmRefine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmRefine.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmRefine.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnConfirmRefine.Location = new System.Drawing.Point(232, 104);
            this.btnConfirmRefine.Name = "btnConfirmRefine";
            this.btnConfirmRefine.Size = new System.Drawing.Size(100, 35);
            this.btnConfirmRefine.TabIndex = 7;
            this.btnConfirmRefine.Text = "Refine";
            this.btnConfirmRefine.UseVisualStyleBackColor = false;
            this.btnConfirmRefine.Click += new System.EventHandler(this.btnConfirmRefine_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(232, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 31);
            this.label5.TabIndex = 25;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnAddtoCart1);
            this.grpSearch.Controls.Add(this.btnRefine);
            this.grpSearch.Controls.Add(this.cboSearchList);
            this.grpSearch.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpSearch.ForeColor = System.Drawing.Color.Azure;
            this.grpSearch.Location = new System.Drawing.Point(93, 38);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(350, 155);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            this.grpSearch.Enter += new System.EventHandler(this.grpSearchRes_Enter);
            // 
            // btnAddtoCart1
            // 
            this.btnAddtoCart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddtoCart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtoCart1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddtoCart1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddtoCart1.Location = new System.Drawing.Point(261, 104);
            this.btnAddtoCart1.Name = "btnAddtoCart1";
            this.btnAddtoCart1.Size = new System.Drawing.Size(70, 35);
            this.btnAddtoCart1.TabIndex = 6;
            this.btnAddtoCart1.Text = "Add to Cart";
            this.btnAddtoCart1.UseVisualStyleBackColor = false;
            this.btnAddtoCart1.Click += new System.EventHandler(this.btnAddtoCart1_Click);
            // 
            // btnRefine
            // 
            this.btnRefine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefine.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefine.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRefine.Location = new System.Drawing.Point(145, 104);
            this.btnRefine.Name = "btnRefine";
            this.btnRefine.Size = new System.Drawing.Size(100, 35);
            this.btnRefine.TabIndex = 4;
            this.btnRefine.Text = "Refine Search";
            this.btnRefine.UseVisualStyleBackColor = false;
            this.btnRefine.Click += new System.EventHandler(this.btnRefine_Click);
            // 
            // cboSearchList
            // 
            this.cboSearchList.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSearchList.FormattingEnabled = true;
            this.cboSearchList.Location = new System.Drawing.Point(32, 51);
            this.cboSearchList.Name = "cboSearchList";
            this.cboSearchList.Size = new System.Drawing.Size(180, 31);
            this.cboSearchList.TabIndex = 3;
            this.cboSearchList.Text = "DVD Titles";
            this.cboSearchList.SelectedIndexChanged += new System.EventHandler(this.cboList_SelectedIndexChanged);
            // 
            // grpRentDetails
            // 
            this.grpRentDetails.Controls.Add(this.lblTotal);
            this.grpRentDetails.Controls.Add(this.lblDueBack);
            this.grpRentDetails.Controls.Add(this.lblRentedOn);
            this.grpRentDetails.Controls.Add(this.lblCart);
            this.grpRentDetails.Controls.Add(this.btnRemove);
            this.grpRentDetails.Controls.Add(this.btnCancel);
            this.grpRentDetails.Controls.Add(this.btnBuy);
            this.grpRentDetails.Controls.Add(this.lstCart);
            this.grpRentDetails.Controls.Add(this.txtPrice);
            this.grpRentDetails.Controls.Add(this.dtpDueBack);
            this.grpRentDetails.Controls.Add(this.dtpRentDate);
            this.grpRentDetails.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpRentDetails.ForeColor = System.Drawing.Color.GhostWhite;
            this.grpRentDetails.Location = new System.Drawing.Point(93, 360);
            this.grpRentDetails.Name = "grpRentDetails";
            this.grpRentDetails.Size = new System.Drawing.Size(746, 334);
            this.grpRentDetails.TabIndex = 0;
            this.grpRentDetails.TabStop = false;
            this.grpRentDetails.Text = "Order Details";
            this.grpRentDetails.Enter += new System.EventHandler(this.grpRentDetails_Enter);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(490, 156);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 28);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblDueBack
            // 
            this.lblDueBack.AutoSize = true;
            this.lblDueBack.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDueBack.Location = new System.Drawing.Point(446, 107);
            this.lblDueBack.Name = "lblDueBack";
            this.lblDueBack.Size = new System.Drawing.Size(113, 28);
            this.lblDueBack.TabIndex = 20;
            this.lblDueBack.Text = "Return On:";
            this.lblDueBack.Click += new System.EventHandler(this.lblDueBack_Click);
            // 
            // lblRentedOn
            // 
            this.lblRentedOn.AutoSize = true;
            this.lblRentedOn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRentedOn.Location = new System.Drawing.Point(446, 66);
            this.lblRentedOn.Name = "lblRentedOn";
            this.lblRentedOn.Size = new System.Drawing.Size(113, 28);
            this.lblRentedOn.TabIndex = 19;
            this.lblRentedOn.Text = "Rented on:";
            this.lblRentedOn.Click += new System.EventHandler(this.lblRentedOn_Click);
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCart.Location = new System.Drawing.Point(32, 66);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(57, 28);
            this.lblCart.TabIndex = 16;
            this.lblCart.Text = "Cart:";
            this.lblCart.Click += new System.EventHandler(this.lblCart_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnRemove.Location = new System.Drawing.Point(112, 276);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 35);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancel.Location = new System.Drawing.Point(488, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuy.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuy.Location = new System.Drawing.Point(623, 276);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(100, 35);
            this.btnBuy.TabIndex = 15;
            this.btnBuy.Text = "Purchase";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lstCart
            // 
            this.lstCart.Font = new System.Drawing.Font("Nirmala UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstCart.ForeColor = System.Drawing.Color.DarkSlateGray;
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
            this.txtPrice.Location = new System.Drawing.Point(565, 156);
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
            this.dtpDueBack.Location = new System.Drawing.Point(565, 105);
            this.dtpDueBack.Name = "dtpDueBack";
            this.dtpDueBack.Size = new System.Drawing.Size(110, 30);
            this.dtpDueBack.TabIndex = 12;
            this.dtpDueBack.Value = new System.DateTime(2021, 11, 18, 0, 0, 0, 0);
            this.dtpDueBack.ValueChanged += new System.EventHandler(this.dtpDueBack_ValueChanged);
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentDate.Location = new System.Drawing.Point(565, 64);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(110, 30);
            this.dtpRentDate.TabIndex = 11;
            this.dtpRentDate.ValueChanged += new System.EventHandler(this.dtpRentDate_ValueChanged);
            // 
            // grpMemCheck
            // 
            this.grpMemCheck.Controls.Add(this.lblMemberId);
            this.grpMemCheck.Controls.Add(this.btnCheck);
            this.grpMemCheck.Controls.Add(this.txtMemId);
            this.grpMemCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.grpMemCheck.Location = new System.Drawing.Point(279, 199);
            this.grpMemCheck.Name = "grpMemCheck";
            this.grpMemCheck.Size = new System.Drawing.Size(350, 155);
            this.grpMemCheck.TabIndex = 0;
            this.grpMemCheck.TabStop = false;
            this.grpMemCheck.Enter += new System.EventHandler(this.grpMemCheck_Enter);
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMemberId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMemberId.Location = new System.Drawing.Point(66, 59);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(123, 28);
            this.lblMemberId.TabIndex = 3;
            this.lblMemberId.Text = "Member ID:";
            this.lblMemberId.Click += new System.EventHandler(this.lblMemberId_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCheck.Location = new System.Drawing.Point(109, 104);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(145, 35);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check Account";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtMemId
            // 
            this.txtMemId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemId.Location = new System.Drawing.Point(195, 59);
            this.txtMemId.MaxLength = 8;
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.PlaceholderText = "00000001";
            this.txtMemId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMemId.Size = new System.Drawing.Size(114, 30);
            this.txtMemId.TabIndex = 1;
            this.txtMemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMemId.TextChanged += new System.EventHandler(this.txtMemId_TextChanged);
            // 
            // frmRentalRentDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.grpMemCheck);
            this.Controls.Add(this.grpRentDetails);
            this.Controls.Add(this.grpRefine);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.mnuAdd);
            this.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmRentalRentDVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRent_Load);
            this.mnuAdd.ResumeLayout(false);
            this.mnuAdd.PerformLayout();
            this.grpRefine.ResumeLayout(false);
            this.grpRefine.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpRentDetails.ResumeLayout(false);
            this.grpRentDetails.PerformLayout();
            this.grpMemCheck.ResumeLayout(false);
            this.grpMemCheck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpRefine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.GroupBox grpRentDetails;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dtpDueBack;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.Button btnConfirmRefine;
        private System.Windows.Forms.Button btnRefine;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpMemCheck;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.ComboBox cboSearchList;
        private System.Windows.Forms.Button btnAddtoCart1;
        private System.Windows.Forms.Label lblRefine;
        private System.Windows.Forms.ComboBox cboRefineOptions;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblRentedOn;
        private System.Windows.Forms.Label lblDueBack;
        private System.Windows.Forms.Label lblTotal;
    }
}