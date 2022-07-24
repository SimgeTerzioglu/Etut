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
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9TA2NG8\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True");
        string pin;
        public Ogretmen_Ekleme_Sayfasi()
        {
            InitializeComponent();
        }
        private void VerileriGoster()
        {
            ListViewOgrt.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Ogretmenler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ogrt_id"].ToString();
                ekle.SubItems.Add(oku["ogrt_ad"].ToString());
                ekle.SubItems.Add(oku["ogrt_soyad"].ToString());
                ekle.SubItems.Add(oku["brans_id"].ToString());
                ekle.SubItems.Add(oku["ogrt_pin"].ToString());
                ekle.SubItems.Add(oku["ogrt_eposta"].ToString());

                ListViewOgrt.Items.Add(ekle);
            }
            baglanti.Close();
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
        private void temizle()
        {
            textBoxOgretmenEkleAd.Text = "";
            textBoxOgretmenEkleSoyad.Text = "";
            comboBoxBrans.Text = "";
            textBoxOgretmenEkleMail.Text = "";
            textBoxOgretmenEklePin.Text = "";
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
            VerileriGoster();
        }

        private void buttonOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            ad = textBoxOgretmenEkleAd.Text;
            soyad = textBoxOgretmenEkleSoyad.Text;
            lblogr_adsoyad.Text= ad + " " + soyad;
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("update Ogretmenler set ogrt_ad = '" + textBoxOgretmenEkleAd.Text + "', ogrt_soyad = '" + textBoxOgretmenEkleSoyad.Text +"', brans_id = '" + comboBoxBrans.SelectedValue + "',ad_soyad='"+lblogr_adsoyad.Text+"' , ogrt_pin = '" + textBoxOgretmenEklePin.Text + "', ogrt_eposta = '" + textBoxOgretmenEkleMail.Text + "' where ogrt_id = '" + id +"'", baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı.");
            temizle();
        }


        private void buttonOgrenciListele_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }
        int id;
        private void ListViewOgrt_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(ListViewOgrt.SelectedItems[0].SubItems[0].Text);
            textBoxOgretmenEkleAd.Text = ListViewOgrt.SelectedItems[0].SubItems[1].Text;
            textBoxOgretmenEkleSoyad.Text = ListViewOgrt.SelectedItems[0].SubItems[2].Text;
            comboBoxBrans.Text = ListViewOgrt.SelectedItems[0].SubItems[3].Text;
            textBoxOgretmenEklePin.Text = ListViewOgrt.SelectedItems[0].SubItems[4].Text;
            textBoxOgretmenEkleMail.Text = ListViewOgrt.SelectedItems[0].SubItems[5].Text;
        }
    }
}
