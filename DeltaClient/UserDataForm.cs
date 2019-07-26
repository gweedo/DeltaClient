using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeltaClient.User;

namespace DeltaClient
{
    public partial class UserDataForm : Form
    {
        protected string Name = null;
        protected string Email = null;
        protected string License = null;
        protected short LicensePoints = 0;
        protected DateTime LicenseExpiration = new DateTime(0,0,0);
        public UserDataForm(string name, string email, string license, short licensePoints, DateTime licenseExpiration)
        {
            Name = name;
            UserLabel.Text = Name;
            Email = email;
            License = license;
            LicensePoints = licensePoints;
            LicenseExpiration = licenseExpiration;

            PasswordUserLabel.Visible = false;
            PasswordUserTextBox.Visible = false;
            PasswordUserLabel.Enabled = false;
            ConfirmPasswordLabel.Visible = false;
            ConfirmPasswordTextBox.Visible = false;
            ConfirmPasswordTextBox.Enabled = false;
            InitializeComponent();
        }

        private void SendSaveButton()
        {
            if(Name != NameUsertextBox.Text || Email != EmailUserTextBox.Text || LicensePoints.ToString() != LicensePointsUserTextBox.Text || LicenseExpiration.ToString() != LicenseExpirationUserTextBox.Text)
            {
                UserManagerClient userManager = new UserManagerClient();
                if (userManager.)  
            }
            
        }

    }
}
