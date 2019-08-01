using System;

namespace DeltaClient
{
    partial class UserCarBooker
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bookCarTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.carLabel = new System.Windows.Forms.Label();
            this.carBox = new System.Windows.Forms.ComboBox();
            this.endPicker = new System.Windows.Forms.DateTimePicker();
            this.Inizio = new System.Windows.Forms.Label();
            this.Fine = new System.Windows.Forms.Label();
            this.bookCarLabel = new System.Windows.Forms.Label();
            this.startPicker = new System.Windows.Forms.DateTimePicker();
            this.returnCarTab = new System.Windows.Forms.TabPage();
            this.kilometersUpDown = new System.Windows.Forms.NumericUpDown();
            this.litersUpDown = new System.Windows.Forms.NumericUpDown();
            this.returnButton = new System.Windows.Forms.Button();
            this.kmLabel = new System.Windows.Forms.Label();
            this.litersLabel = new System.Windows.Forms.Label();
            this.bookingLabel = new System.Windows.Forms.Label();
            this.bookingBox = new System.Windows.Forms.ComboBox();
            this.returnLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.bookCarTab.SuspendLayout();
            this.returnCarTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kilometersUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.litersUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.bookCarTab);
            this.tabControl1.Controls.Add(this.returnCarTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // bookCarTab
            // 
            this.bookCarTab.BackColor = System.Drawing.SystemColors.Control;
            this.bookCarTab.Controls.Add(this.button1);
            this.bookCarTab.Controls.Add(this.carLabel);
            this.bookCarTab.Controls.Add(this.carBox);
            this.bookCarTab.Controls.Add(this.endPicker);
            this.bookCarTab.Controls.Add(this.Inizio);
            this.bookCarTab.Controls.Add(this.Fine);
            this.bookCarTab.Controls.Add(this.bookCarLabel);
            this.bookCarTab.Controls.Add(this.startPicker);
            this.bookCarTab.Location = new System.Drawing.Point(4, 29);
            this.bookCarTab.Name = "bookCarTab";
            this.bookCarTab.Padding = new System.Windows.Forms.Padding(3);
            this.bookCarTab.Size = new System.Drawing.Size(790, 417);
            this.bookCarTab.TabIndex = 0;
            this.bookCarTab.Text = "Prenota";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "Prenota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.confirmBooking);
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carLabel.Location = new System.Drawing.Point(242, 186);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(74, 38);
            this.carLabel.TabIndex = 11;
            this.carLabel.Text = "Auto";
            // 
            // carBox
            // 
            this.carBox.FormattingEnabled = true;
            this.carBox.Location = new System.Drawing.Point(240, 227);
            this.carBox.Name = "carBox";
            this.carBox.Size = new System.Drawing.Size(310, 28);
            this.carBox.TabIndex = 10;
            // 
            // endPicker
            // 
            this.endPicker.Location = new System.Drawing.Point(489, 94);
            this.endPicker.Name = "endPicker";
            this.endPicker.Size = new System.Drawing.Size(236, 26);
            this.endPicker.TabIndex = 9;
            this.endPicker.ValueChanged += new System.EventHandler(this.UpdateAvailableCars);
            // 
            // Inizio
            // 
            this.Inizio.AutoSize = true;
            this.Inizio.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inizio.Location = new System.Drawing.Point(41, 53);
            this.Inizio.Name = "Inizio";
            this.Inizio.Size = new System.Drawing.Size(79, 38);
            this.Inizio.TabIndex = 8;
            this.Inizio.Text = "Inizio";
            // 
            // Fine
            // 
            this.Fine.AutoSize = true;
            this.Fine.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fine.Location = new System.Drawing.Point(482, 53);
            this.Fine.Name = "Fine";
            this.Fine.Size = new System.Drawing.Size(65, 38);
            this.Fine.TabIndex = 7;
            this.Fine.Text = "Fine";
            // 
            // bookCarLabel
            // 
            this.bookCarLabel.AutoSize = true;
            this.bookCarLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCarLabel.Location = new System.Drawing.Point(290, 5);
            this.bookCarLabel.Name = "bookCarLabel";
            this.bookCarLabel.Size = new System.Drawing.Size(215, 48);
            this.bookCarLabel.TabIndex = 6;
            this.bookCarLabel.Text = "Prenota auto";
            // 
            // startPicker
            // 
            this.startPicker.Location = new System.Drawing.Point(48, 94);
            this.startPicker.Name = "startPicker";
            this.startPicker.Size = new System.Drawing.Size(236, 26);
            this.startPicker.TabIndex = 1;
            this.startPicker.ValueChanged += new System.EventHandler(this.UpdateAvailableCars);
            // 
            // returnCarTab
            // 
            this.returnCarTab.BackColor = System.Drawing.SystemColors.Control;
            this.returnCarTab.Controls.Add(this.kilometersUpDown);
            this.returnCarTab.Controls.Add(this.litersUpDown);
            this.returnCarTab.Controls.Add(this.returnButton);
            this.returnCarTab.Controls.Add(this.kmLabel);
            this.returnCarTab.Controls.Add(this.litersLabel);
            this.returnCarTab.Controls.Add(this.bookingLabel);
            this.returnCarTab.Controls.Add(this.bookingBox);
            this.returnCarTab.Controls.Add(this.returnLabel);
            this.returnCarTab.Location = new System.Drawing.Point(4, 29);
            this.returnCarTab.Name = "returnCarTab";
            this.returnCarTab.Padding = new System.Windows.Forms.Padding(3);
            this.returnCarTab.Size = new System.Drawing.Size(790, 417);
            this.returnCarTab.TabIndex = 1;
            this.returnCarTab.Text = "Restituisci";
            this.returnCarTab.Enter += new System.EventHandler(this.UpdateBookings);
            // 
            // kilometersUpDown
            // 
            this.kilometersUpDown.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilometersUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.kilometersUpDown.Location = new System.Drawing.Point(412, 227);
            this.kilometersUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.kilometersUpDown.Name = "kilometersUpDown";
            this.kilometersUpDown.Size = new System.Drawing.Size(120, 39);
            this.kilometersUpDown.TabIndex = 22;
            // 
            // litersUpDown
            // 
            this.litersUpDown.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litersUpDown.Location = new System.Drawing.Point(265, 227);
            this.litersUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.litersUpDown.Name = "litersUpDown";
            this.litersUpDown.Size = new System.Drawing.Size(120, 39);
            this.litersUpDown.TabIndex = 21;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(322, 346);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(122, 37);
            this.returnButton.TabIndex = 20;
            this.returnButton.Text = "Restituisci";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnBooking);
            // 
            // kmLabel
            // 
            this.kmLabel.AutoSize = true;
            this.kmLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kmLabel.Location = new System.Drawing.Point(405, 185);
            this.kmLabel.Name = "kmLabel";
            this.kmLabel.Size = new System.Drawing.Size(55, 38);
            this.kmLabel.TabIndex = 19;
            this.kmLabel.Text = "Km";
            // 
            // litersLabel
            // 
            this.litersLabel.AutoSize = true;
            this.litersLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litersLabel.Location = new System.Drawing.Point(258, 185);
            this.litersLabel.Name = "litersLabel";
            this.litersLabel.Size = new System.Drawing.Size(59, 38);
            this.litersLabel.TabIndex = 18;
            this.litersLabel.Text = "Litri";
            // 
            // bookingLabel
            // 
            this.bookingLabel.AutoSize = true;
            this.bookingLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingLabel.Location = new System.Drawing.Point(315, 85);
            this.bookingLabel.Name = "bookingLabel";
            this.bookingLabel.Size = new System.Drawing.Size(171, 38);
            this.bookingLabel.TabIndex = 14;
            this.bookingLabel.Text = "Prenotazione";
            // 
            // bookingBox
            // 
            this.bookingBox.FormattingEnabled = true;
            this.bookingBox.Location = new System.Drawing.Point(226, 126);
            this.bookingBox.Name = "bookingBox";
            this.bookingBox.Size = new System.Drawing.Size(339, 28);
            this.bookingBox.TabIndex = 13;
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnLabel.Location = new System.Drawing.Point(274, 3);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(242, 48);
            this.returnLabel.TabIndex = 12;
            this.returnLabel.Text = "Restituisci auto";
            this.returnLabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // CarBooker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "CarBooker";
            this.Text = "CarBooker";
            this.tabControl1.ResumeLayout(false);
            this.bookCarTab.ResumeLayout(false);
            this.bookCarTab.PerformLayout();
            this.returnCarTab.ResumeLayout(false);
            this.returnCarTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kilometersUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.litersUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage bookCarTab;
        private System.Windows.Forms.TabPage returnCarTab;
        private System.Windows.Forms.DateTimePicker startPicker;
        private System.Windows.Forms.Label bookCarLabel;
        private System.Windows.Forms.Label Inizio;
        private System.Windows.Forms.Label Fine;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.ComboBox carBox;
        private System.Windows.Forms.DateTimePicker endPicker;
        private System.Windows.Forms.Label bookingLabel;
        private System.Windows.Forms.ComboBox bookingBox;
        private System.Windows.Forms.Label returnLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label kmLabel;
        private System.Windows.Forms.Label litersLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown kilometersUpDown;
        private System.Windows.Forms.NumericUpDown litersUpDown;
    }
}