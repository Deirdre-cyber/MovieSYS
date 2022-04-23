using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmMemberAdd : Form
    {

        frmMainMenu parent;
        private bool validFirstName = false;
        private bool validLastName = false;
        private bool validNumber = false;
        private bool validEmail = false;
        private bool validEircode = false;
        private string message;

        public frmMemberAdd()
        {
            try
            {
                InitializeComponent();
            }
            catch(Exception e)
            {
                Debug.WriteLine("An error has occured\n" + e.ToString());
            }
        }

        public frmMemberAdd(frmMainMenu Parent)
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

        private void frmMemberAdd_Load(object sender, EventArgs e)
        {
            LoadUI();
        }
        
        private void btnAddMem_Click(object sender, EventArgs e)
        {
            try {
                if (AllValid())
                {
                    AddNewMember();
                    MessageBox.Show(null, "Member has been added successfuly", "New Member Added", MessageBoxButtons.OK);
                    grpReceipt.Visible = true;
                    return;
                }

                MessageBox.Show(null, "Invalid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(null, "Must complete all sections", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception)
            {
                MessageBox.Show(null, "Must complete all sections", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            Utility.SavePdf(CreateMessage("print"));
            Utility.PrintPDFWithAcrobat();
            ResetUI();
        }

        private void btnEmail_Click_1(object sender, EventArgs e)
        {
            Utility.EmailReceipt(CreateMessage("email"));
            MessageBox.Show("Receipt sent to member " + txtFirstName.Text + " " + txtLastName.Text);
            ResetUI();
        }

        //LOCAL METHODS
        private void LoadUI()
        {
            grpReceipt.Visible = false;
            txtMemId.Text = Member.GetNextMemberID().ToString("00000");
            dtpDOB.MaxDate = DateTime.Today.AddYears(-13);
            dtpMemStartDate.MinDate = DateTime.Today;
            dtpMemStartDate.Value = DateTime.Today;
            dtpMemStartDate.MaxDate = DateTime.Today.AddMonths(1);

            DataSet memDS = Utility.GetMembershipCodes();
            for (int i = 0; i < memDS.Tables[0].Rows.Count; i++)
            {
                cboMemID.Items.Add(memDS.Tables[0].Rows[i][0] + " - " + memDS.Tables[0].Rows[i][1]);
            }
        }

        private void AddNewMember()
        {
            Member aMember = new Member(Convert.ToInt32(txtMemId.Text), txtFirstName.Text, txtLastName.Text,
                String.Format("{0:dd-MMM-yy}", dtpDOB.Value), txtContactNo.Text, txtEmail.Text,
                txtEircode.Text, String.Format("{0:dd-MMM-yy}", dtpMemStartDate.Value),
                cboMemID.Text.Substring(0, 2), "A");

            aMember.AddMember();
        }

        private void ResetUI()
        {
            message = "You have created a new account with the following details: ";
            txtMemId.Text = Member.GetNextMemberID().ToString("00000");
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDOB.Value = DateTime.Today.AddYears(-13);
            txtContactNo.Clear();
            txtEmail.Clear();
            txtEircode.Clear();
            dtpMemStartDate.Value = DateTime.Today;
            cboMemID.Text = null;
            cboMemID.Focus();
            grpReceipt.Visible = false;
            grpAddMem.Visible = true;
            grpReceipt.Visible = false;
        }

        private string CreateMessage(String s)
        {
            if (s.Equals("print"))
            {
                message += "<p>Start Date: " + String.Format("{0:dd-MMM-yy}", dtpMemStartDate.Value) +
                      "</p><p>Member Id: " + txtMemId.Text + "</p><p>Membership Type: " + cboMemID.Text.Substring(0, 2) +
                      "</p><p>Name: " + txtFirstName.Text + " " + txtLastName.Text + "</p><p>DOB: " + String.Format("{0:dd-MMM-yy}", dtpDOB.Value) + "</p><p>Contact No: " + txtContactNo.Text + "</p><p>Email: " + txtEmail.Text +
                      "</p><p>Eircode: " + txtEircode.Text + "</p>";

                return message;
            }

            if (s.Equals("email"))
            {
                message += "Start Date: " + String.Format("{0:dd-MMM-yy}", dtpMemStartDate.Value) +
                           "\nMember Id: " + txtMemId.Text + 
                           "\nMembership Type: " + cboMemID.Text.Substring(0, 2) +
                           "\nName: " + txtFirstName.Text + " " + txtLastName.Text + 
                           "\nDOB: " + String.Format("{0:dd-MMM-yy}", dtpDOB.Value) + 
                           "\nContact No: " + txtContactNo.Text + 
                           "\nEmail: " + txtEmail.Text +
                           "\nEircode: " + txtEircode.Text;

                return message;
            }
            return message;
        }

        //VALIDATION
        private bool AllValid()
        {
            if (validFirstName && validLastName && validNumber && validEmail && validEircode)
                return true;

            return false;

        }
        private void CboMemID_Validating(object sender, CancelEventArgs e)
        {
            if (cboMemID.Text == "" && cboMemID.SelectedIndex == -1)
            {
                cboMemID.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(cboMemID, "Must choose membership");
                return;
            }
            if (cboMemID.SelectedIndex != -1)
            {
                SetDobRange();
                return;
            }

            cboMemID.BackColor = Color.White;
            errorProvider1.Clear();

            void SetDobRange()
            {
                if (cboMemID.Text.Substring(0, 2).Equals("CH"))
                {
                    dtpDOB.MaxDate = DateTime.Today;
                    dtpDOB.MinDate = DateTime.Today.AddYears(-13);
                    cboMemID.BackColor = Color.White;
                    errorProvider1.Clear();
                    return;
                }

                dtpDOB.MaxDate = DateTime.Today.AddYears(-13);
                dtpDOB.MinDate = new DateTime(1900, 1, 1);
                cboMemID.BackColor = Color.White;
                errorProvider1.Clear();
            }
        }
        private void TxtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                txtFirstName.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtFirstName, "First name should not be left blank");
                validFirstName = false;
                return;
            }
            if (!Validation.HasChars(txtFirstName.Text))
            {
                txtFirstName.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtFirstName, "First name should not contain any digits");
                validFirstName = false;
                return;
            }

            txtFirstName.BackColor = Color.White;
            errorProvider1.Clear();
            validFirstName = true;
        }
        private void TxtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                txtLastName.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtLastName, "Last name should not be left blank");
                validLastName = false;
                return;
            }
            if (!Validation.HasChars(txtLastName.Text))
            {
                txtLastName.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtLastName, "Last name should not contain any digits");
                validLastName = false;
                return;
            }

            txtLastName.BackColor = Color.White;
            errorProvider1.Clear();
            validLastName = true;
        }
        private void TxtContactNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                txtContactNo.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtContactNo, "Contact No should not be left blank");
                validNumber = false;
                return;
            }
            if (!Validation.IsNumber(txtContactNo.Text))
            //if (!Validation.IsValidPhone(txtContactNo.Text))
            {
                txtContactNo.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtContactNo, "Contact No should be valid phone number");
                validNumber = false;
                return;
            }
            if (txtContactNo.Text.Length < 10)
            {
                txtContactNo.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtContactNo, "Contact No should contain 10 digits");
                validNumber = false;
                return;
            }

            txtContactNo.BackColor = Color.White;
            errorProvider1.Clear();
            validNumber = true;
        }
        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtEmail, "Email should not be left blank");
                validEmail = false;
                return;
            }
            if (!Validation.IsValidEmail(txtEmail.Text))
            {
                txtEmail.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtEmail, "Email not a valid email address");
                validEmail = false;
                return;
            }
            if (Validation.EmailExists(txtEmail.Text))
            {
                txtEmail.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtEmail, "Email already exists");
                validEmail = false;
                return;
            }

            txtEmail.BackColor = Color.White;
            errorProvider1.Clear();
            validEmail = true;
        }
        private void TxtEircode_Validating(object sender, CancelEventArgs e)
        {
            txtEircode.Text = txtEircode.Text.ToUpper();
            txtEircode.Text = txtEircode.Text.Replace(" ", "");

            if (string.IsNullOrWhiteSpace(txtEircode.Text))
            {
                txtEircode.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtEircode, "Eircode should not be left blank");
                validEircode = false;
                return;
            }
            if (!Validation.IsValidEircode(txtEircode.Text))
            {
                txtEircode.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtEircode, "Eircode not valid");
                validEircode = false;
                return;
            }

            txtEircode.BackColor = Color.White;
            errorProvider1.Clear();
            validEircode = true;
        }
        private void DtpMemStartDate_Validating(object sender, CancelEventArgs e)
        {
            if(dtpMemStartDate.Value >= DateTime.Today)
            {
                dtpMemStartDate.BackColor = Color.White;
                errorProvider1.Clear();
                return;
            }

            dtpMemStartDate.BackColor = Color.DarkSalmon;
            errorProvider1.SetError(dtpMemStartDate, "Start date must be not in the past");
        }
    }
}