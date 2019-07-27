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
        private User.User editingUser;
        private string Email;
        private string PassHash;
        public UserDataForm(User.User user, string Email, string PassHash)
        {
            InitializeComponent();
            this.editingUser = user;
            this.Email = Email;
            this.PassHash = PassHash;
            NameUsertextBox.Text = user.Name;
            EmailUserTextBox.Text = user.Email;
            EmailUserTextBox.ReadOnly = true;
            LicenseUserTextBox.Text = user.License;
            expirationPicker.Value = user.LicenseExpiration;
            LicensePointsUserTextBox.Text = user.LicensePoints.ToString();
            AdminCheckbox.Checked = user.isAdmin;
        }


        private void SendSaveButton() 
        {
            if(editingUser.Name != NameUsertextBox.Text || editingUser.LicensePoints.ToString() != LicensePointsUserTextBox.Text || editingUser.LicenseExpiration != expirationPicker.Value || PasswordUserTextBox.Text!="")
            {
                UserManagerClient userManager = new UserManagerClient();
                User.User updatingUser = new User.User();

                updatingUser.Name = NameUsertextBox.Text;
                updatingUser.LicensePoints = Convert.ToInt16(LicensePointsUserTextBox.Text);
                updatingUser.License = LicenseUserTextBox.Text;
                updatingUser.LicenseExpiration = expirationPicker.Value;
                updatingUser.isAdmin = AdminCheckbox.Checked;
                if (PasswordUserTextBox.Text == ConfirmPasswordTextBox.Text)
                    updatingUser.PasswordHash = EasyEncryption.MD5.ComputeMD5Hash(PasswordUserTextBox.Text);
                else
                    MessageBox.Show("Le due password non corrispondono", "Controlla bene.", MessageBoxButtons.OK);
                userManager.UpdateUser(updatingUser, this.Email, this.PassHash);
            }
            
        }

        private void cancelEditing (object sender, EventArgs e)
        {
            UserListForm listFormChild = new UserListForm(this.Email, this.PassHash);
            listFormChild.MdiParent = this.ParentForm;
            listFormChild.FormBorderStyle = FormBorderStyle.None;
            listFormChild.Dock = DockStyle.Fill;
            listFormChild.Show();
        }

        private void UserDataForm_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
