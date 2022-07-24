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
    public partial class Personel_Giris_Sayfasi : Form
    {
        public Personel_Giris_Sayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9TA2NG8\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True");
        private void buttonPersonelGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter giris = new SqlDataAdapter("SELECT Count(*) from Personel Where personel_eposta = '" + txtPersonelEmail.Text + "' and personel_pin = '" + txtPersonelPin.Text + "'", baglanti);
            DataTable stablo = new DataTable();
            giris.Fill(stablo);
            if(stablo.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Giriş Başarılı");
                Personel_Anasayfasi syf = new Personel_Anasayfasi();
                syf.Show();
            }
            else
            {
                MessageBox.Show("Eposta Veya Pin Hatalı");
            }
            baglanti.Close();
        }
    }
}
