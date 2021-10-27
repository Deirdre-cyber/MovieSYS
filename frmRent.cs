using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmRent : Form
    {
        public frmRent()
        {
            InitializeComponent();
        }
        private void frmRent_Load(object sender, EventArgs e)
        {

        }

        private void mnuAdd_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void grpSearch_Enter(object sender, EventArgs e)
        {
            //hide and show grpSearchRes
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void cboSearchOpt_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Load relevant list Title/Category/Genre/Language
            //Release Year/Date Added/Country_ID/Age Rating
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //If option selected from drop down show grpSearchResults
            //populate grpSearchResults list with relevant results
        }
        private void grpSearchRes_Enter(object sender, EventArgs e)
        {
            //Validate Title - if available show window with option to add to cart
            //Add to results list and continue adding titles if required

            //if unavailable issue warning and show details of when will be available
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void cboList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void grpResults_Enter(object sender, EventArgs e)
        {

        }
        private void cboSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            //validated Title to be added to cart
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //dispaly window with options to confirm or cancel
        }
        private void grpRentDetails_Enter(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void lstCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            //incrementally populated with DVDs - max depending on membership type...
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void txtMemId_TextChanged(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void cboMemID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void dtpRentDate_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void dtpDueBack_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            //if all valid show window to confirm and print reciept
        }

    }
}
