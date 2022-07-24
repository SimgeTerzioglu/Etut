using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Etut
{
    public partial class EtutTakvimi : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9TA2NG8\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True");
        public EtutTakvimi()
        {
            InitializeComponent();
        }
        void etutlistesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("execute etut_liste", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EtutTakvimi_Load(object sender, EventArgs e)
        {
            etutlistesi();
        }
    }
}
