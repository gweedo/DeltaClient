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
    public partial class CarDataForm : Form
    {
        protected string PlateNumber;
        protected string Make;
        protected string Model;
        protected int Year;
        protected int Kilometers;
        protected int BurnedLiters;

        public CarDataForm(string plateNumber, string make, string model, int year, int kilometers, int burnedLiters)
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
            InitializeComponent();
        }
    }
}
