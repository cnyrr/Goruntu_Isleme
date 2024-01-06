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
    public partial class Hafta_2_Odev_4 : Form
    {
        public Hafta_2_Odev_4()
        {
            InitializeComponent();
        }

        private void AktifEt()
        {
            // Butonları aktif et.
            ResmiKaydetButonu.Enabled = true;
            KarsitlikDegistirButonu.Enabled = true;
            TabanDegerKutusu.Enabled = true;
            TavanDegerKutusu.Enabled = true;
        }

        private void ResimAcButonu_Click(object sender, EventArgs e)
        {
            // Try to an open an image.
            GI.ResimAc(Orjinal);

            // Check if its succesfull.
            if (Orjinal.Image == null) { return; }

            // Create a histogram and copy them into other pictureboxes.
            GI.ResimDegistir(OrjinalHistogram, GI.HistogramOlustur(Orjinal, OrjinalHistogram, GI.RenkKanallari.Gri));

            GI.ResimDegistir(Degistirilmis, (Image)Orjinal.Image.Clone());
            GI.ResimDegistir(DegistirilmisHistogram, (Image)OrjinalHistogram.Image.Clone());

            AktifEt();

            return;
        }

        private void ResmiKaydetButonu_Click(object sender, EventArgs e)
        {
            GI.ResimKaydet(Degistirilmis);
            return;
        }

        private void KarsitlikDegistirButonu_Click(object sender, EventArgs e)
        {
            GI.ResimDegistir(Degistirilmis, GI.KarsitlikDegistir(Orjinal, (int)TabanDegerKutusu.Value, (int)TavanDegerKutusu.Value, 0, 255, GI.RenkKanallari.Gri));
            GI.ResimDegistir(DegistirilmisHistogram, GI.KiyasHistogramOlustur(Degistirilmis, DegistirilmisHistogram, Orjinal, GI.RenkKanallari.Gri));
        }

        private void PikselBilgisi_MouseUp(object sender, MouseEventArgs e)
        {
            // Nothing to do.
            if (Orjinal.Image == null) { return; }

            // Create bitmaps of the images.
            Bitmap OrjinalResim = new(Orjinal.Image);
            Bitmap DegistirilmisResim = new(Degistirilmis.Image);

            // Get the pixel values.
            Color OrjinalPixel = OrjinalResim.GetPixel(e.X, e.Y);
            Color DegisenPixel = DegistirilmisResim.GetPixel(e.X, e.Y);

            // Display the values.
            KoordinatMetni.Text = e.X.ToString() + ", " + e.Y.ToString();
            KirmiziDegerMetni.Text = "Kırmızı: " + OrjinalPixel.R.ToString() + " -> " + DegisenPixel.R.ToString();
            YesilDegerMetni.Text = "Yeşil: " + OrjinalPixel.G.ToString() + " -> " + DegisenPixel.G.ToString();
            MaviDegerMetni.Text = "Mavi: " + OrjinalPixel.B.ToString() + " -> " + DegisenPixel.B.ToString();

            // Free resources.
            OrjinalResim.Dispose();
            DegistirilmisResim.Dispose();

            return;
        }

        private void OrjinalHistogram_MouseDown(object sender, MouseEventArgs e)
        {
            if (TabanDegerKutusu.Enabled == false) { return; }

            switch (e.Button)
            {
                case MouseButtons.Left:
                    TabanDegerKutusu.Value = e.X * 256 / OrjinalHistogram.Width;
                    break;
                case MouseButtons.Right:
                    TavanDegerKutusu.Value = e.X * 256 / OrjinalHistogram.Width;
                    break;
            }
            return;
        }
    }
}
