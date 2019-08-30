namespace DeltaClient
{
    partial class AdminCarList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCarList));
            this.carListView = new System.Windows.Forms.ListView();
            this.carLabel = new System.Windows.Forms.Label();
            this.addCar = new System.Windows.Forms.Button();
            this.carMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.manutenzioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // carListView
            // 
            this.carListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.carListView.Location = new System.Drawing.Point(0, 56);
            this.carListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carListView.Name = "carListView";
            this.carListView.Size = new System.Drawing.Size(711, 304);
            this.carListView.TabIndex = 0;
            this.carListView.UseCompatibleStateImageBehavior = false;
            this.carListView.DoubleClick += new System.EventHandler(this.EditCar);
            this.carListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CarListView_MouseClick);
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carLabel.Location = new System.Drawing.Point(292, 10);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(79, 41);
            this.carLabel.TabIndex = 3;
            this.carLabel.Text = "Auto";
            // 
            // addCar
            // 
            this.addCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCar.BackgroundImage")));
            this.addCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCar.Location = new System.Drawing.Point(656, 10);
            this.addCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addCar.Name = "addCar";
            this.addCar.Size = new System.Drawing.Size(44, 40);
            this.addCar.TabIndex = 4;
            this.addCar.UseVisualStyleBackColor = true;
            this.addCar.Click += new System.EventHandler(this.CreateCar);
            // 
            // carMenu
            // 
            this.carMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.carMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutenzioniToolStripMenuItem,
            this.eliminaToolStripMenuItem});
            this.carMenu.Name = "carMenu";
            this.carMenu.Size = new System.Drawing.Size(211, 80);
            // 
            // manutenzioniToolStripMenuItem
            // 
            this.manutenzioniToolStripMenuItem.Name = "manutenzioniToolStripMenuItem";
            this.manutenzioniToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.manutenzioniToolStripMenuItem.Text = "Vai a manutenzioni";
            this.manutenzioniToolStripMenuItem.Click += new System.EventHandler(this.CheckServices);
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            this.eliminaToolStripMenuItem.Click += new System.EventHandler(this.DeleteCar);
            // 
            // AdminCarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.addCar);
            this.Controls.Add(this.carLabel);
            this.Controls.Add(this.carListView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminCarList";
            this.Text = "CarForm";
            this.carMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView carListView;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.Button addCar;
        private System.Windows.Forms.ContextMenuStrip carMenu;
        private System.Windows.Forms.ToolStripMenuItem manutenzioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
    }
}