﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmPayFines : Form
    {
        frmMainMenu parent;
        public frmPayFines()
        {
            InitializeComponent();
        }

        public frmPayFines(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
            grpMemDetails.Visible = false;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnPayFull_Click(object sender, EventArgs e)
        {

        }

        private void grpMemCheck_Enter(object sender, EventArgs e)
        {

        }

        private void txtMemId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //If details valid make grpMemDetails visible
        }

        private void grpMemDetails_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFineAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPayAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPayPart_Click(object sender, EventArgs e)
        {

        }

        private void mnuAdd_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
    }
}
