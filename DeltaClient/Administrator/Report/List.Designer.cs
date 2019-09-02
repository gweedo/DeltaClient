namespace DeltaClient
{
    partial class AdminReportList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminReportList));
            this.PlateNumberLabel = new System.Windows.Forms.Label();
            this.addReport = new System.Windows.Forms.Button();
            this.reportLabel = new System.Windows.Forms.Label();
            this.reportListView = new System.Windows.Forms.ListView();
            this.reportMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlateNumberLabel
            // 
            this.PlateNumberLabel.AutoSize = true;
            this.PlateNumberLabel.Location = new System.Drawing.Point(352, 49);
            this.PlateNumberLabel.Name = "PlateNumberLabel";
            this.PlateNumberLabel.Size = new System.Drawing.Size(96, 20);
            this.PlateNumberLabel.TabIndex = 12;
            this.PlateNumberLabel.Text = "di XX999XX";
            // 
            // addReport
            // 
            this.addReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addReport.BackgroundImage")));
            this.addReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addReport.Location = new System.Drawing.Point(738, 7);
            this.addReport.Name = "addReport";
            this.addReport.Size = new System.Drawing.Size(50, 50);
            this.addReport.TabIndex = 11;
            this.addReport.UseVisualStyleBackColor = true;
            this.addReport.Click += new System.EventHandler(this.AddReport);
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.Location = new System.Drawing.Point(339, -1);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(123, 48);
            this.reportLabel.TabIndex = 10;
            this.reportLabel.Text = "Report";
            // 
            // reportListView
            // 
            this.reportListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportListView.Location = new System.Drawing.Point(0, 71);
            this.reportListView.Name = "reportListView";
            this.reportListView.Size = new System.Drawing.Size(800, 379);
            this.reportListView.TabIndex = 9;
            this.reportListView.UseCompatibleStateImageBehavior = false;
            this.reportListView.DoubleClick += new System.EventHandler(this.EditReport);
            this.reportListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ReportListView_MouseClick);
            // 
            // reportMenu
            // 
            this.reportMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.reportMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminaToolStripMenuItem});
            this.reportMenu.Name = "reportMenu";
            this.reportMenu.Size = new System.Drawing.Size(141, 36);
            // 
            // eliminaToolStripMenuItem
            // 
            this.eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            this.eliminaToolStripMenuItem.Size = new System.Drawing.Size(140, 32);
            this.eliminaToolStripMenuItem.Text = "Elimina";
            this.eliminaToolStripMenuItem.Click += new System.EventHandler(this.DeleteReport);
            // 
            // AdminReportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlateNumberLabel);
            this.Controls.Add(this.addReport);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.reportListView);
            this.Name = "AdminReportList";
            this.Text = "ReportListForm";
            this.reportMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlateNumberLabel;
        private System.Windows.Forms.Button addReport;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.ListView reportListView;
        private System.Windows.Forms.ContextMenuStrip reportMenu;
        private System.Windows.Forms.ToolStripMenuItem eliminaToolStripMenuItem;
    }
}