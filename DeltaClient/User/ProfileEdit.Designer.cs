namespace DeltaClient
{
    partial class UserProfileEdit
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
            this.PointsUpDown = new System.Windows.Forms.NumericUpDown();
            this.expirationPicker = new System.Windows.Forms.DateTimePicker();
            this.SaveUserButton = new System.Windows.Forms.Button();
            this.LicenseUserTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmailUserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordUserTextBox = new System.Windows.Forms.TextBox();
            this.NameUsertextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.LicenseExpirationUserLabel = new System.Windows.Forms.Label();
            this.EmailUserLabel = new System.Windows.Forms.Label();
            this.LicensePointsUserLabel = new System.Windows.Forms.Label();
            this.PasswordUserLabel = new System.Windows.Forms.Label();
            this.LicenseUserLabel = new System.Windows.Forms.Label();
            this.NameUserLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PointsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PointsUpDown
            // 
            this.PointsUpDown.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsUpDown.Location = new System.Drawing.Point(390, 193);
            this.PointsUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.PointsUpDown.Name = "PointsUpDown";
            this.PointsUpDown.Size = new System.Drawing.Size(120, 39);
            this.PointsUpDown.TabIndex = 60;
            // 
            // expirationPicker
            // 
            this.expirationPicker.Location = new System.Drawing.Point(550, 205);
            this.expirationPicker.Name = "expirationPicker";
            this.expirationPicker.Size = new System.Drawing.Size(235, 26);
            this.expirationPicker.TabIndex = 56;
            // 
            // SaveUserButton
            // 
            this.SaveUserButton.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.SaveUserButton.Location = new System.Drawing.Point(689, 392);
            this.SaveUserButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveUserButton.Name = "SaveUserButton";
            this.SaveUserButton.Size = new System.Drawing.Size(96, 46);
            this.SaveUserButton.TabIndex = 55;
            this.SaveUserButton.Text = "Salva";
            this.SaveUserButton.UseVisualStyleBackColor = true;
            this.SaveUserButton.Click += new System.EventHandler(this.UpdateUser);
            // 
            // LicenseUserTextBox
            // 
            this.LicenseUserTextBox.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.LicenseUserTextBox.Location = new System.Drawing.Point(7, 192);
            this.LicenseUserTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LicenseUserTextBox.Name = "LicenseUserTextBox";
            this.LicenseUserTextBox.Size = new System.Drawing.Size(262, 39);
            this.LicenseUserTextBox.TabIndex = 54;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(390, 324);
            this.ConfirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(318, 39);
            this.ConfirmPasswordTextBox.TabIndex = 53;
            this.ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // EmailUserTextBox
            // 
            this.EmailUserTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EmailUserTextBox.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.EmailUserTextBox.Location = new System.Drawing.Point(390, 56);
            this.EmailUserTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailUserTextBox.Name = "EmailUserTextBox";
            this.EmailUserTextBox.Size = new System.Drawing.Size(318, 39);
            this.EmailUserTextBox.TabIndex = 52;
            // 
            // PasswordUserTextBox
            // 
            this.PasswordUserTextBox.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.PasswordUserTextBox.Location = new System.Drawing.Point(7, 324);
            this.PasswordUserTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordUserTextBox.Name = "PasswordUserTextBox";
            this.PasswordUserTextBox.Size = new System.Drawing.Size(262, 39);
            this.PasswordUserTextBox.TabIndex = 51;
            this.PasswordUserTextBox.UseSystemPasswordChar = true;
            // 
            // NameUsertextBox
            // 
            this.NameUsertextBox.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.NameUsertextBox.Location = new System.Drawing.Point(7, 56);
            this.NameUsertextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameUsertextBox.Name = "NameUsertextBox";
            this.NameUsertextBox.Size = new System.Drawing.Size(262, 37);
            this.NameUsertextBox.TabIndex = 50;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(383, 281);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(250, 38);
            this.ConfirmPasswordLabel.TabIndex = 49;
            this.ConfirmPasswordLabel.Text = "Conferma Password";
            // 
            // LicenseExpirationUserLabel
            // 
            this.LicenseExpirationUserLabel.AutoSize = true;
            this.LicenseExpirationUserLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.LicenseExpirationUserLabel.Location = new System.Drawing.Point(552, 148);
            this.LicenseExpirationUserLabel.Name = "LicenseExpirationUserLabel";
            this.LicenseExpirationUserLabel.Size = new System.Drawing.Size(129, 38);
            this.LicenseExpirationUserLabel.TabIndex = 48;
            this.LicenseExpirationUserLabel.Text = "Scadenza";
            // 
            // EmailUserLabel
            // 
            this.EmailUserLabel.AutoSize = true;
            this.EmailUserLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.EmailUserLabel.Location = new System.Drawing.Point(383, 12);
            this.EmailUserLabel.Name = "EmailUserLabel";
            this.EmailUserLabel.Size = new System.Drawing.Size(80, 38);
            this.EmailUserLabel.TabIndex = 47;
            this.EmailUserLabel.Text = "Email";
            // 
            // LicensePointsUserLabel
            // 
            this.LicensePointsUserLabel.AutoSize = true;
            this.LicensePointsUserLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.LicensePointsUserLabel.Location = new System.Drawing.Point(387, 148);
            this.LicensePointsUserLabel.Name = "LicensePointsUserLabel";
            this.LicensePointsUserLabel.Size = new System.Drawing.Size(76, 38);
            this.LicensePointsUserLabel.TabIndex = 46;
            this.LicensePointsUserLabel.Text = "Punti";
            // 
            // PasswordUserLabel
            // 
            this.PasswordUserLabel.AutoSize = true;
            this.PasswordUserLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.PasswordUserLabel.Location = new System.Drawing.Point(0, 281);
            this.PasswordUserLabel.Name = "PasswordUserLabel";
            this.PasswordUserLabel.Size = new System.Drawing.Size(126, 38);
            this.PasswordUserLabel.TabIndex = 45;
            this.PasswordUserLabel.Text = "Password";
            // 
            // LicenseUserLabel
            // 
            this.LicenseUserLabel.AutoSize = true;
            this.LicenseUserLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.LicenseUserLabel.Location = new System.Drawing.Point(0, 148);
            this.LicenseUserLabel.Name = "LicenseUserLabel";
            this.LicenseUserLabel.Size = new System.Drawing.Size(104, 38);
            this.LicenseUserLabel.TabIndex = 44;
            this.LicenseUserLabel.Text = "Patente";
            // 
            // NameUserLabel
            // 
            this.NameUserLabel.AutoSize = true;
            this.NameUserLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.NameUserLabel.Location = new System.Drawing.Point(0, 14);
            this.NameUserLabel.Name = "NameUserLabel";
            this.NameUserLabel.Size = new System.Drawing.Size(90, 38);
            this.NameUserLabel.TabIndex = 43;
            this.NameUserLabel.Text = "Nome";
            // 
            // ProfileEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PointsUpDown);
            this.Controls.Add(this.expirationPicker);
            this.Controls.Add(this.SaveUserButton);
            this.Controls.Add(this.LicenseUserTextBox);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.EmailUserTextBox);
            this.Controls.Add(this.PasswordUserTextBox);
            this.Controls.Add(this.NameUsertextBox);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.LicenseExpirationUserLabel);
            this.Controls.Add(this.EmailUserLabel);
            this.Controls.Add(this.LicensePointsUserLabel);
            this.Controls.Add(this.PasswordUserLabel);
            this.Controls.Add(this.LicenseUserLabel);
            this.Controls.Add(this.NameUserLabel);
            this.Name = "ProfileEdit";
            this.Text = "ProfileEdit";
            ((System.ComponentModel.ISupportInitialize)(this.PointsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown PointsUpDown;
        private System.Windows.Forms.DateTimePicker expirationPicker;
        private System.Windows.Forms.Button SaveUserButton;
        private System.Windows.Forms.TextBox LicenseUserTextBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.TextBox EmailUserTextBox;
        private System.Windows.Forms.TextBox PasswordUserTextBox;
        private System.Windows.Forms.TextBox NameUsertextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Label LicenseExpirationUserLabel;
        private System.Windows.Forms.Label EmailUserLabel;
        private System.Windows.Forms.Label LicensePointsUserLabel;
        private System.Windows.Forms.Label PasswordUserLabel;
        private System.Windows.Forms.Label LicenseUserLabel;
        private System.Windows.Forms.Label NameUserLabel;
    }
}