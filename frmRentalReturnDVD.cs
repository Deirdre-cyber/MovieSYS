﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmReturnDVD : Form
    {
        frmMainMenu parent;

        public frmReturnDVD()
        {
            InitializeComponent();
        }

        public frmReturnDVD(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
            grpReturnDVD.Visible = false;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            //exit window
            this.Close();
            parent.Visible = true;
        }

        private void mnuAdd_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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

        }

        private void grpSearchResults_Enter(object sender, EventArgs e)
        {

        }

        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void grpReturnDVD_Enter(object sender, EventArgs e)
        {

        }

        private void cboRentedAll_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {

        }

        private void lstReturnList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblReturnDate_Click(object sender, EventArgs e)
        {

        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFineDue_Click(object sender, EventArgs e)
        {

        }

        private void txtFines_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

    }
}
