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
    public partial class frmCatalogueDVD : Form
    {
        public frmCatalogueDVD()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit window
        }

        private void grpDetails_Enter(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Title
        }

        private void txtDVDName_TextChanged(object sender, EventArgs e)
        {
            //must be less than 30 characters
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Genre
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List genre items = genre table
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //Category
        }

        private void cboCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List category items = category table
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //Lang
        }

        private void cboLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List language items = language table
        }

        private void label12_Click(object sender, EventArgs e)
        {
            //Year
        }
        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            //Must be 4 digits
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //Duration
        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {
            //must be max 3 numbers 0-999
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //Date
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //must be numbers in dd-mm-yy format
            //dd: 01-31 mm: 01-12 yy: 00-99
        }
        
        private void label9_Click(object sender, EventArgs e)
        {
            //Country
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List items from Country = country table
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //Age
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
