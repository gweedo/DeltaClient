﻿using DeltaClient.Booking;
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
    public partial class BookingsForm : Form
    {
        private string Email;
        private string PassHash;
        private BookingManagerClient bookingManager;
        public BookingsForm(string Email, string PassHash)
        {
            this.Email = Email;
            this.PassHash = PassHash;
            InitializeComponent();
            bookingsListView.Clear();
            this.bookingManager = new BookingManagerClient();
            bookingsListView.View = View.Details;
            bookingsListView.Columns.Add("Targa", 230, HorizontalAlignment.Left);
            bookingsListView.Columns.Add("Utente", 200, HorizontalAlignment.Left);
            bookingsListView.Columns.Add("Inizio", 150, HorizontalAlignment.Left);
            bookingsListView.Columns.Add("Fine", 50, HorizontalAlignment.Left);
            var bookings = bookingManager.GetBookings(this.Email, this.PassHash);
            foreach (var SingleBooking in bookings)
            {
                bookingsListView.Items.Add(new ListViewItem(new string[] { SingleBooking.BookedCar.PlateNumber, SingleBooking.Booker.Email, SingleBooking.Start.ToString(), SingleBooking.End.ToString() }));
            }
            bookingsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            bookingsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void BookingsLabel_Click(object sender, EventArgs e)
        {

        }

        private void BookingsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}