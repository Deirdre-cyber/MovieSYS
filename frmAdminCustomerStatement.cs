using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            InitializeComponent();
        }

        public frmCustomerStatement(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
            grpStatementDetails.Visible = false;
        }

        private void grpRevenue_Enter(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void grpMemCheck_Enter(object sender, EventArgs e)
        {

        }

        private void lblMemberId_Click(object sender, EventArgs e)
        {

        }

        private void txtMemId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Validate
            grpStatementDetails.Visible = true;
        }

        private void grpStatementDetails_Enter(object sender, EventArgs e)
        {

        }

        private void lblMemebershipStart_Click(object sender, EventArgs e)
        {

        }

        private void dtpDueBack_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblMemberType_Click(object sender, EventArgs e)
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStatementFrom_Click(object sender, EventArgs e)
        {

        }

        private void dtpStatementFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblStatementTo_Click(object sender, EventArgs e)
        {

        }

        private void dtpStatementTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFinesDue_Click(object sender, EventArgs e)
        {

        }

        private void txtFineAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDVDsOut_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
