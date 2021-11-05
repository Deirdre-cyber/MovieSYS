﻿using System;
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
            grpRefine.Visible = false;
            btnDownload.Visible = false;
            btnPrint.Visible = false;
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

        private void chkFirstQuart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkSecondQuart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkThirdQuart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkFourthQuart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkAllQuart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void mnuAdd_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnRefine_Click(object sender, EventArgs e)
        {
            //Validate
            grpRefine.Visible = true;
        }

        private void grpRefine_Enter(object sender, EventArgs e)
        {

        }

        private void chkCategory_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkGenre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkFinesPaid_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkRefineAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerateRefine_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

        }

        
    }
}
