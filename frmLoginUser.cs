using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmLoginUser : Form
    {
        public frmLoginUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            txtPass.MaxLength = 20;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            txtPass.MaxLength = 4;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Validate Username and password
            

            if (txtUser.Text.Equals("ABCD") && txtPass.Text.Equals("1234"))
            {
                MessageBox.Show("Welcome to the System Deirdre", "Welcome", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                //Show relevant Form (Catalogue, Remove, List) and hide login
            }
            else if (txtUser.Text.Equals("") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("Both fields must be completed", "Information Missing", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Invalid Username and Password", "Incorrect Details Entered", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close Window
        }
    }
}
