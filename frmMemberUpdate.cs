using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmMemberUpdate : Form
    {
        frmMainMenu parent;

        public frmMemberUpdate()
        {
            InitializeComponent();
        }

        public frmMemberUpdate(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
            grpEditMem.Visible = false;

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmMemberUpdate_Load(object sender, EventArgs e)
        {

        }

        private void grpMemCheck_Enter(object sender, EventArgs e)
        {

        }

        private void lblMemberSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            grpEditMem.Visible = true;
        }

        private void grpSearchResults_Enter(object sender, EventArgs e)
        {

        }

        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void grpEditMem_Enter(object sender, EventArgs e)
        {

        }

        private void lblMemberId_Click(object sender, EventArgs e)
        {

        }

        private void txtMemId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMembership_Click(object sender, EventArgs e)
        {

        }

        private void cboMemID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDateOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblContactNo_Click(object sender, EventArgs e)
        {

        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEircode_Click(object sender, EventArgs e)
        {

        }

        private void txtEircode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditMem_Click(object sender, EventArgs e)
        {

        }

        private void mnuAdd_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
    }
}
