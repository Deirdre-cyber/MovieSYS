﻿using System;
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
        private string message = "The details of your Rental are as follows: ";

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
                return;
            }

            if (Validation.IsTableEmpty(Member.SearchMember(txtMemberName.Text.ToUpper())))
            {
                MessageBox.Show(null, "There were no results matching your search", "No Data Found", MessageBoxButtons.OK);
                grdMemberResults.DataSource = null;
                txtMemberName.Clear();
                return;
            }

            ShowMemberResults();
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
            ResetUI();
            LoadUI();
        }

        private void grdDvdSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lstCart.Items.Count < dvdLimit)
            {
                if (lstCart.Items.Count > 0)
                {
                    int count;

                    for (count = 0; count < lstCart.Items.Count; count++)
                    {
                        if (lstCart.FindString(String.Format("{0:0000}", grdDvdResults.Rows[grdDvdResults.CurrentCell.RowIndex].Cells[0].Value)) != -1)
                            break;
                    }

                    if (count != lstCart.Items.Count)
                    {
                        MessageBox.Show(null, grdDvdResults.Rows[grdDvdResults.CurrentCell.RowIndex].Cells[1].Value.ToString() +
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
            if(grdMemberResults.Rows[grdMemberResults.CurrentCell.RowIndex].Cells[0].Value.ToString() != "")
            {
                memId = (int)grdMemberResults.Rows[grdMemberResults.CurrentCell.RowIndex].Cells[0].Value;

                if (!aMember.HasFine(memId) && !aMember.HasOverdue(memId))
                {
                    ShowMemberDetails();
                    return;
                }

                MessageBox.Show(null, "There are fines or overdue DVDs connected to this account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(null, "Must select a member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDVDSearch.Text) || string.IsNullOrEmpty(txtDVDSearch.Text))
            {
                MessageBox.Show(null, "Please enter the name of a DVD Title", "No Search Entered", MessageBoxButtons.OK);
                return;
            }

            if (Validation.IsTableEmpty(DVD.SearchDVD(txtDVDSearch.Text.ToUpper())))
            {
                MessageBox.Show(null, "There were no results matching your search", "No Data Found", MessageBoxButtons.OK);
                txtDVDSearch.Clear();
                return;
            }

            ShowDvdDetails();
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

        private void mnuBack_Click(object sender, EventArgs e)
        {
            if (grpMemberResults.Visible == true)
            {
                LoadUI();
            }
            if (grpMemberDetails.Visible == true && grpRentDetails.Visible == true)
            {
                ResetUI();
                grdDvdResults.DataSource = null;
                grpMemberDetails.Visible = false;
                grpRentDetails.Visible = false;
                grpMemberResults.Visible = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Utility.SavePdf(CreateMessage());
            Utility.PrintPDFWithAcrobat();      //necessary/working?

            ResetUI();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            Utility.EmailReceipt(CreateMessage());
            MessageBox.Show("Receipt sent to member" + txtFirstName.Text);

            ResetUI();
        }


        //LOCAL METHODS
        private void LoadUI()
        {
            grdDvdResults.DataSource = null;
            grpMemCheck.Location = new Point(260, 100);
            grdMemberResults.DataSource = null;
            grpMemberResults.Visible = false;
            dtpReturnDate.MinDate = DateTime.Today.AddDays(7);
            dtpReturnDate.MaxDate = DateTime.Today.AddDays(14);
            grpRentDetails.Visible = false;
            grpMemberDetails.Visible = false;
            txtMemberName.Clear();
            mnuBack.Visible = false;
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

            grpMemberResults.Visible = false;
            grpMemberDetails.Visible = true;
            grpRentDetails.Visible = true;
        }

        private void ShowMemberResults()
        {
            grdMemberResults.DataSource = Member.SearchMember(txtMemberName.Text.ToUpper()).Tables["search"];
            grdMemberResults.DefaultCellStyle.Font = new Font("Courier", 9);
            grdMemberResults.DefaultCellStyle.ForeColor = Color.Black;
            grdMemberResults.Size = new Size(720, 300);
            mnuBack.Visible = true;
            grpMemCheck.Visible = false;

            grpMemberResults.Visible = true;
            grpMemberResults.Size = new Size(850, 350);
            grpMemberResults.Location = new Point(100, 100);
        }

        private void ShowDvdDetails()
        {
            grdDvdResults.Visible = false;
            grdDvdResults.DataSource = DVD.SearchDVD(txtDVDSearch.Text.ToUpper()).Tables["search"];
            grdDvdResults.DefaultCellStyle.Font = new Font("Tahoma", 8);
            grdDvdResults.DefaultCellStyle.ForeColor = Color.Black;
            grdDvdResults.Visible = true;
        }

        private void ProcessRental()
        {
            try
            {
                UpdateRental();
                UpdateRentalItem();

                MessageBox.Show(null, "Order complete", "Successful", MessageBoxButtons.OK);
                ResetUI(); 
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
                RentalItem aRentalItem = new RentalItem(Convert.ToInt32(txtRentID.Text), dvdId, 0.00f, "");
                aRentalItem.AddRentalItem();
            }
        }

        private void UpdateRental()
        {
            Rental aRental = new Rental(Convert.ToInt32(txtRentID.Text), String.Format("{0:dd-MMM-yy}", DateTime.Today),
                String.Format("{0:dd-MMM-yy}", dtpReturnDate.Value),
                (float)Math.Round(Convert.ToDouble(txtPrice.Text), 2), Convert.ToInt32(txtMemId.Text), "");

            aRental.AddRental();
        }

        private void AddToCart()
        {
            lstCart.Items.Add(String.Format("{0:0000}", grdDvdResults.Rows[grdDvdResults.CurrentCell.RowIndex].Cells[0].Value) +
                                        "   " + grdDvdResults.Rows[grdDvdResults.CurrentCell.RowIndex].Cells[1].Value.ToString() +
                                        "   " + grdDvdResults.Rows[grdDvdResults.CurrentCell.RowIndex].Cells[2].Value.ToString());

            IncreasePrice();
            txtPrice.Text = price.ToString("0.00");

            void IncreasePrice()
            {
                if (grdDvdResults.Rows[grdDvdResults.CurrentCell.RowIndex].Cells[2].Value.ToString().Equals("CH"))
                    price += 3.50f;
                else if (grdDvdResults.Rows[grdDvdResults.CurrentCell.RowIndex].Cells[2].Value.ToString().Equals("NR"))
                    price += 8.00f;
                else
                    price += 5.00f;
            }
        }

        private void RemoveFromCart()
        {
            DecreasePrice();
            lstCart.Items.RemoveAt(cartIndex);
            txtPrice.Text = price.ToString("0.00");

            void DecreasePrice()
            {
                if ((lstCart.Items[cartIndex]).ToString().Contains("CH"))
                    price -= 3.50f;
                else if ((lstCart.Items[cartIndex]).ToString().Contains("NR"))
                    price -= 8.00f;
                else
                    price -= 5.00f;
            }
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

        private string CreateMessage()
        {
            message += "<p>" + String.Format("{0:dd-MMM-yy}", DateTime.Today) + "</p>";
            //rent date
            //rent id
            //mem id
            //cart contents
            //return date
            //cost

            return message;
        }

        
    }
}
