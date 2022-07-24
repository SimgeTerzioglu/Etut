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
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-L4TSN9F\SQLSERVER;Initial Catalog=DERSHANE;Integrated Security=True");
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

        private void buttonPinOlusturma_Click(object sender, EventArgs e)
        {
          
            Random generator = new Random();
            pin = generator.Next(0, 1000000).ToString("D6");
            textBoxOgrenciEklePin.Text = pin;
        }

        int id = 0;
        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView2.SelectedItems[0].SubItems[0].Text);
            textBoxOgrenciEkleAd.Text = listView2.SelectedItems[0].SubItems[1].Text;
            textBoxOgrenciEkleSoyad.Text = listView2.SelectedItems[0].SubItems[2].Text;
            comboBoxSinif.Text = listView2.SelectedItems[0].SubItems[3].Text;
            textBoxOgrenciEkleTel.Text = listView2.SelectedItems[0].SubItems[4].Text;
            textBoxOgrenciEkleMail.Text = listView2.SelectedItems[0].SubItems[5].Text;
            textBoxOgrenciEklePin.Text = listView2.SelectedItems[0].SubItems[6].Text;
        }

        private void buttonOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Ogretmenler set ogr_ad = '" + textBoxOgrenciEkleAd.Text + "', ogr_soyad = '" + textBoxOgrenciEkleSoyad.Text + "" +
                    ", sınıf = '" + comboBoxSinif.Text + "', telefon_no = '" + textBoxOgrenciEkleTel.Text + "', ogr_mail = '" +textBoxOgrenciEkleMail.Text + "'," +
                    " ogr_pin = '"+textBoxOgrenciEklePin.Text+"'  where ogr_id = " + id + " ", baglanti);



        }
    }
}
