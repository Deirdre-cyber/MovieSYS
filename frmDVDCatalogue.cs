using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmDVDCatalogue : Form
    {
        frmMainMenu parent;

        public frmDVDCatalogue()
        {
            InitializeComponent();
        }
        public frmDVDCatalogue(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void grpDetails_Enter(object sender, EventArgs e)
        {
            
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtDVDName_TextChanged(object sender, EventArgs e)
        {
            //must be less than 30 characters
        }

        private void lblGenre_Click(object sender, EventArgs e)
        {

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List genre items = genre table
        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void cboCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List category items = category table
        }

        private void lblLanguage_Click(object sender, EventArgs e)
        {

        }

        private void cboLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List language items = language table
        }

        private void lblYear_Click(object sender, EventArgs e)
        {

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            //Must be 4 digits
        }

        private void lblDuration_Click(object sender, EventArgs e)
        {

        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {
            //must be max 3 numbers 0-999
        }

        private void lblDateAdd_Click(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            //must be numbers in dd-mm-yy format
            //dd: 01-31 mm: 01-12 yy: 00-99
        }

        private void lblCountry_Click(object sender, EventArgs e)
        {

        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List items from Country = country table
        }

        private void lblAgeRating_Click(object sender, EventArgs e)
        {

        }

        private void cboAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List items from Age rating = Age_Cert Table
        }

        private void btnConfirmInfo_Click(object sender, EventArgs e)
        {
            //VALIDATE ALL - all marked fields must be entered
        }

        
    }
}
