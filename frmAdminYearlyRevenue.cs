using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmYearlyRevenue : Form
    {
        frmMainMenu parent;

        public frmYearlyRevenue()
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

        public frmYearlyRevenue(frmMainMenu Parent)
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

        private void frmYearlyRevenue_Load(object sender, EventArgs e)
        {
            LoadUI();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Revenue Analysis " + cboYear.Text;
            grdRevenue.DataSource = Rental.GetRevenueAnalysis(cboYear.Text.Substring(0,1)).Tables["RA"];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void grdRevenue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //LOCAL METHODS
        public void LoadUI()
        {
            btnDownload.Visible = false;
            btnPrint.Visible = false;
            LoadYears();
        }

        public void LoadYears()
        {
            int year = DateTime.Today.Year;
            int years = 5;

            for (int i= 0; i < years; i++)
            {
                    cboYear.Items.Add(Convert.ToString(year-i));
            }

            cboYear.Text = year.ToString();
        }

        
    }
}
