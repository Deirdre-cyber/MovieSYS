using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmReturnDVD : Form
    {
        frmMainMenu parent;
        private int memId;
        private Member aMember = new Member();
        private float totalFines = 0.00f;
        private float total = 0.00f;
        private float fine = 0.00f;
        private int rentId;

        public frmReturnDVD()
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

        public frmReturnDVD(frmMainMenu Parent)
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

        private void frmReturnDVD_Load(object sender, EventArgs e)
        {
            LoadSearchUI();
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

        private void mnuBack_Click(object sender, EventArgs e)
        {
            if (grpMemberResults.Visible == true)
            {
                LoadSearchUI();
            }
                
            if (grpMemDetails.Visible == true && grpDvdDetails.Visible == true)
            {
                grpMemDetails.Visible = false;
                grpDvdDetails.Visible = false;
                grpMemberResults.Visible = true;
                totalFines = 0f;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMemberName.Text))
            {
                MessageBox.Show(null, "Please enter a name", "No Search Entered", MessageBoxButtons.OK);
                return;
            }

            if (Validation.IsTableEmpty(Member.SearchMember(txtMemberName.Text.ToUpper())))
            {
                MessageBox.Show(null, "There were no results matching your search", "No Data Found", MessageBoxButtons.OK);
                grdMemberResults.DataSource = null;
                txtMemberName.Clear();
                return;
            }

            LoadSearchResults();
        }

        private void grdSearchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdMemberResults.Rows[grdMemberResults.CurrentCell.RowIndex].Cells[0].Value.ToString() != "")
            {
                memId = (int)grdMemberResults.Rows[grdMemberResults.CurrentCell.RowIndex].Cells[0].Value;

                if (Validation.IsTableEmpty(RentalItem.GetRentalItems(memId)))
                {
                    MessageBox.Show(null, "This member currently has no DVDs rented", "No Data Found", MessageBoxButtons.OK);
                    return;
                }

                LoadMemberDetails();
                LoadDvdDetails();
                CheckFinesOverdue();
                return;
            }

            MessageBox.Show(null, "Must select a member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void grdRentedDvdList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtpDueDate.Value = Convert.ToDateTime(String.Format("{0:dd-MMM-yyyy}", grdRentedDvdList.Rows[grdRentedDvdList.CurrentCell.RowIndex].Cells[3].Value));

            SetFineText();
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            ReturnDvd();

            grdRentedDvdList.Rows.Remove(grdRentedDvdList.Rows[grdRentedDvdList.CurrentCell.RowIndex]);

            MessageBox.Show(null, "DVD returned successfully", "Return Successful", MessageBoxButtons.OKCancel);

            if (grdRentedDvdList.Rows.Count == 0)
                EndTransaction();
        }

        private void btnReturnAll_Click(object sender, EventArgs e)
        {
            int rows = grdRentedDvdList.Rows.Count;

            for (int i = 0; i < rows; i++)
            {
                ReturnDvd();
                grdRentedDvdList.Rows.Remove(grdRentedDvdList.Rows[grdRentedDvdList.CurrentCell.RowIndex]);
            }

            EndTransaction();
        }

        //LOCAL METHODS
        private void LoadSearchUI()
        {
            grdMemberResults.DataSource = null;
            grpMemberResults.Visible = false;
            grpDvdDetails.Visible = false;
            grpMemDetails.Visible = false;
            mnuBack.Visible = false;
            grpSearch.Location = new Point(250, 100);
            grpSearch.Visible = true;
        }

        private void LoadSearchResults()
        {
            //grid properties
            grdMemberResults.DataSource = Member.SearchMember(txtMemberName.Text.ToUpper()).Tables["search"];
            grdMemberResults.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMemberResults.Columns[0].Width = 50;
            grdMemberResults.Columns[1].Width = 50;
            grdMemberResults.Columns[9].Width = 50;
            grdMemberResults.Columns[10].Width = 50;
            grdMemberResults.DefaultCellStyle.Font = new Font("Courier", 8);
            grdMemberResults.DefaultCellStyle.ForeColor = Color.Black;

            //header - fix headings
            grdMemberResults.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMemberResults.ColumnHeadersDefaultCellStyle.Font = new Font("Courier", 10);
            grdMemberResults.Size = new Size(830, 300);
            mnuBack.Visible = true;

            //hide search box
            txtMemberName.Clear();
            grpSearch.Visible = false;

            //result box properties
            grpMemberResults.Size = new Size(850, 350);
            grpMemberResults.Location = new Point(70, 100);
            grpMemberResults.Visible = true;
        }

        private void LoadMemberDetails()
        {
            //hide result box
            grpMemberResults.Visible = false;

            //result box properties
            aMember.GetMemberDetails(memId);
            txtMemId.Text = Convert.ToString(memId);
            txtFirstName.Text = aMember.FirstName + " " + aMember.LastName;

            grpMemDetails.Location = new Point(100, 50);
            grpMemDetails.Visible = true;
        }
             
        private void LoadDvdDetails()
        {
            //grid properties
            grdRentedDvdList.DataSource = RentalItem.GetRentalItems(memId).Tables["rented"];
            grdRentedDvdList.DefaultCellStyle.Font = new Font("Courier", 8);
            grdRentedDvdList.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdRentedDvdList.ColumnHeadersDefaultCellStyle.Font = new Font("Courier", 10);
            grdRentedDvdList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdRentedDvdList.DefaultCellStyle.ForeColor = Color.Black;
            grdRentedDvdList.Size = new Size(505, 220);

            CheckOverdue();

            //result box properties
            dtpReturnDate.Value = DateTime.Today;
            dtpDueDate.Value = Convert.ToDateTime(String.Format("{0:dd-MMM-yyyy}", grdRentedDvdList.Rows[grdRentedDvdList.CurrentCell.RowIndex].Cells[3].Value));
            SetFineText();
            btnReturn.Location = new Point(800, 270);
            btnReturnAll.Location = new Point(680, 270);
            grpDvdDetails.Location = new Point(60, 180);
            grpDvdDetails.Size = new Size(910, 370);
            grpDvdDetails.Visible = true;
        }

        private void CheckOverdue()
        {
            for(int i = 0; i < grdRentedDvdList.Rows.Count; i++)
            {
                rentId = Convert.ToInt32(grdRentedDvdList.Rows[i].Cells[0].Value);
                
                if (Convert.ToDateTime(String.Format("{0:dd-MMM-yyyy}", grdRentedDvdList.Rows[i].Cells[3].Value)) < DateTime.Today)
                {
                    grdRentedDvdList.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    totalFines += (RentalItem.GetDaysOverdue(memId, rentId)*0.2f);                    
                }
            }
            total = totalFines;
            SetFineText();
        }

        private void CheckFinesOverdue()
        {
            if (aMember.HasOverdue(memId) && aMember.HasFine(memId))
            {
                MessageBox.Show(null, "This member has overdue DVD(s) and fines on account", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            if (aMember.HasOverdue(memId))
            {
                MessageBox.Show(null, "This member has overdue DVD(s)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            if (aMember.HasFine(memId))
            {
                MessageBox.Show(null, "This member has fines on account", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
        }

        private void ReturnDvd()
        {
            int dvdId = Convert.ToInt32(grdRentedDvdList.Rows[grdRentedDvdList.CurrentCell.RowIndex].Cells[1].Value);
            rentId = Convert.ToInt32(grdRentedDvdList.Rows[grdRentedDvdList.CurrentCell.RowIndex].Cells[0].Value);

            if (grdRentedDvdList.Rows[grdRentedDvdList.CurrentCell.RowIndex].DefaultCellStyle.ForeColor == Color.Red)
            {
                fine = GetFine();
                RentalItem.UpdateFineAmount(dvdId, fine);
            }
                
            float oldFine = Member.GetFinesOwed(memId);

            Member.UpdateFine(memId, oldFine + fine);
            RentalItem.UpdateRentalItem(rentId, dvdId);
            DVD.UpdateStatus(dvdId, "A");

            totalFines -= GetFine();
            SetFineText();
        }

        private float GetFine()
        {
            return RentalItem.GetDaysOverdue(memId, Convert.ToInt32(grdRentedDvdList.Rows[grdRentedDvdList.CurrentCell.RowIndex].Cells[0].Value)) * 0.2f;
        }

        private void EndTransaction()
        {
            MessageBox.Show(null, "All DVDs returned successfully\n\n€" + String.Format("{0:0.00}", total) + " fines added to this account", "Return Successful", MessageBoxButtons.OK);

            LoadSearchUI();
        }

        private void SetFineText()
        {
            txtFines.Text = "€" + String.Format("{0:0.00}", GetFine());
            txtTotalFines.Text = "€" + String.Format("{0:0.00}", totalFines);
        }
    }
}
