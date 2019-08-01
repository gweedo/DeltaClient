namespace DeltaClient
{
    partial class AdminServiceEdit
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
            this.serviceLabel = new System.Windows.Forms.Label();
            this.TotalUpDown = new System.Windows.Forms.NumericUpDown();
            this.KilometersUpDown = new System.Windows.Forms.NumericUpDown();
            this.kilometersLabel = new System.Windows.Forms.Label();
            this.totalSpentLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TotalUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KilometersUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLabel.Location = new System.Drawing.Point(283, 9);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(235, 48);
            this.serviceLabel.TabIndex = 3;
            this.serviceLabel.Text = "Manutenzione";
            // 
            // TotalUpDown
            // 
            this.TotalUpDown.DecimalPlaces = 2;
            this.TotalUpDown.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.TotalUpDown.Location = new System.Drawing.Point(291, 128);
            this.TotalUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TotalUpDown.Name = "TotalUpDown";
            this.TotalUpDown.Size = new System.Drawing.Size(188, 39);
            this.TotalUpDown.TabIndex = 4;
            // 
            // KilometersUpDown
            // 
            this.KilometersUpDown.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.KilometersUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.KilometersUpDown.Location = new System.Drawing.Point(291, 253);
            this.KilometersUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.KilometersUpDown.Name = "KilometersUpDown";
            this.KilometersUpDown.Size = new System.Drawing.Size(188, 39);
            this.KilometersUpDown.TabIndex = 5;
            // 
            // kilometersLabel
            // 
            this.kilometersLabel.AutoSize = true;
            this.kilometersLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kilometersLabel.Location = new System.Drawing.Point(284, 212);
            this.kilometersLabel.Name = "kilometersLabel";
            this.kilometersLabel.Size = new System.Drawing.Size(182, 38);
            this.kilometersLabel.TabIndex = 7;
            this.kilometersLabel.Text = "Kilometraggio";
            // 
            // totalSpentLabel
            // 
            this.totalSpentLabel.AutoSize = true;
            this.totalSpentLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSpentLabel.Location = new System.Drawing.Point(284, 87);
            this.totalSpentLabel.Name = "totalSpentLabel";
            this.totalSpentLabel.Size = new System.Drawing.Size(86, 38);
            this.totalSpentLabel.TabIndex = 8;
            this.totalSpentLabel.Text = "Spesa";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.DeleteButton.Location = new System.Drawing.Point(433, 391);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(111, 46);
            this.DeleteButton.TabIndex = 45;
            this.DeleteButton.Text = "Elimina";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteService);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cancelButton.Location = new System.Drawing.Point(562, 391);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(111, 46);
            this.cancelButton.TabIndex = 44;
            this.cancelButton.Text = "Annulla";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.StopEditing);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.SaveButton.Location = new System.Drawing.Point(687, 391);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 46);
            this.SaveButton.TabIndex = 43;
            this.SaveButton.Text = "Salva";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Save);
            // 
            // ServiceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.totalSpentLabel);
            this.Controls.Add(this.kilometersLabel);
            this.Controls.Add(this.KilometersUpDown);
            this.Controls.Add(this.TotalUpDown);
            this.Controls.Add(this.serviceLabel);
            this.Name = "ServiceEdit";
            this.Text = "ServiceEdit";
            this.Load += new System.EventHandler(this.ServiceEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TotalUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KilometersUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.NumericUpDown TotalUpDown;
        private System.Windows.Forms.NumericUpDown KilometersUpDown;
        private System.Windows.Forms.Label kilometersLabel;
        private System.Windows.Forms.Label totalSpentLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button SaveButton;
    }
}