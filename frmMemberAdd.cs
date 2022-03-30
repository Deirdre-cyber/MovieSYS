using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

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
            txtMemId.Text = Member.GetNextMemberID().ToString("00000");

            grpReceipt.Visible = true;
            grpAddMem.Visible = false; 
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            //ironpdf.com/docs/questions/csharp-print-pdf/
            //printReceipt();
            MessageBox.Show(null, "Receipt sent to printer", "Print", MessageBoxButtons.OK);
            grpReceipt.Visible = false;
            ResetUI();
            //txtMemId.Text = Member.getNextMemberID().ToString("00000");
            grpAddMem.Visible = true;
        }

        private void btnEmail_Click_1(object sender, EventArgs e)
        {
            //docs.microsoft.com/en-us/visualstudio/vsto/how-to-programmatically-send-e-mail-programmatically?view=vs-2022
            //emailReceipt();
            MessageBox.Show(null, "Receipt sent to member", "Email", MessageBoxButtons.OK);
            grpReceipt.Visible = false;
            ResetUI();
            //txtMemId.Text = Member.getNextMemberID().ToString("00000");
            grpAddMem.Visible = true;

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

            DataSet memDS = Utility.getMembershipCodes();
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
        private void ResetUI()    //Universal Method for Reset UI
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDOB.Value = DateTime.Today.AddYears(-13);
            txtContactNo.Clear();
            txtEmail.Clear();
            txtEircode.Clear();
            dtpMemStartDate.Value = DateTime.Today;
            cboMemID.Text = null;
            cboMemID.Focus();
        }

        //private void printReceipt(){}
        //private void emailReceipt(){}



        //VALIDATION
        private bool AllValid()
        {
            if (validFirstName && validLastName && validNumber && validEmail && validEircode)
                return true;
            else
                return false;
        }
        private void cboMemID_Validating(object sender, CancelEventArgs e)
        {
            if (cboMemID.Text == null && cboMemID.SelectedIndex == -1)
            {
                cboMemID.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(cboMemID, "Must choose membership");
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
                validNumber = false;
            }
            else if (!Validation.HasDigits(txtContactNo.Text))
            {
                txtContactNo.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtContactNo, "Contact No should contain only digits");
                validNumber = false;
            }
            else if (txtContactNo.Text.Length < 10)
            {
                txtContactNo.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtContactNo, "Contact No should contain 10 digits");
                validNumber = false;
            }
            else
            {
                txtContactNo.BackColor = Color.White;
                errorProvider1.Clear();
                validNumber = true;
            }
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
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
            else if (Validation.EmailExists(txtEmail.Text))
            {
                txtEmail.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtEmail, "Email already exists");
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
        private void dtpMemStartDate_Validating(object sender, CancelEventArgs e)
        {
            if(dtpMemStartDate.Value >= DateTime.Today)
            {
                dtpMemStartDate.BackColor = Color.White;
                errorProvider1.Clear();
            }
            else
            {
                dtpMemStartDate.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(dtpMemStartDate, "Start date must be not in the past");
            }
        }
    }
}