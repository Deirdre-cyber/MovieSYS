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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit window
            this.Close();
            parent.Visible = true;
        }

        private void grpRemove_Enter(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if option selected, lstDVDs changes to reflect only relevant Categories
        }

        private void label3_Click(object sender, EventArgs e)
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
