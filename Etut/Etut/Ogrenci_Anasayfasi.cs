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
    public partial class Ogrenci_Anasayfasi : Form
    {
        public Ogrenci_Anasayfasi()
        {
            InitializeComponent();
        }

        private void buttonEtutAL_Click(object sender, EventArgs e)
        {
            Etut_Olustur etut = new Etut_Olustur();
            etut.Show();
        }

        private void buttonOgrenciCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkmak istiyor musunuz?", 
                "Çıkış", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                this.Hide();
            }

        }

        private void buttonEtutTakvimi_Click(object sender, EventArgs e)
        {

        }
    }
}
