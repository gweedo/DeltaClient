using DeltaClient.Car;
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
    public partial class Form2 : Form
    {
        protected string Email;
        protected string PassHash;
        public Form2( string Email, string PassHash)
        {
            this.Email = Email;
            this.PassHash = PassHash;
            IsMdiContainer = true;
            InitializeComponent();
        }

        private void ShowUsers(object sender, EventArgs e)
        {
            UserForm userFormChild = new UserForm(this.Email, this.PassHash);
            userFormChild.MdiParent = this;
            userFormChild.FormBorderStyle = FormBorderStyle.None;
            userFormChild.Dock = DockStyle.Fill;
            userFormChild.Show();
            
        }
        private void ShowCars(object sender, EventArgs e)
        {
            CarForm carFormChild = new CarForm(this.Email, this.PassHash);
            carFormChild.MdiParent = this;
            carFormChild.FormBorderStyle = FormBorderStyle.None;
            carFormChild.Dock = DockStyle.Fill;
            carFormChild.Show();
        }

        private void ExitOnClickLabel(object sender, EventArgs e)
        {

        }

        private void AddElementOnClickButton(object sender, EventArgs e)
        {

        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
