using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void dVDsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuMembers_Click(object sender, EventArgs e)
        {

        }

        private void mnuRentals_Click(object sender, EventArgs e)
        {

        }

        private void mnuAdmin_Click(object sender, EventArgs e)
        {

        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuCatalogue_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDVDCatalogue addDVD = new frmDVDCatalogue(this);
            addDVD.Show();
        }

        private void mnuRemove_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDVDRemove rentItem = new frmDVDRemove(this);
            rentItem.Show();
        }

        private void mnuListOverdue_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListOverdue listOverdue = new frmListOverdue(this);
            listOverdue.Show();
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmAddMember addMember = new frmAddMember(this);
            //addMember.Show();
        }

        private void mnuEditMember_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmUpdateMember = updateMember = new frmUpdateMember(this);
            //updateMember.Show();
        }

        private void mnuRentDVD_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRent rentDVD = new frmRent(this);
            rentDVD.Show();
        }

        private void mnuReturnDVD_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturn returnDVD = new frmReturn(this);
            returnDVD.Show();
        }

        private void mnuPayFine_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFines payFine = new frmFines(this);
            payFine.Show();
        }

        private void mnuYearlyRev_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyRevenue revenueOne = new frmYearlyRevenue(this);
            revenueOne.Show();
        }

        private void mnuCustomerStatement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerStatement customerStatement = new frmCustomerStatement(this);
            customerStatement.Show();
        }
    }
    }
