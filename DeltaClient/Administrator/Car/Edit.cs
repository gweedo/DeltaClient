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
    /// this form allow the admin to change or even add platenumber, model, kilometers, year and burned liters of a car
    /// </summary>
    public partial class AdminCarEdit : Form
    {
        private Car.Car EditingCar;
        private string Email;
        private string PassHash;
        private bool newCar;
        private CarManagerClient carManager;

        //constructor
        public AdminCarEdit(Car.Car EditingCar, string Email, string PassHash)
        {
            InitializeComponent();
            this.EditingCar = EditingCar;
            this.Email = Email;
            this.PassHash = PassHash;
            this.newCar = false;
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

            try
            {
                this.carManager = new CarManagerClient();
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
            }
        }

        //overloaded constructor. in this case the admin is adding a car
        public AdminCarEdit (string Email, string PassHash)
        {
            InitializeComponent();
            this.Email = Email;
            this.PassHash = PassHash;
            this.newCar = true;
            MakerTextBox.Text = "";
            ModelTextBox.Text = "";
            PlateNumberTextBox.Text = "";
            PlateNumberTextBox.ReadOnly = false;
            PlateNumberTextBox.BackColor = Color.White;
            PlateNumberTextBox.ForeColor = Color.Black;
            deleteButton.Visible = false;
            for (int i = 1980; i <= DateTime.Now.Year; i++)
            {
                YearComboBox.Items.Add(i);
            }
            LitersUpDown.Value = 0;
            KilometersUpDown.Value = 0;
            try
            {
                this.carManager = new CarManagerClient();
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
            }
        }

        //this function control if there are some changes and update the car
        private void UpdateCar(object sender, EventArgs e)
        {
            if (EditingCar.Make != MakerTextBox.Text || EditingCar.Model != ModelTextBox.Text || EditingCar.Year != Convert.ToInt32(YearComboBox.SelectedIndex + 1980) || EditingCar.Kilometers != KilometersUpDown.Value || EditingCar.BurnedLiters != LitersUpDown.Value)
            {
                
                    Car.Car UpdatingCar = new Car.Car();
                    UpdatingCar.PlateNumber = PlateNumberTextBox.Text;
                    UpdatingCar.Model = ModelTextBox.Text;
                    UpdatingCar.Make = MakerTextBox.Text;
                    UpdatingCar.Kilometers = Convert.ToInt32(KilometersUpDown.Value);
                    UpdatingCar.BurnedLiters = Convert.ToInt32(LitersUpDown.Value);
                    UpdatingCar.Year = Convert.ToInt32(YearComboBox.SelectedIndex + 1980);
               try
                {
                    carManager.UpdateCar(UpdatingCar, this.Email, this.PassHash);
                    this.stopEditing(sender, e);
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco ad aggiornare la macchina.", MessageBoxButtons.OK);
                }
            }
        }

        //on CLick fucntion. control if the amind is modifing or adding a car
        private void SendSaveButton(object sender, EventArgs e)
        {
            if (this.newCar)
            {
                this.CreateCar(sender, e);
            }
            else 
                this.UpdateCar(sender, e);
        }


        //This function add the report
        private void CreateCar(object sender, EventArgs e)
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
                try
                {
                    this.carManager.AddCar(UpdatingCar, this.Email, this.PassHash);
                    this.stopEditing(sender, e);
                }catch(Exception exc)
                {
                    MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a creare la macchina.", MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show("Hai inserito tutti i dati?", "Controlla, per favore.", MessageBoxButtons.OK);
        }

        //on Click function. this function deleate the selected car
        private void DeleteCar(object sender, EventArgs e)
        {
            try
            {
                this.carManager.DeleteCar(this.EditingCar, this.Email, this.PassHash);
                this.stopEditing(sender, e);
            }
            catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco ad eliminare la macchina.", MessageBoxButtons.OK);
            }
        }

        //on Click function. This function close this form and open the carlist Form
        private void stopEditing(object sender, EventArgs e)
        {
            AdminCarList listFormChild = new AdminCarList(this.Email, this.PassHash);
            listFormChild.MdiParent = this.ParentForm;
            listFormChild.FormBorderStyle = FormBorderStyle.None;
            listFormChild.Dock = DockStyle.Fill;
            listFormChild.Show();
        }

        private void AdminCarEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
