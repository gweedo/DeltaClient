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

namespace DeltaClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            string Email = EmailBoxLogin.Text;
            string Password = EasyEncryption.MD5.ComputeMD5Hash(PasswordBoxLogin.Text);
            
           

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
