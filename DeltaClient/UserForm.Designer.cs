namespace DeltaClient
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.usersListView = new System.Windows.Forms.ListView();
            this.addUser = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // usersListView
            // 
            this.usersListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usersListView.Location = new System.Drawing.Point(0, 71);
            this.usersListView.Name = "usersListView";
            this.usersListView.Size = new System.Drawing.Size(800, 379);
            this.usersListView.TabIndex = 0;
            this.usersListView.UseCompatibleStateImageBehavior = false;
            this.usersListView.SelectedIndexChanged += new System.EventHandler(this.usersListView_SelectedIndexChanged);
            // 
            // addUser
            // 
            this.addUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addUser.BackgroundImage")));
            this.addUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addUser.Location = new System.Drawing.Point(738, 12);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(50, 50);
            this.addUser.TabIndex = 1;
            this.addUser.UseVisualStyleBackColor = true;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(329, 12);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(109, 48);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Utenti";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 32);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.usersListView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView usersListView;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}