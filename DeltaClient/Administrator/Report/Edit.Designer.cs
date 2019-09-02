namespace DeltaClient
{
    partial class AdminReportEdit
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.reportLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.subjectTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.DeleteButton.Location = new System.Drawing.Point(436, 391);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(111, 46);
            this.DeleteButton.TabIndex = 51;
            this.DeleteButton.Text = "Elimina";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteReport);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cancelButton.Location = new System.Drawing.Point(565, 391);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(111, 46);
            this.cancelButton.TabIndex = 50;
            this.cancelButton.Text = "Annulla";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.StopEditing);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.SaveButton.Location = new System.Drawing.Point(690, 391);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 46);
            this.SaveButton.TabIndex = 49;
            this.SaveButton.Text = "Salva";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Save);
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(336, 87);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(116, 38);
            this.subjectLabel.TabIndex = 48;
            this.subjectLabel.Text = "Oggetto";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(328, 177);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(144, 38);
            this.messageLabel.TabIndex = 47;
            this.messageLabel.Text = "Messaggio";
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.Location = new System.Drawing.Point(291, 9);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(219, 48);
            this.reportLabel.TabIndex = 46;
            this.reportLabel.Text = "Segnalazione";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(12, 219);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(774, 165);
            this.messageTextBox.TabIndex = 52;
            this.messageTextBox.Text = "";
            // 
            // subjectTextbox
            // 
            this.subjectTextbox.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectTextbox.Location = new System.Drawing.Point(258, 128);
            this.subjectTextbox.Name = "subjectTextbox";
            this.subjectTextbox.Size = new System.Drawing.Size(284, 39);
            this.subjectTextbox.TabIndex = 53;
            // 
            // AdminReportEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.subjectTextbox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.reportLabel);
            this.Name = "AdminReportEdit";
            this.Text = "ReportEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.TextBox subjectTextbox;
    }
}