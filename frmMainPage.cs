using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void dVDsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open Catalogue DVD window
            this.Hide();
            frmCatalogueDVD catalogueDVD = new frmCatalogueDVD();
            catalogueDVD.Show();

        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open Members DVD window
            this.Hide();
            
        }

        private void rentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open Rental DVD window
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open Admin DVD window
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit window
        }
    }
}
