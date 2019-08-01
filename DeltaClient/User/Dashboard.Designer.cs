namespace DeltaClient
{
    partial class UserDashboard
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.profileLabel = new System.Windows.Forms.ToolStripLabel();
            this.bookLabel = new System.Windows.Forms.ToolStripLabel();
            this.reportLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileLabel,
            this.bookLabel,
            this.reportLabel,
            this.toolStripSeparator1,
            this.logoutLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(140, 458);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // profileLabel
            // 
            this.profileLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(135, 48);
            this.profileLabel.Text = "Profilo";
            this.profileLabel.Click += new System.EventHandler(this.ShowProfileForm);
            // 
            // bookLabel
            // 
            this.bookLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(135, 48);
            this.bookLabel.Text = "Prenota";
            this.bookLabel.Click += new System.EventHandler(this.ShowBookingForm);
            // 
            // reportLabel
            // 
            this.reportLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(135, 48);
            this.reportLabel.Text = "Segnala";
            this.reportLabel.Click += new System.EventHandler(this.ShowReportForm);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // logoutLabel
            // 
            this.logoutLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(135, 48);
            this.logoutLabel.Text = "Esci";
            this.logoutLabel.Click += new System.EventHandler(this.ExitOnClickLabel);
            // 
            // SimpleUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 458);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SimpleUserForm";
            this.Text = "DeltaClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.killDelta);
            this.Load += new System.EventHandler(this.SimpleUserForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel profileLabel;
        private System.Windows.Forms.ToolStripLabel bookLabel;
        private System.Windows.Forms.ToolStripLabel reportLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel logoutLabel;
    }
}