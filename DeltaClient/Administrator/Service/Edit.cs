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
    public partial class AdminServiceEdit : Form
    {
        private string Email;
        private string PassHash;
        private Service.Car ServicedCar;
        private ServiceManagerClient serviceManager;
        private Service.Service service;
        private bool newService;
        public AdminServiceEdit(string Email, string PassHash, Service.Service service)
        {
            InitializeComponent();
            this.Email = Email;
            this.PassHash = PassHash;
            this.service = service;
            this.ServicedCar = service.ServicedCar;
            this.newService = false;
            this.serviceManager = new ServiceManagerClient();
            TotalUpDown.Value = Convert.ToDecimal(service.TotalSpent);
            KilometersUpDown.Value = service.Kilometers;

        }

        public AdminServiceEdit (string Email, string PassHash, string CarPlate)
        {
            InitializeComponent();
            this.Email = Email;
            this.PassHash = PassHash;
            this.ServicedCar = new Service.Car();
            this.newService = true;
            CarManagerClient carManager = new CarManagerClient();
            Car.Car FetchedCar = carManager.GetCarByPlate(CarPlate, this.Email, this.PassHash);
            ServicedCar.PlateNumber = FetchedCar.PlateNumber;
            ServicedCar.Make = FetchedCar.Make;
            ServicedCar.Model = FetchedCar.Model;
            ServicedCar.Year = FetchedCar.Year;
            ServicedCar.Kilometers = FetchedCar.Kilometers;
            ServicedCar.BurnedLiters = FetchedCar.BurnedLiters;
            this.serviceManager = new ServiceManagerClient();
            TotalUpDown.Value = 0;
            KilometersUpDown.Value = 0;
            DeleteButton.Visible = false;
        }

        private void Save (object sender, EventArgs e)
        {
            if (this.newService)
                this.CreateService(sender, e);
            else
                this.UpdateService(sender, e);
        }
        private void DeleteService (object sender, EventArgs e)
        {
            this.serviceManager.DeleteService(this.service.ID, this.Email, this.PassHash);
            this.StopEditing(sender, e);
        }
        private void CreateService(object sender, EventArgs e)
        {
            this.serviceManager.addCarService(Convert.ToInt32(KilometersUpDown.Value), this.ServicedCar, (float)TotalUpDown.Value, this.Email, this.PassHash);
            this.StopEditing(sender, e);
        }
        private void UpdateService(object sender, EventArgs e)
        {
            this.service.Kilometers = Convert.ToInt32(KilometersUpDown.Value);
            this.service.TotalSpent = (float) TotalUpDown.Value;
            this.serviceManager.UpdateService(this.service, this.Email, this.PassHash);
            this.StopEditing(sender, e);
        }
        private void StopEditing(object sender, EventArgs e)
        {
            AdminServiceList ServicesListChild = new AdminServiceList(this.Email, this.PassHash, this.ServicedCar.PlateNumber);
            ServicesListChild.MdiParent = this.ParentForm;
            ServicesListChild.FormBorderStyle = FormBorderStyle.None;
            ServicesListChild.Dock = DockStyle.Fill;
            ServicesListChild.Show();
        }
    }
}
