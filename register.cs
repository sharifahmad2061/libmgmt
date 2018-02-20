using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace libmgmt
{
    public partial class register : Form
    {
        string email;
        string psd;

        public register()
        {
            InitializeComponent();
        }

        private void regEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void regBack_Click(object sender, EventArgs e)
        {
            Form ret = (mainForm)this.Tag;
            ret.Show();
            this.Hide();
        }

        private void registerToSystemBtn_Click(object sender, EventArgs e)
        {
            email = regEmail.Text;
            psd = regPsd.Text;

            MySqlConnection conn = new MySqlConnection(helper.cnnVal("lbmgmt"));
            MySqlCommand cmd = new MySqlCommand();

            string sql = string.Format("INSERT INTO admin VALUES({0},{1})", email, psd);
            cmd.CommandText = sql;
            //MessageBox.Show(cmd.CommandText);
            cmd.Connection = conn;

            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows == 1)
            {
                MessageBox.Show("registeration successfull");
            }
            else
            {
                MessageBox.Show("registeration unsuccessful");
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
