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
    public partial class Form1 : Form
    {
        private string tempHint;
        private bool loggingIn;
        public Form1()
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

        private void Login(object sender, EventArgs e)
        {
            string Email = EmailBoxLogin.Text;
            string Password = EasyEncryption.MD5.ComputeMD5Hash(PasswordBoxLogin.Text);
            
           

        }

        private void deactivateHint (object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            this.tempHint = box.Text;
            box.Text = "";
            box.ForeColor = Color.Black;
            if (box.Name=="PasswordBoxLogin" || box.Name == "PasswordBoxSignUp"){
                box.PasswordChar = '*';
            }
        }

        private void activateHint (object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box.Text == "")
            {
                box.Text = this.tempHint;
                box.ForeColor = Color.Gray;
            }
        }

        private void login (object sender, EventArgs e)
        {
            UserManagerClient userManager = new UserManagerClient();
            try
            {
                if (userManager.LoginChecker(EmailBoxLogin.Text, EasyEncryption.MD5.ComputeMD5Hash(PasswordBoxLogin.Text)))
                {
                    loggingIn = true;
                    this.Hide();
                    Form2 main = new Form2(EmailBoxLogin.Text, EasyEncryption.MD5.ComputeMD5Hash(PasswordBoxLogin.Text));
                    main.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Utente/Password errati.", "Non è così che si fa.", MessageBoxButtons.OK);
            }catch (Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
            }
        }

        private void signUp (object sender, EventArgs e)
        {
            try
            {
                UserManagerClient userManager = new UserManagerClient();
                if (this.CheckEmail(EmailBoxSignUp.Text))
                {
                    if (userManager.CreateUser(NameBoxSignUp.Text, EmailBoxSignUp.Text, EasyEncryption.MD5.ComputeMD5Hash(PasswordBoxSignUp.Text), false, null, 20))
                        MessageBox.Show("Utente creato.", "Loggati pure.", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Sicuro?", "Temo che ci sia qualcosa che non va.", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Sicuro?", "Controlla l'email.", MessageBoxButtons.OK);

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);


            }
        }
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
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void killDelta(object sender, FormClosedEventArgs e)
        {
            if (!loggingIn)
                Application.Exit();
        }
    }
}
