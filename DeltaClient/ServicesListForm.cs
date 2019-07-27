using DeltaClient.Car;
using DeltaClient.Service;
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
    public partial class ServicesListForm : Form
    {
        private string Email;
        private string PassHash;
        private string CarPlate;
        private ServiceManagerClient serviceManager;
        private CarManagerClient carManager;
        public ServicesListForm(string Email, string PassHash, string CarPlate)
        {
            this.Email = Email;
            this.PassHash = PassHash;
            this.serviceManager = new ServiceManagerClient();
            this.carManager = new CarManagerClient();
            InitializeComponent();
            this.CarPlate = CarPlate;
            servicesListView.View = View.Details;
            servicesListView.Columns.Add("ID", 230, HorizontalAlignment.Left);
            servicesListView.Columns.Add("Kilometri", 200, HorizontalAlignment.Left);
            servicesListView.Columns.Add("Spesa totale", 150, HorizontalAlignment.Left);
            this.UpdateServices();
        }

        private void UpdateServices()
        {
            servicesListView.Items.Clear();
            var services = serviceManager.GetCarServicesForCar(this.CarPlate, this.Email, this.PassHash);
                PlateNumberLabel.Text = "su " + this.CarPlate;
            foreach (var SingleService in services)
            {
                servicesListView.Items.Add(new ListViewItem(new string[] { SingleService.ID.ToString(), SingleService.Kilometers.ToString(), SingleService.TotalSpent.ToString()}));
            }
            servicesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            servicesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void AddService(object sender, EventArgs e)
        {
            ServiceEdit ServicesListChild = new ServiceEdit(this.Email, this.PassHash, CarPlate);
            ServicesListChild.MdiParent = this.ParentForm;
            ServicesListChild.FormBorderStyle = FormBorderStyle.None;
            ServicesListChild.Dock = DockStyle.Fill;
            ServicesListChild.Show();
        }

        private void DeleteService()
        {
            this.serviceManager.DeleteService(Convert.ToInt32(servicesListView.SelectedItems[0].Text), this.Email, this.PassHash);
            this.UpdateServices();
        }

        private void EditService (object sender, EventArgs e)
        {
            if (servicesListView.SelectedItems.Count == 1)
            {
                var selectedService = this.serviceManager.GetServiceByID(Convert.ToInt32(this.servicesListView.SelectedItems[0].Text), this.Email, this.PassHash);
                ServiceEdit ServicesListChild = new ServiceEdit(this.Email, this.PassHash, selectedService);
                ServicesListChild.MdiParent = this.ParentForm;
                ServicesListChild.FormBorderStyle = FormBorderStyle.None;
                ServicesListChild.Dock = DockStyle.Fill;
                ServicesListChild.Show();

            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ServicesListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
