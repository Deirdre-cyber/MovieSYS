using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmMemberUpdate : Form
    {
        frmMainMenu parent;

        private Member aMember = new Member();
        private int memId;
        private bool validFirstName = true;
        private bool validLastName = true;
        private bool validContact = true;
        private bool validEmail = true;
        private bool validEircode = true;

        public frmMemberUpdate()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception e)
            {
                Debug.WriteLine("An error has occured\n" + e.ToString());
            }
        }

        public frmMemberUpdate(frmMainMenu Parent)
        {
            try
            {
                InitializeComponent();
                this.parent = Parent;
            }
            catch (Exception e)
            {
                Debug.WriteLine("An error has occured\n" + e.ToString());
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                parent.Visible = true;
            }
            catch (NullReferenceException nre)
            {
                Debug.WriteLine("An error has occured\n" + nre.ToString());
            }
        }

        private void frmMemberUpdate_Load(object sender, EventArgs e)
        {
            grpSearchResults.Visible = false;
            grpEditMem.Visible = false;
            grpMemCheck.Location = new Point(260, 100);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMemberName.Text))
            {
                MessageBox.Show(null, "Please enter the name of a member", "No Search Entered", MessageBoxButtons.OK);
            }
            else
            {
                if (Validation.IsTableEmpty(Member.SearchMember(txtMemberName.Text.ToUpper())))
                {
                    MessageBox.Show(null, "There were no results matching your search", "No Member Found", MessageBoxButtons.OK);
                    txtMemberName.Clear();
                }
                else
                {
                    ShowMemberResults();
                }
                    
            }            
        }

        private void btnEditMem_Click(object sender, EventArgs e)
        {
            try
            {
                if (allValid())
                {
                    Member.UpdateMember(Convert.ToInt32(txtMemId.Text), cboMemID.Text.Substring(0, 2),
                                        txtFirstName.Text, txtLastName.Text, String.Format("{0:dd-MMM-yy}", dtpDOB.Value), txtContactNo.Text,
                                        txtEmail.Text, txtEircode.Text, cboStatus.Text.Substring(0, 1));

                    MessageBox.Show(null, "Member has been updated", "Update Successful", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(null, "Invalid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(null, "Must complete all sections", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show(null, "Must complete all sections", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            ResetUI();
            grpEditMem.Visible = false;
            grpMemCheck.Visible = true;
        }

        private void grdSearchRes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdSearchRes.Rows[grdSearchRes.CurrentCell.RowIndex].Cells[0].Value.ToString() != "")
            {
                LoadMemberDetails();
            }
            else
            {
                MessageBox.Show(null, "Please choose a member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            grdSearchRes.DataSource = null;
            grpSearchResults.Visible = false;
            txtMemberName.Clear();
            grpMemCheck.Visible = true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetUI();
            grpEditMem.Visible = false;
            txtMemberName.Clear();
            grpMemCheck.Visible = true;
        }

        //LOCAL METHODS
        private void LoadStatus()
        {
            cboStatus.Items.Clear();

            char[] status = { 'A', 'I' };

            for (int i = 0; i < status.Length; i++)
            {
                cboStatus.Items.Add(status[i]);
            }

            cboStatus.SelectedIndex = 0;
        }
        private void LoadMemberDetails()
        {
            memId = Convert.ToInt32(grdSearchRes.Rows[grdSearchRes.CurrentCell.RowIndex].Cells[0].Value);

            aMember.GetMemberDetails(memId);

            txtMemId.Text = Convert.ToString(memId);
            cboMemID.Text = aMember.MembershipID;

            DataSet memDS = Utility.getMembershipCodes();
            for (int i = 0; i < memDS.Tables[0].Rows.Count; i++)
                cboMemID.Items.Add(memDS.Tables[0].Rows[i][0] + " - " + memDS.Tables[0].Rows[i][1]);

            txtFirstName.Text = aMember.FirstName;
            txtLastName.Text = aMember.LastName;
            dtpDOB.Value = Convert.ToDateTime(aMember.DOB1);
            txtContactNo.Text = aMember.ContactNo;
            txtEmail.Text = aMember.Email;
            txtEircode.Text = aMember.Eircode;
            dtpStartDate.Value = Convert.ToDateTime(aMember.StartDate);

            LoadStatus();

            grpSearchResults.Visible = false;
            grpEditMem.Visible = true;
        }
        private void ShowMemberResults()
        {
            grdSearchRes.DataSource = Member.SearchMember(txtMemberName.Text.ToUpper()).Tables["search"];
            grdSearchRes.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin", 10);
            grdSearchRes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdSearchRes.DefaultCellStyle.Font = new Font("Franklin", 8);
            grdSearchRes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdSearchRes.DefaultCellStyle.ForeColor = Color.DarkSlateGray;
            grdSearchRes.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdSearchRes.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;

            DataGridViewColumn column = grdSearchRes.Columns[0];
            column.Width = 60;

            grdSearchRes.Size = new Size(720, 350);
            btnReturn.Location = new Point(750, 150);

            grpMemCheck.Visible = false;

            grpSearchResults.Visible = true;
            grpSearchResults.Size = new Size(850, 350);
            grpSearchResults.Location = new Point(100, 100);
        }
        private void ResetUI()      
        {
            Utility.ClearText(this.Controls);
            cboMemID.Text = null;
            dtpStartDate.Value = DateTime.Today;
        }  //universal method

        //VALIDATION
        private bool allValid()
        {
            if (validFirstName && validLastName && validContact && validEmail && validEircode)
                return true;
            else
                return false;
        }
        private void cboMemID_Validating(object sender, CancelEventArgs e)
        {
            if (cboMemID.Text == null && cboMemID.SelectedIndex == -1)
            {
                cboMemID.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(cboMemID, "Must choose category");
            }
            else if (cboMemID.SelectedIndex != -1)
            {
                if (cboMemID.Text.Substring(0, 2).Equals("CH"))
                {
                    dtpDOB.MaxDate = DateTime.Today;
                    dtpDOB.MinDate = DateTime.Today.AddYears(-13);
                    cboMemID.BackColor = Color.White;
                    errorProvider1.Clear();
                }
                else
                {
                    dtpDOB.MaxDate = DateTime.Today.AddYears(-13);
                    dtpDOB.MinDate = new DateTime(1900, 1, 1);
                    cboMemID.BackColor = Color.White;
                    errorProvider1.Clear();
                }
            }
            else
            {
                cboMemID.BackColor = Color.White;
                errorProvider1.Clear();
            }
        }
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                txtFirstName.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtFirstName, "First name should not be left blank");
                validFirstName = false;
            }
            else if (!Validation.HasChars(txtFirstName.Text))
            {
                txtFirstName.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtFirstName, "First name should not contain any digits");
                validFirstName = false;
            }
            else
            {
                txtFirstName.BackColor = Color.White;
                errorProvider1.Clear();
                validFirstName = true;
            }
        }
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                txtLastName.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtLastName, "Last name should not be left blank");
                validLastName = false;
            }
            else if (!Validation.HasChars(txtLastName.Text))
            {
                txtLastName.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtLastName, "Last name should not contain any digits");
                validLastName = false;
            }
            else
            {
                txtLastName.BackColor = Color.White;
                errorProvider1.Clear();
                validLastName = true;
            }
        }
        private void txtContactNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                txtContactNo.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtContactNo, "Contact No should not be left blank");
                validContact = false;
            }
            else if (!Validation.HasDigits(txtContactNo.Text))
            {
                txtContactNo.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtContactNo, "Contact No should contain only digits");
                validContact = false;
            }
            else if (txtContactNo.Text.Length > 10)
            {
                txtContactNo.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtContactNo, "Contact No should only be 10 digits");
                validContact = false;
            }
            else
            {
                txtContactNo.BackColor = Color.White;
                errorProvider1.Clear();
                validContact = true;
            }
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                e.Cancel = true;
                txtEmail.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtEmail, "Email should not be left blank");
                validEmail = false;
            }
            else if (!Validation.IsValidEmail(txtEmail.Text))
            {
                txtEmail.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtEmail, "Email not a valid email address");
                validEmail = false;
            }
            else
            {
                txtEmail.BackColor = Color.White;
                errorProvider1.Clear();
                validEmail = true;
            }
        }
        private void txtEircode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEircode.Text))
            {
                txtEircode.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtEircode, "Eircode should not be left blank");
                validEircode = false;
            }
            else if (!Validation.IsValidEircode(txtEircode.Text))
            {
                txtEircode.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtEircode, "Eircode not valid");
                validEircode = false;
            }
            else
            {
                txtEircode.BackColor = Color.White;
                errorProvider1.Clear();
                validEircode = true;
            }
        }
        private void dtpStartDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpStartDate.Value >= DateTime.Today)
            {
                dtpStartDate.BackColor = Color.White;
                errorProvider1.Clear();
            }
            else
            {
                dtpStartDate.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(dtpStartDate, "Start date must be not in the past");
            }
        }

    }
}