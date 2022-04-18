
namespace MovieSYS
{
    partial class frmDVDRemove
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
            this.components = new System.ComponentModel.Container();
            this.grpRemove = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grdDVDList = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDVDTitle = new System.Windows.Forms.TextBox();
            this.lblEnterTitle = new System.Windows.Forms.Label();
            this.mnuRemove = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.lblCopies = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.txtDVDId = new System.Windows.Forms.TextBox();
            this.lblDvdId = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblDateAdd = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cboAge = new System.Windows.Forms.ComboBox();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMins = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtDVDName = new System.Windows.Forms.TextBox();
            this.grpRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDVDList)).BeginInit();
            this.mnuRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRemove
            // 
            this.grpRemove.BackColor = System.Drawing.Color.LightSlateGray;
            this.grpRemove.Controls.Add(this.btnClear);
            this.grpRemove.Controls.Add(this.grdDVDList);
            this.grpRemove.Controls.Add(this.btnSearch);
            this.grpRemove.Controls.Add(this.txtDVDTitle);
            this.grpRemove.Controls.Add(this.lblEnterTitle);
            this.grpRemove.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpRemove.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpRemove.Location = new System.Drawing.Point(138, 79);
            this.grpRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRemove.Name = "grpRemove";
            this.grpRemove.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRemove.Size = new System.Drawing.Size(722, 291);
            this.grpRemove.TabIndex = 1;
            this.grpRemove.TabStop = false;
            this.grpRemove.Text = "Remove DVD";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnClear.Location = new System.Drawing.Point(606, 34);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 41);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grdDVDList
            // 
            this.grdDVDList.AllowUserToAddRows = false;
            this.grdDVDList.AllowUserToDeleteRows = false;
            this.grdDVDList.AllowUserToResizeColumns = false;
            this.grdDVDList.AllowUserToResizeRows = false;
            this.grdDVDList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdDVDList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDVDList.Location = new System.Drawing.Point(104, 95);
            this.grdDVDList.Name = "grdDVDList";
            this.grdDVDList.RowHeadersVisible = false;
            this.grdDVDList.RowHeadersWidth = 51;
            this.grdDVDList.RowTemplate.Height = 29;
            this.grdDVDList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDVDList.Size = new System.Drawing.Size(512, 168);
            this.grdDVDList.TabIndex = 8;
            this.grdDVDList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDVDList_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSearch.Location = new System.Drawing.Point(487, 34);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 41);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDVDTitle
            // 
            this.txtDVDTitle.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDVDTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtDVDTitle.Location = new System.Drawing.Point(158, 40);
            this.txtDVDTitle.Name = "txtDVDTitle";
            this.txtDVDTitle.Size = new System.Drawing.Size(302, 30);
            this.txtDVDTitle.TabIndex = 3;
            // 
            // lblEnterTitle
            // 
            this.lblEnterTitle.AutoSize = true;
            this.lblEnterTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnterTitle.Location = new System.Drawing.Point(25, 41);
            this.lblEnterTitle.Name = "lblEnterTitle";
            this.lblEnterTitle.Size = new System.Drawing.Size(129, 28);
            this.lblEnterTitle.TabIndex = 2;
            this.lblEnterTitle.Text = "Search Title:";
            // 
            // mnuRemove
            // 
            this.mnuRemove.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mnuRemove.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuRemove.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuRemove.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuRemove.Location = new System.Drawing.Point(0, 0);
            this.mnuRemove.Name = "mnuRemove";
            this.mnuRemove.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnuRemove.Size = new System.Drawing.Size(1000, 33);
            this.mnuRemove.TabIndex = 8;
            this.mnuRemove.Text = "Exit";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.BackColor = System.Drawing.Color.Transparent;
            this.mnuExit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnuExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(35, 27);
            this.mnuExit.Text = "X";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grpDetails
            // 
            this.grpDetails.BackColor = System.Drawing.Color.LightSlateGray;
            this.grpDetails.Controls.Add(this.txtCopies);
            this.grpDetails.Controls.Add(this.lblCopies);
            this.grpDetails.Controls.Add(this.lblGenre);
            this.grpDetails.Controls.Add(this.cboGenre);
            this.grpDetails.Controls.Add(this.txtDVDId);
            this.grpDetails.Controls.Add(this.lblDvdId);
            this.grpDetails.Controls.Add(this.dtpDate);
            this.grpDetails.Controls.Add(this.lblAgeRating);
            this.grpDetails.Controls.Add(this.lblCountry);
            this.grpDetails.Controls.Add(this.lblDateAdd);
            this.grpDetails.Controls.Add(this.lblDuration);
            this.grpDetails.Controls.Add(this.lblYear);
            this.grpDetails.Controls.Add(this.lblCategory);
            this.grpDetails.Controls.Add(this.lblTitle);
            this.grpDetails.Controls.Add(this.txtYear);
            this.grpDetails.Controls.Add(this.cboAge);
            this.grpDetails.Controls.Add(this.cboCat);
            this.grpDetails.Controls.Add(this.cboCountry);
            this.grpDetails.Controls.Add(this.btnDelete);
            this.grpDetails.Controls.Add(this.lblMins);
            this.grpDetails.Controls.Add(this.txtDuration);
            this.grpDetails.Controls.Add(this.txtDVDName);
            this.grpDetails.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpDetails.Location = new System.Drawing.Point(48, 377);
            this.grpDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDetails.Size = new System.Drawing.Size(904, 321);
            this.grpDetails.TabIndex = 9;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "DVD Details";
            // 
            // txtCopies
            // 
            this.txtCopies.BackColor = System.Drawing.SystemColors.Window;
            this.txtCopies.Enabled = false;
            this.txtCopies.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCopies.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCopies.Location = new System.Drawing.Point(670, 165);
            this.txtCopies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCopies.MaxLength = 2;
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.PlaceholderText = "0";
            this.txtCopies.Size = new System.Drawing.Size(57, 30);
            this.txtCopies.TabIndex = 10;
            this.txtCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCopies.Location = new System.Drawing.Point(577, 167);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(79, 28);
            this.lblCopies.TabIndex = 24;
            this.lblCopies.Text = "Copies:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenre.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblGenre.Location = new System.Drawing.Point(138, 183);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(73, 28);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "Genre:";
            // 
            // cboGenre
            // 
            this.cboGenre.Enabled = false;
            this.cboGenre.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboGenre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(224, 175);
            this.cboGenre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(205, 31);
            this.cboGenre.TabIndex = 4;
            // 
            // txtDVDId
            // 
            this.txtDVDId.Enabled = false;
            this.txtDVDId.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDVDId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDVDId.Location = new System.Drawing.Point(224, 49);
            this.txtDVDId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDVDId.MaxLength = 4;
            this.txtDVDId.Name = "txtDVDId";
            this.txtDVDId.Size = new System.Drawing.Size(66, 30);
            this.txtDVDId.TabIndex = 1;
            // 
            // lblDvdId
            // 
            this.lblDvdId.AutoSize = true;
            this.lblDvdId.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDvdId.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblDvdId.Location = new System.Drawing.Point(126, 56);
            this.lblDvdId.Name = "lblDvdId";
            this.lblDvdId.Size = new System.Drawing.Size(87, 28);
            this.lblDvdId.TabIndex = 2;
            this.lblDvdId.Text = "DVD ID:";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.dtpDate.CalendarTitleBackColor = System.Drawing.Color.LightSlateGray;
            this.dtpDate.CalendarTitleForeColor = System.Drawing.Color.LightSlateGray;
            this.dtpDate.Enabled = false;
            this.dtpDate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.Location = new System.Drawing.Point(670, 127);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.MaxDate = new System.DateTime(2099, 2, 4, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(2020, 12, 25, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(159, 30);
            this.dtpDate.TabIndex = 9;
            this.dtpDate.Value = new System.DateTime(2022, 1, 27, 0, 0, 0, 0);
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.AutoSize = true;
            this.lblAgeRating.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAgeRating.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblAgeRating.Location = new System.Drawing.Point(94, 264);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(122, 28);
            this.lblAgeRating.TabIndex = 20;
            this.lblAgeRating.Text = "Age Rating:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountry.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblCountry.Location = new System.Drawing.Point(119, 220);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(93, 28);
            this.lblCountry.TabIndex = 18;
            this.lblCountry.Text = "Country:";
            // 
            // lblDateAdd
            // 
            this.lblDateAdd.AutoSize = true;
            this.lblDateAdd.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateAdd.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblDateAdd.Location = new System.Drawing.Point(533, 128);
            this.lblDateAdd.Name = "lblDateAdd";
            this.lblDateAdd.Size = new System.Drawing.Size(129, 28);
            this.lblDateAdd.TabIndex = 16;
            this.lblDateAdd.Text = "Date Added:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDuration.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblDuration.Location = new System.Drawing.Point(558, 92);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(101, 28);
            this.lblDuration.TabIndex = 14;
            this.lblDuration.Text = "Duration:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(597, 49);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(58, 28);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Year:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.Location = new System.Drawing.Point(110, 139);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(103, 28);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTitle.Location = new System.Drawing.Point(151, 97);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(60, 28);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title:";
            // 
            // txtYear
            // 
            this.txtYear.Enabled = false;
            this.txtYear.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtYear.Location = new System.Drawing.Point(670, 48);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(57, 30);
            this.txtYear.TabIndex = 7;
            // 
            // cboAge
            // 
            this.cboAge.Enabled = false;
            this.cboAge.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboAge.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboAge.FormattingEnabled = true;
            this.cboAge.Location = new System.Drawing.Point(224, 263);
            this.cboAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboAge.Name = "cboAge";
            this.cboAge.Size = new System.Drawing.Size(57, 31);
            this.cboAge.TabIndex = 6;
            // 
            // cboCat
            // 
            this.cboCat.Enabled = false;
            this.cboCat.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCat.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(224, 131);
            this.cboCat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(205, 31);
            this.cboCat.TabIndex = 3;
            // 
            // cboCountry
            // 
            this.cboCountry.Enabled = false;
            this.cboCountry.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCountry.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(224, 219);
            this.cboCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(205, 31);
            this.cboCountry.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.Location = new System.Drawing.Point(750, 253);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 39);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMins
            // 
            this.lblMins.AutoSize = true;
            this.lblMins.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMins.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblMins.Location = new System.Drawing.Point(734, 92);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(54, 25);
            this.lblMins.TabIndex = 0;
            this.lblMins.Text = "mins";
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.SystemColors.Window;
            this.txtDuration.Enabled = false;
            this.txtDuration.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDuration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDuration.Location = new System.Drawing.Point(670, 85);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDuration.MaxLength = 3;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.PlaceholderText = "0";
            this.txtDuration.Size = new System.Drawing.Size(57, 30);
            this.txtDuration.TabIndex = 8;
            this.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDVDName
            // 
            this.txtDVDName.BackColor = System.Drawing.SystemColors.Window;
            this.txtDVDName.Enabled = false;
            this.txtDVDName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDVDName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDVDName.Location = new System.Drawing.Point(224, 91);
            this.txtDVDName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDVDName.MaxLength = 50;
            this.txtDVDName.Name = "txtDVDName";
            this.txtDVDName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDVDName.Size = new System.Drawing.Size(205, 30);
            this.txtDVDName.TabIndex = 2;
            // 
            // frmDVDRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpRemove);
            this.Controls.Add(this.mnuRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnuRemove;
            this.Name = "frmDVDRemove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove a DVD";
            this.Load += new System.EventHandler(this.frmDVDRemove_Load);
            this.grpRemove.ResumeLayout(false);
            this.grpRemove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDVDList)).EndInit();
            this.mnuRemove.ResumeLayout(false);
            this.mnuRemove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpRemove;
        private System.Windows.Forms.MenuStrip mnuRemove;
        private System.Windows.Forms.TextBox txtDVDTitle;
        private System.Windows.Forms.Label lblEnterTitle;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grdDVDList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.TextBox txtDVDId;
        private System.Windows.Forms.Label lblDvdId;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblAgeRating;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblDateAdd;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cboAge;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtDVDName;
        private System.Windows.Forms.Button btnClear;
    }
}