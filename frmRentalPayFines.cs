using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmPayFines : Form
    {
        frmMainMenu parent;
        private Member aMember = new Member();
        private int memId;
        private float fine;
        private bool validPayment = true;
        private string message = "Here are the details of this transaction: ";

        public frmPayFines()
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

        public frmPayFines(frmMainMenu Parent)
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

        private void frmPayFines_Load(object sender, EventArgs e)
        {
            LoadUI();
        }

        private void mnuExit_Click_1(object sender, EventArgs e)
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMemberName.Text))
            {
                MessageBox.Show(null, "Please enter a name", "No Search Entered", MessageBoxButtons.OK);
                return;
            }

            if (Validation.IsTableEmpty(Member.SearchMember(txtMemberName.Text.ToUpper())))
            {
                MessageBox.Show(null, "There were no results matching your search", "No Data Found", MessageBoxButtons.OK);
                grdMemberResults.DataSource = null;
                txtMemberName.Clear();
                return;
            }

            mnuBack.Visible = true;
            LoadMemberGrid();
        }

        private void grdSearchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdMemberResults.Rows[grdMemberResults.CurrentCell.RowIndex].Cells[0].Value.ToString() != "")
            {
                memId = (int)grdMemberResults.Rows[grdMemberResults.CurrentCell.RowIndex].Cells[0].Value;

                if (aMember.HasOverdue(memId))
                {
                    MessageBox.Show(null, "There are overdue DVDs connected to this account, please advise member to return DVDs first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (aMember.HasFine(memId))
                {
                    LoadMemberDetails();
                    fine = Member.GetFinesOwed(memId);
                    txtFineAmount.Text = String.Format("{0:0.00}", fine);
                    return;
                }

                MessageBox.Show(null, "There are no fines connected to this account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(null, "Must select a member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (validPayment)
                {
                    PayFine();
                    Member.UpdateFine(memId, fine);
                    txtFineAmount.Text = "€" + String.Format("{0:0.00}", fine);
                    txtPayAmount.Clear();
                    grpReceipt.Visible = true;
                    return;
                }

                MessageBox.Show(null, "Invalid payment amount entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show(null, "Invalid payment amount entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception)
            {
                MessageBox.Show(null, "Invalid payment amount entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            if (grpMemberResults.Visible == true)
            {
                ResetUI();
                return;
            }

            if(grpMemberDetails.Visible == true && grpFineDetails.Visible == true)
            {
                validPayment = true;
                grpReceipt.Visible = false;
                grpMemberDetails.Visible = false;
                grpFineDetails.Visible = false;
                grpMemberResults.Visible = true;
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Utility.SavePdf(CreateMessage());
            Utility.PrintPDFWithAcrobat();      //necessary/working?

            ResetUI();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            Utility.EmailReceipt(CreateMessage());
            MessageBox.Show("Receipt sent to member" + txtFirstName.Text);

            ResetUI();
        }

        //LOCAL METHODS
        private void LoadUI()
        {
            grpMemCheck.Location = new Point(260, 100);
            grdMemberResults.DataSource = null;
            grpReceipt.Visible = false;
            grpMemberResults.Visible = false;
            grpMemberDetails.Visible = false;
            grpFineDetails.Visible = false;
            mnuBack.Visible = false;
            txtMemberName.Clear();
            grpMemCheck.Visible = true;
        }

        private void ResetUI()
        {
            mnuBack.Visible = false;
            grpMemberResults.Visible = false;
            txtMemberName.Clear();
            grpMemCheck.Visible = true;
        }

        private void LoadMemberGrid()
        {
            grdMemberResults.DataSource = Member.SearchMember(txtMemberName.Text.ToUpper()).Tables["search"];
            grdMemberResults.DefaultCellStyle.Font = new Font("Courier", 9);
            grdMemberResults.DefaultCellStyle.ForeColor = Color.Black;
            grdMemberResults.Size = new Size(720, 300);
            grpMemCheck.Visible = false;
            grpMemberResults.Visible = true;
            grpMemberResults.Size = new Size(850, 350);
            grpMemberResults.Location = new Point(20, 100);
        }

        private void LoadMemberDetails()
        {
            aMember.GetMemberDetails(memId);
            txtMemId.Text = Convert.ToString(memId);
            txtFirstName.Text = aMember.FirstName + " " + aMember.LastName;
            grpMemberResults.Visible = false;
            grpMemberDetails.Visible = true;
            grpFineDetails.Visible = true;
        }

        private void PayFine()
        {
            float payment = (float)Convert.ToDouble(txtPayAmount.Text);

            if (payment >= fine)
            {
                float change = (fine - payment) * -1;
                fine = 0;

                MessageBox.Show(null, "Payment processed, no fine left on account. Change due: €" + String.Format("{0:0.00}", change), "Payment Successful", MessageBoxButtons.OKCancel);
                return;
            }

            if (payment < fine)
            {
                fine -= payment;
                MessageBox.Show(null, "Payment processed, €" + String.Format("{0:0.00}", fine) + " fine left on account", "Payment Successful", MessageBoxButtons.OKCancel);
                return;
            }
        }

        //VALIDATION METHODS
        private void TxtPayAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPayAmount.Text))
            {
                txtPayAmount.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtPayAmount, "Amount cannot be left blank");
                validPayment = false;
                return;
            }

            if (!Validation.IsNumber(txtPayAmount.Text))
            {
                txtPayAmount.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtPayAmount, "Invalid characters, must enter digits in correct format. eg 10 or 10.00");
                validPayment = false;
                return;
            }

            txtPayAmount.BackColor = Color.White;
            errorProvider1.Clear();
            validPayment = true;
        }

        private string CreateMessage()
        {
            message += "<p> </p>";

            return message;
        }
    }
}
