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

    //This form can show all Data about Car, Users and Bookings of all client, and from that only amind Users can use this form.
    public partial class AdminDashboard : Form
    {
        protected string Email; //It record the email of the admin
        protected string PassHash; //It record the PassHash of the User
        private bool loggedOut; //it's a control for the eventual Logout

        //Constructorc
        public AdminDashboard( string Email, string PassHash)
        {
            this.Email = Email;
            this.PassHash = PassHash;
            this.loggedOut = false;
            IsMdiContainer = true; //set this form a father form to creat child form in it.

            InitializeComponent();
        }

        //A function which show the list of all users in the database, it's called by a label
        private void ShowUsers(object sender, EventArgs e)
        {
            UserListForm userFormChild = new UserListForm(this.Email, this.PassHash);  //initialize the child form
            userFormChild.MdiParent = this; 
            userFormChild.FormBorderStyle = FormBorderStyle.None;
            userFormChild.Dock = DockStyle.Fill;   //set the layout of the child form
            userFormChild.Show(); 
            
        }

        //A function which show the list of all cars in the database, it's called by a label
        private void ShowCars(object sender, EventArgs e)
        {
            CarForm carFormChild = new CarForm(this.Email, this.PassHash);
            carFormChild.MdiParent = this;
            carFormChild.FormBorderStyle = FormBorderStyle.None;
            carFormChild.Dock = DockStyle.Fill;
            carFormChild.Show();
        }

        //A function which show the list of all user, it's called by a label
        private void ShowBookings (object sender, EventArgs e)
        {
            BookingsForm bookingFormChild = new BookingsForm(this.Email, this.PassHash);
            bookingFormChild.MdiParent = this;
            bookingFormChild.FormBorderStyle = FormBorderStyle.None;
            bookingFormChild.Dock = DockStyle.Fill;
            bookingFormChild.Show();
        }

        //Logout fFuncion
        private void ExitOnClickLabel(object sender, EventArgs e)
        {
            loggedOut = true;
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        //Close the Connection with the server
        private void killDelta(object sender, FormClosedEventArgs e)
        {
            if(this.loggedOut!=true)
                Application.Exit();
        }

    }
}
