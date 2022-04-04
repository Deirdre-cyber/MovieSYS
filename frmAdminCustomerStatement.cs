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
    public partial class frmCustomerStatement : Form
    {
        frmMainMenu parent;
        private Member aMember = new Member();
        int memId;

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

        private void grdSearchRes_CellClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //if successful
            MessageBox.Show(null, "Statement sent to printer", "Printed", MessageBoxButtons.OK);
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            //if successful
            MessageBox.Show(null, "Statement sent to member", "Email Sent", MessageBoxButtons.OK);
        }

        //LOCAL METHODS

        private void LoadUI()
        {
            grpSearchResults.Visible = false;
            grpStatementDetails.Visible = false;
            btnPrint.Visible = false;
            btnEmail.Visible = false;
            grpStatementPeriod.Visible = false;

            lblFinesDue.Visible = false;
            txtFinesUnpaid.Visible = false;
            lblDVDsRented.Visible = false;
            lstRented.Visible = false;

            grpMemCheck.Location = new Point(300, 100);
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

            grdSearchRes.Size = new Size(800, 350);
            btnReturn.Location = new Point(750, 150);

            grpMemCheck.Visible = false;

            grpSearchResults.Visible = true;
            grpSearchResults.Size = new Size(850, 360);
            grpSearchResults.Location = new Point(100, 100);
        }

        private void LoadMemberDetails()
        {
            memId = Convert.ToInt32(grdSearchRes.Rows[grdSearchRes.CurrentCell.RowIndex].Cells[0].Value);

            aMember.GetMemberDetails(memId);

            txtMemId.Text = Convert.ToString(memId);
            cboMemID.Text = aMember.MembershipID;
            dtpStartDate.Value = Convert.ToDateTime(aMember.StartDate);
            txtFirstName.Text = aMember.FirstName;
            txtLastName.Text = aMember.LastName;
            dtpDOB.Value = Convert.ToDateTime(aMember.DOB1);
            txtEmail.Text = aMember.Email;

            txtFinesPaid.Text = String.Format("{0:0.00}", Member.GetFines(memId, String.Format("{0:dd-MMM-yy}", dtpStatementFrom.Value), String.Format("{0:dd-MMM-yy}", dtpStatementTo.Value)));

            //txtFinesUnpaid.Text = Convert.ToString(Member.GetFinesOwed(memId));

            dtpStatementFrom.MinDate = Convert.ToDateTime(aMember.StartDate);
            dtpStatementFrom.Value = Convert.ToDateTime(aMember.StartDate);
            dtpStatementTo.MaxDate = DateTime.Today;
            dtpStatementTo.Value = DateTime.Today;

            grpSearchResults.Visible = false;
            grpStatementDetails.Visible = true;
            grpStatementPeriod.Visible = true;
            grpStatementPeriod.Location = new Point(150, 200);
        }
    }
}
