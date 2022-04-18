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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
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

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            LoadUI();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (NullReferenceException nre)
            {
                Debug.WriteLine("An error has occured\n" + nre.ToString());
            }
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
            frmDVDRemove removeDVD = new frmDVDRemove(this);
            removeDVD.Show();
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

        private void mnuListOverdue_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListOverdue listOverdue = new frmListOverdue(this);
            listOverdue.Show();
        }

        private void mnuYearlyRev_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearlyRevenue issueYrlyRevenue = new frmYearlyRevenue(this);
            issueYrlyRevenue.Show();
        }

        private void mnuCustomerStatement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomerStatement issueCustStatement = new frmCustomerStatement(this);
            issueCustStatement.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("ABC") && txtPass.Text.Equals("123"))
            {
                MessageBox.Show("Welcome to the System " + txtUser.Text, "Welcome", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                ShowMenuItems();
                grpLogin.Visible = false;
            }
            else if (txtUser.Text.Equals("") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("Both fields must be completed", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Invalid Username and Password", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            HideMenuItems();
            grpLogin.Visible = true;
        }

        //LOCAL METHOD
        private void LoadUI()
        {
            HideMenuItems();
            txtPass.PasswordChar = '*';
            txtPass.MaxLength = 8;
            txtUser.MaxLength = 70;
        }

        private void HideMenuItems()
        {
            mnuMembers.Visible = false;
            mnuDVD.Visible = false;
            mnuRentals.Visible = false;
            mnuAdmin.Visible = false;
            mnuLogout.Visible = false;
        }
        
        private void ShowMenuItems()
        {
            mnuMembers.Visible = true;
            mnuDVD.Visible = true;
            mnuRentals.Visible = true;
            mnuAdmin.Visible = true;
            mnuLogout.Visible = true;
        }
    }
}
