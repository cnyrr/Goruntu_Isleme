using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görüntü_İşleme
{
    public partial class Hafta_2_Odev_1 : Form
    {
        public Hafta_2_Odev_1()
        {
            InitializeComponent();
        }

        private void ResimAcButonu_Click(object sender, EventArgs e)
        {
            GI.ResimAc(Orjinal);

            if (Orjinal.Image != null)
            {
                GI.ResimDegistir(Degistirilmis, (Image)Orjinal.Image.Clone());

                // Enable stuff.
                ResmiKaydetButonu.Enabled = true;
                ParlaklikBar.Enabled = true;

                // Reset bar.
                ParlaklikBar.Value = 0;
                ParlaklikMetin.Text = "Parlaklik Degişimi: 0";
            }

            return;
        }

        private void ResmiKaydetButonu_Click(object sender, EventArgs e)
        {
            GI.ResimKaydet(Degistirilmis);
            return;
        }

        private void ParlaklikBar_MouseUp(object sender, MouseEventArgs e)
        {
            ParlaklikMetin.Text = "Parlaklik Degişimi: " + ParlaklikBar.Value.ToString();
            GI.ResimDegistir(Degistirilmis, GI.ParlaklikDegistir(Orjinal, ParlaklikBar.Value));
            
            return;
        }
    }
}
