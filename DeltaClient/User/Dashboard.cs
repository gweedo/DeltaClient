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
    public partial class UserDashboard : Form
    {
        private string Email;
        private string PassHash;
        private bool loggedOut;
        public UserDashboard(string Email, string PassHash)
        {
            this.Email = Email;
            this.PassHash = PassHash;
            this.loggedOut = false;
            IsMdiContainer = true;
            InitializeComponent();
            homeButton.AutoSize = false;
            toolStrip.ImageScalingSize = new Size(80, 80);
            toolStrip.AutoSize = false;
        }

        private void ShowBookingForm (object sender, EventArgs e)
        {
            UserCarBooker carBookerChild= new UserCarBooker(this.Email, this.PassHash);
            carBookerChild.MdiParent = this;
            carBookerChild.FormBorderStyle = FormBorderStyle.None;
            carBookerChild.Dock = DockStyle.Fill;
            carBookerChild.Show();
        }

        private void ShowReportForm (object sender, EventArgs e)
        {
            UserAddReport reportFormChild = new UserAddReport(this.Email, this.PassHash);
            reportFormChild.MdiParent = this;
            reportFormChild.FormBorderStyle = FormBorderStyle.None;
            reportFormChild.Dock = DockStyle.Fill;
            reportFormChild.Show();
        }
        private void ShowProfileForm (object sender, EventArgs e)
        {
            UserProfileEdit userFormChild = new UserProfileEdit(this.Email, this.PassHash);
            userFormChild.MdiParent = this;
            userFormChild.FormBorderStyle = FormBorderStyle.None;
            userFormChild.Dock = DockStyle.Fill;
            userFormChild.Show();
        }
        private void SimpleUserForm_Load(object sender, EventArgs e)
        {

        }
        private void killDelta(object sender, FormClosedEventArgs e)
        {
            if (this.loggedOut != true)
                Application.Exit();
        }
        private void ExitOnClickLabel(object sender, EventArgs e)
        {
            loggedOut = true;
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
