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
    /// <summary>
    /// This form is visibile only if the user own the admin referencies. it's allow the administrator to see and modify some details about users,
    /// booking, servicies and cars by some other child forms
    /// </summary>
    public partial class AdminDashboard : Form
    {
        protected string Email;
        protected string PassHash;
        private bool loggedOut;

        //Constructor
        public AdminDashboard( string Email, string PassHash)
        {
            this.Email = Email;
            this.PassHash = PassHash;
            this.loggedOut = false;
            IsMdiContainer = true;
            //initialize desing
            InitializeComponent();
            homeButton.AutoSize = false;
            toolStrip.ImageScalingSize = new Size(80, 80);
            toolStrip.AutoSize = false;
        }

        //on Click function. this function initilize and show the child form for handle all users
        private void ShowUsers(object sender, EventArgs e)
        {
            AdminUserList userFormChild = new AdminUserList(this.Email, this.PassHash);
            userFormChild.MdiParent = this;
            userFormChild.FormBorderStyle = FormBorderStyle.None;
            userFormChild.Dock = DockStyle.Fill;
            userFormChild.Show();
            
        }

        //on Click function. this function initilize and show the child form for handle all cars
        private void ShowCars(object sender, EventArgs e)
        {
            AdminCarList carFormChild = new AdminCarList(this.Email, this.PassHash);
            carFormChild.MdiParent = this;
            carFormChild.FormBorderStyle = FormBorderStyle.None;
            carFormChild.Dock = DockStyle.Fill;
            carFormChild.Show();
        }

        //on Click function. this function initilize and show the child form for handle all bookings
        private void ShowBookings (object sender, EventArgs e)
        {
            AdminBookingList bookingFormChild = new AdminBookingList(this.Email, this.PassHash);
            bookingFormChild.MdiParent = this;
            bookingFormChild.FormBorderStyle = FormBorderStyle.None;
            bookingFormChild.Dock = DockStyle.Fill;
            bookingFormChild.Show();
        }

        //on Click function. this function make the logout of the user, close this form, initialize and shoe the login form 
        private void ExitOnClickLabel(object sender, EventArgs e)
        {
            loggedOut = true;
            Login login = new Login();
            login.Show();
            this.Close();
        }

        //on Click Function. this function close the program
        private void killDelta(object sender, FormClosedEventArgs e)
        {
            if(this.loggedOut!=true)
                Application.Exit();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
