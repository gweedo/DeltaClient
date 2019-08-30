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
    /// <summary>
    /// this form allow the admin to change or even add kilometers and cost of a service 
    /// </summary>
    public partial class AdminServiceEdit : Form
    {
        private string Email;
        private string PassHash;
        private Service.Car ServicedCar;
        private ServiceManagerClient serviceManager;
        private Service.Service service;
        private bool newService;

        //constructor
        public AdminServiceEdit(string Email, string PassHash, Service.Service service)
        {
            InitializeComponent();
            this.Email = Email;
            this.PassHash = PassHash;
            this.service = service;
            this.ServicedCar = service.ServicedCar;
            this.newService = false;
            TotalUpDown.Value = Convert.ToDecimal(service.TotalSpent);
            KilometersUpDown.Value = service.Kilometers;
            try
            {
                this.serviceManager = new ServiceManagerClient();
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
            }

        }

        //overloaded constructor. in this case the admin add a services
        public AdminServiceEdit (string Email, string PassHash, string CarPlate)
        {
            InitializeComponent();
            this.Email = Email;
            this.PassHash = PassHash;
            this.ServicedCar = new Service.Car();
            this.newService = true;
            
            TotalUpDown.Value = 0;
            KilometersUpDown.Value = 0;
            DeleteButton.Visible = false;

            try
            {
                CarManagerClient carManager = new CarManagerClient();
                Car.Car FetchedCar = carManager.GetCarByPlate(CarPlate, this.Email, this.PassHash);
                ServicedCar.PlateNumber = FetchedCar.PlateNumber;
                ServicedCar.Make = FetchedCar.Make;
                ServicedCar.Model = FetchedCar.Model;
                ServicedCar.Year = FetchedCar.Year;
                ServicedCar.Kilometers = FetchedCar.Kilometers;
                ServicedCar.BurnedLiters = FetchedCar.BurnedLiters;
                this.serviceManager = new ServiceManagerClient();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
            }
        }


        //this function control if there are some changes and update the service
        private void UpdateService(object sender, EventArgs e)
        {
            this.service.Kilometers = Convert.ToInt32(KilometersUpDown.Value);
            this.service.TotalSpent = (float)TotalUpDown.Value;
            try
            {
                this.serviceManager.UpdateService(this.service, this.Email, this.PassHash);
                this.StopEditing(sender, e);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco ad aggiornare la manutenzione.", MessageBoxButtons.OK);
            }
        }

        //on CLick fucntion. control if the amind is modifing or adding a service
        private void Save (object sender, EventArgs e)
        {
            if (this.newService)
                this.CreateService(sender, e);
            else
                this.UpdateService(sender, e);
        }

        //This function control that input fields aren't empty and then add the service
        private void CreateService(object sender, EventArgs e)
        {
            try
            {
                this.serviceManager.addCarService(Convert.ToInt32(KilometersUpDown.Value), this.ServicedCar, (float)TotalUpDown.Value, this.Email, this.PassHash);
                this.StopEditing(sender, e);
            }
            catch (Exception exc)
            {

                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a creare la manutenzione.", MessageBoxButtons.OK);
            }
        }

        //on Click function. this function deleate the selected user
        private void DeleteService (object sender, EventArgs e)
        {
            try
            {
                this.serviceManager.DeleteService(this.service.ID, this.Email, this.PassHash);
                this.StopEditing(sender, e);
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a cancellare la manutenzione.", MessageBoxButtons.OK);
            }

        }

        //on Click function. This function close this form and open the servicelist Form
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
