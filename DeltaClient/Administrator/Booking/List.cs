using DeltaClient.Booking;
using DeltaClient.Car;
using DeltaClient.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeltaClient
{
    public partial class AdminBookingList : Form
    {
        private string Email;
        private string PassHash;
        private string UserEmail;
        private BookingManagerClient bookingManager;
        public AdminBookingList(string Email, string PassHash, string UserEmail = "")
        {
            this.Email = Email;
            this.PassHash = PassHash;
            InitializeComponent();
            bookingsListView.Clear();
            this.bookingManager = new BookingManagerClient();
            this.UserEmail = UserEmail;
            bookingsListView.View = View.Details;
            bookingsListView.Columns.Add("ID", 230, HorizontalAlignment.Left);
            bookingsListView.Columns.Add("Targa", 230, HorizontalAlignment.Left);
            bookingsListView.Columns.Add("Utente", 200, HorizontalAlignment.Left);
            bookingsListView.Columns.Add("Inizio", 150, HorizontalAlignment.Left);
            bookingsListView.Columns.Add("Fine", 50, HorizontalAlignment.Left);
            this.UpdateBookings();
        }

        private void DeleteBooking (object sender, EventArgs e)
        {
            this.bookingManager.DeleteBooking(this.bookingManager.GetBookingByID(Convert.ToInt32(bookingsListView.SelectedItems[0].Text), this.Email, this.PassHash), this.Email, this.PassHash);
            this.UpdateBookings();
        }

        private void UpdateBookings()
        {
            var bookings = bookingManager.GetBookings(this.Email, this.PassHash);
            if (this.UserEmail != "")
            {
                bookings = bookingManager.GetBookingsForUser(this.UserEmail, this.Email, this.PassHash);
                labelUser.Text = "di " + this.UserEmail;
                labelUser.Left = (this.ClientSize.Width - labelUser.Width) / 2;

            }
            foreach (var SingleBooking in bookings)
            {
                bookingsListView.Items.Add(new ListViewItem(new string[] { SingleBooking.ID.ToString(), SingleBooking.BookedCar.PlateNumber, SingleBooking.Booker.Email, SingleBooking.Start.ToShortDateString(), SingleBooking.End.ToShortDateString() }));
            }
            bookingsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            bookingsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void EditUser (object sender, EventArgs e)
        {
            UserManagerClient userManager = new UserManagerClient();
            var selectedUser = bookingManager.GetBookingByID(Convert.ToInt32(bookingsListView.SelectedItems[0].Text), this.Email, this.PassHash).Booker;
            AdminUserEdit bookingFormChild = new AdminUserEdit(userManager.GetUserByEmail(selectedUser.Email, this.Email, this.PassHash), this.Email, this.PassHash);
            bookingFormChild.MdiParent = this.ParentForm;
            bookingFormChild.FormBorderStyle = FormBorderStyle.None;
            bookingFormChild.Dock = DockStyle.Fill;
            bookingFormChild.Show();
        }

        private void EditCar (object sender, EventArgs e)
        {
            CarManagerClient carManager = new CarManagerClient();
            var selectedCar = bookingManager.GetBookingByID(Convert.ToInt32(bookingsListView.SelectedItems[0].Text), this.Email, this.PassHash).BookedCar;
            AdminCarEdit bookingFormChild = new AdminCarEdit(carManager.GetCarByPlate(selectedCar.PlateNumber, this.Email, this.PassHash), this.Email, this.PassHash);
            bookingFormChild.MdiParent = this.ParentForm;
            bookingFormChild.FormBorderStyle = FormBorderStyle.None;
            bookingFormChild.Dock = DockStyle.Fill;
            bookingFormChild.Show();
        }
        private void BookingsListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (bookingsListView.FocusedItem.Bounds.Contains(e.Location))
                {
                    bookingMenu.Show(Cursor.Position);
                }
            }
        }

        private void VaiAReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminReportList reportFormChild = new AdminReportList(this.Email, this.PassHash, Convert.ToInt32(this.bookingsListView.SelectedItems[0].Text));
            reportFormChild.MdiParent = this.ParentForm;
            reportFormChild.FormBorderStyle = FormBorderStyle.None;
            reportFormChild.Dock = DockStyle.Fill;
            reportFormChild.Show();
        }
    }
}
