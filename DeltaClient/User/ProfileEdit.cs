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
    /// this child form allow the user to change some details of his data
    /// </summary>
    public partial class UserProfileEdit : Form
    {
        private User.User editingUser;
        private string Email;
        private string PassHash;
        private UserManagerClient userManager;

        //constructor
        public UserProfileEdit(string Email, string PassHash)
        {
            try { this.userManager = new UserManagerClient(); }
            catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
            }

            this.Email = Email;
            this.PassHash = PassHash;
            InitializeComponent();
            this.HydrateFields();
        }

        //initialize text components.  
        private void HydrateFields()
        {
            try { 
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
            catch (Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a caricare i contenuti.", MessageBoxButtons.OK);
            }
        }

        // on Click function. control all insert data, then send all data to the server
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
                // password control, if the password field is empty will send to the server the old hash password. 
                if (PasswordUserTextBox.Text != "")
                {
                    if (PasswordUserTextBox.Text == ConfirmPasswordTextBox.Text) //if the user want to change the password the program crypt the new password
                        updatingUser.PasswordHash = EasyEncryption.MD5.ComputeMD5Hash(PasswordUserTextBox.Text);
                    else
                        MessageBox.Show("Le due password non corrispondono", "Controlla bene.", MessageBoxButtons.OK);
                }
                else
                {
                    updatingUser.PasswordHash = this.editingUser.PasswordHash;
                }
                try { 

                    this.userManager.UpdateUser(updatingUser, this.editingUser.Email, this.editingUser.PasswordHash);
                    MessageBox.Show("Grazie per le informazioni! Non le venderemo certo a Cambridge Analytica...", "Profilo modificato con successo");
                    this.HydrateFields();
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a inviare i dati al server.", MessageBoxButtons.OK);

                    }
                
            }
        }
    }
}
