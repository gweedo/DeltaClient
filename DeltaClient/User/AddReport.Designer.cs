namespace DeltaClient
{
    partial class UserAddReport
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.BookingListComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            this.cancelButton.Click += new System.EventHandler(this.cancelReport);
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.SendButton.Location = new System.Drawing.Point(692, 391);
            this.SendButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(96, 46);
            this.SendButton.TabIndex = 48;
            this.SendButton.Text = "Invia";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.InviaButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(414, 174);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(315, 186);
            this.MessageTextBox.TabIndex = 47;
            this.MessageTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label4.Location = new System.Drawing.Point(409, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 30);
            this.label4.TabIndex = 46;
            this.label4.Text = "Messaggio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label3.Location = new System.Drawing.Point(53, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 30);
            this.label3.TabIndex = 45;
            this.label3.Text = "Oggetto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label2.Location = new System.Drawing.Point(152, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 30);
            this.label2.TabIndex = 44;
            this.label2.Text = "Prenotazione";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 38);
            this.label1.TabIndex = 43;
            this.label1.Text = "Segnalazioni";
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(58, 174);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(255, 26);
            this.SubjectTextBox.TabIndex = 42;
            // 
            // BookingListComboBox
            // 
            this.BookingListComboBox.FormattingEnabled = true;
            this.BookingListComboBox.Location = new System.Drawing.Point(157, 91);
            this.BookingListComboBox.Name = "BookingListComboBox";
            this.BookingListComboBox.Size = new System.Drawing.Size(495, 28);
            this.BookingListComboBox.TabIndex = 41;
            // 
            // UserAddReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.BookingListComboBox);
            this.Name = "UserAddReport";
            this.Text = "UserAddReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.RichTextBox MessageTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.ComboBox BookingListComboBox;
    }
}