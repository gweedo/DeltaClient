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
    public partial class AdminCarList : Form
    {
        private string Email;
        private string PassHash;
        private CarManagerClient carManager;
        public AdminCarList(string Email, string PassHash)
        {
            this.Email = Email;
            this.PassHash = PassHash;
            InitializeComponent();
            carListView.Clear();
            carManager = new CarManagerClient();
            carListView.View = View.Details;
            carListView.Columns.Add("Targa", 230, HorizontalAlignment.Left);
            carListView.Columns.Add("Marca", 200, HorizontalAlignment.Left);
            carListView.Columns.Add("Modello", 150, HorizontalAlignment.Left);
            carListView.Columns.Add("Anno", 50, HorizontalAlignment.Left);
            carListView.Columns.Add("Kilometri", 50, HorizontalAlignment.Left);
            this.UpdateList();
        }

        private void UpdateList()
        {
            carListView.Items.Clear();
            var cars = carManager.GetCars(this.Email, this.PassHash);
            foreach (var SingleCar in cars)
            {
                carListView.Items.Add(new ListViewItem(new string[] { SingleCar.PlateNumber, SingleCar.Make, SingleCar.Model, SingleCar.Year.ToString(), SingleCar.Kilometers.ToString() }));
            }
            carListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            carListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateCar (object sender, EventArgs e)
        {
            AdminCarEdit EditCarChild = new AdminCarEdit(this.Email, this.PassHash);
            EditCarChild.MdiParent = this.ParentForm;
            EditCarChild.FormBorderStyle = FormBorderStyle.None;
            EditCarChild.Dock = DockStyle.Fill;
            EditCarChild.Show();
        }

        private void EditCar (object sender, EventArgs e)
        {
            if (carListView.SelectedItems.Count == 1)
            {
                var selectedCar = this.carManager.GetCarByPlate(carListView.SelectedItems[0].Text, this.Email, this.PassHash);

                AdminCarEdit EditCarChild = new AdminCarEdit(selectedCar, this.Email, this.PassHash);
                EditCarChild.MdiParent = this.ParentForm;
                EditCarChild.FormBorderStyle = FormBorderStyle.None;
                EditCarChild.Dock = DockStyle.Fill;
                EditCarChild.Show();

            }
        }


        private void CheckServices(object sender, EventArgs e)
        {
            if (carListView.SelectedItems.Count == 1)
            {
                var selectedCar = this.carManager.GetCarByPlate(carListView.SelectedItems[0].Text, this.Email, this.PassHash);

                AdminServiceList ServicesListChild = new AdminServiceList(this.Email, this.PassHash, selectedCar.PlateNumber);
                ServicesListChild.MdiParent = this.ParentForm;
                ServicesListChild.FormBorderStyle = FormBorderStyle.None;
                ServicesListChild.Dock = DockStyle.Fill;
                ServicesListChild.Show();

            }
        }

        private void CheckReports(object sender, EventArgs e)
        {

        }
        
        private void DeleteCar (object sender, EventArgs e)
        {
            this.carManager.DeleteCar(this.carManager.GetCarByPlate(carListView.SelectedItems[0].Text, this.Email, this.PassHash), this.Email, this.PassHash);
            this.UpdateList();
        }

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
    }
}
