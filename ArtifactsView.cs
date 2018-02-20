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
    public partial class ArtifactsView : Form
    {
        MySqlDataAdapter adp;
        DataSet ds;
        public ArtifactsView()
        {
            InitializeComponent();
        }

        private void ArtifactsView_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(helper.cnnVal("lbmgmt"));
            string sql = string.Format("SELECT * FROM artifact");
            
            adp = new MySqlDataAdapter(sql,conn);
            adp.Fill(ds, "artifact");
            artifactViewDataGrid.DataSource = ds;
            artifactViewDataGrid.DataMember = "artifact";
        }

        private void ArtifactsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            ds.Dispose();
            adp.Dispose();
            Application.Exit();
        }
    }
}
