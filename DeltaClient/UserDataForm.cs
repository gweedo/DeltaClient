﻿using System;
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
        private bool newUser;
        public UserDataForm(User.User user, string Email, string PassHash)
        {
            InitializeComponent();
            this.newUser = false;
            this.editingUser = user;
            this.Email = Email;
            this.PassHash = PassHash;
            NameUsertextBox.Text = user.Name;
            EmailUserTextBox.Text = user.Email;
            EmailUserTextBox.ReadOnly = true;
            LicenseUserTextBox.Text = user.License;
            expirationPicker.Value = user.LicenseExpiration;
            PointsUpDown.Value= user.LicensePoints;
            AdminCheckbox.Checked = user.isAdmin;
        }

        public UserDataForm (string Email, string PassHash)
        {
            InitializeComponent();
            this.newUser = true;
            this.Email = Email;
            this.PassHash = PassHash;
            NameUsertextBox.Text = "";
            EmailUserTextBox.Text = "";
            EmailUserTextBox.ReadOnly = false;
            LicenseUserTextBox.Text = "";
            PointsUpDown.Value = 0;
            AdminCheckbox.Checked = false;
            DeleteButton.Visible = false;
        }


        private void UpdateUser()
        {
            if (editingUser.isAdmin != AdminCheckbox.Checked || editingUser.Name != NameUsertextBox.Text || editingUser.LicensePoints != PointsUpDown.Value || editingUser.LicenseExpiration != expirationPicker.Value || PasswordUserTextBox.Text != "" || editingUser.License != LicenseUserTextBox.Text)
            {
                UserManagerClient userManager = new UserManagerClient();
                User.User updatingUser = new User.User();
                updatingUser.Email = EmailUserTextBox.Text;
                updatingUser.Name = NameUsertextBox.Text;
                updatingUser.LicensePoints = Convert.ToInt16(PointsUpDown.Value);
                updatingUser.License = LicenseUserTextBox.Text;
                updatingUser.LicenseExpiration = expirationPicker.Value;
                updatingUser.isAdmin = AdminCheckbox.Checked;
                if (PasswordUserTextBox.Text != "")
                {
                    if (PasswordUserTextBox.Text == ConfirmPasswordTextBox.Text)
                        updatingUser.PasswordHash = EasyEncryption.MD5.ComputeMD5Hash(PasswordUserTextBox.Text);
                    else
                        MessageBox.Show("Le due password non corrispondono", "Controlla bene.", MessageBoxButtons.OK);
                }
                else
                    updatingUser.PasswordHash = this.editingUser.PasswordHash;
                userManager.UpdateUser(updatingUser, this.Email, this.PassHash);
            }
        }

        private void SendSaveButton(object sender, EventArgs e) 
        {
            if (this.newUser)
                this.CreateUser();
            else
                this.UpdateUser();
            this.cancelEditing(sender, e);
            
        }

        private void cancelEditing (object sender, EventArgs e)
        {
            UserListForm listFormChild = new UserListForm(this.Email, this.PassHash);
            listFormChild.MdiParent = this.ParentForm;
            listFormChild.FormBorderStyle = FormBorderStyle.None;
            listFormChild.Dock = DockStyle.Fill;
            listFormChild.Show();
        }
        private void CreateUser()
        {
            if ("" != NameUsertextBox.Text || 0 != PointsUpDown.Value || DateTime.Now.Date > expirationPicker.Value || PasswordUserTextBox.Text != "" || "" != LicenseUserTextBox.Text)
            {
                UserManagerClient userManager = new UserManagerClient();
                User.User updatingUser = new User.User();
                updatingUser.Email = EmailUserTextBox.Text;
                updatingUser.Name = NameUsertextBox.Text;
                updatingUser.LicensePoints = Convert.ToInt16(PointsUpDown.Value);
                updatingUser.License = LicenseUserTextBox.Text;
                updatingUser.LicenseExpiration = expirationPicker.Value;
                updatingUser.isAdmin = AdminCheckbox.Checked;

                    if (PasswordUserTextBox.Text == ConfirmPasswordTextBox.Text)
                        updatingUser.PasswordHash = EasyEncryption.MD5.ComputeMD5Hash(PasswordUserTextBox.Text);
                    else
                        MessageBox.Show("Le due password non corrispondono", "Controlla bene.", MessageBoxButtons.OK);
                userManager.AddUser(updatingUser, this.Email, this.PassHash);
            }
            else
                MessageBox.Show("Controlla bene i campi.", "Non posso salvare così.", MessageBoxButtons.OK);
        }
        private void DeleteUser (object sender, EventArgs e)
        {
            UserManagerClient userManager = new UserManagerClient();
            userManager.DeleteUser(this.editingUser, this.Email, this.PassHash);
            this.cancelEditing(sender, e);
        }
        private void UserDataForm_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
