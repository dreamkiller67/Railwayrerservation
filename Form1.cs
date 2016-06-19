using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IndianRailways
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Refresh();
        }


        private void trainInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Traininfo ti = new Traininfo();
            ti.StartPosition = FormStartPosition.CenterScreen;
            ti.MdiParent = Traininfo.ActiveForm;
            ti.Show();

        }

        private void stationInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stationinformation si = new Stationinformation();
            si.StartPosition = FormStartPosition.CenterScreen;
            si.MdiParent = Stationinformation.ActiveForm;
            si.Show();
        }

        private void trainWithStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trainwithStation tws = new trainwithStation();
            tws.MdiParent = trainwithStation.ActiveForm;
            tws.Show();
        }

        private void compartmentAllotmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compartmentAllot ca = new compartmentAllot();
            ca.MdiParent = compartmentAllot.ActiveForm;
            ca.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }












        }

}