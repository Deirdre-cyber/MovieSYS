using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmListOverdue : Form
    {
        frmMainMenu parent;

        public frmListOverdue()
        {
            InitializeComponent();
        }

        public frmListOverdue(frmMainMenu Parent)
        {
            InitializeComponent();
            this.parent = Parent;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmListOverdue_Load(object sender, EventArgs e)
        {

        }

        private void lstOverDue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void mnuCloseLogin_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
    }
}
