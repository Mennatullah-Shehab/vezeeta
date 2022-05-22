using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;



namespace SWEProject
{
    public partial class DoctorInfo : Form
    {
        OracleConnection conn;
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        public DoctorInfo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (SignIn.isDoctor==true)
            {
                
                procbook_btn.Visible = false;
                bck_btn.Visible = true;
                bck_btn.Text = "Back to Main Page";
            }
            else
            {
                bck_btn.Visible = true;
                chpass_btn.Visible = false;
            }
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "selectDr";
          
            
            cmd.Parameters.Add("drid", ChooseSpecialty.docid);
            cmd.Parameters.Add("name", OracleDbType.Varchar2, 100, null, ParameterDirection.Output);
            cmd.Parameters.Add("specialty", OracleDbType.Varchar2, 100, null, ParameterDirection.Output);
            cmd.Parameters.Add("starttime", OracleDbType.TimeStamp, ParameterDirection.Output);
            cmd.Parameters.Add("endtime", OracleDbType.TimeStamp, ParameterDirection.Output);
            cmd.Parameters.Add("dur", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("fee", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();

            drname_label.Text = cmd.Parameters["name"].Value.ToString();
            specialty_label.Text = cmd.Parameters["specialty"].Value.ToString();

            String st = cmd.Parameters["starttime"].Value.ToString().Substring(10, 5)+ cmd.Parameters["starttime"].Value.ToString().Substring(28, 3);
            String et = cmd.Parameters["endtime"].Value.ToString().Substring(10, 5) + cmd.Parameters["endtime"].Value.ToString().Substring(28, 3);

            hours_label.Text = st + " to " + et;
            dur_label.Text = cmd.Parameters["dur"].Value.ToString();
            label4.Text= cmd.Parameters["fee"].Value.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void drname_label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        
        private void DoctorInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bck_btn_Click(object sender, EventArgs e)
        {
            if (SignIn.isDoctor == true)
            {
                MainForm c = new MainForm();
                c.Show();
                this.Hide();
            }
            else
            {
                ChooseSpecialty c = new ChooseSpecialty();
                c.Show();
                this.Hide();
            }
        }

        private void procbook_btn_Click(object sender, EventArgs e)
        {
           
            BookAppt b = new BookAppt();
            b.Show();
            this.Hide();
        }

        private void chpass_btn_Click(object sender, EventArgs e)
        {
            DoctorChangePass u = new DoctorChangePass();
            u.Show();
            this.Hide();
        }
    }
}