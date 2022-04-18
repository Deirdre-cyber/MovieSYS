using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmRentalRentDVD : Form
    {
        frmMainMenu parent;

        private Member aMember = new Member();
        private int memId;
        private float price = 0.00f;
        private int dvdLimit = 5;
        private int cartIndex;

        public frmRentalRentDVD()
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

        public frmRentalRentDVD(frmMainMenu Parent)
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

        private void frmRent_Load(object sender, EventArgs e)
        {
            LoadUI();
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

        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMemberName.Text))
            {
                MessageBox.Show(null, "Please enter a name", "No Search Entered", MessageBoxButtons.OK);
            }
            else
            {
                if (Validation.IsTableEmpty(Member.SearchMember(txtMemberName.Text.ToUpper())))
                {
                    MessageBox.Show(null, "There were no results matching your search", "No Data Found", MessageBoxButtons.OK);
                    grdSearchResults.DataSource = null;
                    txtMemberName.Clear();
                    return;
                }

                ShowMemberResults();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { 
            EmptyCart();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            ProcessRental();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            ResetUI();      //create univeral method...
            LoadUI();
        }

        private void grdDvdSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //fix
            if (lstCart.Items.Count < dvdLimit)
            {
                if (lstCart.Items.Count > 0)
                {
                    int count;

                    for (count = 0; count < lstCart.Items.Count; count++)
                    {
                        if (lstCart.FindString(String.Format("{0:0000}", grdDvdSearch.Rows[grdDvdSearch.CurrentCell.RowIndex].Cells[0].Value)) != -1)
                            break;
                    }

                    if (count != lstCart.Items.Count)
                    {
                        MessageBox.Show(null, grdDvdSearch.Rows[grdDvdSearch.CurrentCell.RowIndex].Cells[1].Value.ToString() +
                        " has already been selected", "Error", MessageBoxButtons.OK);
                    }
                    else
                        AddToCart();
                }
                else
                    AddToCart();

                return;
            }

            MessageBox.Show(null, "Cannot rent more than " + dvdLimit + " DVDs", "Limit Reached", MessageBoxButtons.OK);

        }

        private void grdSearchResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdSearchResults.Rows[grdSearchResults.CurrentCell.RowIndex].Cells[0].Value.ToString() != "")
            {
                memId = (int)grdSearchResults.Rows[grdSearchResults.CurrentCell.RowIndex].Cells[0].Value;

                if (!aMember.HasFine(memId) && !aMember.HasOverdue(memId))
                {
                    ShowMemberDetails();
                    return;
                }

                MessageBox.Show(null, "There are fines or overdue DVDs connected to this account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadUI();
                return;
            }

            MessageBox.Show(null, "Must select a member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDVDSearch.Text) || string.IsNullOrEmpty(txtDVDSearch.Text))
            {
                MessageBox.Show(null, "Please enter the name of a DVD Title", "No Search Entered", MessageBoxButtons.OK);
            }
            else
            {
                if (Validation.IsTableEmpty(DVD.SearchDVD(txtDVDSearch.Text.ToUpper())))
                {
                    MessageBox.Show(null, "There were no results matching your search", "No Data Found", MessageBoxButtons.OK);
                    txtDVDSearch.Clear();
                    return;
                }

                ShowDvdDetails();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            cartIndex = lstCart.SelectedIndex;

            if (cartIndex != -1)
            {
                RemoveFromCart();
                return;
            }

            MessageBox.Show(null, "Nothing selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LoadUI();
        }


        //LOCAL METHODS
        private void LoadUI()
        {
            grdDvdSearch.DataSource = null;
            grpMemCheck.Location = new Point(260, 100);
            grdSearchResults.DataSource = null;
            grpSearchResults.Visible = false;
            dtpReturnDate.MinDate = DateTime.Today.AddDays(7);
            dtpReturnDate.MaxDate = DateTime.Today.AddDays(14);
            grpRentDetails.Visible = false;
            grpSearch.Visible = false;
            txtMemberName.Clear();
            grpMemCheck.Visible = true;
        }

        private void ResetUI()
        {
            txtMemId.Clear();
            txtRentID.Clear();
            txtDVDSearch.Clear();
            lstCart.Items.Clear();
            txtPrice.Clear();
            price = 0.00f;
        }

        private void AddToCart()
        {
            lstCart.Items.Add(String.Format("{0:0000}", grdDvdSearch.Rows[grdDvdSearch.CurrentCell.RowIndex].Cells[0].Value) +
                                        "   " + grdDvdSearch.Rows[grdDvdSearch.CurrentCell.RowIndex].Cells[1].Value.ToString() +
                                        "   " + grdDvdSearch.Rows[grdDvdSearch.CurrentCell.RowIndex].Cells[2].Value.ToString());

            IncreasePrice();
            txtPrice.Text = price.ToString("0.00");
            
            void IncreasePrice()
            {
                if (grdDvdSearch.Rows[grdDvdSearch.CurrentCell.RowIndex].Cells[2].Value.ToString().Equals("CH"))
                    price += 3.50f;
                else if (grdDvdSearch.Rows[grdDvdSearch.CurrentCell.RowIndex].Cells[2].Value.ToString().Equals("NR"))
                    price += 8.00f;
                else
                    price += 5.00f;
            }
        }

        private void RemoveFromCart()
        {
            lstCart.Items.RemoveAt(cartIndex);
            DecreasePrice();
            txtPrice.Text = price.ToString("0.00");

            void DecreasePrice()
            {
                if (lstCart.Items[cartIndex].ToString().Contains("CH"))
                    price -= 3.50f;
                else if (lstCart.Items[cartIndex].ToString().Contains("NR"))
                    price -= 8.00f;
                else
                    price -= 5.00f;
            }
        }

        private void ShowMemberDetails()
        {
            txtRentID.Text = Rental.GetNextRentalId().ToString("00000");

            aMember.GetMemberDetails(memId);
            txtMemId.Text = Convert.ToString(memId);
            txtFirstName.Text = aMember.FirstName + " " + aMember.LastName;

            if (aMember.MembershipID == "PM")
            {
                dvdLimit = 10;
            }

            grpSearchResults.Visible = false;
            grpSearch.Visible = true;
            grpRentDetails.Visible = true;
        }

        private void ShowMemberResults()
        {
            grdSearchResults.DataSource = Member.SearchMember(txtMemberName.Text.ToUpper()).Tables["search"];
            grdSearchResults.DefaultCellStyle.Font = new Font("Courier", 9);
            grdSearchResults.DefaultCellStyle.ForeColor = Color.Black;
            grdSearchResults.Size = new Size(720, 300);
            btnReturn.Location = new Point(750, 150);

            grpMemCheck.Visible = false;

            grpSearchResults.Visible = true;
            grpSearchResults.Size = new Size(850, 350);
            grpSearchResults.Location = new Point(100, 100);
        }

        private void ShowDvdDetails()
        {
            grdDvdSearch.Visible = false;
            grdDvdSearch.DataSource = DVD.SearchDVD(txtDVDSearch.Text.ToUpper()).Tables["search"];
            grdDvdSearch.DefaultCellStyle.Font = new Font("Tahoma", 8);
            grdDvdSearch.DefaultCellStyle.ForeColor = Color.Black;
            grdDvdSearch.Visible = true;
        }

        private void ProcessRental()
        {
            try
            {
                UpdateRental();
                UpdateRentalItem();

                MessageBox.Show(null, "Order complete", "Successful", MessageBoxButtons.OK);
                ResetUI();  //necessary
                LoadUI();
            }
            catch (Exception e)
            {
                MessageBox.Show(null, "Error updating Database", "Error", MessageBoxButtons.OK);
                Debug.WriteLine("Error updating Database\n" + e.ToString());
            }
        }

        private void UpdateRentalItem()
        {
            for (int i = 0; i < lstCart.Items.Count; i++)
            {
                int dvdId = Convert.ToInt32(lstCart.Items[i].ToString().Substring(0, 4));
                DVD.UpdateStatus(dvdId, "A");
                RentalItem aRentalItem = new RentalItem(Convert.ToInt32(txtRentID.Text), dvdId, 0.00f);
                aRentalItem.AddRentalItem();
            }
        }

        private void UpdateRental()
        {
            Rental aRental = new Rental(Convert.ToInt32(txtRentID.Text), String.Format("{0:dd-MMM-yy}", DateTime.Today),
                String.Format("{0:dd-MMM-yy}", dtpReturnDate.Value),
                (float)Math.Round(Convert.ToDouble(txtPrice.Text), 2), Convert.ToInt32(txtMemId.Text));

            aRental.AddRental();
        }

        private void EmptyCart()
        {
            if (lstCart.Items.Count > 0)
            {
                lstCart.Items.Clear();
                price = 0.00f;
                txtPrice.Text = price.ToString("0.00");
            }
        }
    }
}
