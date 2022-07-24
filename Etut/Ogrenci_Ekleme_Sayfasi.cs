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
    public partial class Ogrenci_Ekleme_Sayfasi : Form
    {
        public Ogrenci_Ekleme_Sayfasi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9TA2NG8\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True");
        string pin;
        private void buttonOgrenciEkle_Click(object sender, EventArgs e)
        {
            if (textBoxOgrenciEkleAd.Text == "" || textBoxOgrenciEkleSoyad.Text == "" || textBoxOgrenciEkleMail.Text == "" || textBoxOgrenciEkleTel.Text == "" || textBoxOgrenciEklePin.Text =="")
            {
                MessageBox.Show("Tüm alanlar doldurulmalıdır.");
            }
            else
            {
                string ad, soyad, sinif, tel, mail;
                ad = textBoxOgrenciEkleAd.Text;
                soyad = textBoxOgrenciEkleSoyad.Text;
                sinif = comboBoxSinif.Text;
                tel = textBoxOgrenciEkleTel.Text;
                mail = textBoxOgrenciEkleMail.Text;
                pin = textBoxOgrenciEklePin.Text;
               

                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Ogrenciler" + "(ogr_ad,ogr_soyad,sınıf,telefon_no,ogr_mail,ogr_pin)" +
                    "values('"+ad+"','"+soyad+"','"+sinif+"','"+tel+"','"+mail+"','"+pin+"')",baglanti);
                komut.ExecuteNonQuery();

                MessageBox.Show("Öğrenci Başarıyla Kaydedildi.");
                baglanti.Close();


            }
        }
        private void temizle()
        {
            textBoxOgrenciEkleAd.Text = "";
            textBoxOgrenciEkleSoyad.Text = "";
            comboBoxSinif.Text = "";
            textBoxOgrenciEkleMail.Text = "";
            textBoxOgrenciEklePin.Text = "";
            textBoxOgrenciEkleTel.Text = "";
        }
        private void VerileriGoster()
        {
            ListViewOgrnc.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Ogrenciler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ogr_id"].ToString();
                ekle.SubItems.Add(oku["ogr_ad"].ToString());
                ekle.SubItems.Add(oku["ogr_soyad"].ToString());
                ekle.SubItems.Add(oku["sınıf"].ToString());
                ekle.SubItems.Add(oku["telefon_no"].ToString());
                ekle.SubItems.Add(oku["ogr_mail"].ToString());
                ekle.SubItems.Add(oku["ogr_pin"].ToString());

                ListViewOgrnc.Items.Add(ekle);
            }
            baglanti.Close();
         }

            private void buttonPinOlusturma_Click(object sender, EventArgs e)
        {
          
            Random generator = new Random();
            pin = generator.Next(0, 1000000).ToString("D6");
            textBoxOgrenciEklePin.Text = pin;
        }

        private void buttonOgrenciListele_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }
        int id;
        private void ListViewOgrnc_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(ListViewOgrnc.SelectedItems[0].SubItems[0].Text);
            textBoxOgrenciEkleAd.Text = ListViewOgrnc.SelectedItems[0].SubItems[1].Text;
            textBoxOgrenciEkleSoyad.Text = ListViewOgrnc.SelectedItems[0].SubItems[2].Text;
            comboBoxSinif.Text = ListViewOgrnc.SelectedItems[0].SubItems[3].Text;
            textBoxOgrenciEkleTel.Text = ListViewOgrnc.SelectedItems[0].SubItems[4].Text;
            textBoxOgrenciEkleMail.Text = ListViewOgrnc.SelectedItems[0].SubItems[5].Text;
            textBoxOgrenciEklePin.Text = ListViewOgrnc.SelectedItems[0].SubItems[6].Text;
        }

        private void Ogrenci_Ekleme_Sayfasi_Load(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void buttonOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Ogrenciler set ogr_ad = '" + textBoxOgrenciEkleAd.Text + "', ogr_soyad = '" + textBoxOgrenciEkleSoyad.Text + "', sınıf = '" + comboBoxSinif.Text + "', telefon_no = '" + textBoxOgrenciEkleTel.Text + "', ogr_mail = '" + textBoxOgrenciEkleMail.Text + "', ogr_pin = '" + textBoxOgrenciEklePin.Text + "'  where ogr_id = '" + id + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı.");
            temizle();
        }
    }
}
