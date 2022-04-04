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
                LoadStatementDatePicker();
                
            }
            else
            {
                MessageBox.Show(null, "Please choose a member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewStatement_Click(object sender, EventArgs e)
        {
            LoadStatement();
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
            this.Height = 600;

            grpSearchResults.Visible = false;
            grpStatementDetails.Visible = false;
            btnPrint.Visible = false;
            btnEmail.Visible = false;
            grpStatementPeriod.Visible = false;

            optYear.Visible = false;
            optQuarter.Visible = false;
            optStart.Visible = false;

            dtpStatementFrom.Visible = false;
            dtpStatementTo.Visible = false;

            lblTotal.Visible = false;
            lblTotal.Visible = false;
            lblRentals.Visible = false;
            txtRentals.Visible = false;
            lblFinesOwed.Visible = false;
            txtFinesOwed.Visible = false;
            lblFinesPaid.Visible = false;
            txtFinesPaid.Visible = false;

            txtTotal.Visible = false;

            grpMemCheck.Location = new Point(300, 100);
        }

        private void ShowMemberResults()
        {
            grpMemCheck.Visible = false;
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

            grdSearchRes.Size = new Size(820, 150);
            btnReturn.Location = new Point(350, 200);
            grpSearchResults.Visible = true;
            grpSearchResults.Size = new Size(850, 240);
            grpSearchResults.Location = new Point(100, 100);
        }

        private void LoadStatementDatePicker()
        {
            memId = Convert.ToInt32(grdSearchRes.Rows[grdSearchRes.CurrentCell.RowIndex].Cells[0].Value);
            aMember.GetMemberDetails(memId);

            int currentYear = DateTime.Today.Year;
            int Years = currentYear - Convert.ToDateTime(aMember.StartDate).Year;

            for (int i = 0; i <= Years; i++)
            {
                cboYear.Items.Add(Convert.ToString(currentYear - i));
            }

            cboYear.Text = currentYear.ToString();

            optYear.Visible = true;
            optQuarter.Visible = true;
            optStart.Visible = true;

            dtpStatementFrom.MinDate = Convert.ToDateTime(aMember.StartDate);
            dtpStatementFrom.Value = DateTime.Today;

            dtpStatementTo.MaxDate = DateTime.Today;
            dtpStatementTo.Value = DateTime.Today;

            grpStatementPeriod.Location = new Point(100, 400);
            grpStatementPeriod.Visible = true;
        }

        private void LoadStatement()
        {
            this.Height = 1200;
            //position
            //statement period options

            //CONTINUE FROM HERE +++++++


            txtMemId.Text = Convert.ToString(memId);

            txtMembership.Text = aMember.MembershipID;

            txtPeriod.Text = dtpStatementFrom.Text + " - " + dtpStatementTo.Text;

            txtName.Text = aMember.FirstName + " " + aMember.LastName;
            txtEmail.Text = aMember.Email;
            txtContact.Text = aMember.ContactNo;

            txtFinesPaid.Text = String.Format("{0:0.00}", Member.GetFines(memId, String.Format("{0:dd-MMM-yy}", dtpStatementFrom.Value), String.Format("{0:dd-MMM-yy}", dtpStatementTo.Value)));

            //txtFinesUnpaid.Text = Convert.ToString(Member.GetFinesOwed(memId));

            grpSearchResults.Visible = false;
            grpStatementDetails.Visible = true;
            
        }

        
    }
}
