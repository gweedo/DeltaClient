namespace DeltaClient
{
    partial class ServicesListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesListForm));
            this.addCar = new System.Windows.Forms.Button();
            this.servicesLabel = new System.Windows.Forms.Label();
            this.servicesListView = new System.Windows.Forms.ListView();
            this.PlateNumberLabel = new System.Windows.Forms.Label();
            this.serviceMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // addCar
            // 
            this.addCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCar.BackgroundImage")));
            this.addCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCar.Location = new System.Drawing.Point(738, 6);
            this.addCar.Name = "addCar";
            this.addCar.Size = new System.Drawing.Size(50, 50);
            this.addCar.TabIndex = 7;
            this.addCar.UseVisualStyleBackColor = true;
            this.addCar.Click += new System.EventHandler(this.AddService);
            // 
            // servicesLabel
            // 
            this.servicesLabel.AutoSize = true;
            this.servicesLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesLabel.Location = new System.Drawing.Point(288, -2);
            this.servicesLabel.Name = "servicesLabel";
            this.servicesLabel.Size = new System.Drawing.Size(224, 48);
            this.servicesLabel.TabIndex = 6;
            this.servicesLabel.Text = "Manutenzioni";
            // 
            // servicesListView
            // 
            this.servicesListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.servicesListView.Location = new System.Drawing.Point(0, 71);
            this.servicesListView.Name = "servicesListView";
            this.servicesListView.Size = new System.Drawing.Size(800, 379);
            this.servicesListView.TabIndex = 5;
            this.servicesListView.UseCompatibleStateImageBehavior = false;
            this.servicesListView.DoubleClick += new System.EventHandler(this.EditService);
            this.servicesListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ServicesListView_MouseClick);
            // 
            // PlateNumberLabel
            // 
            this.PlateNumberLabel.AutoSize = true;
            this.PlateNumberLabel.Location = new System.Drawing.Point(352, 48);
            this.PlateNumberLabel.Name = "PlateNumberLabel";
            this.PlateNumberLabel.Size = new System.Drawing.Size(96, 20);
            this.PlateNumberLabel.TabIndex = 8;
            this.PlateNumberLabel.Text = "di XX999XX";
            this.PlateNumberLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // serviceMenu
            // 
            this.serviceMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.serviceMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminaToolStripMenuItem});
            this.serviceMenu.Name = "serviceMenu";
            this.serviceMenu.Size = new System.Drawing.Size(241, 69);
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            this.eliminaToolStripMenuItem.Click += new System.EventHandler(this.DeleteService);
            // 
            // ServicesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlateNumberLabel);
            this.Controls.Add(this.addCar);
            this.Controls.Add(this.servicesLabel);
            this.Controls.Add(this.servicesListView);
            this.Name = "ServicesListForm";
            this.Text = "ServicesListForm";
            this.Load += new System.EventHandler(this.ServicesListForm_Load);
            this.serviceMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCar;
        private System.Windows.Forms.Label servicesLabel;
        private System.Windows.Forms.ListView servicesListView;
        private System.Windows.Forms.Label PlateNumberLabel;
        private System.Windows.Forms.ContextMenuStrip serviceMenu;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
    }
}