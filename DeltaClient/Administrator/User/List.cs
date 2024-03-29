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

    /// <summary>
    /// this child form show the list of all user and, once selected one, reiderct the admin to another child form which allow some changes to the selceted user
    /// </summary>
    public partial class AdminUserList : Form
    {
        private string Email;
        private string PassHash;
        private UserManagerClient userManager;

        //constructor
        public AdminUserList(string Email, string PassHash)
        {
            this.Email = Email;
            this.PassHash = PassHash;
            InitializeComponent();            
            usersListView.Clear();
            usersListView.View = View.Details;
            usersListView.Columns.Add("Email", 230, HorizontalAlignment.Left);
            usersListView.Columns.Add("Nome", 200, HorizontalAlignment.Left);
            usersListView.Columns.Add("Scadenza", 150, HorizontalAlignment.Left);
            usersListView.Columns.Add("Punti", 50, HorizontalAlignment.Left);
            usersListView.Columns.Add("Admin", 50, HorizontalAlignment.Left);
            try
            {
                this.userManager = new UserManagerClient();//initilize connection
                
                this.UpdateUsers();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco.", MessageBoxButtons.OK);
            }
        }

        //this function reload the list of all users
        private void UpdateUsers()
        {
            try
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
            catch (Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a caricare gli utenti.", MessageBoxButtons.OK);
            }
        }


        //on Click function. this function delete a user of the list
        private void DeleteUser (object sender, EventArgs e)
        {
            try
            {
                this.userManager.DeleteUser(this.userManager.GetUserByEmail(usersListView.SelectedItems[0].Text, this.Email, this.PassHash), this.Email, this.PassHash);
                this.UpdateUsers();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a eliminare l'utente.", MessageBoxButtons.OK);
            }
        }

        //on click function. this function reidirect the admin to a child form which the bookings of the selected user
        private void showBookingsForUser (object sender, EventArgs e)
        {
            AdminBookingList bookingFormChild = new AdminBookingList(this.Email, this.PassHash, usersListView.SelectedItems[0].Text);
            bookingFormChild.MdiParent = this.ParentForm;
            bookingFormChild.FormBorderStyle = FormBorderStyle.None;
            bookingFormChild.Dock = DockStyle.Fill;
            bookingFormChild.Show();
        }

        //on Click function. this show a new child form which allow the admin to add a user
        private void AddUser (object sender, EventArgs e)
        {
            AdminUserEdit bookingFormChild = new AdminUserEdit(this.Email, this.PassHash);
            bookingFormChild.MdiParent = this.ParentForm;
            bookingFormChild.FormBorderStyle = FormBorderStyle.None;
            bookingFormChild.Dock = DockStyle.Fill;
            bookingFormChild.Show();
        }

        //on Double Click function. this function reidirect the user to another child form which allow the admin to change some details of the user
        private void UsersListView_DoubleClick(object sender, EventArgs e)
        {
            if (usersListView.SelectedItems.Count == 1)
            {
                try
                {
                    var selectedUser = this.userManager.GetUserByEmail(usersListView.SelectedItems[0].Text, this.Email, this.PassHash);

                    AdminUserEdit bookingFormChild = new AdminUserEdit(selectedUser, this.Email, this.PassHash);
                    bookingFormChild.MdiParent = this.ParentForm;
                    bookingFormChild.FormBorderStyle = FormBorderStyle.None;
                    bookingFormChild.Dock = DockStyle.Fill;
                    bookingFormChild.Show();
                }catch(Exception exc)
                {
                    MessageBox.Show("Errore nella connessione al server.", "Proprio non riesco a farti modificare l'utente.", MessageBoxButtons.OK);
                }
            }
        }

        //on Click function. this function open a menu strip menu if the admin click, with the right buttons of the mouse, on a user of the list
        private void UsersListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (usersListView.FocusedItem.Bounds.Contains(e.Location))
                {
                    userMenuStrip.Show(Cursor.Position);
                }
            }
        }
    }
}
