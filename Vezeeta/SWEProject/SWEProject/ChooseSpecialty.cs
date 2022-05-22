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
    public partial class ChooseSpecialty : Form
    {
        public static int docid=-1;
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public ChooseSpecialty()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetDoctors";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("specialty", cmb_sp.SelectedItem.ToString());
            cmd.Parameters.Add("dname", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();                
            DataTable dataTable = new DataTable();                
            dataTable.Load(dr);                
            dataGridView1.DataSource = dataTable;
            dr.Close();

        }

        private void ChooseSpecialty_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select distinct SPECIALTY from doctor";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_sp.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["view"].Index)
            {
                
                int id = dataGridView1.Columns["docID"].Index;

                docid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[id].Value.ToString());
               
                DoctorInfo d = new DoctorInfo();
                d.Show();
                this.Hide();
           
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

  

        private void ChooseSpecialty_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void bck_btn_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }
    }
}
