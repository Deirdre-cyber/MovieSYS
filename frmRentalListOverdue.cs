using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MovieSYS
{
    public partial class frmListOverdue : Form
    {
        frmMainMenu parent;
        private int memId;
        private int rentId;

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

            if (Validation.IsTableEmpty(RentalItem.GetOverdueDvds()))
            {
                MessageBox.Show(null, "There are no DVDs overdue at this time", "No Data Found", MessageBoxButtons.OK);
                txtDVDTitle.Clear();
                return;
            }

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
            if (Rental.GetLastReminderDate().CompareTo(DateTime.Today.ToString()) < 0)
            {
                for (int i = 0; i < grdOverdueDVDs.RowCount; i++)
                {
                    memId = Convert.ToInt32(grdOverdueDVDs.Rows[i].Cells[0].Value);
                    rentId = Convert.ToInt32(grdOverdueDVDs.Rows[i].Cells[1].Value);
                    SendOverdueReminders();
                }

                lblReminderDate.Text = "Reminders last sent : " + Rental.GetLastReminderDate();
                MessageBox.Show(null, "Overdue rental reminders have been sent", "Reminder Sent", MessageBoxButtons.OKCancel);
                return;
            }

            MessageBox.Show(null, "Overdue rental reminders have already been sent today", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        //LOCAL METHODS
        private void LoadUI()
        {
            btnSendReminder.Visible = false;
            grpOverdueDetails.Visible = false;
            //grid box attributes, size position etc
        }

        private void LoadList()
        {
            grdOverdueDVDs.DataSource = RentalItem.GetOverdueDvds().Tables["overdue"];
            grdOverdueDVDs.DefaultCellStyle.Font = new Font("Tahoma", 8);
            grdOverdueDVDs.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10);
            grdOverdueDVDs.DefaultCellStyle.ForeColor = Color.Black;

            string[] headings = { "Member ID", "Rent ID", "DVD ID", "Title", "Rent Date", "Due Date" };

            for(int i = 0; i < grdOverdueDVDs.ColumnCount; i++)
            {
                grdOverdueDVDs.Columns[i].HeaderText = headings[i];
            }

            grdOverdueDVDs.Columns[0].Width = 60;
            grdOverdueDVDs.Columns[1].Width = 60;
            grdOverdueDVDs.Columns[2].Width = 60;
            grdOverdueDVDs.Columns[3].Width = 200;
            grdOverdueDVDs.Columns[4].Width = 120;
            grdOverdueDVDs.Columns[5].Width = 120;
        }

        private void LoadDetails()
        {
            grpOverdueDetails.Visible = true;

            dtpRentDate.Value = Convert.ToDateTime(grdOverdueDVDs.Rows[grdOverdueDVDs.CurrentCell.RowIndex].Cells[4].Value.ToString());
            dtpDueBack.Value = Convert.ToDateTime(grdOverdueDVDs.Rows[grdOverdueDVDs.CurrentCell.RowIndex].Cells[5].Value.ToString());

            memId = Convert.ToInt32(grdOverdueDVDs.Rows[grdOverdueDVDs.CurrentCell.RowIndex].Cells[0].Value);
            rentId = Convert.ToInt32(grdOverdueDVDs.Rows[grdOverdueDVDs.CurrentCell.RowIndex].Cells[1].Value);
            float fine = (float)(RentalItem.GetDaysOverdue(memId, rentId) * 0.20);

            txtMemId.Text = memId.ToString("00000");
            txtDVDTitle.Text = grdOverdueDVDs.Rows[grdOverdueDVDs.CurrentCell.RowIndex].Cells[3].Value.ToString();

            txtFineAmount.Text = fine.ToString("0.00");
            lblReminderDate.Text = "Reminders last sent : " + Rental.GetLastReminderDate();
            btnSendReminder.Visible = true;
        }

        private void SendOverdueReminders()
        {
            if (RentalItem.GetDaysOverdue(memId, rentId) == 0)
            {
                Rental.SendReminder(rentId);
                //send email
                MessageBox.Show(null, "Reminders have been sent to Member " + memId, "Reminder Sent", MessageBoxButtons.OKCancel);
                return;
            }

            if (RentalItem.GetDaysOverdue(memId, rentId) == 7)
            {
                Rental.SendReminder(rentId);
                //send email
                MessageBox.Show(null, "Week overdue reminders have been sent to Member " + memId, "Reminder Sent", MessageBoxButtons.OKCancel);
                return;
            }

            if (RentalItem.GetDaysOverdue(memId, rentId) == 30)
            {
                Rental.SendReminder(rentId);
                //send email
                MessageBox.Show(null, "Month overdue reminders have been sent to Member " + memId, "Reminder Sent", MessageBoxButtons.OKCancel);
                return;
            }

            if (RentalItem.GetDaysOverdue(memId, rentId) == 60)
            {
                Rental.SendReminder(rentId);
                //send email
                MessageBox.Show(null, "Final reminder has been sent to Member " + memId, "Reminder Sent", MessageBoxButtons.OKCancel);
                return;
            }
        }
    }
}