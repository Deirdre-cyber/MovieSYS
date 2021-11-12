using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmDVDRemove : Form
    {
        frmMainMenu parent;

        public frmDVDRemove()
        {
            InitializeComponent();
        }

        public frmDVDRemove(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void grpRemove_Enter(object sender, EventArgs e)
        {

        }

        private void lblEnterTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtDVDTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblChooseDVD_Click(object sender, EventArgs e)
        {

        }

        private void lstDVDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Populate list with all available DVDs on file (available = not out on rent)
        }

        private void btnConfirmDel_Click(object sender, EventArgs e)
        {
            //Bring up password box to confirm
            //Remove DVD name from list
            //MessageBox.Show("Are you sure you want to remove this DVD entry?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
            //if yes - bring up password box
            //if no - close window
            //if cancel - close warning box
        }

        
    }
}
