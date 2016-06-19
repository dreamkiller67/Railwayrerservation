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
    public partial class Stationinformation : Form
    {
        int autoId = 0;
        public Stationinformation()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((stncodeBox.Text == ""))
            {
                MessageBox.Show("Station code required", Application.ProductName, MessageBoxButtons.OK);
                return;

            }
            if ((stnNamebox.Text == ""))
            {
                MessageBox.Show("Station name required", Application.ProductName, MessageBoxButtons.OK);
                return;

            }
            if (MessageBox.Show("ready to save it !!!", Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                SqlCommand sqlmd = new SqlCommand("sp_masterStationinfo", Class1.cn);
                Class1.cn.Open();
                sqlmd.CommandType = CommandType.StoredProcedure;

                sqlmd.Parameters.Add(new SqlParameter("@autoId", SqlDbType.Int)).Value = autoId;

                sqlmd.Parameters.Add(new SqlParameter("@station_code", SqlDbType.VarChar, 50)).Value = stncodeBox.Text;
                sqlmd.Parameters.Add(new SqlParameter("@station_name", SqlDbType.VarChar, 50)).Value = stnNamebox.Text;



                sqlmd.ExecuteNonQuery();
                Class1.cn.Close();




                MessageBox.Show("Done..");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            mainpanel.Enabled = false;
            gridpanel.Visible = true;
        //    searchbox.Focus();
         

           // Class1.cn.Open();
          //  SqlDataAdapter sda = new SqlDataAdapter("Select * from masterStationinfo where isAlive ='true'", Class1.cn);
          //  DataTable dt = new DataTable();
         //   sda.Fill(dt);
         //   dataGridView1.DataSource = dt;
         //   Class1.cn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Stationinformation si = new Stationinformation();
            si.MdiParent = Stationinformation.ActiveForm;
            si.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            gridpanel.Visible = false;
            mainpanel.Enabled = true;
            //searchbox.Focus();
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
         SearchGrid();  
        }
       
        void SearchGrid(){

            if (cmbsearch.Text == "station code")
            {


                SqlDataAdapter sda = new SqlDataAdapter("select * from masterStationinformation where station_code like '"+searchbox.Text+"%' ", Class1.cn);
                Class1.cn.Open();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    Class1.cn.Close();
                    
                }
            
               
            else if(cmbsearch.Text == "station name")
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from masterStationinformation where station_name like '"+searchbox.Text+"%' ", Class1.cn);

                Class1.cn.Open();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                Class1.cn.Close();
            }

          //  dataGridView1.Columns[4].Visible = false;
            //dataGridView1.Columns[0].HeaderText = "station Code";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //select_row();
            gridpanel.Visible = false;
            mainpanel.Enabled = true;
            btnSave.Text = "U&pdate";
            btnDel.Enabled = true;
            btnList.Enabled = false;

            int index = dataGridView1.SelectedCells[0].RowIndex;
            autoId = (int)dataGridView1.Rows[index].Cells[0].Value;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from masterStationinformation where autoID = +autoID", Class1.cn);
            stncodeBox.Text = dt.Rows[0]["station_code"].ToString();
            stnNamebox.Text = dt.Rows[0]["station_name"].ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void select_row()
        {
      
           
        }

        }
    }

    

