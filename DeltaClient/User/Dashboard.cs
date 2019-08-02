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
{/// <summary>
/// this is the form that show after the login as norma user. it handle three child which allow the user to book a car or to add a report 
/// or handle his profile
/// </summary>
    public partial class UserDashboard : Form
    {
        private string Email;
        private string PassHash;
        private bool loggedOut;

        //constructor
        public UserDashboard(string Email, string PassHash)
        {
            // Initializing
            this.Email = Email;
            this.PassHash = PassHash;
            this.loggedOut = false;
            IsMdiContainer = true;
            InitializeComponent();
            // Initializing Design
            homeButton.AutoSize = false;
            toolStrip.ImageScalingSize = new Size(80, 80);
            toolStrip.AutoSize = false;
        }

        //on Click function. in the empty space of the page show the child form which show the possible booking fot the user
        private void ShowBookingForm (object sender, EventArgs e)
        {
            UserCarBooker carBookerChild= new UserCarBooker(this.Email, this.PassHash); 
            carBookerChild.MdiParent = this;
            carBookerChild.FormBorderStyle = FormBorderStyle.None;
            carBookerChild.Dock = DockStyle.Fill;
            carBookerChild.Show();
        }

        //on Click function. in the empty space of the page show the child form which show the reporta made by the user
        private void ShowReportForm (object sender, EventArgs e)
        {
            UserAddReport reportFormChild = new UserAddReport(this.Email, this.PassHash);
            reportFormChild.MdiParent = this;
            reportFormChild.FormBorderStyle = FormBorderStyle.None;
            reportFormChild.Dock = DockStyle.Fill;
            reportFormChild.Show();
        }

        //on Click function. in the empty space of the page show the child form which show the data of the user and the chance to change it
        private void ShowProfileForm (object sender, EventArgs e)
        {
            UserProfileEdit userFormChild = new UserProfileEdit(this.Email, this.PassHash);
            userFormChild.MdiParent = this;
            userFormChild.FormBorderStyle = FormBorderStyle.None;
            userFormChild.Dock = DockStyle.Fill;
            userFormChild.Show();
        }
        private void killChildren(object sender, EventArgs e) // This may sound a bit wrong
        {
            foreach (var child in this.MdiChildren)
            {
                child.Close();
            }
        }
        private void killDelta(object sender, FormClosedEventArgs e)
        {
            if (this.loggedOut != true)
                Application.Exit();
        }

        //on click logout function. close this form and show the login form
        private void ExitOnClickLabel(object sender, EventArgs e)
        {
            loggedOut = true;
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
