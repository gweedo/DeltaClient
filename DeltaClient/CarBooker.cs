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
    public partial class CarBooker : Form
    {
        private string Email;
        private string PassHash;
        private List<Car.Car> AvailableCars;
        private BookingManagerClient bookingManager;
        private CarManagerClient carManager;
        public CarBooker(string Email, string PassHash)
        {
            InitializeComponent();
            this.bookingManager = new BookingManagerClient();
            this.Email = Email;
            this.PassHash = PassHash;
            this.carManager = new CarManagerClient();
        }

        private void UpdateAvailableCars(object sender, DateRangeEventArgs e)
        {
            carBox.Items.Clear();
            this.AvailableCars = new List<Car.Car> (carManager.GetAvailableCars(startPicker.Value, endPicker.Value, this.Email, this.PassHash));
            foreach (var AvailableCar in this.AvailableCars)
            {
                carBox.Items.Add(AvailableCar.PlateNumber);
            }
        }

        private void confirmBooking(object sender, EventArgs e)
        {
            var car = new Booking.Car();
            var fetchedCar = carManager.GetCarByPlate(carBox.SelectedItem.ToString(), this.Email, this.PassHash);
            car.PlateNumber = fetchedCar.PlateNumber;
            car.Make = fetchedCar.Make;
            car.Model = fetchedCar.Model;
            car.Year = fetchedCar.Year;
            car.Kilometers = fetchedCar.Kilometers;
            car.BurnedLiters = fetchedCar.BurnedLiters;
            if(carBox.SelectedItem.ToString()!="")
                bookingManager.BookCar(car, startPicker.Value, endPicker.Value, this.Email, this.PassHash);
            else
                MessageBox.Show("Seleziona l'auto.", "Proprio non riesco così.", MessageBoxButtons.OK);

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

    }
}
