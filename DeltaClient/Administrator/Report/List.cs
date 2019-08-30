using DeltaClient.Car;
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
    /// this child form show the list of all reports and, once selected one, reiderct the admin to another child form which allow some changes to the selceted report
    /// </summary>
    public partial class AdminReportList : Form
    {
        private string Email;
        private string PassHash;
        private int BookingID;
        private ReportManagerClient reportManager;
        private CarManagerClient carManager;

        //contrusctor
        public AdminReportList(string Email, string PassHash, int BookingID)
        {
            this.Email = Email;
            this.PassHash = PassHash;

            InitializeComponent();
            this.BookingID = BookingID;
            reportListView.View = View.Details;
            reportListView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            reportListView.Columns.Add("Oggetto", -2, HorizontalAlignment.Left);
            reportListView.Columns.Add("Messaggio", -2, HorizontalAlignment.Left);

            try
            {
                this.reportManager = new ReportManagerClient();
                this.carManager = new CarManagerClient();
                this.UpdateReports();
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
            }
        }


        //this function reload the list of all reports
        private void UpdateReports()
        {
            reportListView.Items.Clear();

            try
            {
                var reports = reportManager.getReportsForBooking(this.BookingID, this.Email, this.PassHash);
                PlateNumberLabel.Text = "su prenotazione " + this.BookingID;
                PlateNumberLabel.Left = (this.ClientSize.Width - PlateNumberLabel.Width) / 2;
                foreach (var SingleReport in reports)
                {
                    reportListView.Items.Add(new ListViewItem(new string[] { SingleReport.ID.ToString(), SingleReport.Subject, SingleReport.Message }));
                }
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco ad aggiornare la lista dei report.", MessageBoxButtons.OK);
            }
            reportListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            reportListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //on Click function. this show a new child form which allow the admin to add a report
        private void AddReport(object sender, EventArgs e)
        {
            AdminReportEdit ReportListChild = new AdminReportEdit(this.Email, this.PassHash, this.BookingID);
            ReportListChild.MdiParent = this.ParentForm;
            ReportListChild.FormBorderStyle = FormBorderStyle.None;
            ReportListChild.Dock = DockStyle.Fill;
            ReportListChild.Show();
        }

        //on Click function. this function delete a report of the list
        private void DeleteReport(object sender, EventArgs e)
        {
            try
            {
                this.reportManager.DeleteReport(Convert.ToInt32(reportListView.SelectedItems[0].Text), this.Email, this.PassHash);
                this.UpdateReports();
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco ad eliminare il report", MessageBoxButtons.OK);
            }
        }

        //on Click function. this show a new child form which allow the admin to modify a service
        private void EditReport (object sender, EventArgs e)
        {
            if (reportListView.SelectedItems.Count == 1)
            {
                try
                {
                    var selectedReport = this.reportManager.getReportByID(Convert.ToInt32(this.reportListView.SelectedItems[0].Text), this.Email, this.PassHash);
                    AdminReportEdit ReportListChild = new AdminReportEdit(this.Email, this.PassHash, selectedReport);
                    ReportListChild.MdiParent = this.ParentForm;
                    ReportListChild.FormBorderStyle = FormBorderStyle.None;
                    ReportListChild.Dock = DockStyle.Fill;
                    ReportListChild.Show();
                }catch(Exception exc)
                {
                    MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a farti editare il report", MessageBoxButtons.OK);
                }
            }
        }

        //on Click function. this function open a menu strip menu if the admin click, with the right buttons of the mouse, on a service of the list   
        private void ReportListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (reportListView.FocusedItem.Bounds.Contains(e.Location))
                {
                    reportMenu.Show(Cursor.Position);
                }
            }
        }
    }
}
