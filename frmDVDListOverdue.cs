using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmListOverdue : Form
    {
        frmMainMenu parent;

        public frmListOverdue()
        {
            InitializeComponent();
        }

        public frmListOverdue(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
            grpOverdueDetails.Visible = false;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmListOverdue_Load(object sender, EventArgs e)
        {

        }

        private void mnuCloseLogin_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void grpListOverDue_Enter(object sender, EventArgs e)
        {

        }

        private void cboOverdue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            grpOverdueDetails.Visible = true;
        }

        private void grpOverdueDetails_Enter(object sender, EventArgs e)
        {

        }

        private void lblMember_Click(object sender, EventArgs e)
        {

        }

        private void txtMemId2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRentedon_Click(object sender, EventArgs e)
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

        private void lblFineDue_Click(object sender, EventArgs e)
        {

        }

        private void txtFineAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grpOverdueDetails.Visible = false;
        }

        private void btnSendReminder_Click(object sender, EventArgs e)
        {

        }
    }
}
