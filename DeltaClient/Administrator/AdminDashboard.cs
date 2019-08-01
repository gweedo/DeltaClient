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
    public partial class AdminDashboard : Form
    {
        protected string Email;
        protected string PassHash;
        private bool loggedOut;
        public AdminDashboard( string Email, string PassHash)
        {
            this.Email = Email;
            this.PassHash = PassHash;
            this.loggedOut = false;
            IsMdiContainer = true;

            InitializeComponent();
        }

        private void ShowUsers(object sender, EventArgs e)
        {
            AdminUserList userFormChild = new AdminUserList(this.Email, this.PassHash);
            userFormChild.MdiParent = this;
            userFormChild.FormBorderStyle = FormBorderStyle.None;
            userFormChild.Dock = DockStyle.Fill;
            userFormChild.Show();
            
        }
        private void ShowCars(object sender, EventArgs e)
        {
            AdminCarList carFormChild = new AdminCarList(this.Email, this.PassHash);
            carFormChild.MdiParent = this;
            carFormChild.FormBorderStyle = FormBorderStyle.None;
            carFormChild.Dock = DockStyle.Fill;
            carFormChild.Show();
        }
        private void ShowBookings (object sender, EventArgs e)
        {
            AdminBookingList bookingFormChild = new AdminBookingList(this.Email, this.PassHash);
            bookingFormChild.MdiParent = this;
            bookingFormChild.FormBorderStyle = FormBorderStyle.None;
            bookingFormChild.Dock = DockStyle.Fill;
            bookingFormChild.Show();
        }

        private void ExitOnClickLabel(object sender, EventArgs e)
        {
            loggedOut = true;
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void AddElementOnClickButton(object sender, EventArgs e)
        {

        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void killDelta(object sender, FormClosedEventArgs e)
        {
            if(this.loggedOut!=true)
                Application.Exit();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
