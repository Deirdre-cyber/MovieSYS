using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmDVDRemove : Form
    {
        frmMainMenu parent;
        private DVD aDvd = new DVD();
        private int id;
        private string title;

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

            if (string.IsNullOrEmpty(txtDVDTitle.Text))
            {
                MessageBox.Show(null, "Please enter a DVD title", "No Search Entered", MessageBoxButtons.OK);
            }
            else
            {
                if (Validation.IsTableEmpty(DVD.SearchDVD(txtDVDTitle.Text.ToUpper())))
                {
                    MessageBox.Show(null, "There were no results matching your search", "No Data Found", MessageBoxButtons.OK);
                    txtDVDTitle.Clear();
                }
                else
                    ShowDvdResults();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGrid();
        }

        private void grdDVDList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowDvdDetails();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(null, "Are you sure you want to delete this copy of " + title + "", "Confirm",  MessageBoxButtons.OKCancel);

            if(result == DialogResult.OK)
            {
                DVD.RemoveDVD(id);
                ResetUI();
                MessageBox.Show(null, title + " removed successfully", "Successful", MessageBoxButtons.OKCancel);
                grpDetails.Visible = false;
                ClearGrid();
                return;
            }

        }

        //LOCAL METHODS
        private void ShowDvdResults()
        {
            grdDVDList.DataSource = DVD.SearchDVD(txtDVDTitle.Text.ToUpper()).Tables["search"];
            grdDVDList.DefaultCellStyle.Font = new Font("Tahoma", 8);
            grdDVDList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            grdDVDList.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDVDList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdDVDList.DefaultCellStyle.ForeColor = Color.Black;

            string[] headings = { "DVD ID", "Title", "Category ID" };

            for (int i = 0; i < grdDVDList.ColumnCount; i++)
            {
                grdDVDList.Columns[i].HeaderText = headings[i];
            }

            grdDVDList.Columns[0].Width = 120;
            grdDVDList.Columns[1].Width = 200;
            grdDVDList.Columns[2].Width = 150;
        }
        private void ShowDvdDetails()
        {
            id = Convert.ToInt32(grdDVDList.Rows[grdDVDList.CurrentCell.RowIndex].Cells[0].Value);
            title = grdDVDList.Rows[grdDVDList.CurrentCell.RowIndex].Cells[1].Value.ToString();

            aDvd.GetAllDvdDetails(id);
            txtDVDId.Text = aDvd.DvdID.ToString("0000");
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
        private void ClearGrid()
        {
            grdDVDList.DataSource = null;
            txtDVDTitle.Clear();
            grpDetails.Visible = false;
        }
        private void ResetUI()
        {
            txtDVDId.Clear();
            txtDVDName.Clear();
            txtDVDTitle.Clear();
            txtDuration.Clear();
            txtCopies.Clear();
            dtpDate.Value = DateTime.Today;
            cboCat.Text = null;
            cboGenre.Text = null;
            cboCountry.Text = null;
            cboAge.Text = null;
            txtDVDName.Focus();
        }
    }
}
