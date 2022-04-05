using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmListOverdue : Form
    {
        frmMainMenu parent;

        public frmListOverdue()
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

        public frmListOverdue(frmMainMenu Parent)
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

        private void frmListOverdue_Load(object sender, EventArgs e)
        {
            LoadUI();

            if (Validation.IsTableEmpty(Rental.GetOverdueDvds()))
            {
                MessageBox.Show(null, "There are no DVDs overdue at this time", "No Data Found", MessageBoxButtons.OK);
                txtDVDTitle.Clear();
            }
            else
                LoadList();
        }

        private void grdOverdueDVDs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDetails();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grpOverdueDetails.Visible = false;
        }

        private void btnSendReminder_Click(object sender, EventArgs e)
        {
            //METHOD SendReminder()
            MessageBox.Show(null, "Overdue rental reminders have been sent", "Reminder Sent", MessageBoxButtons.OKCancel);
        }

        //LOCAL METHODS
        private void LoadUI()
        {
            grpOverdueDetails.Visible = false;
            //grid box attributes, size position etc
        }

        private void LoadList()
        {
            grdOverdueDVDs.DataSource = Rental.GetOverdueDvds().Tables["overdue"];
            grdOverdueDVDs.DefaultCellStyle.Font = new Font("Tahoma", 8);
            grdOverdueDVDs.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void LoadDetails()
        {
            grpOverdueDetails.Visible = true;

            dtpRentDate.Value = Convert.ToDateTime(grdOverdueDVDs.Rows[grdOverdueDVDs.CurrentCell.RowIndex].Cells[4].Value.ToString());
            dtpDueBack.Value = Convert.ToDateTime(grdOverdueDVDs.Rows[grdOverdueDVDs.CurrentCell.RowIndex].Cells[5].Value.ToString());

            int memId = Convert.ToInt32(grdOverdueDVDs.Rows[grdOverdueDVDs.CurrentCell.RowIndex].Cells[0].Value);
            int rentId = Convert.ToInt32(grdOverdueDVDs.Rows[grdOverdueDVDs.CurrentCell.RowIndex].Cells[1].Value);
            int fine = (int)(RentalItem.GetDaysOverdue(memId, rentId) * 0.20);

            txtMemId.Text = memId.ToString("0000");
            txtDVDTitle.Text = grdOverdueDVDs.Rows[grdOverdueDVDs.CurrentCell.RowIndex].Cells[3].Value.ToString();

            txtFineAmount.Text = fine.ToString("0.00");
        }

    }
}