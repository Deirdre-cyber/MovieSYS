using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmRentalRentDVD : Form
    {
        frmMainMenu parent;
        public frmRentalRentDVD()
        {
            InitializeComponent();
        }

        public frmRentalRentDVD(frmMainMenu Parent)
        {
            InitializeComponent();
            grpRentDetails.Visible = false;
            grpRefine.Visible = false;
            grpSearch.Visible = false;
            this.parent = Parent;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmRent_Load(object sender, EventArgs e)
        {

        }

        private void grpMemCheck_Enter(object sender, EventArgs e)
        {

        }

        private void lblMemberId_Click(object sender, EventArgs e)
        {

        }

        private void txtMemId_TextChanged(object sender, EventArgs e)
        {
            //if valid make grpSearch visible
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }

        private void grpSearchRes_Enter(object sender, EventArgs e)
        {

        }

        private void cboList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefine_Click(object sender, EventArgs e)
        {
            //make grpSearchRes visible
        }

        private void btnAddtoCart1_Click(object sender, EventArgs e)
        {

        }

        private void grpSearch_Enter(object sender, EventArgs e)
        {

        }

        private void lblRefine_Click(object sender, EventArgs e)
        {

        }

        private void cboRefineOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmRefine_Click(object sender, EventArgs e)
        {

        }

        private void grpRentDetails_Enter(object sender, EventArgs e)
        {

        }

        private void lblCart_Click(object sender, EventArgs e)
        {

        }

        private void lstCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            //incrementally populated with DVDs - max depending on membership type...
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void lblMember_Click(object sender, EventArgs e)
        {

        }

        private void txtMemId2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRentedOn_Click(object sender, EventArgs e)
        {

        }

        private void dtpRentDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblDueBack_Click(object sender, EventArgs e)
        {

        }

        private void dtpDueBack_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            //if all valid show window to confirm and print reciept
        }

        private void mnuAdd_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
