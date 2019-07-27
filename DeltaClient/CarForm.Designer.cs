namespace DeltaClient
{
    partial class CarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarForm));
            this.carListView = new System.Windows.Forms.ListView();
            this.carLabel = new System.Windows.Forms.Label();
            this.addCar = new System.Windows.Forms.Button();
            this.carMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.manutenzioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // carListView
            // 
            this.carListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.carListView.Location = new System.Drawing.Point(0, 71);
            this.carListView.Name = "carListView";
            this.carListView.Size = new System.Drawing.Size(800, 379);
            this.carListView.TabIndex = 0;
            this.carListView.UseCompatibleStateImageBehavior = false;
            this.carListView.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            this.carListView.DoubleClick += new System.EventHandler(this.EditCar);
            this.carListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CarListView_MouseClick);
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carLabel.Location = new System.Drawing.Point(329, 12);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(93, 48);
            this.carLabel.TabIndex = 3;
            this.carLabel.Text = "Auto";
            // 
            // addCar
            // 
            this.addCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCar.BackgroundImage")));
            this.addCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCar.Location = new System.Drawing.Point(738, 12);
            this.addCar.Name = "addCar";
            this.addCar.Size = new System.Drawing.Size(50, 50);
            this.addCar.TabIndex = 4;
            this.addCar.UseVisualStyleBackColor = true;
            this.addCar.Click += new System.EventHandler(this.CreateCar);
            // 
            // carMenu
            // 
            this.carMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.carMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutenzioniToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.eliminaToolStripMenuItem});
            this.carMenu.Name = "carMenu";
            this.carMenu.Size = new System.Drawing.Size(241, 133);
            // 
            // manutenzioniToolStripMenuItem
            // 
            this.manutenzioniToolStripMenuItem.Name = "manutenzioniToolStripMenuItem";
            this.manutenzioniToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.manutenzioniToolStripMenuItem.Text = "Vai a manutenzioni";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.reportToolStripMenuItem.Text = "Vai a report";
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCar);
            this.Controls.Add(this.carLabel);
            this.Controls.Add(this.carListView);
            this.Name = "CarForm";
            this.Text = "CarForm";
            this.Load += new System.EventHandler(this.CarForm_Load);
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
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
    }
}