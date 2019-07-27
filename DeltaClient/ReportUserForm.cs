using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeltaClient.Booking;
using DeltaClient.Report;

namespace DeltaClient
{
    public partial class ReportUserForm : Form
    {
        protected string Email;
        protected string PasswordHash;
        private BookingManagerClient bookingManager;
        private Booking.Booking[] bookings;

        public ReportUserForm(string email, string passwordHash)
        {
            Email = email;
            PasswordHash = passwordHash;
            InitializeComponent();

            this.bookingManager = new BookingManagerClient();
            bookings = bookingManager.GetBookings(Email, PasswordHash);
            foreach (Booking.Booking SingleBooking in bookings) {
                BookingListComboBox.Items.Add(SingleBooking);
            }
        }

        private void InviaButton_Click(object sender, EventArgs e)
        {
            if (SubjectTextBox.Text == ("") || MessageTextBox.Text == ("")) MessageBox.Show("riempire i campi di testo");
            else if (BookingListComboBox.SelectedIndex == -1) MessageBox.Show("selezionare una prenotazione");//la combobox restituisce -1 se non è stato selezionato nessun elemento
            else
            {
                Booking.Booking Booked = bookings[BookingListComboBox.SelectedIndex];
                Report.Booking selectedBooking = new Report.Booking();

                selectedBooking.ID = Booked.ID;
                selectedBooking.Start = Booked.Start;
                selectedBooking.End = Booked.End;
                selectedBooking.Returned = Booked.Returned;

                //aggiungo i dati dell'utente
                Report.User UserReported = new Report.User();
                UserReported.Email = Booked.Booker.Email;
                UserReported.PasswordHash = Booked.Booker.PasswordHash;
                UserReported.Name = Booked.Booker.Name;
                UserReported.License = Booked.Booker.License;
                UserReported.LicensePoints = Booked.Booker.LicensePoints;
                UserReported.LicenseExpiration = Booked.Booker.LicenseExpiration;

                selectedBooking.Booker = UserReported;

                //aggiungo i dati della macchina noleggiata
                Report.Car CarReported = new Report.Car();
                CarReported.PlateNumber = Booked.BookedCar.PlateNumber;
                CarReported.Make = Booked.BookedCar.Make;
                CarReported.Model = Booked.BookedCar.Model;
                CarReported.Year = Booked.BookedCar.Year;
                CarReported.Kilometers = Booked.BookedCar.Kilometers;
                CarReported.BurnedLiters = Booked.BookedCar.BurnedLiters;

                selectedBooking.BookedCar = CarReported;


                ReportManagerClient reportManager = new ReportManagerClient();
                reportManager.AddReport(SubjectTextBox.Text, MessageTextBox.Text, selectedBooking , Email, PasswordHash);
            }
        }

        private void cancelReport(object sender, EventArgs e)
        {
            UserListForm listFormChild = new UserListForm(Email, PasswordHash);
            listFormChild.MdiParent = ParentForm;
            listFormChild.FormBorderStyle = FormBorderStyle.None;
            listFormChild.Dock = DockStyle.Fill;
            listFormChild.Show();
        }
    }
}
