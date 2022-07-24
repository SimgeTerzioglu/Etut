using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etut
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void buttonOgrenci_Click(object sender, EventArgs e)
        {
            Ogrenci_Giris_Sayfasi grs = new Ogrenci_Giris_Sayfasi();
            grs.Show();
        }

        private void buttonOgretmen_Click(object sender, EventArgs e)
        {
            Ogretmen_Giris_Sayfasi grs = new Ogretmen_Giris_Sayfasi();
            grs.Show();
        }

        private void buttonPersonel_Click(object sender, EventArgs e)
        {
            Personel_Giris_Sayfasi grs = new Personel_Giris_Sayfasi();
            grs.Show();
        }
    }
}
