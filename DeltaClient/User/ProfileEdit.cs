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
    public partial class UserProfileEdit : Form
    {
        private User.User editingUser;
        private string Email;
        private string PassHash;
        private UserManagerClient userManager;
        public UserProfileEdit(string Email, string PassHash)
        {
            this.userManager = new UserManagerClient();
            this.Email = Email;
            this.PassHash = PassHash;
            InitializeComponent();
            this.HydrateFields();
        }

        private void HydrateFields()
        {
            this.editingUser = userManager.GetUserByEmail(this.Email, this.Email, this.PassHash);
            NameUsertextBox.Text = editingUser.Name;
            EmailUserTextBox.Text = editingUser.Email;
            EmailUserTextBox.ReadOnly = true;
            LicenseUserTextBox.Text = editingUser.License;
            expirationPicker.Value = editingUser.LicenseExpiration;
            PointsUpDown.Value = editingUser.LicensePoints;
            PasswordUserTextBox.Text = "";
            ConfirmPasswordTextBox.Text = "";
        }

        private void UpdateUser (object sender, EventArgs e)
        {
            if (editingUser.Name != NameUsertextBox.Text || editingUser.LicensePoints != PointsUpDown.Value || editingUser.LicenseExpiration != expirationPicker.Value || PasswordUserTextBox.Text != "" || editingUser.License != LicenseUserTextBox.Text)
            {
                User.User updatingUser = new User.User();
                updatingUser.Email = EmailUserTextBox.Text;
                EmailUserTextBox.ForeColor = Color.White;
                updatingUser.Name = NameUsertextBox.Text;
                updatingUser.LicensePoints = Convert.ToInt16(PointsUpDown.Value);
                updatingUser.License = LicenseUserTextBox.Text;
                updatingUser.LicenseExpiration = expirationPicker.Value;
                if (PasswordUserTextBox.Text != "")
                {
                    if (PasswordUserTextBox.Text == ConfirmPasswordTextBox.Text)
                        updatingUser.PasswordHash = EasyEncryption.MD5.ComputeMD5Hash(PasswordUserTextBox.Text);
                    else
                        MessageBox.Show("Le due password non corrispondono", "Controlla bene.", MessageBoxButtons.OK);
                }
                else
                {
                    updatingUser.PasswordHash = this.editingUser.PasswordHash;
                    this.userManager.UpdateUser(updatingUser, this.editingUser.Email, this.editingUser.PasswordHash);
                    MessageBox.Show("Grazie per le informazioni! Non le venderemo certo a Cambridge Analytica...", "Profilo modificato con successo");
                    this.HydrateFields();
                }
            }
        }
    }
}
