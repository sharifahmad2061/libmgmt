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
        private Form adminView;
        private string email;
        private string psd;
        public login()
        {
            InitializeComponent();
            //email = loginEmail.Text;
            //psd = loginPsd.Text;
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
            email = loginEmail.Text;
            psd = loginPsd.Text;

            MySqlConnection conn = new MySqlConnection(helper.cnnVal("lbmgmt"));
            MySqlCommand cmd = new MySqlCommand();
            
            string sql = string.Format("SELECT COUNT(*) FROM admin WHERE email='{0}' and password='{1}'",email,psd);
            cmd.CommandText = sql;
            //MessageBox.Show(cmd.CommandText);
            cmd.Connection = conn;
            
            conn.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            //MessageBox.Show(rdr[0].GetType().ToString());
            if ((Int64)rdr[0] == 1)
            {
                //MessageBox.Show("login successfull");
                adminView = new adminView();
                adminView.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("login unsuccessful");
            }

            //MySqlDataAdapter adp = new MySqlDataAdapter(sql,conn);
            //DataSet us = new DataSet();
            //adp.Fill(us,"admin");
            //MessageBox.Show(us.GetXml());
            //us.Dispose();
            //adp.Dispose();


            conn.Close();
        }
    }
}
