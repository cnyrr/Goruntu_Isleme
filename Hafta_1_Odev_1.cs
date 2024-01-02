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
    public partial class Hafta_1_Odev_1 : Form
    {
        public Hafta_1_Odev_1()
        {
            InitializeComponent();
        }

        private void NormalButonu_CheckedChanged(object sender, EventArgs e)
        {
            Orjinal.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void SigdirButonu_CheckedChanged(object sender, EventArgs e)
        {
            Orjinal.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void MerkezleButonu_CheckedChanged(object sender, EventArgs e)
        {
            Orjinal.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void YakinlastirButonu_CheckedChanged(object sender, EventArgs e)
        {
            Orjinal.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void GriSkalaButonu_Click(object sender, EventArgs e)
        {
            int skala_boyutu = (int)GriSkalaDegerKutusu.Value;
            G_Isleyici.ResimDegistir(Orjinal, G_Isleyici.GriSkalaOlustur(skala_boyutu));
            return;
        }
    }
}
