using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Etut
{
    public partial class etut_takvimi : Form
    {
        public etut_takvimi()
        {
            InitializeComponent();
        }
        void etutlistesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("execute etut", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }
        private void etutlistele_Click(object sender, EventArgs e)
        {
            etut_takvimi fr = new etut_takvimi();
            fr.Show();
        }
    }
}
