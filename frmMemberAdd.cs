﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieSYS.Properties
{
    public partial class frmAddMember : Form
    {
        frmMainMenu parent;
        public frmAddMember()
        {
            InitializeComponent();
        }

        public frmAddMember(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmAddMem_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //generated by system, old ID + 1. Max 8 digits. Unique
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cboMemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List items from Memberships file
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            //Must be max 30 characters
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            //Must be max 30 characters
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //If under 18, membership type must be 'Child Member'
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            //Must be valid less than 15 digits
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            //Must be valid ('@', '.', 'com/ie/co.uk') less than 50 characters
            //Does not need to be unique - parent for childs account
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtEircode_TextChanged(object sender, EventArgs e)
        {
            //must be 6 characters and valid eircode
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtIban_TextChanged(object sender, EventArgs e)
        {
            //Must be 16 characters and valid IBAN
        }

        private void btnAddMem_Click(object sender, EventArgs e)
        {
            //All fields must be entered and validated
            //If valid display Confirm/Cancel window

            //If 'Confirm' display window 'Print Receipt/ Email Receipt'
        }

        private void mnuAdd_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
    }
}
