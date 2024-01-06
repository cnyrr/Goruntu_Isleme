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
    public partial class Hafta_2_Odev_3 : Form
    {
        public Hafta_2_Odev_3()
        {
            InitializeComponent();
        }

        private void AktifEt()
        {
            // Enables stuff.
            OrjinalAltDegerBari.Enabled = true;
            OrjinalUstDegerBari.Enabled = true;

            KarsitlikDegistirButonu.Enabled = true;
            ResmiKaydetButonu.Enabled = true;

            return;
        }

        private void ResimAcButonu_Click(object sender, EventArgs e)
        {
            GI.ResimAc(Orjinal);

            if (Orjinal.Image != null)
            {
                // Create histograms of original image.
                GI.ResimDegistir(OrjinalHistogramR, GI.HistogramOlustur(Orjinal, OrjinalHistogramR, GI.RenkKanallari.Kirmizi));
                GI.ResimDegistir(OrjinalHistogramG, GI.HistogramOlustur(Orjinal, OrjinalHistogramG, GI.RenkKanallari.Yesil));
                GI.ResimDegistir(OrjinalHistogramB, GI.HistogramOlustur(Orjinal, OrjinalHistogramB, GI.RenkKanallari.Mavi));


                // Make copy of the original image and histograms.
                GI.ResimDegistir(Degistirilmis, (Image)Orjinal.Image.Clone());
                GI.ResimDegistir(DegistirilmisHistogramR, (Image)OrjinalHistogramR.Image.Clone());
                GI.ResimDegistir(DegistirilmisHistogramG, (Image)OrjinalHistogramG.Image.Clone());
                GI.ResimDegistir(DegistirilmisHistogramB, (Image)OrjinalHistogramB.Image.Clone());

                AktifEt();
            }

            return;
        }

        private void ResmiKaydetButonu_Click(object sender, EventArgs e)
        {
            GI.ResimKaydet(Degistirilmis);
            return;
        }

        private void KarsitlikDegistirButonu_Click(object sender, EventArgs e)
        {
            // Create the new image.
            GI.ResimDegistir(Degistirilmis, GI.KarsitlikDegistir(Orjinal, OrjinalAltDegerBari.Value, OrjinalUstDegerBari.Value
                                                                        , 0, 255
                                                                        , GI.RenkKanallari.TumKanallar));

            // Create the histograms.
            GI.ResimDegistir(DegistirilmisHistogramR, GI.KiyasHistogramOlustur(Degistirilmis, DegistirilmisHistogramR, Orjinal, GI.RenkKanallari.Kirmizi));
            GI.ResimDegistir(DegistirilmisHistogramG, GI.KiyasHistogramOlustur(Degistirilmis, DegistirilmisHistogramG, Orjinal, GI.RenkKanallari.Yesil));
            GI.ResimDegistir(DegistirilmisHistogramB, GI.KiyasHistogramOlustur(Degistirilmis, DegistirilmisHistogramB, Orjinal, GI.RenkKanallari.Mavi));

            return;
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
    }
}
