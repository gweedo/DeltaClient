using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeltaClient.Car;

namespace DeltaClient
{
    public partial class CarDataForm : Form
    {
        protected string PlateNumber;
        protected string Make;
        protected string Model;
        protected int Year;
        protected int Kilometers;
        protected int BurnedLiters;

        protected string Email;
        protected string MD5Password;

        public CarDataForm(string plateNumber, string make, string model, int year, int kilometers, int burnedLiters, string email, string md5Password)
        {
            PlateNumber = plateNumber;
            PlateNumberCarTextBox.Text = plateNumber;

            Make = make;
            MakeCarTextBox.Text = make;

            Model = model;
            ModelCarTextBox.Text = model;

            Year = year;
            YearCarNumbers.Value = year;
            
            Kilometers = kilometers;
            KilometersCarNumbers.Value = kilometers;

            BurnedLiters = burnedLiters;
            burnedLitersCarNumbers.Value = burnedLiters;

            Email = email;
            MD5Password = md5Password;

            InitializeComponent();
        }

        private void OnClickSendButton()
        {
            if (PlateNumber != PlateNumberCarTextBox.Text || Make != MakeCarTextBox.Text || Model != ModelCarTextBox.Text || Year != YearCarNumbers.Value || Kilometers != KilometersCarNumbers.Value || BurnedLiters != burnedLitersCarNumbers.Value)
            {
                CarManagerClient carManager = new CarManagerClient();
                Car.Car car = new Car.Car();
                car.PlateNumber = PlateNumberCarTextBox.Text;
                car.Make = MakeCarTextBox.Text;
                car.Model = ModelCarTextBox.Text;
                car.Year = Convert.ToInt16(YearCarNumbers.Value);
                car.Kilometers = Convert.ToInt16(KilometersCarNumbers.Value);
                car.BurnedLiters = Convert.ToInt16(burnedLitersCarNumbers.Value);
                if (carManager.UpdateCar(car, Email, MD5Password)) MessageBox.Show("operazione eseguita con successo");
                else MessageBox.Show("aiai e mo che se fa?");
                   
            }

        }

    }
}
