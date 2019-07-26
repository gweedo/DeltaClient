﻿using DeltaClient.User;
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
    public partial class UserForm : Form
    {
        private string Email;
        private string PassHash;
        private UserManagerClient userManager;
        public UserForm(string Email, string PassHash)
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
            var users = this.userManager.GetUsers(this.Email, this.PassHash);
            var AdminString = "";
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void usersListView_SelectedIndexChanged(object sender, EventArgs e)
        {

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
