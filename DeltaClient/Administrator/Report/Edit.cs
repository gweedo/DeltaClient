using DeltaClient.Booking;
using DeltaClient.Report;
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
    /// this form allow the admin to change or even add object and message of a report
    /// </summary>
    public partial class AdminReportEdit : Form
    {
        private string Email;
        private string PassHash;
        private Report.Booking ReportedBooking;
        private ReportManagerClient reportManager;
        private Report.Report report;
        private bool newReport;

        //constructor
        public AdminReportEdit(string Email, string PassHash, Report.Report report)
        {
            InitializeComponent();
            this.Email = Email;
            this.PassHash = PassHash;
            this.report = report;
            this.ReportedBooking = report.ReportedBooking;
            this.newReport = false;
            subjectTextbox.Text = report.Subject;
            messageTextBox.Text = report.Message;

            try
            {
                this.reportManager = new ReportManagerClient();
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
            }
        }


        //overloaded constructor. in this case the admin add a report
        public AdminReportEdit(string Email, string PassHash, int BookingID) {
            InitializeComponent();
            this.Email = Email;
            this.PassHash = PassHash;
            this.ReportedBooking = new Report.Booking();
            this.newReport = true;
            subjectTextbox.Text = "";
            messageTextBox.Text = "";
            DeleteButton.Visible = false;
            try
            {
                BookingManagerClient bookingManager = new BookingManagerClient();
                this.reportManager = new ReportManagerClient();
                Booking.Booking FetchedBooking = bookingManager.GetBookingByID(BookingID, this.Email, this.PassHash);
                ReportedBooking.ID = FetchedBooking.ID;
                ReportedBooking.BookedCar = new Report.Car();
                ReportedBooking.BookedCar.PlateNumber = FetchedBooking.BookedCar.PlateNumber;
                ReportedBooking.Booker = new Report.User();
                ReportedBooking.Booker.Email = FetchedBooking.Booker.Email;
                ReportedBooking.End = FetchedBooking.End;
                ReportedBooking.Start = FetchedBooking.Start;
              
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
            }
        }

        //this update the report
        private void UpdateReport(object sender, EventArgs e)
        {
            this.report.Subject = subjectTextbox.Text;
            this.report.Message = messageTextBox.Text;
            try
            {
                this.reportManager.UpdateReport(this.report, this.Email, this.PassHash);
                this.StopEditing(sender, e);
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco ad aggiornare il report.", MessageBoxButtons.OK);
            }
        }

        //on CLick fucntion. control if the amind is modifing or adding a report
        private void Save(object sender, EventArgs e)
        {
            if (this.newReport)
                this.CreateReport(sender, e);
            else
                this.UpdateReport(sender, e);
        }

        //This function add the report
        private void CreateReport(object sender, EventArgs e)
        {
            try
            {
                this.reportManager.AddReport(messageTextBox.Text, subjectTextbox.Text, this.ReportedBooking, this.Email, this.PassHash);
                this.StopEditing(sender, e);
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a creare il report.", MessageBoxButtons.OK);
            }
        }

        //on Click function. this function deleate the selected report
        private void DeleteReport(object sender, EventArgs e)
        {
            try
            {
                this.reportManager.DeleteReport(this.report.ID, this.Email, this.PassHash);
                this.StopEditing(sender, e);
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a cancellare il report.", MessageBoxButtons.OK);
            }
        }

        //on Click function. This function close this form and open the reportlist Form
        private void StopEditing(object sender, EventArgs e)
        {
            AdminReportList ServicesListChild = new AdminReportList(this.Email, this.PassHash, this.ReportedBooking.ID);
            ServicesListChild.MdiParent = this.ParentForm;
            ServicesListChild.FormBorderStyle = FormBorderStyle.None;
            ServicesListChild.Dock = DockStyle.Fill;
            ServicesListChild.Show();
        }
    }
}
