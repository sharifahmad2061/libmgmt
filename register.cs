using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libmgmt
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void regEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void regBack_Click(object sender, EventArgs e)
        {
            Form ret = (mainForm)this.Tag;
            ret.Show();
            this.Hide();
        }
    }
}
