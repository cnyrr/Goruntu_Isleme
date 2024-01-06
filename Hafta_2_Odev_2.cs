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
    public partial class Hafta_2_Odev_2 : Form
    {
        public Hafta_2_Odev_2()
        {
            InitializeComponent();
        }

        private void AktifEt()
        {
            // Enables stuff.
            GriveRTabanEsikBar.Enabled = true;
            GriveRTavanEsikBar.Enabled = true;
            GTabanEsikBar.Enabled = true;
            GTavanEsikBar.Enabled = true;
            BTabanEsikBar.Enabled = true;
            BTavanEsikBar.Enabled = true;

            ResimEsikleButonu.Enabled = true;
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

        private void ResimEsikleButonu_Click(object sender, EventArgs e)
        {
            // Determine which mode to run.
            switch (RenkModuKutusu.Checked)
            { 
                case true: // Color mode.
                
                    // Create the new image.
                    GI.ResimDegistir(Degistirilmis, GI.ResmiEsikle(Orjinal, GriveRTabanEsikBar.Value, GriveRTavanEsikBar.Value
                                                                          , GTabanEsikBar.Value,      GTavanEsikBar.Value
                                                                          , BTabanEsikBar.Value,      BTavanEsikBar.Value
                                                                          , GI.RenkKanallari.TumKanallar));

                    // Create the histograms.
                    GI.ResimDegistir(DegistirilmisHistogramR, GI.KiyasHistogramOlustur(Degistirilmis, DegistirilmisHistogramR, Orjinal, GI.RenkKanallari.Kirmizi));
                    GI.ResimDegistir(DegistirilmisHistogramG, GI.KiyasHistogramOlustur(Degistirilmis, DegistirilmisHistogramG, Orjinal, GI.RenkKanallari.Yesil));
                    GI.ResimDegistir(DegistirilmisHistogramB, GI.KiyasHistogramOlustur(Degistirilmis, DegistirilmisHistogramB, Orjinal, GI.RenkKanallari.Mavi));
                    break;
                case false: // Grey mode.
                    
                    // Create the new image.
                    GI.ResimDegistir(Degistirilmis, GI.ResmiEsikle(Orjinal, GriveRTabanEsikBar.Value, GriveRTavanEsikBar.Value
                                                                          , GriveRTabanEsikBar.Value, GriveRTavanEsikBar.Value
                                                                          , GriveRTabanEsikBar.Value, GriveRTavanEsikBar.Value
                                                                          , GI.RenkKanallari.Gri));

                    // Create the histogram.
                    GI.ResimDegistir(DegistirilmisHistogramR, GI.KiyasHistogramOlustur(Degistirilmis, DegistirilmisHistogramR, Orjinal, GI.RenkKanallari.Gri));
                    break;
            }

            return;
        }

        private void RenkModuKutusu_CheckedChanged(object sender, EventArgs e)
        {
            // Some hacks to make things look nicer.
            if (RenkModuKutusu.Checked == false)
            {
                OrjinalHistogramR.Width = 780;
                DegistirilmisHistogramR.Width = 780;

                GriveRTabanEsikMetin.Text = "Gri Ton Taban Eşik Değer: " + GriveRTabanEsikBar.Value.ToString();
                GriveRTavanEsikMetin.Text = "Gri Ton Tavan Eşik Değer: " + GriveRTavanEsikBar.Value.ToString();

                OrjinalHistogramG.Visible = false;
                OrjinalHistogramB.Visible = false;
                DegistirilmisHistogramG.Visible = false;
                DegistirilmisHistogramB.Visible = false;

                GTabanEsikMetin.Visible = false;
                GTavanEsikMetin.Visible = false;
                BTabanEsikMetin.Visible = false;
                BTavanEsikMetin.Visible = false;

                GTabanEsikBar.Visible = false;
                GTavanEsikBar.Visible = false;
                BTabanEsikBar.Visible = false;
                BTavanEsikBar.Visible = false;

                if (Orjinal.Image != null)
                {
                    GI.ResimDegistir(OrjinalHistogramR, GI.HistogramOlustur(Orjinal, OrjinalHistogramR, GI.RenkKanallari.Kirmizi));
                    GI.ResimDegistir(DegistirilmisHistogramR, GI.HistogramOlustur(Degistirilmis, DegistirilmisHistogramR, GI.RenkKanallari.Kirmizi));
                }
            }
            else
            {
                OrjinalHistogramR.Width = 256;
                DegistirilmisHistogramR.Width = 256;

                GriveRTabanEsikMetin.Text = "Kırmızı Ton Taban Eşik Değer: " + GriveRTabanEsikBar.Value.ToString();
                GriveRTavanEsikMetin.Text = "Kırmızı Ton Tavan Eşik Değer: " + GriveRTavanEsikBar.Value.ToString();

                OrjinalHistogramG.Visible = true;
                OrjinalHistogramB.Visible = true;
                DegistirilmisHistogramG.Visible = true;
                DegistirilmisHistogramB.Visible = true;

                GTabanEsikMetin.Visible = true;
                GTavanEsikMetin.Visible = true;
                BTabanEsikMetin.Visible = true;
                BTavanEsikMetin.Visible = true;

                GTabanEsikBar.Visible = true;
                GTavanEsikBar.Visible = true;
                BTabanEsikBar.Visible = true;
                BTavanEsikBar.Visible = true;

                if (Orjinal.Image != null)
                {
                    GI.ResimDegistir(OrjinalHistogramR, GI.HistogramOlustur(Orjinal, OrjinalHistogramR, GI.RenkKanallari.Gri));
                    GI.ResimDegistir(DegistirilmisHistogramR, GI.KiyasHistogramOlustur(Degistirilmis, DegistirilmisHistogramR, Orjinal, GI.RenkKanallari.Gri));
                }
            }
            return;
        }

        private void GriveRTabanEsikBar_ValueChanged(object sender, EventArgs e)
        {
            if (RenkModuKutusu.Checked)
            {
                GriveRTabanEsikMetin.Text = "Kırmızı Ton Taban Eşik Değer: " + GriveRTabanEsikBar.Value.ToString();
            }
            else
            {
                GriveRTabanEsikMetin.Text = "Gri Ton Taban Eşik Değer: " + GriveRTabanEsikBar.Value.ToString();
            }
            return;
        }

        private void GriveRTavanEsikBar_ValueChanged(object sender, EventArgs e)
        {
            if (RenkModuKutusu.Checked)
            {
                GriveRTavanEsikMetin.Text = "Kırmızı Ton Tavan Eşik Değer: " + GriveRTavanEsikBar.Value.ToString();
            }
            else
            {
                GriveRTavanEsikMetin.Text = "Gri Ton Tavan Eşik Değer: " + GriveRTavanEsikBar.Value.ToString();
            }
            return;
        }

        private void GTabanEsikBar_ValueChanged(object sender, EventArgs e)
        {
            GTabanEsikMetin.Text = "Yeşil Ton Taban Eşik Değer: " + GTabanEsikBar.Value.ToString();
            return;
        }

        private void GTavanEsikBar_ValueChanged(object sender, EventArgs e)
        {
            GTavanEsikMetin.Text = "Yeşil Ton Tavan Eşik Değer: " + GTavanEsikBar.Value.ToString();
            return;
        }

        private void BTabanEsikBar_ValueChanged(object sender, EventArgs e)
        {
            BTabanEsikBar.Text = "Mavi Ton Taban Eşik Değer: " + BTabanEsikBar.Value.ToString();
            return;
        }

        private void BTavanEsikBar_ValueChanged(object sender, EventArgs e)
        {
            BTavanEsikBar.Text = "Mavi Ton Tavan Eşik Değer: " + BTavanEsikBar.Value.ToString();
            return;
        }

        private void ResmiKaydetButonu_Click(object sender, EventArgs e)
        {
            GI.ResimKaydet(Degistirilmis);
            return;
        }
    }
}
