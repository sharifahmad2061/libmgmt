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
    public partial class artifactInsertion : Form
    {
        string artifactNameHolder, artifactGenreHolder, artifactTypeHolder;
        int artifactBatchHolder, artifactPriceHolder, artifactQuantityHolder;
        DateTime artifactPublicationDateHolder;
        bool artifactAcquisitionHolder;
        public artifactInsertion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void artifactInsert_Click(object sender, EventArgs e)
        {
            artifactNameHolder = artifactName.Text;
            artifactGenreHolder = artifactGenre.Text;
            artifactTypeHolder = artifactType.Text;
            artifactBatchHolder = int.Parse(artifactBatch.Text);
            artifactPriceHolder = int.Parse(artifactPrice.Text);
            artifactQuantityHolder = int.Parse(artifactQuantity.Text);
            artifactPublicationDateHolder = DateTime.Parse(artifactPublicationDate.Text);
            artifactAcquisitionHolder = artifactAcquisition.Text == "Purchased" ? true : false;

            MySqlConnection conn = new MySqlConnection(helper.cnnVal("lbmgmt"));
            MySqlCommand cmd = new MySqlCommand();

            string sql = string.Format("INSERT INTO artifact VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", artifactBatchHolder, artifactNameHolder, artifactTypeHolder, artifactGenreHolder, artifactPublicationDateHolder, artifactPriceHolder, artifactAcquisitionHolder, artifactQuantityHolder, artifactQuantityHolder, 0, 0);
            cmd.CommandText = sql;
            cmd.Connection = conn;

            conn.Open();
            int rows = cmd.ExecuteNonQuery();

            if (rows == 1)
            {
                MessageBox.Show("artifact insertion successfull");
            }
            else
            {
                MessageBox.Show("artifact insertion unsuccessful");
            }

            conn.Close();
        }

        private void artifactInsertion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
