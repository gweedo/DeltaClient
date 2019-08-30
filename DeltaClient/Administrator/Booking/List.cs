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
    /// <summary>
    /// this child form show the list of all bookings
    /// </summary>
    public partial class AdminBookingList : Form
    {
        private string Email;
        private string PassHash;
        private string UserEmail;
        private BookingManagerClient bookingManager;

        //constructor
        public AdminBookingList(string Email, string PassHash, string UserEmail = "")
        {
            this.Email = Email;
            this.PassHash = PassHash;
            InitializeComponent();
            bookingsListView.Clear();
            this.UserEmail = UserEmail;
            bookingsListView.View = View.Details;
            bookingsListView.Columns.Add("ID", 230, HorizontalAlignment.Left);
            bookingsListView.Columns.Add("Targa", 230, HorizontalAlignment.Left);
            bookingsListView.Columns.Add("Utente", 200, HorizontalAlignment.Left);
            bookingsListView.Columns.Add("Inizio", 150, HorizontalAlignment.Left);
            bookingsListView.Columns.Add("Fine", 50, HorizontalAlignment.Left);

            try
            {
                this.bookingManager = new BookingManagerClient();
                this.UpdateBookings();
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
            }
        }


        //this function reload the list of all cars
        private void UpdateBookings()
        {
            bookingsListView.Clear();
            try
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
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco ad aggiornare la lista.", MessageBoxButtons.OK);
            }
            bookingsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            bookingsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //on Click function. this function delete a booking of the list
        private void DeleteBooking (object sender, EventArgs e)
        {
            try
            {
                this.bookingManager.DeleteBooking(this.bookingManager.GetBookingByID(Convert.ToInt32(bookingsListView.SelectedItems[0].Text), this.Email, this.PassHash), this.Email, this.PassHash);
                this.UpdateBookings();
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco ad eliminare la prenotazione.", MessageBoxButtons.OK);
            }
        }

        //on Click function. this show a new child form which allow the admin to modify the user of the booking
        private void EditUser (object sender, EventArgs e)
        {
            try
            {
                UserManagerClient userManager = new UserManagerClient();
                var selectedUser = bookingManager.GetBookingByID(Convert.ToInt32(bookingsListView.SelectedItems[0].Text), this.Email, this.PassHash).Booker;
                AdminUserEdit bookingFormChild = new AdminUserEdit(userManager.GetUserByEmail(selectedUser.Email, this.Email, this.PassHash), this.Email, this.PassHash);
                bookingFormChild.MdiParent = this.ParentForm;
                bookingFormChild.FormBorderStyle = FormBorderStyle.None;
                bookingFormChild.Dock = DockStyle.Fill;
                bookingFormChild.Show();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a mostrare l'utente della prenotazione.", MessageBoxButtons.OK);
            }
        }

        //on Click function. this show a new child form which allow the admin to modify the car of the booking
        private void EditCar (object sender, EventArgs e)
        {
            try
            {
                CarManagerClient carManager = new CarManagerClient();
                var selectedCar = bookingManager.GetBookingByID(Convert.ToInt32(bookingsListView.SelectedItems[0].Text), this.Email, this.PassHash).BookedCar;
                AdminCarEdit bookingFormChild = new AdminCarEdit(carManager.GetCarByPlate(selectedCar.PlateNumber, this.Email, this.PassHash), this.Email, this.PassHash);
                bookingFormChild.MdiParent = this.ParentForm;
                bookingFormChild.FormBorderStyle = FormBorderStyle.None;
                bookingFormChild.Dock = DockStyle.Fill;
                bookingFormChild.Show();
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a mostrare la macchina della prenotazione.", MessageBoxButtons.OK);
            }
        }

        //on Click function. this show the servicelist relative at the selected booking
        private void VaiAReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminReportList reportFormChild = new AdminReportList(this.Email, this.PassHash, Convert.ToInt32(this.bookingsListView.SelectedItems[0].Text));
            reportFormChild.MdiParent = this.ParentForm;
            reportFormChild.FormBorderStyle = FormBorderStyle.None;
            reportFormChild.Dock = DockStyle.Fill;
            reportFormChild.Show();
        }

        //on Click function. this function open a menu strip menu if the admin click, with the right buttons of the mouse, on a booking of the list   
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
    }
}
