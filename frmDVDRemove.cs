using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmDVDRemove : Form
    {
        frmMainMenu parent;
        private DVD aDvd = new DVD();
        private int id;
        private String title;

        public frmDVDRemove()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception e)
            {
                Debug.WriteLine("An error has occured\n" + e.ToString());
            }
        }

        public frmDVDRemove(frmMainMenu Parent)
        {
            try
            {
                InitializeComponent();
                this.parent = Parent;
            }
            catch (Exception e)
            {
                Debug.WriteLine("An error has occured\n" + e.ToString());
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                parent.Visible = true;
            }
            catch (NullReferenceException nre)
            {
                Debug.WriteLine("An error has occured\n" + nre.ToString());
            }
        }

        private void frmDVDRemove_Load(object sender, EventArgs e)
        {
            grpRemove.Visible = true;
            grpDetails.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtDVDTitle.Text))
            {
                MessageBox.Show(null, "Please enter a name", "No Search Entered", MessageBoxButtons.OK);
            }
            else
            {
                if (Validation.IsTableEmpty(DVD.SearchDVD(txtDVDTitle.Text.ToUpper())))
                {
                    MessageBox.Show(null, "There were no results matching your search", "No Data Found", MessageBoxButtons.OK);
                    txtDVDTitle.Clear();
                }
                else
                    showDvdResults();
            }
        }

        private void grdDVDList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDvdDetails();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(null, "Are you sure you want to delete this copy of " + title + "", "Confirm",  MessageBoxButtons.OKCancel);

            if(result == DialogResult.OK)
            {
                DVD.RemoveDVD(id);
                resetUI();
                MessageBox.Show(null, title + " removed successfully", "Successful", MessageBoxButtons.OKCancel);
            }
            grpDetails.Visible = false;
            clearGrid();
        }

        //LOCAL METHODS
        private void showDvdResults()
        {
            grdDVDList.DataSource = DVD.SearchDVD(txtDVDTitle.Text.ToUpper()).Tables["search"];
            grdDVDList.DefaultCellStyle.Font = new Font("Tahoma", 8);
            grdDVDList.DefaultCellStyle.ForeColor = Color.Black;
        }
        public void loadDvdDetails()
        {
            id = Convert.ToInt32(grdDVDList.Rows[grdDVDList.CurrentCell.RowIndex].Cells[0].Value);
            title = grdDVDList.Rows[grdDVDList.CurrentCell.RowIndex].Cells[1].Value.ToString();

            aDvd.GetAllDvdDetails(id);
            txtDVDId.Text = Convert.ToString(aDvd.DvdID);
            txtDVDName.Text = aDvd.Title;
            cboCat.Text = aDvd.CategoryCode;
            cboGenre.Text = aDvd.GenreCode;
            cboCountry.Text = aDvd.CountryCode;
            txtYear.Text = aDvd.ReleaseYear;
            txtDuration.Text = Convert.ToString(aDvd.Duration);
            dtpDate.Value = Convert.ToDateTime(aDvd.DateAdded);
            cboAge.Text = aDvd.AgeCode;
            txtCopies.Text = Convert.ToString(DVD.GetDvdCount(title.ToUpper()));

            grpDetails.Visible = true;
        }
        private void clearGrid()
        {
            grdDVDList.DataSource = null;
            txtDVDTitle.Clear();
        }
        private void resetUI() //MAKE UNIVERSAL METHOD IN UTILITY CLASS
        {
            Utility.ClearText(this.Controls);
            dtpDate.Value = DateTime.Today;
            cboCat.Text = null;
            cboGenre.Text = null;
            cboCountry.Text = null;
            cboAge.Text = null;
            txtDVDName.Focus();
        }
    }
}
