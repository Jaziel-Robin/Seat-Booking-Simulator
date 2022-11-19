namespace SeatBookingSimulator
{
    partial class ParentForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.safeDistanceModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.safeDistanceSmartModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalModeToolStripMenuItem,
            this.safeDistanceModeToolStripMenuItem,
            this.safeDistanceSmartModeToolStripMenuItem});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // normalModeToolStripMenuItem
            // 
            this.normalModeToolStripMenuItem.Name = "normalModeToolStripMenuItem";
            this.normalModeToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.normalModeToolStripMenuItem.Text = "Normal Mode";
            this.normalModeToolStripMenuItem.Click += new System.EventHandler(this.NormalModeToolStripMenuItem_Click);
            // 
            // safeDistanceModeToolStripMenuItem
            // 
            this.safeDistanceModeToolStripMenuItem.Name = "safeDistanceModeToolStripMenuItem";
            this.safeDistanceModeToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.safeDistanceModeToolStripMenuItem.Text = "Safe Distance Mode";
            this.safeDistanceModeToolStripMenuItem.Click += new System.EventHandler(this.SafeDistanceModeToolStripMenuItem_Click);
            // 
            // safeDistanceSmartModeToolStripMenuItem
            // 
            this.safeDistanceSmartModeToolStripMenuItem.Name = "safeDistanceSmartModeToolStripMenuItem";
            this.safeDistanceSmartModeToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.safeDistanceSmartModeToolStripMenuItem.Text = "Safe Distance Smart Mode";
            this.safeDistanceSmartModeToolStripMenuItem.Click += new System.EventHandler(this.SafeDistanceSmartModeToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 551);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentForm";
            this.Text = "Cinema Simulator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem safeDistanceModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem safeDistanceSmartModeToolStripMenuItem;
    }
}