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
    public partial class CarForm : Form
    {
        private string Email;
        private string PassHash;
        public CarForm(string Email, string PassHash)
        {
            this.Email = Email;
            this.PassHash = PassHash;
            InitializeComponent();
            carListView.Clear();
            CarManagerClient carManager = new CarManagerClient();
            carListView.View = View.Details;
            carListView.Columns.Add("Targa", 230, HorizontalAlignment.Left);
            carListView.Columns.Add("Marca", 200, HorizontalAlignment.Left);
            carListView.Columns.Add("Modello", 150, HorizontalAlignment.Left);
            carListView.Columns.Add("Anno", 50, HorizontalAlignment.Left);
            carListView.Columns.Add("Kilometri", 50, HorizontalAlignment.Left);
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
    }
}
