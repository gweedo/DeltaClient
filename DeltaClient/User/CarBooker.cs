using DeltaClient.Booking;
using DeltaClient.Car;
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
    public partial class UserCarBooker : Form
    {
        private string Email;
        private string PassHash;
        private List<Car.Car> AvailableCars;
        private BookingManagerClient bookingManager;
        private CarManagerClient carManager;
        public UserCarBooker(string Email, string PassHash)
        {
            InitializeComponent();
            this.bookingManager = new BookingManagerClient();
            this.Email = Email;
            this.PassHash = PassHash;
            this.carManager = new CarManagerClient();
            this.UpdateAvailableCars();
            bookingBox.DropDownStyle = ComboBoxStyle.DropDownList;
            carBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void UpdateBookings(object sender, EventArgs e)
        {
            var bookings = this.bookingManager.GetBookingsForUser(this.Email, this.Email, this.Email);
            bookingBox.Items.Clear();
            foreach (var SingleBooking in bookings)
            {
                bookingBox.Items.Add(SingleBooking.ID.ToString() + " - " + SingleBooking.Start.ToShortDateString() + " - " + SingleBooking.BookedCar.PlateNumber);
            }
        }

        private void UpdateAvailableCars(object sender = null, EventArgs e = null)
        {
            carBox.Items.Clear();
            this.AvailableCars = new List<Car.Car> (carManager.GetAvailableCars(startPicker.Value, endPicker.Value, this.Email, this.PassHash));
            foreach (var AvailableCar in this.AvailableCars)
            {
                carBox.Items.Add(AvailableCar.PlateNumber + " - " + AvailableCar.Make + " " + AvailableCar.Model);
            }
        }

        private void confirmBooking(object sender, EventArgs e)
        {
            if (carBox.SelectedItem.ToString() != "" && startPicker.Value < endPicker.Value)
            {
                var car = new Booking.Car();
                var CarPlate = carBox.SelectedItem.ToString();
                CarPlate = CarPlate.Substring(0, CarPlate.IndexOf(" "));
                var fetchedCar = carManager.GetCarByPlate(CarPlate, this.Email, this.PassHash);
                car.PlateNumber = fetchedCar.PlateNumber;
                car.Make = fetchedCar.Make;
                car.Model = fetchedCar.Model;
                car.Year = fetchedCar.Year;
                car.Kilometers = fetchedCar.Kilometers;
                car.BurnedLiters = fetchedCar.BurnedLiters;

                bookingManager.BookCar(car, startPicker.Value, endPicker.Value, this.Email, this.PassHash);
                MessageBox.Show("Auto prenotata!", "Puoi dormire sonni tranquilli.", MessageBoxButtons.OK);
                this.StopEditing();
            }
            else
                MessageBox.Show("Controlla di aver inserito tutti i dati.", "Proprio non riesco così.", MessageBoxButtons.OK);
        }

        private void returnBooking (object sender, EventArgs e)
        {
            if (bookingBox.SelectedIndex == -1 || Convert.ToInt32(litersUpDown.Value)== 0 || Convert.ToInt32(kilometersUpDown.Value) == 0)
                MessageBox.Show("Inserisci tutti i dati.", "Controlla bene i dati inseriti.", MessageBoxButtons.OK);
            else
            {
                var SelectedBooking = bookingBox.SelectedItem.ToString();
                SelectedBooking = SelectedBooking.Substring(0, SelectedBooking.IndexOf(" "));
                this.bookingManager.EndBooking(bookingManager.GetBookingByID(Convert.ToInt32(SelectedBooking), this.Email, this.PassHash),Convert.ToInt32(kilometersUpDown.Value), Convert.ToInt32(litersUpDown.Value), this.Email, this.PassHash);
                MessageBox.Show("Auto restituita!", "Puoi dormire sonni tranquilli.", MessageBoxButtons.OK);
                this.StopEditing();
            }
        }

        private void StopEditing()
        {
            UserCarBooker childBooker = new UserCarBooker(this.Email, this.PassHash);
            childBooker.MdiParent = ParentForm;
            childBooker.FormBorderStyle = FormBorderStyle.None;
            childBooker.Dock = DockStyle.Fill;
            childBooker.Show();
        }
        private void BookCarTab_Click(object sender, EventArgs e)
        {

        }
        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void BookingsLabel_Click (object sender, EventArgs e)
        {

        }
        private void Label1_Click (object sender, EventArgs e)
        {

        }

        private void CarBooker_Load(object sender, EventArgs e)
        {

        }

        private void ReturnCarTab_Click(object sender, EventArgs e)
        {

        }
    }
}
