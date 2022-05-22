
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SWEProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            SignIn s = new SignIn();
            s.Show();
            this.Hide();
        }

        private void createacc_btn_Click(object sender, EventArgs e)
        {
            CreateAccount c = new CreateAccount();
            c.Show();
            this.Hide();
        }

        private void viewrep1_btn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void viewrep2_btn_Click(object sender, EventArgs e)
        {
            Report1Form f = new Report1Form();
            f.Show();
            this.Hide();
        }
    }
}
