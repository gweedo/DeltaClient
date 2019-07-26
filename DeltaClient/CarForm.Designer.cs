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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarForm));
            this.carListView = new System.Windows.Forms.ListView();
            this.carLabel = new System.Windows.Forms.Label();
            this.addCar = new System.Windows.Forms.Button();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView carListView;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.Button addCar;
    }
}