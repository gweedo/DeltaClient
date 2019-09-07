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
{/// <summary>
/// this form permit the user to book a car for a lapse of time
/// </summary>
    public partial class UserCarBooker : Form
    {
        private string Email;
        private string PassHash;
        private List<Car.Car> AvailableCars;
        private BookingManagerClient bookingManager;
        private CarManagerClient carManager;

        //constuctor
        public UserCarBooker(string Email, string PassHash)//this page if accesible only for logged users so it requested the datas of the 
                                                           //logged users
        {
            InitializeComponent();
            try { 
                //initialize connection with the server
            this.bookingManager = new BookingManagerClient();
            this.carManager = new CarManagerClient();
            this.Email = Email;
            this.PassHash = PassHash;
            this.UpdateAvailableCars();

            bookingBox.DropDownStyle = ComboBoxStyle.DropDownList;
            carBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", exc.ToString(), MessageBoxButtons.OK);
                this.StopEditing();
            }

        }

        // reload function. every time the user get into the return car cab this function reload the bookings of the user
        private void UpdateBookings(object sender, EventArgs e)
        {
            try { 

            var bookings = this.bookingManager.GetBookingsForUser(this.Email, this.Email, this.Email);
            bookingBox.Items.Clear();

            foreach (var SingleBooking in bookings)
            {
                bookingBox.Items.Add(SingleBooking.ID.ToString() + " - " + SingleBooking.Start.ToShortDateString() + " - " + SingleBooking.BookedCar.PlateNumber);
            }
            }
            catch ( Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco ad aggiornare la pagina.", MessageBoxButtons.OK);
            }
        }


        // reload function. every time the user change the booking date this function reload the available cars
        private void UpdateAvailableCars(object sender = null, EventArgs e = null)
        {
            try
            {
                carBox.Items.Clear();
                this.AvailableCars = new List<Car.Car>(carManager.GetAvailableCars(startPicker.Value, endPicker.Value, this.Email, this.PassHash));
                foreach (var AvailableCar in this.AvailableCars)
                {
                    carBox.Items.Add(AvailableCar.PlateNumber + " - " + AvailableCar.Make + " " + AvailableCar.Model);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a ricaricare la lista delle macchine.", MessageBoxButtons.OK);
            }
        }
        //on Click function. take the data of the selected car and initialize a new booking sending data to the server
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
                try
                {
                    bookingManager.BookCar(car, startPicker.Value, endPicker.Value, this.Email, this.PassHash);
                MessageBox.Show("Auto prenotata!", "Puoi dormire sonni tranquilli.", MessageBoxButtons.OK);
                this.StopEditing();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a confermare la richiesta.", MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show("Controlla di aver inserito tutti i dati.", "Proprio non riesco così.", MessageBoxButtons.OK);
        }
        
        // on Click function. control all insert data, then close the book sending all data to the server
        private void returnBooking (object sender, EventArgs e)
        {
            if (bookingBox.SelectedIndex == -1 || Convert.ToInt32(litersUpDown.Value)== 0 || Convert.ToInt32(kilometersUpDown.Value) == 0)
                MessageBox.Show("Inserisci tutti i dati.", "Controlla bene i dati inseriti.", MessageBoxButtons.OK);
            else
            {
                var SelectedBooking = bookingBox.SelectedItem.ToString();
                SelectedBooking = SelectedBooking.Substring(0, SelectedBooking.IndexOf(" "));
                try
                {
                    this.bookingManager.EndBooking(bookingManager.GetBookingByID(Convert.ToInt32(SelectedBooking), this.Email, this.PassHash), Convert.ToInt32(kilometersUpDown.Value), Convert.ToInt32(litersUpDown.Value), this.Email, this.PassHash);
                    MessageBox.Show("Auto restituita!", "Puoi dormire sonni tranquilli.", MessageBoxButtons.OK);
                    this.StopEditing();
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a confermare la richiesta.", MessageBoxButtons.OK);
                }
            }
        }
        //close this form
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
    }
}
