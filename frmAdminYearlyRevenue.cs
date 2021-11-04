using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmYearlyRevenue : Form
    {
        frmMainMenu parent;

        public frmYearlyRevenue()
        {
            InitializeComponent();
        }

        public frmYearlyRevenue(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void grpRevenue_Enter(object sender, EventArgs e)
        {

        }

        private void lblYear_Click(object sender, EventArgs e)
        {

        }

        private void cboEnterYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbFirstQuart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSecQuart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbThirdQuart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFourthQuart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSelectAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void mnuAdd_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
