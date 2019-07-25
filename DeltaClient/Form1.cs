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
        public Form1()
        {
            InitializeComponent();
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
            if (userManager.LoginChecker(EmailBoxLogin.Text, EasyEncryption.MD5.ComputeMD5Hash(PasswordBoxLogin.Text)))
                Application.Run(new Form2());
            else
                MessageBox.Show("Utente/Password errati.", "Non è così che si fa.", MessageBoxButtons.OK);
        }

        private void signUp (object sender, EventArgs e)
        {
            UserManagerClient userManager = new UserManagerClient();
            if (this.CheckEmail(EmailBoxSignUp.Text))
            {
                if (userManager.CreateUser(NameBoxSignUp.Text, EmailBoxSignUp.Text, EasyEncryption.MD5.ComputeMD5Hash(PasswordBoxSignUp.Text), false, null, 20))
                    MessageBox.Show("Utente creato.", "Loggati pure.", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Sicuro?", "Temo che ci sia qualcosa che non va.", MessageBoxButtons.OK);
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
    }
}
