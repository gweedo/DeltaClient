﻿namespace DeltaClient
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EmailBoxLogin = new System.Windows.Forms.TextBox();
            this.PasswordBoxLogin = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PaswordBoxSignUp = new System.Windows.Forms.TextBox();
            this.EmailBoxSignUp = new System.Windows.Forms.TextBox();
            this.NameBoxSignUp = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailBoxLogin
            // 
            this.EmailBoxLogin.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBoxLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.EmailBoxLogin.Location = new System.Drawing.Point(44, 226);
            this.EmailBoxLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EmailBoxLogin.Name = "EmailBoxLogin";
            this.EmailBoxLogin.Size = new System.Drawing.Size(286, 47);
            this.EmailBoxLogin.TabIndex = 0;
            this.EmailBoxLogin.Text = "Email";
            this.EmailBoxLogin.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // PasswordBoxLogin
            // 
            this.PasswordBoxLogin.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBoxLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.PasswordBoxLogin.Location = new System.Drawing.Point(44, 327);
            this.PasswordBoxLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PasswordBoxLogin.Name = "PasswordBoxLogin";
            this.PasswordBoxLogin.Size = new System.Drawing.Size(286, 47);
            this.PasswordBoxLogin.TabIndex = 1;
            this.PasswordBoxLogin.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(137, 449);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(65, 36);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // PaswordBoxSignUp
            // 
            this.PaswordBoxSignUp.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaswordBoxSignUp.ForeColor = System.Drawing.SystemColors.GrayText;
            this.PaswordBoxSignUp.Location = new System.Drawing.Point(605, 380);
            this.PaswordBoxSignUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PaswordBoxSignUp.Name = "PaswordBoxSignUp";
            this.PaswordBoxSignUp.Size = new System.Drawing.Size(286, 47);
            this.PaswordBoxSignUp.TabIndex = 3;
            this.PaswordBoxSignUp.Text = "Password";
            // 
            // EmailBoxSignUp
            // 
            this.EmailBoxSignUp.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBoxSignUp.ForeColor = System.Drawing.SystemColors.GrayText;
            this.EmailBoxSignUp.Location = new System.Drawing.Point(605, 279);
            this.EmailBoxSignUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EmailBoxSignUp.Name = "EmailBoxSignUp";
            this.EmailBoxSignUp.Size = new System.Drawing.Size(286, 47);
            this.EmailBoxSignUp.TabIndex = 4;
            this.EmailBoxSignUp.Text = "Email";
            // 
            // NameBoxSignUp
            // 
            this.NameBoxSignUp.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBoxSignUp.ForeColor = System.Drawing.SystemColors.GrayText;
            this.NameBoxSignUp.Location = new System.Drawing.Point(605, 180);
            this.NameBoxSignUp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NameBoxSignUp.Name = "NameBoxSignUp";
            this.NameBoxSignUp.Size = new System.Drawing.Size(286, 47);
            this.NameBoxSignUp.TabIndex = 5;
            this.NameBoxSignUp.Text = "Nome";
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(697, 449);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(95, 36);
            this.SignUpButton.TabIndex = 6;
            this.SignUpButton.Text = "Registrati";
            this.SignUpButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 26F);
            this.label1.Location = new System.Drawing.Point(112, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 60);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 26F);
            this.label2.Location = new System.Drawing.Point(609, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 60);
            this.label2.TabIndex = 9;
            this.label2.Text = "Registrazione";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 518);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.NameBoxSignUp);
            this.Controls.Add(this.EmailBoxSignUp);
            this.Controls.Add(this.PaswordBoxSignUp);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordBoxLogin);
            this.Controls.Add(this.EmailBoxLogin);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailBoxLogin;
        private System.Windows.Forms.TextBox PasswordBoxLogin;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PaswordBoxSignUp;
        private System.Windows.Forms.TextBox EmailBoxSignUp;
        private System.Windows.Forms.TextBox NameBoxSignUp;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

