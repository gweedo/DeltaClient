namespace DeltaClient
{
    partial class AdminBookingList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bookingsLabel = new System.Windows.Forms.Label();
            this.bookingsListView = new System.Windows.Forms.ListView();
            this.labelUser = new System.Windows.Forms.Label();
            this.bookingMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vaiAReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaUtenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingsLabel
            // 
            this.bookingsLabel.AutoSize = true;
            this.bookingsLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingsLabel.Location = new System.Drawing.Point(297, -2);
            this.bookingsLabel.Name = "bookingsLabel";
            this.bookingsLabel.Size = new System.Drawing.Size(207, 48);
            this.bookingsLabel.TabIndex = 5;
            this.bookingsLabel.Text = "Prenotazioni";
            this.bookingsLabel.Click += new System.EventHandler();
            // 
            // bookingsListView
            // 
            this.bookingsListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bookingsListView.Location = new System.Drawing.Point(0, 71);
            this.bookingsListView.Name = "bookingsListView";
            this.bookingsListView.Size = new System.Drawing.Size(800, 379);
            this.bookingsListView.TabIndex = 3;
            this.bookingsListView.UseCompatibleStateImageBehavior = false;
            this.bookingsListView.SelectedIndexChanged += new System.EventHandler();
            this.bookingsListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BookingsListView_MouseClick);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(375, 45);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 20);
            this.labelUser.TabIndex = 6;
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bookingMenu
            // 
            this.bookingMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bookingMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vaiAReportToolStripMenuItem,
            this.modificaUtenteToolStripMenuItem,
            this.modificaAutoToolStripMenuItem,
            this.eliminaToolStripMenuItem});
            this.bookingMenu.Name = "bookingMenu";
            this.bookingMenu.Size = new System.Drawing.Size(209, 132);
            // 
            // vaiAReportToolStripMenuItem
            // 
            this.vaiAReportToolStripMenuItem.Name = "vaiAReportToolStripMenuItem";
            this.vaiAReportToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.vaiAReportToolStripMenuItem.Text = "Vai a report";
            this.vaiAReportToolStripMenuItem.Click += new System.EventHandler(this.VaiAReportToolStripMenuItem_Click);
            // 
            // modificaUtenteToolStripMenuItem
            // 
            this.modificaUtenteToolStripMenuItem.Name = "modificaUtenteToolStripMenuItem";
            this.modificaUtenteToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.modificaUtenteToolStripMenuItem.Text = "Modifica utente";
            this.modificaUtenteToolStripMenuItem.Click += new System.EventHandler(this.EditUser);
            // 
            // modificaAutoToolStripMenuItem
            // 
            this.modificaAutoToolStripMenuItem.Name = "modificaAutoToolStripMenuItem";
            this.modificaAutoToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.modificaAutoToolStripMenuItem.Text = "Modifica auto";
            this.modificaAutoToolStripMenuItem.Click += new System.EventHandler(this.EditCar);
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            this.eliminaToolStripMenuItem.Click += new System.EventHandler(this.DeleteBooking);
            // 
            // BookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.bookingsLabel);
            this.Controls.Add(this.bookingsListView);
            this.Name = "BookingsForm";
            this.Text = "BookingsForm";
            this.Load += new System.EventHandler();
            this.bookingMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookingsLabel;
        private System.Windows.Forms.ListView bookingsListView;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ContextMenuStrip bookingMenu;
        private System.Windows.Forms.ToolStripMenuItem modificaUtenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vaiAReportToolStripMenuItem;
    }
}