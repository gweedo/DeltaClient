﻿using System;
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
    /// <summary>
    /// this is the child form For the normal User. It handle the report messages of the users for problems or events with the car
    /// </summary>


    public partial class UserAddReport : Form
    {
        protected string Email;
        protected string PasswordHash;
        private BookingManagerClient bookingManager;
        private Booking.Booking[] bookings;

        //constructor
        public UserAddReport(string Email, string PasswordHash)//this page if accesible only for logged users so it requested the datas of the 
                                                               //logged users
        {
            try
            {
                this.Email = Email;
                this.PasswordHash = PasswordHash;
                InitializeComponent();
                // Initializing Design
                BookingListComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                //initialize connection with the server
                this.bookingManager = new BookingManagerClient();
                bookings = bookingManager.GetBookingsForUser(Email, Email, PasswordHash);
                //show all the bookings of the user so he can select the one to add the report
                foreach (Booking.Booking SingleBooking in bookings)
                {
                    BookingListComboBox.Items.Add(SingleBooking.ID.ToString() + " - " + SingleBooking.BookedCar.Make + " " + SingleBooking.BookedCar.Model);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
                this.cancelReport();
            }
        }

        //on Click function. this function control the data insert by the user and, if the data are correct, send all to the server
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
                
                    //adding user data
                    Report.User UserReported = new Report.User();
                    UserReported.Email = Booked.Booker.Email;
                    UserReported.PasswordHash = Booked.Booker.PasswordHash;
                    UserReported.Name = Booked.Booker.Name;
                    UserReported.License = Booked.Booker.License;
                    UserReported.LicensePoints = Booked.Booker.LicensePoints;
                    UserReported.LicenseExpiration = Booked.Booker.LicenseExpiration;

                    selectedBooking.Booker = UserReported;

                    //addign booked car data
                    Report.Car CarReported = new Report.Car();
                    CarReported.PlateNumber = Booked.BookedCar.PlateNumber;
                    CarReported.Make = Booked.BookedCar.Make;
                    CarReported.Model = Booked.BookedCar.Model;
                    CarReported.Year = Booked.BookedCar.Year;
                    CarReported.Kilometers = Booked.BookedCar.Kilometers;
                    CarReported.BurnedLiters = Booked.BookedCar.BurnedLiters;

                    selectedBooking.BookedCar = CarReported;

                try
                {
                    ReportManagerClient reportManager = new ReportManagerClient();
                    if (reportManager.AddReport(SubjectTextBox.Text, MessageTextBox.Text, selectedBooking, Email, PasswordHash))
                    {
                        MessageBox.Show("Report inviato", "Grazie per la sua disponibilita");
                        this.cancelReport();
                    }
                    else MessageBox.Show("oh-ho c'è stato un problema non previsto. La preghiamo di riprovare più tardi");
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
                }
            }

        }
        //on Click function.delete the report and close this child form
        protected void cancelReport()
        {
            UserAddReport listFormChild = new UserAddReport(Email, PasswordHash);
            listFormChild.MdiParent = ParentForm;
            listFormChild.FormBorderStyle = FormBorderStyle.None;
            listFormChild.Dock = DockStyle.Fill;
            listFormChild.Show();
        }
    }
}

        

  