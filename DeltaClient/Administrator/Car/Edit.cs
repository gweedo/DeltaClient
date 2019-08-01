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
    public partial class AdminCarEdit : Form
    {
        private Car.Car EditingCar;
        private string Email;
        private string PassHash;
        private bool newCar;
        private CarManagerClient carManager;

        public AdminCarEdit(Car.Car EditingCar, string Email, string PassHash)
        {
            InitializeComponent();
            this.EditingCar = EditingCar;
            this.Email = Email;
            this.PassHash = PassHash;
            this.newCar = false;
            this.carManager = new CarManagerClient();
            MakerTextBox.Text = EditingCar.Make;
            ModelTextBox.Text = EditingCar.Model;
            PlateNumberTextBox.Text = EditingCar.PlateNumber;
            PlateNumberTextBox.ReadOnly = true;
            for (int i=1980; i<=DateTime.Now.Year; i++)
            {
                YearComboBox.Items.Add(i);
            }
            if (EditingCar.Year != 0)
                YearComboBox.SelectedIndex = EditingCar.Year-1980;
            LitersUpDown.Value = EditingCar.BurnedLiters;
            KilometersUpDown.Value=EditingCar.Kilometers;
        }

        public AdminCarEdit (string Email, string PassHash)
        {
            InitializeComponent();
            this.Email = Email;
            this.PassHash = PassHash;
            this.newCar = true;
            this.carManager = new CarManagerClient();
            MakerTextBox.Text = "";
            ModelTextBox.Text = "";
            PlateNumberTextBox.Text = "";
            PlateNumberTextBox.ReadOnly = false;
            PlateNumberTextBox.ForeColor = Color.White;
            for (int i = 1980; i <= DateTime.Now.Year; i++)
            {
                YearComboBox.Items.Add(i);
            }
            LitersUpDown.Value = 0;
            KilometersUpDown.Value = 0;
        }


        private void DeleteCar(object sender, EventArgs e)
        {
            this.carManager.DeleteCar(this.EditingCar, this.Email, this.PassHash);
            this.stopEditing(sender, e);
        }
        private void UpdateCar()
        {
            if (EditingCar.Make != MakerTextBox.Text || EditingCar.Model != ModelTextBox.Text || EditingCar.Year != Convert.ToInt32(YearComboBox.SelectedIndex + 1980) || EditingCar.Kilometers != KilometersUpDown.Value || EditingCar.BurnedLiters != LitersUpDown.Value)
            {
                CarManagerClient carManager = new CarManagerClient();
                Car.Car UpdatingCar = new Car.Car();
                UpdatingCar.PlateNumber = PlateNumberTextBox.Text;
                UpdatingCar.Model = ModelTextBox.Text;
                UpdatingCar.Make = MakerTextBox.Text;
                UpdatingCar.Kilometers = Convert.ToInt32(KilometersUpDown.Value);
                UpdatingCar.BurnedLiters = Convert.ToInt32(LitersUpDown.Value);
                UpdatingCar.Year = Convert.ToInt32(YearComboBox.SelectedIndex + 1980);
                carManager.UpdateCar(UpdatingCar, this.Email, this.PassHash);
            }
        }
        private void SendSaveButton(object sender, EventArgs e)
        {
            if (this.newCar)
            {
                this.CreateCar();
            }
            else
                this.UpdateCar();
            this.stopEditing(sender, e);


        }

        private void CreateCar()
        {
            if ("" != MakerTextBox.Text && "" != ModelTextBox.Text && 0 != Convert.ToInt32(YearComboBox.SelectedIndex + 1980) && "" != PlateNumberTextBox.Text)
            {
                Car.Car UpdatingCar = new Car.Car();
                UpdatingCar.PlateNumber = PlateNumberTextBox.Text;
                UpdatingCar.Model = ModelTextBox.Text;
                UpdatingCar.Make = MakerTextBox.Text;
                UpdatingCar.Kilometers = Convert.ToInt32(KilometersUpDown.Value);
                UpdatingCar.BurnedLiters = Convert.ToInt32(LitersUpDown.Value);
                UpdatingCar.Year = Convert.ToInt32(YearComboBox.SelectedIndex + 1980);
                this.carManager.AddCar(UpdatingCar, this.Email, this.PassHash);
            }
            else
                MessageBox.Show("Hai inserito tutti i dati?", "Controlla, per favore.", MessageBoxButtons.OK);
        }

        private void stopEditing(object sender, EventArgs e)
        {
            AdminCarList listFormChild = new AdminCarList(this.Email, this.PassHash);
            listFormChild.MdiParent = this.ParentForm;
            listFormChild.FormBorderStyle = FormBorderStyle.None;
            listFormChild.Dock = DockStyle.Fill;
            listFormChild.Show();
        }
 
    }
}
