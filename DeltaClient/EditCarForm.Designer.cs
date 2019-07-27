namespace DeltaClient
{
    partial class EditCarForm
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
            this.PlateNumberTextBox = new System.Windows.Forms.TextBox();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.MakerTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PlateNumberLabel = new System.Windows.Forms.Label();
            this.LitersLabel = new System.Windows.Forms.Label();
            this.KilometersLabel = new System.Windows.Forms.Label();
            this.MakerLabel = new System.Windows.Forms.Label();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.KilometersUpDown = new System.Windows.Forms.NumericUpDown();
            this.LitersUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.KilometersUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LitersUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PlateNumberTextBox
            // 
            this.PlateNumberTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PlateNumberTextBox.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.PlateNumberTextBox.Location = new System.Drawing.Point(436, 230);
            this.PlateNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlateNumberTextBox.Name = "PlateNumberTextBox";
            this.PlateNumberTextBox.Size = new System.Drawing.Size(140, 39);
            this.PlateNumberTextBox.TabIndex = 44;
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.ModelTextBox.Location = new System.Drawing.Point(436, 94);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(318, 39);
            this.ModelTextBox.TabIndex = 43;
            // 
            // MakerTextBox
            // 
            this.MakerTextBox.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.MakerTextBox.Location = new System.Drawing.Point(53, 94);
            this.MakerTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MakerTextBox.Name = "MakerTextBox";
            this.MakerTextBox.Size = new System.Drawing.Size(262, 37);
            this.MakerTextBox.TabIndex = 41;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.ModelLabel.Location = new System.Drawing.Point(429, 50);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(114, 38);
            this.ModelLabel.TabIndex = 40;
            this.ModelLabel.Text = "Modello";
            // 
            // PlateNumberLabel
            // 
            this.PlateNumberLabel.AutoSize = true;
            this.PlateNumberLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.PlateNumberLabel.Location = new System.Drawing.Point(433, 186);
            this.PlateNumberLabel.Name = "PlateNumberLabel";
            this.PlateNumberLabel.Size = new System.Drawing.Size(78, 38);
            this.PlateNumberLabel.TabIndex = 39;
            this.PlateNumberLabel.Text = "Targa";
            // 
            // LitersLabel
            // 
            this.LitersLabel.AutoSize = true;
            this.LitersLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.LitersLabel.Location = new System.Drawing.Point(46, 319);
            this.LitersLabel.Name = "LitersLabel";
            this.LitersLabel.Size = new System.Drawing.Size(187, 38);
            this.LitersLabel.TabIndex = 38;
            this.LitersLabel.Text = "Litri consumati";
            // 
            // KilometersLabel
            // 
            this.KilometersLabel.AutoSize = true;
            this.KilometersLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.KilometersLabel.Location = new System.Drawing.Point(46, 186);
            this.KilometersLabel.Name = "KilometersLabel";
            this.KilometersLabel.Size = new System.Drawing.Size(120, 38);
            this.KilometersLabel.TabIndex = 37;
            this.KilometersLabel.Text = "Kilometri";
            // 
            // MakerLabel
            // 
            this.MakerLabel.AutoSize = true;
            this.MakerLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.MakerLabel.Location = new System.Drawing.Point(46, 52);
            this.MakerLabel.Name = "MakerLabel";
            this.MakerLabel.Size = new System.Drawing.Size(88, 38);
            this.MakerLabel.TabIndex = 36;
            this.MakerLabel.Text = "Marca";
            this.MakerLabel.Click += new System.EventHandler(this.NameUserLabel_Click);
            // 
            // YearComboBox
            // 
            this.YearComboBox.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Location = new System.Drawing.Point(598, 230);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(121, 40);
            this.YearComboBox.TabIndex = 46;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.YearLabel.Location = new System.Drawing.Point(591, 189);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(81, 38);
            this.YearLabel.TabIndex = 47;
            this.YearLabel.Text = "Anno";
            this.YearLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cancelButton.Location = new System.Drawing.Point(567, 391);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(111, 46);
            this.cancelButton.TabIndex = 49;
            this.cancelButton.Text = "Annulla";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.stopEditing);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.SaveButton.Location = new System.Drawing.Point(692, 391);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 46);
            this.SaveButton.TabIndex = 48;
            this.SaveButton.Text = "Salva";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SendSaveButton);
            // 
            // KilometersUpDown
            // 
            this.KilometersUpDown.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KilometersUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.KilometersUpDown.Location = new System.Drawing.Point(53, 227);
            this.KilometersUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.KilometersUpDown.Name = "KilometersUpDown";
            this.KilometersUpDown.Size = new System.Drawing.Size(155, 39);
            this.KilometersUpDown.TabIndex = 50;
            // 
            // LitersUpDown
            // 
            this.LitersUpDown.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LitersUpDown.Location = new System.Drawing.Point(53, 360);
            this.LitersUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.LitersUpDown.Name = "LitersUpDown";
            this.LitersUpDown.Size = new System.Drawing.Size(155, 39);
            this.LitersUpDown.TabIndex = 51;
            // 
            // EditCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LitersUpDown);
            this.Controls.Add(this.KilometersUpDown);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.PlateNumberTextBox);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.MakerTextBox);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.PlateNumberLabel);
            this.Controls.Add(this.LitersLabel);
            this.Controls.Add(this.KilometersLabel);
            this.Controls.Add(this.MakerLabel);
            this.Name = "EditCarForm";
            this.Text = "EditCarForm";
            this.Load += new System.EventHandler(this.EditCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KilometersUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LitersUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PlateNumberTextBox;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.TextBox MakerTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label PlateNumberLabel;
        private System.Windows.Forms.Label LitersLabel;
        private System.Windows.Forms.Label KilometersLabel;
        private System.Windows.Forms.Label MakerLabel;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.NumericUpDown KilometersUpDown;
        private System.Windows.Forms.NumericUpDown LitersUpDown;
    }
}