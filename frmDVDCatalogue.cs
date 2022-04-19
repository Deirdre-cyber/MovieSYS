using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmDVDCatalogue : Form
    {
        frmMainMenu parent;
        private bool validName = false;
        private bool validDuration = false;
        private bool validYear = false;
        private bool validCopies = false;


        public frmDVDCatalogue()
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
        public frmDVDCatalogue(frmMainMenu Parent)
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

        private void frmDVDCatalogue_Load(object sender, EventArgs e)
        {
            LoadUI();
        }

        private void btnConfirmInfo_Click(object sender, EventArgs e)
        {
            if (AllValid())
            {
                DialogResult result = MessageBox.Show(null, "Do you want to add " + txtCopies.Text + " copies of '" + txtDVDName.Text + "' to MovieSYS?", "Confirm", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    try
                    {
                        AddDvdCopy();
                        MessageBox.Show(null, "DVD has been added successfuly", "Added Successfully", MessageBoxButtons.OK);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show(null, "All fields must be completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(null, "All fields must be completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show(null, "Invalid data, please check form for errors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
            ResetUI();
            txtDVDId.Text = DVD.GetNextDVDID().ToString("0000");
        }

        //LOACAL METHODS
        private void LoadUI()
        {
            txtDVDId.Text = DVD.GetNextDVDID().ToString("0000");

            dtpDate.Value = DateTime.Today;

            DataSet genreDS = Utility.getGenreCodes();
            for (int i = 0; i < genreDS.Tables[0].Rows.Count; i++)
                cboGenre.Items.Add(genreDS.Tables[0].Rows[i][0] + " - " + genreDS.Tables[0].Rows[i][1]);

            DataSet catDS = Utility.getCategoryCodes();
            for (int i = 0; i < catDS.Tables[0].Rows.Count; i++)
                cboCat.Items.Add(catDS.Tables[0].Rows[i][0] + " - " + catDS.Tables[0].Rows[i][1]);

            DataSet countryDS = Utility.getCountryCodes();
            for (int i = 0; i < countryDS.Tables[0].Rows.Count; i++)
                cboCountry.Items.Add(countryDS.Tables[0].Rows[i][0] + " - " + countryDS.Tables[0].Rows[i][1]);

            DataSet ageDS = Utility.getAgeCodes();
            for (int i = 0; i < ageDS.Tables[0].Rows.Count; i++)
                cboAge.Items.Add(ageDS.Tables[0].Rows[i][0]);
        }
        private void AddDvdCopy()
        {
            if (Convert.ToInt32(txtCopies.Text) >= 1)
            {
                for (int i = 0; i < Convert.ToInt32(txtCopies.Text); i++)
                {
                    DVD aDVD = new DVD(Convert.ToInt32(txtDVDId.Text), txtDVDName.Text, cboCat.Text.Substring(0, 2),
                            Utility.setGenre(cboGenre.Text), cboCountry.Text.Substring(0, 2), txtYear.Text, Convert.ToInt32(txtDuration.Text),
                            String.Format("{0:dd-MMM-yy}", dtpDate.Value), cboAge.Text.Substring(0, 2), "A");

                    aDVD.AddDVD();
                }
            }            
        }
        private void ResetUI() //MAKE UNIVERSAL METHOD IN UTILITY CLASS
        {
            Utility.ClearText(this.Controls);
            dtpDate.Value = DateTime.Today;
            cboCat.Text = null;
            cboGenre.Text = null;
            cboCountry.Text = null;
            cboAge.Text = null;
            txtDVDName.Focus();
        }
        private void AutoCompleteDvd()
        {
            DVD bDVD = new DVD();
            bDVD.GetPartialDvdDetails(txtDVDName.Text.ToUpper());
            txtDVDName.Text = bDVD.Title;
            cboCat.Text = bDVD.CategoryCode;
            cboGenre.Text = bDVD.GenreCode;
            cboCountry.Text = bDVD.CountryCode;
            txtYear.Text = bDVD.ReleaseYear;
            txtDuration.Text = Convert.ToString(bDVD.Duration);
            cboAge.Text = bDVD.AgeCode;
        }

        //VALIDATION METHODS
        private bool AllValid()
        {
            if (validName && validDuration && validYear && validCopies)
                return true;
            else
                return false;
        }
        private void TxtDVDName_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDVDName.Text))
            {
                txtDVDName.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtDVDName, "Title should not be left blank");
                validName = false;
                return;
            }

            if (!Validation.IsTableEmpty(DVD.SearchDVD(txtDVDName.Text.ToUpper())))
            {
                DialogResult res = MessageBox.Show(null, "DVD title already exists, autocomplete form?", "DVD Title already exists", MessageBoxButtons.OKCancel);

                CheckAnswer(res);
                validYear = true;
                validDuration = true;
                return;
            }

            txtDVDName.BackColor = Color.White;
            errorProvider1.Clear();
            validName = true;

            void CheckAnswer(DialogResult r)
            {
                if (r == DialogResult.OK)
                {
                    AutoCompleteDvd();
                    txtDVDName.BackColor = Color.White;
                    errorProvider1.Clear();
                    validName = true;
                    return;
                }

                validName = false;
            }

        }
        private void CboCat_Validating(object sender, CancelEventArgs e)
        {
            if (cboCat.Text == "" && cboCat.SelectedIndex == -1)
            {
                cboCat.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(cboCat, "Must choose category");
                return;
            }

            cboCat.BackColor = Color.White;
            errorProvider1.Clear();
        }
        private void CboGenre_Validating(object sender, CancelEventArgs e)
        {
            if (cboGenre.Text == "" && cboGenre.SelectedIndex == -1)
            {
                cboGenre.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(cboGenre, "Must choose genre");
                return;
            }

            cboGenre.BackColor = Color.White;
            errorProvider1.Clear();
        }
        private void CboCountry_Validating(object sender, CancelEventArgs e)
        {
            if (cboCountry.Text == "" && cboCountry.SelectedIndex == -1)
            {
                cboCountry.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(cboCountry, "Must choose country");
                return;
            }

            cboCountry.BackColor = Color.White;
            errorProvider1.Clear();
        }
        private void CboAge_Validating(object sender, CancelEventArgs e)
        {
            if (cboAge.Text == "" && cboAge.SelectedIndex == -1)
            {
                cboAge.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(cboAge, "Must choose age rating");
                return;
            }

            cboAge.BackColor = Color.White;
            errorProvider1.Clear();
        }
        private void TxtDuration_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDuration.Text))
            {
                txtDuration.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtDuration, "Duration cannot be left blank");
                validDuration = false;
                return;
            }
            if (!Validation.IsNumber(txtDuration.Text))
            {
                txtDuration.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtDuration, "Duration should be only digits");
                validDuration = false;
                return;
            }
            if (Convert.ToInt32(txtDuration.Text) <= 0)
            {
                txtDuration.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtDuration, "Duration should be more than 0");
                validDuration = false;
                return;
            }

            txtDuration.BackColor = Color.White;
            errorProvider1.Clear();
            validDuration = true;
        }
        private void TxtCopies_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCopies.Text))
            {
                txtCopies.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtCopies, "Copies cannot be left blank");
                validCopies = false;
                return;
            }
            if (!Validation.IsNumber(txtCopies.Text))
            {
                txtCopies.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtCopies, "Copies should be only digits");
                validCopies = false;
                return;
            }
            if (Convert.ToInt32(txtCopies.Text) <= 0)
            {
                txtCopies.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtCopies, "Copies should be more than 0");
                validCopies = false;
                return;
            }

            txtCopies.BackColor = Color.White;
            errorProvider1.Clear();
            validCopies = true;
        }
        private void TxtYear_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtYear.Text))
            {
                txtYear.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtYear, "Year cannot be left blank");
                validYear = false;
                return;
            }
            if (!Validation.IsNumber(txtYear.Text))
            {
                txtYear.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtYear, "Year should be four digits");
                validYear = false;
                return;
            }
            if (Convert.ToInt32(txtYear.Text) < 1900 || Convert.ToInt32(txtYear.Text) > 2999)
            {
                txtYear.BackColor = Color.DarkSalmon;
                errorProvider1.SetError(txtYear, "Year should be valid year");
                validYear = false;
                return;
            }

            txtYear.BackColor = Color.White;
            errorProvider1.Clear();
            validYear = true;
        }
    }
}
