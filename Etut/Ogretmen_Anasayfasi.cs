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
    public partial class Ogretmen_Anasayfasi : Form
    {
        public Ogretmen_Anasayfasi()
        {
            InitializeComponent();
        }

        private void buttonOgrenciCikis1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkmak istiyor musunuz?",
               "Çıkış", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                this.Hide();
            }

        }

        private void buttonEtutTakvimi1_Click(object sender, EventArgs e)
        {
            EtutTakvimi syf = new EtutTakvimi();
            syf.Show();
        }
    }
}
