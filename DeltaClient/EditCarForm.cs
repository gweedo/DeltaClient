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
    public partial class EditCarForm : Form
    {
        private Car.Car EditingCar;
        private string Email;
        private string PassHash;
        public EditCarForm(Car.Car EditingCar, string Email, string PassHash)
        {
            InitializeComponent();
            this.EditingCar = EditingCar;
            this.Email = Email;
            this.PassHash = PassHash;
            MakerTextBox.Text = EditingCar.Make;
            ModelTextBox.Text = EditingCar.Model;
            PlateNumberTextBox.Text = EditingCar.PlateNumber;
            PlateNumberTextBox.ReadOnly = true;
            for (int i=1980; i<=DateTime.Now.Year; i++)
            {
                YearComboBox.Items.Add(i);
            }
            if (EditingCar.Year != 0)
                YearComboBox.SelectedValue = EditingCar.Year;
            LitersUpDown.Value = EditingCar.BurnedLiters;
            KilometersUpDown.Value=EditingCar.Kilometers;
        }

        private void NameUserLabel_Click(object sender, EventArgs e)
        {

        }
        private void SendSaveButton()
        {
            if (EditingCar.Make!= MakerTextBox.Text || EditingCar.Model != ModelTextBox.Text || EditingCar.Year != Convert.ToInt32(YearComboBox.SelectedValue) || EditingCar.Kilometers != KilometersUpDown.Value || EditingCar.BurnedLiters != LitersUpDown.Value)
            {
                CarManagerClient carManager = new CarManagerClient();
                Car.Car UpdatingCar = new Car.Car();
                UpdatingCar.Model= ModelTextBox.Text;
                UpdatingCar.Make = MakerTextBox.Text;
                UpdatingCar.Kilometers = Convert.ToInt32(KilometersUpDown.Value);
                UpdatingCar.BurnedLiters= Convert.ToInt32(LitersUpDown.Value);
                UpdatingCar.Year= Convert.ToInt32(YearComboBox.SelectedValue);
                carManager.UpdateCar(UpdatingCar, this.Email, this.PassHash);
            }

        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void EditCarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
