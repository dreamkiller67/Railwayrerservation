namespace IndianRailways
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stationInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainWithStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compartmentAllotmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fairChargesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pNRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainsBetweenStationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seatAvilabilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.pNRToolStripMenuItem,
            this.reservationToolStripMenuItem,
            this.trainsBetweenStationsToolStripMenuItem,
            this.seatAvilabilityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainInformationToolStripMenuItem,
            this.stationInformationToolStripMenuItem,
            this.trainWithStationToolStripMenuItem,
            this.compartmentAllotmentToolStripMenuItem,
            this.fairChargesToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "M&aster";
            // 
            // trainInformationToolStripMenuItem
            // 
            this.trainInformationToolStripMenuItem.Name = "trainInformationToolStripMenuItem";
            this.trainInformationToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.trainInformationToolStripMenuItem.Text = "Train Information";
            this.trainInformationToolStripMenuItem.Click += new System.EventHandler(this.trainInformationToolStripMenuItem_Click);
            // 
            // stationInformationToolStripMenuItem
            // 
            this.stationInformationToolStripMenuItem.Name = "stationInformationToolStripMenuItem";
            this.stationInformationToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.stationInformationToolStripMenuItem.Text = "Station Information";
            this.stationInformationToolStripMenuItem.Click += new System.EventHandler(this.stationInformationToolStripMenuItem_Click);
            // 
            // trainWithStationToolStripMenuItem
            // 
            this.trainWithStationToolStripMenuItem.Name = "trainWithStationToolStripMenuItem";
            this.trainWithStationToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.trainWithStationToolStripMenuItem.Text = "Train With Station";
            this.trainWithStationToolStripMenuItem.Click += new System.EventHandler(this.trainWithStationToolStripMenuItem_Click);
            // 
            // compartmentAllotmentToolStripMenuItem
            // 
            this.compartmentAllotmentToolStripMenuItem.Name = "compartmentAllotmentToolStripMenuItem";
            this.compartmentAllotmentToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.compartmentAllotmentToolStripMenuItem.Text = "Compartment Allotment";
            this.compartmentAllotmentToolStripMenuItem.Click += new System.EventHandler(this.compartmentAllotmentToolStripMenuItem_Click);
            // 
            // fairChargesToolStripMenuItem
            // 
            this.fairChargesToolStripMenuItem.Name = "fairChargesToolStripMenuItem";
            this.fairChargesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.fairChargesToolStripMenuItem.Text = "Fair Charges";
            // 
            // pNRToolStripMenuItem
            // 
            this.pNRToolStripMenuItem.Name = "pNRToolStripMenuItem";
            this.pNRToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.pNRToolStripMenuItem.Text = "P&NR";
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.reservationToolStripMenuItem.Text = "R&eservation";
            // 
            // trainsBetweenStationsToolStripMenuItem
            // 
            this.trainsBetweenStationsToolStripMenuItem.Name = "trainsBetweenStationsToolStripMenuItem";
            this.trainsBetweenStationsToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.trainsBetweenStationsToolStripMenuItem.Text = "Trains Between Stations";
            // 
            // seatAvilabilityToolStripMenuItem
            // 
            this.seatAvilabilityToolStripMenuItem.Name = "seatAvilabilityToolStripMenuItem";
            this.seatAvilabilityToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.seatAvilabilityToolStripMenuItem.Text = "S&eat Avilability";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(817, 633);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stationInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainWithStationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compartmentAllotmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fairChargesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pNRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainsBetweenStationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seatAvilabilityToolStripMenuItem;
    }
}

