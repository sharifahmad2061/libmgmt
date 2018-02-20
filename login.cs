using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace libmgmt
{
    public partial class login : Form
    {
        private string email;
        private string psd;
        public login()
        {
            InitializeComponent();
            email = loginEmail.Text;
            psd = loginPsd.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBack_Click(object sender, EventArgs e)
        {
            Form ret = (mainForm)this.Tag;
            ret.Show();
            this.Hide();
        }

        private void loginToSystemBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(helper.cnnVal("lbmgmt"));
            MySqlConnection conn = new MySqlConnection(helper.cnnVal("lbmgmt"));
            //MySqlCommand cmd = new MySqlCommand();
            //cmd.CommandText = "SELECT * FROM admin WHERE ";
            String temp = "hello " + email + " to " + psd;
            MessageBox.Show(temp);

            //conn.Open();
            


        }
    }
}
