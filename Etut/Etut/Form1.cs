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
    public partial class Etut_Olustur : Form
    {
        public Etut_Olustur()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-L4TSN9F\SQLSERVER;Initial Catalog=DERSHANE;Integrated Security=True");

        void dersListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Dersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxDers.ValueMember = "ders_id";
            comboBoxDers.DisplayMember = "ders_ad";
            comboBoxDers.DataSource = dt;
        }

        private void comboBoxDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Ogretmenler where brans_id = " + comboBoxDers.SelectedValue, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBoxOgretmen.ValueMember = "ogrt_id";
            comboBoxOgretmen.DisplayMember ="ad_soyad";
            comboBoxOgretmen.DataSource = dt2;
            
        }

        private void Etut_Olustur_Load(object sender, EventArgs e)
        {
            dersListesi();
        }

        private void temizle()
        {
            comboBoxDers.Text = "";
            comboBoxOgretmen.Text = "";
            dateTimePickerTarih.Text = "";
            comboBoxSaat.Text = "";
            txtOgrNo.Text = "";
        }

        private void buttonEtutOluştur_Click(object sender, EventArgs e)
        {

            if (dateTimePickerTarih.Value < DateTime.Now)
            {
                MessageBox.Show("Etüt verilemiyor. Hatalı giriş yaptınız..");
                temizle();
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Etut (ders_id,ogrt_id,ogr_id,tarih,saat,durum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                komut.Parameters.AddWithValue("@p1", comboBoxDers.SelectedValue);
                komut.Parameters.AddWithValue("@p2", comboBoxOgretmen.SelectedValue);
                komut.Parameters.AddWithValue("@p3", Convert.ToInt32(txtOgrNo.Text));
                komut.Parameters.AddWithValue("@p4", dateTimePickerTarih.Value.ToString("yyyy-MM-dd"));
                komut.Parameters.AddWithValue("@p5", comboBoxSaat.Text);
                komut.Parameters.AddWithValue("@p6", "True");


                komut.ExecuteNonQuery();

                MessageBox.Show("Etüt Başarıyla Oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                baglanti.Close();
            }
           
            /* SqlCommand komut1 = new SqlCommand("select * from Etut", baglanti);
             SqlDataReader oku = komut1.ExecuteReader();

             while (oku.Read())
             {
                 if (oku["ogrt_id"] == comboBoxOgretmen.SelectedValue && oku["tarih"] == dateTimePickerTarih.Value.ToString("yyyy-MM-dd") && oku["saat"] == comboBoxSaat.SelectedValue || dateTimePickerTarih.Value <= DateTime.Now)
                 {
                 MessageBox.Show("Etüt verilemiyor. Hatalı giriş yaptınız..");
                 temizle();
                 baglanti.Close();
                 }

                 else
                 {
                     baglanti.Close();
                     baglanti.Open();
                     SqlCommand komut = new SqlCommand("insert into Etut (ders_id,ogrt_id,ogr_id,tarih,saat,durum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                     komut.Parameters.AddWithValue("@p1", comboBoxDers.SelectedValue);
                     komut.Parameters.AddWithValue("@p2", comboBoxOgretmen.SelectedValue);
                     komut.Parameters.AddWithValue("@p3", Convert.ToInt32(txtOgrNo.Text));
                     komut.Parameters.AddWithValue("@p4", dateTimePickerTarih.Value.ToString("yyyy-MM-dd"));
                     komut.Parameters.AddWithValue("@p5", comboBoxSaat.Text); 
                     komut.Parameters.AddWithValue("@p6", "True");


                     komut.ExecuteNonQuery();

                     MessageBox.Show("Etüt Başarıyla Oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     temizle();
                     baglanti.Close();
                 } 
             }
             baglanti.Close();*/

        }
    }
}
