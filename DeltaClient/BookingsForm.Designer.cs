namespace DeltaClient
{
    partial class BookingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingsForm));
            this.bookingsLabel = new System.Windows.Forms.Label();
            this.addBooking = new System.Windows.Forms.Button();
            this.bookingsListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // bookingsLabel
            // 
            this.bookingsLabel.AutoSize = true;
            this.bookingsLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingsLabel.Location = new System.Drawing.Point(285, 9);
            this.bookingsLabel.Name = "bookingsLabel";
            this.bookingsLabel.Size = new System.Drawing.Size(207, 48);
            this.bookingsLabel.TabIndex = 5;
            this.bookingsLabel.Text = "Prenotazioni";
            this.bookingsLabel.Click += new System.EventHandler(this.BookingsLabel_Click);
            // 
            // addBooking
            // 
            this.addBooking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBooking.BackgroundImage")));
            this.addBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBooking.Location = new System.Drawing.Point(738, 6);
            this.addBooking.Name = "addBooking";
            this.addBooking.Size = new System.Drawing.Size(50, 50);
            this.addBooking.TabIndex = 4;
            this.addBooking.UseVisualStyleBackColor = true;
            // 
            // bookingsListView
            // 
            this.bookingsListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bookingsListView.Location = new System.Drawing.Point(0, 71);
            this.bookingsListView.Name = "bookingsListView";
            this.bookingsListView.Size = new System.Drawing.Size(800, 379);
            this.bookingsListView.TabIndex = 3;
            this.bookingsListView.UseCompatibleStateImageBehavior = false;
            this.bookingsListView.SelectedIndexChanged += new System.EventHandler(this.BookingsListView_SelectedIndexChanged);
            // 
            // BookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookingsLabel);
            this.Controls.Add(this.addBooking);
            this.Controls.Add(this.bookingsListView);
            this.Name = "BookingsForm";
            this.Text = "BookingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookingsLabel;
        private System.Windows.Forms.Button addBooking;
        private System.Windows.Forms.ListView bookingsListView;
    }
}