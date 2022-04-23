using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmCustomerStatement : Form
    {
        frmMainMenu parent;
        private Member aMember = new Member();
        private int memId;
        private int currentYear = DateTime.Today.Year;
        private DateTime startYear = new DateTime();
        private string message;

        public frmCustomerStatement()
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

        public frmCustomerStatement(frmMainMenu Parent)
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

        private void frmCustomerStatement_Load(object sender, EventArgs e)
        {
            LoadUI();
        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMemberName.Text))
            {
                MessageBox.Show(null, "Please enter the name of a member", "No Search Entered", MessageBoxButtons.OK);
                return;
            }

            if (Validation.IsTableEmpty(Member.SearchMember(txtMemberName.Text.ToUpper())))
            {
                MessageBox.Show(null, "There were no results matching your search", "No Member Found", MessageBoxButtons.OK);
                txtMemberName.Clear();
                return;
            }

            ShowMemberResults();

        }

        private void grdSearchRes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (grdSearchRes.Rows[grdSearchRes.CurrentCell.RowIndex].Cells[0].Value.ToString() != "")
            {
                LoadStatementDatePicker();
                return;
            }

            MessageBox.Show(null, "Please choose a member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnViewStatement_Click(object sender, EventArgs e)
        {
            LoadStatementDetails();
        }

        private void optYear_CheckedChanged(object sender, EventArgs e)
        {
            CheckStatementPeriod();
        }

        private void optQuarter_CheckedChanged(object sender, EventArgs e)
        {
            CheckStatementPeriod();
        }

        private void optStart_CheckedChanged(object sender, EventArgs e)
        {
            CheckStatementPeriod();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckStatementPeriod();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            if (grpSearchResults.Visible || grpStatementPeriod.Visible)
            {
                mnuBack.Visible = false;
                grpSearchResults.Visible = false;
                grpStatementPeriod.Visible = false;
                txtMemberName.Clear();
                grpMemCheck.Visible = true;
                return;
            }

            if (grpStatementDetails.Visible)
            {
                grpStatementDetails.Visible = false;
                grpSearchResults.Visible = true;
                grpStatementPeriod.Visible = true;
                return;
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            Utility.EmailReceipt(CreateMessage("email"));
            MessageBox.Show(null, "Statement sent to member", "Email Sent", MessageBoxButtons.OK);
            LoadUI();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Utility.SavePdf(CreateMessage("print"));
            Utility.PrintPDFWithAcrobat();
            LoadUI();
        }

        //LOCAL METHODS

        private void LoadUI()
        {
            this.Height = 600;
            mnuBack.Visible = false;
            grpSearchResults.Visible = false;
            grpStatementDetails.Visible = false;
            grpStatementPeriod.Visible = false;

            HideRadioButtons();
            HideTextBoxes();

            grpMemCheck.Location = new Point(300, 100);
        }

        private void ShowMemberResults()
        {
            grpMemCheck.Visible = false;
            mnuBack.Visible = true;
            SetMemberGridAttributes();

            grdSearchRes.Size = new Size(840, 150);
            grpSearchResults.Size = new Size(850, 200);
            grpSearchResults.Location = new Point(100, 100);
            grpSearchResults.Visible = true;
        }

        private void SetMemberGridAttributes()
        {
            grdSearchRes.DataSource = Member.SearchMember(txtMemberName.Text.ToUpper()).Tables["search"];
            grdSearchRes.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin", 10);
            grdSearchRes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdSearchRes.DefaultCellStyle.Font = new Font("Franklin", 8);
            grdSearchRes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdSearchRes.DefaultCellStyle.ForeColor = Color.DarkSlateGray;
            grdSearchRes.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grdSearchRes.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;
        }

        private void LoadStatementDatePicker()
        {
            memId = Convert.ToInt32(grdSearchRes.Rows[grdSearchRes.CurrentCell.RowIndex].Cells[0].Value);
            aMember.GetMemberDetails(memId);

            cboYear.Items.Clear();
            LoadYears();
            ShowRadioButtons();

            dtpStatementFrom.Visible = false;
            dtpStatementTo.Visible = false;

            grpStatementPeriod.Location = new Point(100, 400);
            grpStatementPeriod.Visible = true;
        }

        private void LoadYears()
        {
            int Years = currentYear - Convert.ToDateTime(aMember.StartDate).Year;

            for (int i = 0; i <= Years; i++)
            {
                cboYear.Items.Add(Convert.ToString(currentYear - i));
            }

            cboYear.Text = currentYear.ToString();
        }

        private void LoadStatementDetails()
        {
            if (optYear.Checked || optStart.Checked || optCustom.Checked)
            {
                PopulateTextBoxes();

                this.Height = 900;

                ShowTextBoxes();
                LoadReturnedDvdGrid();
                LoadRentedDvdGrid();

                grpSearchResults.Visible = false;
                grpStatementPeriod.Visible = false;
                grpStatementDetails.Visible = true;
                grpStatementDetails.Location = new Point(50, 100);
                return;
            }

            MessageBox.Show(null, "Please select a statement period option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            cboYear.Focus();
        }

        private void LoadReturnedDvdGrid()
        {
            grdReturned.DataSource = aMember.GetReturnedDVDsForPeriod(memId, String.Format("{0:dd-MMM-yy}", dtpStatementFrom.Value), String.Format("{0:dd-MMM-yy}", dtpStatementTo.Value)).Tables["returned"];

            grdReturned.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin", 10);
            grdReturned.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdReturned.DefaultCellStyle.Font = new Font("Franklin", 10);
            grdReturned.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdReturned.DefaultCellStyle.ForeColor = Color.DarkSlateGray;
            grdReturned.DefaultCellStyle.SelectionForeColor = Color.DarkSlateGray;
            grdReturned.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
        }

        private void LoadRentedDvdGrid()
        {
            grdRented.DataSource = aMember.GetRentedDVDsForPeriod(memId, String.Format("{0:dd-MMM-yy}", dtpStatementFrom.Value), String.Format("{0:dd-MMM-yy}", dtpStatementTo.Value)).Tables["rented"];

            grdRented.ColumnHeadersDefaultCellStyle.Font = new Font("Franklin", 10);
            grdRented.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdRented.DefaultCellStyle.Font = new Font("Franklin", 10);
            grdRented.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdRented.DefaultCellStyle.ForeColor = Color.DarkSlateGray;
            grdRented.DefaultCellStyle.SelectionForeColor = Color.DarkSlateGray;
            grdRented.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
        }

        private void PopulateTextBoxes()
        {
            txtMemId.Text = String.Format("{0:00000}", memId);
            txtMembership.Text = aMember.MembershipID;
            txtPeriod.Text = dtpStatementFrom.Text + " - " + dtpStatementTo.Text;
            txtName.Text = aMember.FirstName + " " + aMember.LastName;
            txtEmail.Text = aMember.Email;
            txtContact.Text = aMember.ContactNo;

            float finesPaid = aMember.GetFinesForPeriod(memId, String.Format("{0:dd-MMM-yy}", dtpStatementFrom.Value), String.Format("{0:dd-MMM-yy}", dtpStatementTo.Value));

            float rentals = aMember.GetTotalForPeriod(memId, String.Format("{0:dd-MMM-yy}", dtpStatementFrom.Value), String.Format("{0:dd-MMM-yy}", dtpStatementTo.Value));

            txtFinesPaid.Text = String.Format("{0:0.00}", finesPaid);
            txtFinesOwed.Text = Convert.ToString(Member.GetFinesOwed(memId));

            if (txtFinesOwed.Text != "0")
            {
                txtFinesOwed.BackColor = Color.LightGray;  //change font color not bg
                lblFinesOwed.Visible = true;
                txtFinesOwed.Visible = true;
            }

            txtRentals.Text = String.Format("{0:0.00}", rentals);
            txtTotal.Text = String.Format("{0:0.00}", finesPaid + rentals);
        }

        private void HideTextBoxes()
        {
            btnPrint.Visible = false;
            btnEmail.Visible = false;
            lblTotal.Visible = false;
            txtTotal.Visible = false;
            lblRentals.Visible = false;
            txtRentals.Visible = false;
            lblFinesOwed.Visible = false;
            txtFinesOwed.Visible = false;
            lblFinesPaid.Visible = false;
            txtFinesPaid.Visible = false;
        }

        private void ShowTextBoxes()
        {
            btnEmail.Visible = true;
            btnPrint.Visible = true;
            lblTotal.Visible = true;
            txtTotal.Visible = true;
            lblRentals.Visible = true;
            txtRentals.Visible = true;
            lblFinesPaid.Visible = true;
            txtFinesPaid.Visible = true;
        }

        private void HideRadioButtons()
        {
            optYear.Visible = false;
            optCustom.Visible = false;
            optStart.Visible = false;
        }

        private void ShowRadioButtons()
        {
            optYear.Visible = true;
            optCustom.Visible = true;
            optStart.Visible = true;
        }

        private void CheckStatementPeriod()
        {
            if (optYear.Checked)
            {
                SetYearPeriod();
            }
            else if (optCustom.Checked)
            {
                SetCustomPeriod();
            }
            else if (optStart.Checked)
            {
                SetTotalPeriod();
            }

            btnViewStatement.Focus();
        }

        private void SetYearPeriod()
        {
            cboYear.Enabled = true;

            int year = currentYear - Convert.ToInt32(cboYear.Text);

            dtpStatementFrom.MinDate = startYear.AddYears(currentYear - (year + 1));

            dtpStatementFrom.Value = startYear.AddYears(currentYear - (year + 1));

            if (cboYear.Text.Equals(currentYear.ToString()))
            {
                dtpStatementTo.Value = DateTime.Today.AddYears(-year);
            }
            else
            {
                dtpStatementTo.Value = startYear.AddYears(currentYear - (year + 1)).AddMonths(11).AddDays(30);
            }

            dtpStatementFrom.Enabled = false;
            dtpStatementTo.Enabled = false;
            dtpStatementFrom.Visible = true;
            dtpStatementTo.Visible = true;
            
        }

        private void SetCustomPeriod()
        {
            cboYear.Enabled = false;
            dtpStatementFrom.MinDate = Convert.ToDateTime(aMember.StartDate);
            dtpStatementTo.MaxDate = DateTime.Today;
            dtpStatementFrom.Value = Convert.ToDateTime(aMember.StartDate);
            dtpStatementTo.Value = DateTime.Today;
            dtpStatementFrom.Enabled = true;
            dtpStatementTo.Enabled = true;
            dtpStatementFrom.Visible = true;
            dtpStatementTo.Visible = true;
        }

        private void SetTotalPeriod()
        {
            cboYear.Enabled = true;
            dtpStatementFrom.MinDate = Convert.ToDateTime(aMember.StartDate);
            dtpStatementFrom.Value = Convert.ToDateTime(aMember.StartDate);
            dtpStatementTo.Value = DateTime.Today;
            dtpStatementFrom.Enabled = false;
            dtpStatementTo.Enabled = false;
            dtpStatementFrom.Visible = true;
            dtpStatementTo.Visible = true;
        }

        private string CreateMessage(String s)
        {
            if (s.Equals("print"))
            {
                message += "<p>Statement Period: " + txtPeriod.Text +
                           "</p><p>Member Id: " + txtMemId.Text +
                           "</p><p>Membership Id: " + txtMembership.Text +
                           "</p><p>Rentals Total: " + txtRentals.Text +
                           "</p><p>Fines Paid: " + txtFinesPaid.Text +
                           "</p><p>Total: " + txtTotal.Text +
                           "</p><p>Fines Owed: " + txtFinesOwed.Text + "</p>";

                return message;
            }

            if (s.Equals("email"))
            {
                message += "Statement Period: " + txtPeriod.Text +
                           "\nMember Id: " + txtMemId.Text +
                           "\nMembership Id: " + txtMembership.Text +
                           "\nRentals Total: " + txtRentals.Text +
                           "\nFines Paid: " + txtFinesPaid.Text +
                           "\nTotal: " + txtTotal.Text +
                           "\nFines Owed: " + txtFinesOwed.Text;

                return message;
            }
            return message;
        }

    }
}
