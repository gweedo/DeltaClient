using System;
using System.Data.HashFunction.CityHash;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeltaClient.User;
using System.Collections;

namespace DeltaClient
{

    /// <summary>
    /// That form give the access to all the functionality, if the user haven't got the access referencies he can create them in this form.
    /// </summary>
    public partial class Login : Form
    {
        private string tempHint;
        private bool loggingIn;
        public Login()
        {
            InitializeComponent();
            this.loggingIn = false;
            // Initializing "hint" texts
            EmailBoxLogin.Text = "Email";
            EmailBoxLogin.ForeColor = Color.Gray;
            PasswordBoxLogin.Text = "Password";
            PasswordBoxLogin.ForeColor = Color.Gray;
            NameBoxSignUp.Text = "Nome";
            NameBoxSignUp.ForeColor = Color.Gray;
            EmailBoxSignUp.Text = "Email";
            EmailBoxSignUp.ForeColor = Color.Gray;
            PasswordBoxSignUp.Text = "Password";
            PasswordBoxSignUp.ForeColor = Color.Gray;
        }

        //design function. change the color font in all the textbox when the user is writing down 
        private void deactivateHint (object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            this.tempHint = box.Text;
            box.Text = "";
            box.ForeColor = Color.Black;
            if (box.Name=="PasswordBoxLogin" || box.Name == "PasswordBoxSignUp"){ //this control change the font of the field of the password 
                box.PasswordChar = '*';
            }
        }

        //design function. after a textbox deselection, if the fiel is empty, reset the grapich design.
        private void activateHint (object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box.Text == "")
            {
                box.Text = this.tempHint;
                box.ForeColor = Color.Gray;
            }
        }

        // on click function. Check if the access refericies are good and then give the access at the program. Otherwise show an error message
        private void loginNow (object sender, EventArgs e)
        {
             
            try
            {   //take the data of the textBox
                UserManagerClient userManager = new UserManagerClient(); //initialize
                string UserMail = EmailBoxLogin.Text;
                string PassHash= EasyEncryption.MD5.ComputeMD5Hash(PasswordBoxLogin.Text);//encode the password 

                //apply the funcition control on the referencies
                if (userManager.LoginChecker(UserMail,PassHash))
                {
                    loggingIn = true; //set the user logged

                    this.Hide();//hide the control to the user
                    //verify if the user is an admin or not
                    if (userManager.IsAdmin(UserMail, PassHash))
                    {
                        AdminDashboard main = new AdminDashboard(UserMail, PassHash); //initialize a new admin form
                        main.Show(); //send to the new form
                    }
                    else
                    {
                        UserDashboard main = new UserDashboard(UserMail, PassHash); //initialize a new user form
                        main.Show();
                    }
                    this.Close();// End of the control Hiding
                }
                else
                    MessageBox.Show("Utente/Password errati.", "Non è così che si fa.", MessageBoxButtons.OK);//Error Message

            }catch (Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
            }
        }


        //on Click function. allow the access at the program to the user creating new referencies 
        private void signUp (object sender, EventArgs e)
        {
            try
            {
                UserManagerClient userManager = new UserManagerClient(); //initialize
                
                //check if the Email is just used for another account, if the email is valid try to create and save into the databse the account  
                if (this.CheckEmail(EmailBoxSignUp.Text))
                {
                    //control of the good account's creation
                    if (userManager.CreateUser(NameBoxSignUp.Text, EmailBoxSignUp.Text, EasyEncryption.MD5.ComputeMD5Hash(PasswordBoxSignUp.Text), false, null, 20)) //account's creation
                        MessageBox.Show("Utente creato.", "Loggati pure.", MessageBoxButtons.OK); //affermative message
                    else
                        MessageBox.Show("Sicuro?", "Temo che ci sia qualcosa che non va.", MessageBoxButtons.OK); //negative message
                }
                else // if the Email isin't valid the program show an errore message
                {
                    MessageBox.Show("Sicuro?", "Controlla l'email.", MessageBoxButtons.OK);

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
            }
        }

        //control function used in "singUp" function for the email control
        private bool CheckEmail(string Email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(Email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //on Click function. close the program   
        private void killDelta(object sender, FormClosedEventArgs e)
        {
            if (!loggingIn)
                Application.Exit();
        }
    }
}
