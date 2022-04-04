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
            //btnReturn.Location = new Point(750, 150);

            grpMemCheck.Visible = false;

            grpSearchResults.Visible = true;
            grpSearchResults.Size = new Size(850, 360);
            grpSearchResults.Location = new Point(100, 100);
        }

    }
}
