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
{/// <summary>
/// this form allow the admin to change name, license, license's points, license's exipiration date, and promote a user to admin
/// </summary>
    public partial class AdminUserEdit : Form
    {
        private User.User editingUser;
        private UserManagerClient userManager;
        private string Email;
        private string PassHash;
        private bool newUser;

        //constructor
        public AdminUserEdit(User.User user, string Email, string PassHash)
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
            try
            {
                this.userManager = new UserManagerClient();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
            }
        }

        //overloaded constructor. in this case the admin add a user
        public AdminUserEdit (string Email, string PassHash)
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
            try
            {
                this.userManager = new UserManagerClient();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
            }
        }

        //this function control if there are some changes and update the user
        private void UpdateUser(object sender, EventArgs e)
        {
            if (editingUser.isAdmin != AdminCheckbox.Checked || editingUser.Name != NameUsertextBox.Text || editingUser.LicensePoints != PointsUpDown.Value || editingUser.LicenseExpiration != expirationPicker.Value || PasswordUserTextBox.Text != "" || editingUser.License != LicenseUserTextBox.Text)
            {
                User.User updatingUser = new User.User();
                updatingUser.Email = EmailUserTextBox.Text;
                EmailUserTextBox.ForeColor = Color.White;
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
                try { 
                this.userManager.UpdateUser(updatingUser, this.Email, this.PassHash);
                this.cancelEditing(sender, e);
                }catch(Exception exc)
                {
                    MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a modificare l'utente.", MessageBoxButtons.OK);
                }
            }
        }

        //on CLick fucntion. control if the amind is modifing or adding a user
        private void SendSaveButton(object sender, EventArgs e) 
        {
            if (this.newUser)
                this.CreateUser(sender, e);
            else
                this.UpdateUser(sender, e);            
        }

        

        //This function control that input fields aren't empty and then add the user
        private void CreateUser(object sender, EventArgs e)
        {
            if ("" != EmailUserTextBox.Text && "" != NameUsertextBox.Text && 0 != PointsUpDown.Value && DateTime.Now.Date < expirationPicker.Value && PasswordUserTextBox.Text != "" && "" != LicenseUserTextBox.Text)
            {
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
                try
                {
                    this.userManager.AddUser(updatingUser, this.Email, this.PassHash);
                    this.cancelEditing(sender, e);
                }catch(Exception exc)
                {
                    MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco ad aggiungere l'utente.", MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show("Controlla bene i campi.", "Non posso salvare così.", MessageBoxButtons.OK);
        }

        //on Click function. this function deleate the selected user
        private void DeleteUser (object sender, EventArgs e)
        {
            try
            {
                userManager.DeleteUser(this.editingUser, this.Email, this.PassHash);
                this.cancelEditing(sender, e);
            }catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a eliminare l'utente.", MessageBoxButtons.OK);
            }
        }

        //this function close this form and initilize and show the user list form
        private void cancelEditing(object sender, EventArgs e)
        {
            AdminUserList listFormChild = new AdminUserList(this.Email, this.PassHash);
            listFormChild.MdiParent = this.ParentForm;
            listFormChild.FormBorderStyle = FormBorderStyle.None;
            listFormChild.Dock = DockStyle.Fill;
            listFormChild.Show();
        }
    }
}
