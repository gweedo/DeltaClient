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
    /// this child form show the list of all services and, once selected one, reiderct the admin to another child form which allow some changes to the selceted service
    /// </summary>
    public partial class AdminServiceList : Form
    {
        private string Email;
        private string PassHash;
        private string CarPlate;
        private ServiceManagerClient serviceManager;
        private CarManagerClient carManager;

        //constructor
        public AdminServiceList(string Email, string PassHash, string CarPlate)
        {
            this.Email = Email;
            this.PassHash = PassHash;
            this.CarPlate = CarPlate;
            this.serviceManager = new ServiceManagerClient();
            this.carManager = new CarManagerClient();
            InitializeComponent();
            servicesListView.View = View.Details;
            servicesListView.Columns.Add("ID", -2, HorizontalAlignment.Left);
            servicesListView.Columns.Add("Kilometri", -2, HorizontalAlignment.Left);
            servicesListView.Columns.Add("Spesa totale", -2, HorizontalAlignment.Left);

            try { 
            this.serviceManager = new ServiceManagerClient();
            this.carManager = new CarManagerClient();
            this.UpdateServices();
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
            }
        }


        //this function reload the list of all services
        private void UpdateServices()
        {
            servicesListView.Items.Clear();
            try
            {
                var services = serviceManager.GetCarServicesForCar(this.CarPlate, this.Email, this.PassHash);
                PlateNumberLabel.Text = "su " + this.CarPlate;
                foreach (var SingleService in services)
                {
                    servicesListView.Items.Add(new ListViewItem(new string[] { SingleService.ID.ToString(), SingleService.Kilometers.ToString(), SingleService.TotalSpent.ToString() }));
                }
            }catch(Exception exc)
            {

                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco ad aggiornare la lista delle macchine.", MessageBoxButtons.OK);
            }
            servicesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            servicesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        //on Click function. this show a new child form which allow the admin to add a service
        private void AddService(object sender, EventArgs e)
        {
            AdminServiceEdit ServicesListChild = new AdminServiceEdit(this.Email, this.PassHash, CarPlate);
            ServicesListChild.MdiParent = this.ParentForm;
            ServicesListChild.FormBorderStyle = FormBorderStyle.None;
            ServicesListChild.Dock = DockStyle.Fill;
            ServicesListChild.Show();
        }


        //on Click function. this function delete a service of the list
        private void DeleteService(object sender, EventArgs e)
        {
            try
            {
                this.serviceManager.DeleteService(Convert.ToInt32(servicesListView.SelectedItems[0].Text), this.Email, this.PassHash);
                this.UpdateServices();
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco ad eliminare il servizio", MessageBoxButtons.OK);
            }
        }

        //on Click function. this show a new child form which allow the admin to modify a service
        private void EditService (object sender, EventArgs e)
        {
            if (servicesListView.SelectedItems.Count == 1)
            {
                try
                {
                    var selectedService = this.serviceManager.GetServiceByID(Convert.ToInt32(this.servicesListView.SelectedItems[0].Text), this.Email, this.PassHash);
                    AdminServiceEdit ServicesListChild = new AdminServiceEdit(this.Email, this.PassHash, selectedService);
                    ServicesListChild.MdiParent = this.ParentForm;
                    ServicesListChild.FormBorderStyle = FormBorderStyle.None;
                    ServicesListChild.Dock = DockStyle.Fill;
                    ServicesListChild.Show();
                }catch(Exception exc)
                {
                    MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco ad editare il servizio", MessageBoxButtons.OK);

                }

            }
        }

        //on Click function. this function open a menu strip menu if the admin click, with the right buttons of the mouse, on a service of the list
        private void ServicesListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (servicesListView.FocusedItem.Bounds.Contains(e.Location))
                {
                    serviceMenu.Show(Cursor.Position);
                }
            }
        }
    }
}
