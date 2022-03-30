using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
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
            if (String.IsNullOrEmpty(txtMemberName.Text))
            {
                MessageBox.Show(null, "Please enter a name", "No Search Entered", MessageBoxButtons.OK);
            }
            else
            {
                if (Validation.IsTableEmpty(Member.SearchMember(txtMemberName.Text.ToUpper())))
                {
                    MessageBox.Show(null, "There were no results matching your search", "No Data Found", MessageBoxButtons.OK);
                    grdSearchResults.DataSource = null;
                    txtMemberName.Clear();
                }
                else
                    LoadMemberGrid();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ResetUI();
        }

        private void grdSearchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdSearchResults.Rows[grdSearchResults.CurrentCell.RowIndex].Cells[0].Value.ToString() != "")
            {
                memId = (int)grdSearchResults.Rows[grdSearchResults.CurrentCell.RowIndex].Cells[0].Value;

                if (aMember.HasOverdue(memId))
                {
                    OverdueWarning();
                }
                else if (aMember.HasFine(memId))
                {
                    LoadMemberDetails();
                    fine = Member.GetFinesOwed(memId);
                    txtFineAmount.Text = String.Format("{0:0.00}", fine);
                }
                else
                {
                    MessageBox.Show(null, "There are no fines connected to this account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetUI();
                }
            }
            else
                MessageBox.Show(null, "Must select a member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            //CONTINUE FROM HERE+++++++++++++++++

            try
            {
                if (validPayment)
                {
                    PayFine();
                    Member.UpdateFine(memId, fine);
                    //txtFineAmount.Text = "€" + String.Format("{0:00.00}", fine);
                    //txtPayAmount.Clear();
                    grpReceipt.Visible = true;
                    return;
                }
                else
                {
                    MessageBox.Show(null, "Invalid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            
        }

        //LOCAL METHODS
        private void LoadUI()
        {
            grpMemCheck.Location = new Point(260, 100);
            grdSearchResults.DataSource = null;
            grpReceipt.Visible = false;
            grpSearchResults.Visible = false;
            grpSearch.Visible = false;
            grpMemDetails.Visible = false;
            txtMemberName.Clear();
            grpMemCheck.Visible = true;
        }

        private void LoadMemberGrid()
        {
            grdSearchResults.DataSource = Member.SearchMember(txtMemberName.Text.ToUpper()).Tables["search"];
            grdSearchResults.DefaultCellStyle.Font = new Font("Courier", 9);
            grdSearchResults.DefaultCellStyle.ForeColor = Color.Black;
            grdSearchResults.Size = new Size(720, 300);
            btnReturn.Location = new Point(750, 150);

            grpMemCheck.Visible = false;

            grpSearchResults.Visible = true;
            grpSearchResults.Size = new Size(850, 350);
            grpSearchResults.Location = new Point(20, 100);
        }

        private void LoadMemberDetails()
        {
            aMember.GetMemberDetails(memId);
            txtMemId.Text = Convert.ToString(memId);
            txtFirstName.Text = aMember.FirstName + " " + aMember.LastName;
            grpSearchResults.Visible = false;
            grpSearch.Visible = true;
            grpMemDetails.Visible = true;
        }

        private void OverdueWarning()
        {
            MessageBox.Show(null, "There are overdue DVDs connected to this account, please advise member to return DVDs", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            grpSearchResults.Visible = false;
            txtMemberName.Clear();
            grpMemCheck.Visible = true;
        }

        private void ResetUI()
        {
            grpSearchResults.Visible = false;
            txtMemberName.Clear();
            grpMemCheck.Visible = true;
        }

        private void PayFine()
        {
            float payment = (float)Convert.ToDouble(txtPayAmount.Text);

            if (payment >= fine)
            {
                //fine -= payment; - necessary to deal with payment?
                fine = 0;
                MessageBox.Show(null, "Payment processed, no fine left on account", "Payment Successful", MessageBoxButtons.OKCancel);
            }
            else if (payment < fine)
            {
                fine -= payment;
                MessageBox.Show(null, "Payment processed, €" + String.Format("{0:00.00}", fine) + " fine left on account", "Payment Successful", MessageBoxButtons.OKCancel);
            }
        }

        //VALIDATION METHODS - complete this
        private void txtPayAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPayAmount.Text))
            {
                txtPayAmount.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtPayAmount, "Amount cannot be left blank");
                validPayment = false;
            }
            //check have digits and one dot
            /*if (txtPayAmount.Text)
            {
                txtPayAmount.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtPayAmount, "Amount cannot be left blank");
                validPayment = false;
            }*/
            else
            {
                txtPayAmount.BackColor = Color.White;
                errorProvider1.Clear();
                validPayment = true;
            }
        }


    }
}
