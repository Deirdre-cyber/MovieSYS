using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmYearlyRevenue : Form
    {
        frmMainMenu parent;
        const int Months = 12;

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
            HideDetails();
            lblTitle.Text = "Revenue Analysis " + cboYear.Text;
            
            LoadDefaultGrid();
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grdRevenue.DataSource = null;
            grpRevenueDetails.Visible = false;
            btnDownload.Visible = false;
            btnPrint.Visible = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Send to printer
            MessageBox.Show("Revenue analysis for " + cboYear.Text + " sent to printer", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            //Download/convert to pdf
            MessageBox.Show("Revenue analysis for " + cboYear.Text + " downloaded as pdf", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //LOCAL METHODS
        private void LoadUI()
        {
            btnDownload.Visible = false;
            btnPrint.Visible = false;
            grpRevenueDetails.Visible = false;
            LoadYears();
        }

        private void LoadYears()
        {
            int year = DateTime.Today.Year;
            const int Years = 5;

            for (int i= 0; i < Years; i++)
            {
                cboYear.Items.Add(Convert.ToString(year-i));
            }

            cboYear.Text = year.ToString();
        }

        private void LoadDefaultGrid() {

            grdRevenue.ColumnCount = Months;
            grdRevenue.RowCount = 1;

            for (int i = 0; i < Months; i++)
            {
                grdRevenue.Columns[i].Width = 60;
                grdRevenue.Columns[i].Name = GetMonth(i + 1);
                grdRevenue.CurrentCell = grdRevenue.Rows[0].Cells[i];
                grdRevenue.CurrentCell.Value = 0;
            }

            //grid attributes
            grdRevenue.DefaultCellStyle.ForeColor = Color.Black;
            grdRevenue.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            grdRevenue.DefaultCellStyle.SelectionForeColor = Color.Black;
            grdRevenue.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdRevenue.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdRevenue.Visible = false;

        }

        private void HideDetails()
        {
            grpRevenueDetails.Visible = false;
            btnDownload.Visible = false;
            btnPrint.Visible = false;
        }

        private String GetMonth(int monthNum)
        {
            switch (monthNum)
            {
                case 1: return "JAN";
                case 2: return "FEB";
                case 3: return "MAR";
                case 4: return "APR";
                case 5: return "MAY";
                case 6: return "JUN";
                case 7: return "JUL";
                case 8: return "AUG";
                case 9: return "SEP";
                case 10: return "OCT";
                case 11: return "NOV";
                case 12: return "DEC";
                default: return "";
            }
        }

        private void LoadData()
        {
            if(Validation.IsTableEmpty(Rental.GetRevenueAnalysis(cboYear.Text.Substring(2, 2))))
            {
                MessageBox.Show("No data found for " + cboYear.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                cboYear.Focus();
                return;
            }

            DataSet ds = Rental.GetRevenueAnalysis(cboYear.Text.Substring(2, 2));

            for (int i = 0; i < ds.Tables["RA"].Rows.Count; i++)
            {
                grdRevenue.CurrentCell = grdRevenue.Rows[0].Cells[Convert.ToInt32(ds.Tables["RA"].Rows[i][0]) - 1];
                grdRevenue.CurrentCell.Value = ds.Tables["RA"].Rows[i][1].ToString();
            }

            HighlightMaxMin();

            grpRevenueDetails.Visible = true;
            grdRevenue.Visible = true;
            btnDownload.Visible = true;
            btnPrint.Visible = true;
        }

        private void HighlightMaxMin()
        {
            double max = Convert.ToDouble(grdRevenue.Rows[0].Cells[0].Value);
            double min = Convert.ToDouble(grdRevenue.Rows[0].Cells[0].Value);
            int maxCol = 0;
            int minCol = 0;

            for (int i = 0; i < Months; i++)
            {
                double currentValue = Convert.ToDouble(grdRevenue.Rows[0].Cells[i].Value);

                if (currentValue == 0)
                    grdRevenue.Rows[0].Cells[i].Style.ForeColor = Color.LightGray;

                if (currentValue > max)
                {
                    max = currentValue;
                    maxCol = i;
                }

                if (currentValue != 0 && currentValue < min)
                {
                    min = currentValue;
                    minCol = i;
                }
            }

            grdRevenue.CurrentCell = grdRevenue.Rows[0].Cells[0];
            //change header font
            grdRevenue.Rows[0].Cells[maxCol].Style.ForeColor = Color.Blue;
            //change header font
            grdRevenue.Rows[0].Cells[minCol].Style.ForeColor = Color.Red;
        }

    }
}
