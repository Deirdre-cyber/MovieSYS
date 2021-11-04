using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {

        }

        private void mnuDVD_Click(object sender, EventArgs e)
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

        private void mnuCatalogue_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmDVDCatalogue addDVD = new frmDVDCatalogue(this);
            addDVD.Show();
        }

        private void mnuRemove_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmDVDRemove rentItem = new frmDVDRemove(this);
            rentItem.Show();
        }

        private void mnuListOverdue_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmListOverdue listOverdue = new frmListOverdue(this);
            listOverdue.Show();
        }

        private void mnuAddMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMemberAdd addMember = new frmMemberAdd(this);
            addMember.Show();
        }

        private void mnuEditMember_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMemberUpdate updateMember = new frmMemberUpdate(this);
            updateMember.Show();
        }

        private void mnuRentDVD_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRentalRentDVD rentDVD = new frmRentalRentDVD(this);
            rentDVD.Show();
        }

        private void mnuReturnDVD_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnDVD returnDVD = new frmReturnDVD(this);
            returnDVD.Show();
        }

        private void mnuPayFine_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPayFines payFine = new frmPayFines(this);
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
