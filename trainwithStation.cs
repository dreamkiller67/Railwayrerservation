using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IndianRailways
{
    public partial class trainwithStation : Form
    {
        public trainwithStation()
        {
            InitializeComponent();
        }

        private void trainwithStation_Load(object sender, EventArgs e)

        {
           
            SqlDataAdapter sda = new SqlDataAdapter("Select TrainName from Trainlist", Class1.cn);
            Class1.cn.Open();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            trnCombo.ValueMember = "autoId" ;
            trnCombo.DisplayMember = "TrainName";
            trnCombo.DataSource = dt;
            Class1.cn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void stnCodecombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string constring = "Data Source=DEV-PC\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);

            string query = "select TrainNumber , TrainSourceStn, TrainDestinationStn from Trainlist where TrainName = '" + trnCombo.Text + "';";


            SqlCommand sqlmd = new SqlCommand(query, con);



            SqlDataReader reader;
            con.Open();

            reader = sqlmd.ExecuteReader();


            reader.Read();



            string strstnname = reader["TrainNumber"].ToString();
            string strsrcstnName = reader["TrainSourcestn"].ToString();
            string strdestStation = reader["TrainDestinationStn"].ToString();


            trnNoBox.Text = strstnname;
             codebox.Text = strsrcstnName;
            stnName.Text = strdestStation;
            
            con.Close();
        }

        private void trnNamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            trainwithStation tws = new trainwithStation();
            tws.MdiParent = trainwithStation.ActiveForm;
            tws.Show();
        }



    }




}
