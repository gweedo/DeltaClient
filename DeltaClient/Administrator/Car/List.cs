using DeltaClient.Car;
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
    /// this child form show the list of all cars and, once selected one, reiderct the admin to another child form which allow some changes to the selceted car
    /// </summary>
    public partial class AdminCarList : Form
    {
        private string Email;
        private string PassHash;
        private CarManagerClient carManager;

        //constructor
        public AdminCarList(string Email, string PassHash)
        {
            this.Email = Email;
            this.PassHash = PassHash;
            InitializeComponent();
            carListView.Clear();
            carListView.View = View.Details;
            carListView.Columns.Add("Targa", 230, HorizontalAlignment.Left);
            carListView.Columns.Add("Marca", 200, HorizontalAlignment.Left);
            carListView.Columns.Add("Modello", 150, HorizontalAlignment.Left);
            carListView.Columns.Add("Anno", 50, HorizontalAlignment.Left);
            carListView.Columns.Add("Kilometri", 50, HorizontalAlignment.Left);

            try
            {
                carManager = new CarManagerClient();
                this.UpdateList();
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", exc.ToString(), MessageBoxButtons.OK);
            }
        }

        //this function reload the list of all cars
        private void UpdateList()
        {
            carListView.Items.Clear();

            try
            {
                var cars = carManager.GetCars(this.Email, this.PassHash);
                foreach (var SingleCar in cars)
                {
                    carListView.Items.Add(new ListViewItem(new string[] { SingleCar.PlateNumber, SingleCar.Make, SingleCar.Model, SingleCar.Year.ToString(), SingleCar.Kilometers.ToString() }));
                }
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco ad aggiornare la lista delle macchine.", MessageBoxButtons.OK);
            }
            carListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            carListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        //on Click function. this show a new child form which allow the admin to add a car
        private void CreateCar (object sender, EventArgs e)
        {
            AdminCarEdit EditCarChild = new AdminCarEdit(this.Email, this.PassHash);
            EditCarChild.MdiParent = this.ParentForm;
            EditCarChild.FormBorderStyle = FormBorderStyle.None;
            EditCarChild.Dock = DockStyle.Fill;
            EditCarChild.Show();
        }

        //on Click function. this function delete a car of the list
        private void DeleteCar(object sender, EventArgs e)
        {
            try
            {
                this.carManager.DeleteCar(this.carManager.GetCarByPlate(carListView.SelectedItems[0].Text, this.Email, this.PassHash), this.Email, this.PassHash);
                this.UpdateList();
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco ad eliminare la macchina.", MessageBoxButtons.OK);
            }
        }

        //on double Click function. this show a new child form which allow the admin to modify a car
        private void EditCar (object sender, EventArgs e)
        {
            if (carListView.SelectedItems.Count == 1)
            {
                try
                {
                    var selectedCar = this.carManager.GetCarByPlate(carListView.SelectedItems[0].Text, this.Email, this.PassHash);

                    AdminCarEdit EditCarChild = new AdminCarEdit(selectedCar, this.Email, this.PassHash);
                    EditCarChild.MdiParent = this.ParentForm;
                    EditCarChild.FormBorderStyle = FormBorderStyle.None;
                    EditCarChild.Dock = DockStyle.Fill;
                    EditCarChild.Show();
                }catch(Exception exc)
                {
                    MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a farti modificare la macchina.", MessageBoxButtons.OK);
                }

            }
        }

        //on Click function. this show the servicelist form relative at the selected car
        private void CheckServices(object sender, EventArgs e)
        {
            if (carListView.SelectedItems.Count == 1)
            {
                try
                {
                    var selectedCar = this.carManager.GetCarByPlate(carListView.SelectedItems[0].Text, this.Email, this.PassHash);

                    AdminServiceList ServicesListChild = new AdminServiceList(this.Email, this.PassHash, selectedCar.PlateNumber);
                    ServicesListChild.MdiParent = this.ParentForm;
                    ServicesListChild.FormBorderStyle = FormBorderStyle.None;
                    ServicesListChild.Dock = DockStyle.Fill;
                    ServicesListChild.Show();
                }catch(Exception exc)
                {
                    MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a farti vedere i servizi della macchina.", MessageBoxButtons.OK);
                }

            }
        }

        //on Click function. this function open a menu strip menu if the admin click, with the right buttons of the mouse, on a car of the list   
        private void CarListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (carListView.FocusedItem.Bounds.Contains(e.Location))
                {
                    carMenu.Show(Cursor.Position);
                }
            }
        }

        private void AdminCarList_Load(object sender, EventArgs e)
        {

        }
    }
}
