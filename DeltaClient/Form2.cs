using DeltaClient.Car;
using DeltaClient.User;
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
    public partial class Form2 : Form
    {
        private string Email;
        private string PassHash;
        public Form2( string Email, string PassHash)
        {
            this.Email = Email;
            this.PassHash = PassHash;
            InitializeComponent();
            //listBox1.Text = "acv";
            //listBox1.a
        }

        private void ShowUsers(object sender, EventArgs e)
        {
            UsersCarslistView.Clear();
            UserManagerClient userManager = new UserManagerClient();
            Label label = sender as Label;
            UsersCarslistView.View = View.Details;
            UsersCarslistView.Columns.Add("Email", 230, HorizontalAlignment.Left);
            UsersCarslistView.Columns.Add("Nome", 200, HorizontalAlignment.Left);
            UsersCarslistView.Columns.Add("Scadenza", 150, HorizontalAlignment.Left);
            var users = userManager.GetUsers(this.Email, this.PassHash);
            foreach (var SingleUser in users)
            {
                UsersCarslistView.Items.Add(new ListViewItem(new string[] { SingleUser.Email, SingleUser.Name, SingleUser.LicenseExpiration.ToShortDateString()}));
            }
            UsersCarslistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void ShowCars(object sender, EventArgs e)
        {
            UsersCarslistView.Clear();
            CarManagerClient carManager = new CarManagerClient();
            Label label = sender as Label;
            UsersCarslistView.View = View.Details;
            UsersCarslistView.Columns.Add("Targa", 230, HorizontalAlignment.Left);
            UsersCarslistView.Columns.Add("Marca", 200, HorizontalAlignment.Left);
            UsersCarslistView.Columns.Add("Modello", 150, HorizontalAlignment.Left);
            UsersCarslistView.Columns.Add("Anno", 150, HorizontalAlignment.Left);
            UsersCarslistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            var cars = carManager.GetCars(this.Email, this.PassHash);
            foreach (var SingleCar in cars)
            {
                UsersCarslistView.Items.Add(new ListViewItem(new string[] { SingleCar.PlateNumber, SingleCar.Make, SingleCar.Model, SingleCar.Year.ToString() }));
            }
            UsersCarslistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        private void ExitOnClickLabel(object sender, EventArgs e)
        {

        }

        private void AddElementOnClickButton(object sender, EventArgs e)
        {

        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
