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
    public partial class ReportEdit : Form
    {
        private string Email;
        private string PassHash;
        private Report.Booking ReportedBooking;
        private ReportManagerClient reportManager;
        private Report.Report report;
        private bool newReport;
        public ReportEdit(string Email, string PassHash, Report.Report report)
        {
            InitializeComponent();
            this.Email = Email;
            this.PassHash = PassHash;
            this.report = report;
            this.ReportedBooking = report.ReportedBooking;
            this.newReport = false;
            this.reportManager = new ReportManagerClient();
            subjectTextbox.Text = report.Subject;
            messageTextBox.Text = report.Message;
        }
        public ReportEdit (string Email, string PassHash, int BookingID) { 
        InitializeComponent();
            this.Email = Email;
            this.PassHash = PassHash;
            this.ReportedBooking = new Report.Booking();
            this.newReport = true;
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
            subjectTextbox.Text = "";
            messageTextBox.Text = "";
            DeleteButton.Visible = false;
        }
        private void Save(object sender, EventArgs e)
        {
            if (this.newReport)
                this.CreateReport(sender, e);
            else
                this.UpdateReport(sender, e);
        }
        private void DeleteReport(object sender, EventArgs e)
        {
            this.reportManager.DeleteReport(this.report.ID, this.Email, this.PassHash);
            this.StopEditing(sender, e);
        }
        private void CreateReport(object sender, EventArgs e)
        {
            this.reportManager.AddReport(messageTextBox.Text, subjectTextbox.Text, this.ReportedBooking, this.Email, this.PassHash);
            this.StopEditing(sender, e);
        }
        private void UpdateReport(object sender, EventArgs e)
        {
            this.report.Subject = subjectTextbox.Text;
            this.report.Message= messageTextBox.Text;
            this.reportManager.UpdateReport(this.report, this.Email, this.PassHash);
            this.StopEditing(sender, e);
        }
        private void StopEditing(object sender, EventArgs e)
        {
            ReportListForm ServicesListChild = new ReportListForm(this.Email, this.PassHash, this.ReportedBooking.ID);
            ServicesListChild.MdiParent = this.ParentForm;
            ServicesListChild.FormBorderStyle = FormBorderStyle.None;
            ServicesListChild.Dock = DockStyle.Fill;
            ServicesListChild.Show();
        }
  
    }
}
