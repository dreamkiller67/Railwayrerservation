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
    public partial class Traininfo : Form
    {
        int autoId = 0;
        public Traininfo()
        {
            InitializeComponent();
        }

        private void trnNamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (trnNobox.Text == "")
            {
                trnnoerror.Show();

                return;
            }
            if (trnNobox.Text != "")
            {
                trnnoerror.Hide();
            }
            if (trnNamebox.Text == "")
            {

                trnnameerror.Show();
                return;

            }
            if (trnNamebox.Text != "")
            {
                trnnameerror.Hide();
            }
             
            if(MessageBox.Show("ready to save",Application.ProductName , MessageBoxButtons.YesNo) == DialogResult.Yes )
            {
            SqlCommand sqlmd = new SqlCommand("sp_masterTraininfo", Class1.cn);
            Class1.cn.Open();
            
            sqlmd.CommandType = CommandType.StoredProcedure ;
            sqlmd.Parameters.Add(new SqlParameter("@autoId", SqlDbType.Int)).Value = autoId;
            sqlmd.Parameters.Add(new SqlParameter("@tname", SqlDbType.VarChar, 50)).Value = trnNamebox.Text;
            sqlmd.Parameters.Add(new SqlParameter("@tno", SqlDbType.VarChar, 50)).Value = trnNobox.Text;
            sqlmd.ExecuteNonQuery();

            Class1.cn.Close();
            MessageBox.Show("save success");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void trnnoerror_Click(object sender, EventArgs e)
        {

        }

        private void Traininfo_Load(object sender, EventArgs e)
        {
            trnnoerror.Hide();
            trnnameerror.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Traininfo ti = new Traininfo();
            ti.MdiParent = Traininfo.ActiveForm;
            ti.Show();
        }

        private void trnNobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
