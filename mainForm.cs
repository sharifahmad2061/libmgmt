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
    public partial class mainForm : Form
    {
        public login login_form;
        public register register_form;
        public mainForm()
        {
            InitializeComponent();
            login_form = new login();
            register_form = new register();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            login_form.Tag = this;
            login_form.Show();
            this.Hide();

        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            register_form.Tag = this;
            register_form.Show();
            this.Hide();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            login_form.Close();
            register_form.Close();
            Application.Exit();
        }
    }
}
