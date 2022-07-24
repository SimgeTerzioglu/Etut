using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Etut
{

    public partial class Ogretmen_Ekleme_Sayfasi : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-L4TSN9F\SQLSERVER;Initial Catalog=DERSHANE;Integrated Security=True");
        string pin;
        public Ogretmen_Ekleme_Sayfasi()
        {
            InitializeComponent();
        }
        void dersListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Dersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxBrans.ValueMember = "ders_id";
            comboBoxBrans.DisplayMember = "ders_ad";
            comboBoxBrans.DataSource = dt;
        }
        private void buttonOgrenciEkle_Click(object sender, EventArgs e)
        {
            if (textBoxOgretmenEkleAd.Text == "" || textBoxOgretmenEkleSoyad.Text == "" || textBoxOgretmenEkleMail.Text == "" || textBoxOgretmenEklePin.Text == "")
            {
                MessageBox.Show("Tüm alanlar doldurulmalıdır.");
            }
            else
            {
                string ad, soyad, mail;
                ad = textBoxOgretmenEkleAd.Text;
                soyad = textBoxOgretmenEkleSoyad.Text;
                //int brans = Convert.ToInt32(comboBoxBrans.SelectedValue);
                mail = textBoxOgretmenEkleMail.Text;
                pin = textBoxOgretmenEklePin.Text;
                lblogr_adsoyad.Text = ad + " " + soyad;

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Ogretmenler" + "(ogrt_ad,ogrt_soyad,brans_id,ad_soyad,ogrt_pin,ogrt_eposta)" +
                    "values('" + ad + "','" + soyad + "','" + comboBoxBrans.SelectedValue + "','" + lblogr_adsoyad.Text + "','" + pin + "','" + mail + "')", baglanti);
                komut.ExecuteNonQuery();

                MessageBox.Show("Öğretmen Başarıyla Kaydedildi.");
                baglanti.Close();
            }
        }

        private void buttonPinOlusturma_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            pin = generator.Next(0, 1000000).ToString("D6");
            textBoxOgretmenEklePin.Text = pin;
        }

        private void Ogretmen_Ekleme_Sayfasi_Load(object sender, EventArgs e)
        {
            dersListesi();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBoxOgretmenEkleAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBoxOgretmenEkleSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBoxBrans.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBoxOgretmenEklePin.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBoxOgretmenEkleMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void buttonOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Ogretmenler set ogrt_ad = '"+textBoxOgretmenEkleAd.Text+"', ogrt_soyad = '"+textBoxOgretmenEkleSoyad.Text+"" +
                ", brans_id = '"+comboBoxBrans.Text+"', ogrt_pin = '"+textBoxOgretmenEklePin.Text+"', ogrt_eposta = '"+textBoxOgretmenEkleMail.Text+"', where ogrt_id = "+id+" ", baglanti);



        }

        private void buttonOgrenciListele_Click(object sender, EventArgs e)
        {

        }

    }
}
