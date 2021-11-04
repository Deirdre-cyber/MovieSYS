using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmCustomerStatement : Form
    {
        frmMainMenu parent;

        public frmCustomerStatement()
        {
            InitializeComponent();
        }

        public frmCustomerStatement(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void grpRevenue_Enter(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
