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
    public partial class ReportListForm : Form
    {
        private string Email;
        private string PassHash;
        private int BookingID;
        private ReportManagerClient reportManager;
        private CarManagerClient carManager;
        public ReportListForm(string Email, string PassHash, int BookingID)
        {
            this.Email = Email;
            this.PassHash = PassHash;
            this.reportManager = new ReportManagerClient();
            this.carManager = new CarManagerClient();
            InitializeComponent();
            this.BookingID = BookingID;
            reportListView.View = View.Details;
            reportListView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            reportListView.Columns.Add("Oggetto", -2, HorizontalAlignment.Left);
            reportListView.Columns.Add("Messaggio", -2, HorizontalAlignment.Left);
            this.UpdateReports();
        }

        private void UpdateReports()
        {
            reportListView.Items.Clear();
            var reports = reportManager.getReportsForBooking(this.BookingID, this.Email, this.PassHash);
            PlateNumberLabel.Text = "su " + this.BookingID;
            foreach (var SingleReport in reports)
            {
                reportListView.Items.Add(new ListViewItem(new string[] { SingleReport.ID.ToString(), SingleReport.Subject, SingleReport.Message }));
            }
            reportListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            reportListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void AddReport(object sender, EventArgs e)
        {
            ReportEdit ReportListChild = new ReportEdit(this.Email, this.PassHash, this.BookingID);
            ReportListChild.MdiParent = this.ParentForm;
            ReportListChild.FormBorderStyle = FormBorderStyle.None;
            ReportListChild.Dock = DockStyle.Fill;
            ReportListChild.Show();
        }

        private void DeleteReport(object sender, EventArgs e)
        {
            this.reportManager.DeleteReport(Convert.ToInt32(reportListView.SelectedItems[0].Text), this.Email, this.PassHash);
            this.UpdateReports();
        }

        private void EditReport (object sender, EventArgs e)
        {
            if (reportListView.SelectedItems.Count == 1)
            {
                var selectedReport = this.reportManager.getReportByID(Convert.ToInt32(this.reportListView.SelectedItems[0].Text), this.Email, this.PassHash);
                ReportEdit ReportListChild = new ReportEdit(this.Email, this.PassHash, selectedReport);
                ReportListChild.MdiParent = this.ParentForm;
                ReportListChild.FormBorderStyle = FormBorderStyle.None;
                ReportListChild.Dock = DockStyle.Fill;
                ReportListChild.Show();
            }
        }
        

        private void ReportListForm_Load(object sender, EventArgs e)
        {

        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

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
