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
        protected DateTime LicenseExpiration = new DateTime(0, 0, 0);
        protected string Password;

        protected string Temp;
        public UserDataForm(string name, string email, string license, short licensePoints, DateTime licenseExpiration, string password)
        {
            Name = name;
            UserLabel.Text = Name;
            Email = email;
            License = license;
            LicensePoints = licensePoints;
            LicenseExpiration = licenseExpiration;
            Password = password;

            PasswordUserLabel.Visible = false;
            PasswordUserTextBox.Visible = false;
            PasswordUserLabel.Enabled = false;
            ConfirmPasswordLabel.Visible = false;
            ConfirmPasswordTextBox.Visible = false;
            ConfirmPasswordTextBox.Enabled = false;
            InitializeComponent();
        }

        private void SendSaveButton(object sender, EventArgs e)
        {
            if (Name != NameUsertextBox.Text || Email != EmailUserTextBox.Text || License != LicenseUserTextBox.Text || LicensePoints.ToString() != LicensePointsUserTextBox.Text || LicenseExpiration != LicenseExpirationUserDateTime.Value)
            {
                User.User UpdatableUser = new User.User();
                UpdatableUser.Name = NameUsertextBox.Text;
                UpdatableUser.Email = EmailUserTextBox.Text;
                UpdatableUser.License = LicenseUserTextBox.Text;
                UpdatableUser.LicensePoints = short.Parse(LicensePointsUserTextBox.Text);
                UpdatableUser.LicenseExpiration = LicenseExpirationUserDateTime.Value;

                UserManagerClient UserManager = new UserManagerClient();
                if (UserManager.UpdateUser(UpdatableUser, Email, Password)) MessageBox.Show("Modifica effettuata");
                else MessageBox.Show("aiai casini");

            }
        }
    }
}
