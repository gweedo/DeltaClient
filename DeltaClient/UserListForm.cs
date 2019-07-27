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
    public partial class UserListForm : Form
    {
        private string Email;
        private string PassHash;
        private UserManagerClient userManager;
        public UserListForm(string Email, string PassHash)
        {
            this.Email = Email;
            this.PassHash = PassHash;
            InitializeComponent();            
            usersListView.Clear();
            this.userManager = new UserManagerClient();
            usersListView.View = View.Details;
            usersListView.Columns.Add("Email", 230, HorizontalAlignment.Left);
            usersListView.Columns.Add("Nome", 200, HorizontalAlignment.Left);
            usersListView.Columns.Add("Scadenza", 150, HorizontalAlignment.Left);
            usersListView.Columns.Add("Punti", 50, HorizontalAlignment.Left);
            usersListView.Columns.Add("Admin", 50, HorizontalAlignment.Left);
            this.UpdateUsers();
        }

        private void UpdateUsers()
        {
            var users = this.userManager.GetUsers(this.Email, this.PassHash);
            var AdminString = "";
            usersListView.Items.Clear();
            foreach (var SingleUser in users)
            {
                if (SingleUser.isAdmin == true)
                    AdminString = "Sì";
                else
                    AdminString = "No";
                usersListView.Items.Add(new ListViewItem(new string[] { SingleUser.Email, SingleUser.Name, SingleUser.LicenseExpiration.ToShortDateString(), SingleUser.LicensePoints.ToString(), AdminString }));
            }
            usersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            usersListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void DeleteUser (object sender, EventArgs e)
        {
            this.userManager.DeleteUser(this.userManager.GetUserByEmail(usersListView.SelectedItems[0].Text, this.Email, this.PassHash), this.Email, this.PassHash);
            this.UpdateUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void usersListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UsersListView_MouseClick (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (usersListView.FocusedItem.Bounds.Contains(e.Location))
                {
                    userMenuStrip.Show(Cursor.Position);
                }
            }
        }
        private void showBookingsForUser (object sender, EventArgs e)
        {
            BookingsForm bookingFormChild = new BookingsForm(this.Email, this.PassHash, usersListView.SelectedItems[0].Text);
            bookingFormChild.MdiParent = this.ParentForm;
            bookingFormChild.FormBorderStyle = FormBorderStyle.None;
            bookingFormChild.Dock = DockStyle.Fill;
            bookingFormChild.Show();
        }

        private void AddUser (object sender, EventArgs e)
        {
            UserDataForm bookingFormChild = new UserDataForm(this.Email, this.PassHash);
            bookingFormChild.MdiParent = this.ParentForm;
            bookingFormChild.FormBorderStyle = FormBorderStyle.None;
            bookingFormChild.Dock = DockStyle.Fill;
            bookingFormChild.Show();
        }

        private void UsersListView_DoubleClick(object sender, EventArgs e)
        {
            if (usersListView.SelectedItems.Count == 1)
            {
                var selectedUser = this.userManager.GetUserByEmail(usersListView.SelectedItems[0].Text, this.Email, this.PassHash);

                UserDataForm bookingFormChild = new UserDataForm(selectedUser, this.Email, this.PassHash);
                bookingFormChild.MdiParent = this.ParentForm;
                bookingFormChild.FormBorderStyle = FormBorderStyle.None;
                bookingFormChild.Dock = DockStyle.Fill;
                bookingFormChild.Show();

            }
        }
    }
}
