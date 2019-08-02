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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.profileLabel = new System.Windows.Forms.ToolStripLabel();
            this.bookLabel = new System.Windows.Forms.ToolStripLabel();
            this.reportLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutLabel = new System.Windows.Forms.ToolStripLabel();
            this.homeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeButton,
            this.profileLabel,
            this.bookLabel,
            this.reportLabel,
            this.toolStripSeparator1,
            this.logoutLabel});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(140, 458);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip1";
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
            // homeButton
            // 
            this.homeButton.AutoSize = false;
            this.homeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(100, 100);
            this.homeButton.Text = "Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.homeButton.Click += new System.EventHandler(this.killChildren);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 458);
            this.Controls.Add(this.toolStrip);
            this.Name = "UserDashboard";
            this.Text = "DeltaClient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.killDelta);
            this.Load += new System.EventHandler(this.SimpleUserForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel profileLabel;
        private System.Windows.Forms.ToolStripLabel bookLabel;
        private System.Windows.Forms.ToolStripLabel reportLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel logoutLabel;
        private System.Windows.Forms.ToolStripButton homeButton;
    }
}