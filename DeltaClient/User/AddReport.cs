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
    public partial class UserAddReport : Form
    {
        protected string Email;
        protected string PasswordHash;
        private BookingManagerClient bookingManager;
        private Booking.Booking[] bookings;

        public UserAddReport(string Email, string PasswordHash)
        {
            this.Email = Email;
            this.PasswordHash = PasswordHash;
            InitializeComponent();
            BookingListComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.bookingManager = new BookingManagerClient();
            bookings = bookingManager.GetBookingsForUser(Email, Email, PasswordHash);
            foreach (Booking.Booking SingleBooking in bookings)
            {
                BookingListComboBox.Items.Add(SingleBooking.ID.ToString() + " - " + SingleBooking.BookedCar.Make + " " + SingleBooking.BookedCar.Model);
            }
        }

        private void InviaButton_Click(object sender, EventArgs e)
        {
            if (SubjectTextBox.Text == ("") || MessageTextBox.Text == ("")) MessageBox.Show("Riempi tutti i campi", "Controlla bene!", MessageBoxButtons.OK);
            else if (BookingListComboBox.SelectedIndex == -1) MessageBox.Show("Selezionare una prenotazione", "Controlla bene!", MessageBoxButtons.OK);//la combobox restituisce -1 se non è stato selezionato nessun elemento
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
                if (reportManager.AddReport(SubjectTextBox.Text, MessageTextBox.Text, selectedBooking, Email, PasswordHash))
                {
                    MessageBox.Show("Report inviato", "Grazie per la sua disponibilita");
                    this.cancelReport(sender, e);
                }
                else MessageBox.Show("oh-ho c'è stato un problema non previsto. La preghiamo di riprovare più tardi");
            }
        }

        private void cancelReport(object sender, EventArgs e)
        {
            UserAddReport listFormChild = new UserAddReport(Email, PasswordHash);
            listFormChild.MdiParent = ParentForm;
            listFormChild.FormBorderStyle = FormBorderStyle.None;
            listFormChild.Dock = DockStyle.Fill;
            listFormChild.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
        private void SendButton_Click(object sender, EventArgs e)
        {

        }

        private void UserAddReport_Load(object sender, EventArgs e)
        {

        }
    }
}
