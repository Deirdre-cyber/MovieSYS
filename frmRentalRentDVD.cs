using System;
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
            grpSearchResults.Visible = false;
            grpRentDetails.Visible = false;
            grpSearch.Visible = false;
            this.parent = Parent;
        }

        private void frmRent_Load(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void grpMemCheck_Enter_1(object sender, EventArgs e)
        {

        }

        private void lblMemberSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            grpSearchResults.Visible = true;
        }

        private void grpSearchResults_Enter(object sender, EventArgs e)
        {

        }

        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            grpSearch.Visible = true;
            grpRentDetails.Visible = true;
        }

        private void grpSearchRes_Enter(object sender, EventArgs e)
        {

        }

        private void lblMemberId_Click(object sender, EventArgs e)
        {

        }

        private void txtMemId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFines_Click(object sender, EventArgs e)
        {

        }

        private void txtFines_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpRentDetails_Enter(object sender, EventArgs e)
        {

        }

        private void lblRentId_Click(object sender, EventArgs e)
        {

        }

        private void txtRentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSearchDVD_Click(object sender, EventArgs e)
        {

        }

        private void txtDVDSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstSearchRes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddtoCart1_Click(object sender, EventArgs e)
        {
            
        }

        private void lblCar(object sender, EventArgs e)
        {

        }

        private void lstCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            //incrementally populated with DVDs - max depending on membership type...
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblReturn_Click(object sender, EventArgs e)
        {

        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grpRentDetails.Visible = false;
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
