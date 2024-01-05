using System.DirectoryServices;
using System.Windows.Forms;
using System.Xml.Serialization;



namespace Görüntü_İşleme
{
    public partial class Hafta_1 : Form
    {
        enum RenkSecimi
        {
            Kırmızı,
            Yeşil,
            Mavi,
            Kırmızıdan_Gri,
            Yeşilden_Gri,
            Maviden_Gri,
            Gri
        }
        public Hafta_1()
        {
            InitializeComponent();
            
            // Renk Listesi tanımlamaları:
            RenkveGriCevirListesi.Items.Add(RenkSecimi.Kırmızı);
            RenkveGriCevirListesi.Items.Add(RenkSecimi.Yeşil);
            RenkveGriCevirListesi.Items.Add(RenkSecimi.Mavi);
            RenkveGriCevirListesi.Items.Add(RenkSecimi.Kırmızıdan_Gri);
            RenkveGriCevirListesi.Items.Add(RenkSecimi.Yeşilden_Gri);
            RenkveGriCevirListesi.Items.Add(RenkSecimi.Maviden_Gri);
            RenkveGriCevirListesi.Items.Add(RenkSecimi.Gri);
        }

        private void Hafta_1_Load(object sender, EventArgs e)
        {
            OrneklemeListesi.SelectedIndex = 0;
            RenkOrneklemeListesi.SelectedIndex = 0;
            RenkveGriCevirListesi.SelectedIndex = 0;
            BantDegisimListesi.SelectedIndex = 0;
            GriRenkDerinligiListesi.SelectedIndex = 0;
            NormalRenkDerinligiListesi.SelectedIndex = 0;
            MozaiklemeListesi.SelectedIndex = 0;
            YakinlastirButonu.Checked = true;
        }


        enum bant_degisimi
        {
            RBG = 0,
            GRB = 1,
            GBR = 2,
            BRG = 3,
            BGR = 4
        }

        private void ButonlariAktifEt()
        {
            if (Orjinal.Image != null)
            {
                NegatifAlmaButonu.Enabled = true;

                OrneklemeButonu.Enabled = true;
                OrneklemeListesi.Enabled = true;

                RenkCevirButonu.Enabled = true;
                RenkOrneklemeListesi.Enabled = true;
                RenkveGriCevirListesi.Enabled = true;

                BantDegisimButonu.Enabled = true;
                BantDegisimListesi.Enabled = true;

                GriRenkDerinligiButonu.Enabled = true;
                GriRenkDerinligiListesi.Enabled = true;

                NormalRenkDerinligiDegistirButonu.Enabled = true;
                NormalRenkDerinligiListesi.Enabled = true;

                MozaiklestirmeButonu.Enabled = true;
                MozaiklemeListesi.Enabled = true;
            }

            if (Degistirilmis.Image != null)
            {
                ResmiKaydetButonu.Enabled = true;
            }

            return;
        }

        private static int renkOrnekle(int girdi, int ornekleme_sikligi)
        {
            int taban_deger, tavan_deger;

            taban_deger = (girdi / ornekleme_sikligi) * ornekleme_sikligi;

            tavan_deger = taban_deger + ornekleme_sikligi;

            if (tavan_deger - girdi > girdi - taban_deger)
            {
                girdi = taban_deger;
            }
            else if (tavan_deger > 255)
            {
                girdi = 255;
            }
            else
            {
                girdi = tavan_deger;
            }

            return girdi;
        }

        private static int renkDerinlikDegistir(int deger, int yeni_derinlik)
        {
            int taban_deger, tavan_deger;

            taban_deger = deger / (int)Math.Pow(2, yeni_derinlik) * (int)Math.Pow(2, yeni_derinlik);

            tavan_deger = taban_deger + (int)Math.Pow(2, yeni_derinlik);

            if (taban_deger == 0)
            {
                deger = 0;
            }
            else if (tavan_deger > 255)
            {
                deger = 255;
            }
            else
            {
                deger = (taban_deger + tavan_deger) / 2;
            }

            return deger;
        }

        private void resmiOrnekle()
        {
            int ornekleme_sikligi = int.Parse(OrneklemeListesi.SelectedItem.ToString());
            int renk_ornekleme_sikligi = int.Parse(RenkOrneklemeListesi.SelectedItem.ToString());

            int genislik = Orjinal.Image.Width;
            int yukseklik = Orjinal.Image.Height;

            int R, G, B;

            Bitmap orneklenecek_gorsel = new(Orjinal.Image);
            Bitmap orneklenmis_gorsel = new(genislik / ornekleme_sikligi, yukseklik / ornekleme_sikligi);

            Color orneklenmis_renk;

            for (int y = 0; y < yukseklik / ornekleme_sikligi; y++)
            {
                for (int x = 0; x < genislik / ornekleme_sikligi; x++)
                {
                    orneklenmis_renk = orneklenecek_gorsel.GetPixel(x * ornekleme_sikligi, y * ornekleme_sikligi);

                    R = renkOrnekle(orneklenmis_renk.R, renk_ornekleme_sikligi);
                    G = renkOrnekle(orneklenmis_renk.G, renk_ornekleme_sikligi);
                    B = renkOrnekle(orneklenmis_renk.B, renk_ornekleme_sikligi);

                    orneklenmis_renk = Color.FromArgb(R, G, B);

                    orneklenmis_gorsel.SetPixel(x, y, orneklenmis_renk);
                }
            }

            Degistirilmis.Image = null;
            Degistirilmis.Image = orneklenmis_gorsel;
            orneklenecek_gorsel.Dispose();
            ButonlariAktifEt();
            return;
        }

        private void resmiTekBantYap()
        {
            Bitmap DuzenlenecekResim = new(Orjinal.Image);
            Color yeni_renk;

            int yukseklik = Orjinal.Image.Height;
            int genislik = Orjinal.Image.Width;
            int gecici_deger;

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    yeni_renk = DuzenlenecekResim.GetPixel(x, y);

                    switch (RenkveGriCevirListesi.SelectedItem)
                    {
                        case RenkSecimi.Kırmızı:
                            yeni_renk = Color.FromArgb(yeni_renk.R, 0, 0);
                            break;
                        case RenkSecimi.Yeşil:
                            yeni_renk = Color.FromArgb(0, yeni_renk.G, 0);
                            break;
                        case RenkSecimi.Mavi:
                            yeni_renk = Color.FromArgb(0, 0, yeni_renk.B);
                            break;
                        case RenkSecimi.Kırmızıdan_Gri:
                            yeni_renk = Color.FromArgb(yeni_renk.R, yeni_renk.R, yeni_renk.R);
                            break;
                        case RenkSecimi.Yeşilden_Gri:
                            yeni_renk = Color.FromArgb(yeni_renk.G, yeni_renk.G, yeni_renk.G);
                            break;
                        case RenkSecimi.Maviden_Gri:
                            yeni_renk = Color.FromArgb(yeni_renk.B, yeni_renk.B, yeni_renk.B);
                            break;
                        case RenkSecimi.Gri:
                            gecici_deger = (yeni_renk.R + yeni_renk.G + yeni_renk.B) / 3;
                            yeni_renk = Color.FromArgb(gecici_deger, gecici_deger, gecici_deger);
                            break;
                    }
                    DuzenlenecekResim.SetPixel(x, y, yeni_renk);
                }
            }

            Degistirilmis.Image = null;
            Degistirilmis.Image = DuzenlenecekResim;
            ButonlariAktifEt();
            return;
        }

        private void resimBandiniDegistir()
        {
            Bitmap DuzenlenecekResim = new(Orjinal.Image);
            Color yeni_renk;

            int yukseklik = Orjinal.Image.Height;
            int genislik = Orjinal.Image.Width;

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    yeni_renk = DuzenlenecekResim.GetPixel(x, y);

                    switch (BantDegisimListesi.SelectedIndex)
                    {
                        case (int)bant_degisimi.RBG:
                            yeni_renk = Color.FromArgb(yeni_renk.R, yeni_renk.B, yeni_renk.G);
                            break;
                        case (int)bant_degisimi.GRB:
                            yeni_renk = Color.FromArgb(yeni_renk.G, yeni_renk.R, yeni_renk.B);
                            break;
                        case (int)bant_degisimi.GBR:
                            yeni_renk = Color.FromArgb(yeni_renk.G, yeni_renk.B, yeni_renk.R);
                            break;
                        case (int)bant_degisimi.BRG:
                            yeni_renk = Color.FromArgb(yeni_renk.B, yeni_renk.R, yeni_renk.G);
                            break;
                        case (int)bant_degisimi.BGR:
                            yeni_renk = Color.FromArgb(yeni_renk.B, yeni_renk.G, yeni_renk.R);
                            break;
                    }

                    DuzenlenecekResim.SetPixel(x, y, yeni_renk);
                }
            }

            //goruntuDegistir();
            Degistirilmis.Image = null;
            Degistirilmis.Image = DuzenlenecekResim;
            ButonlariAktifEt();
            return;
        }

        private void resimGriRenkDerinligiDegistir()
        {
            Bitmap DuzenlenecekResim = new(Orjinal.Image);
            Color yeni_renk;

            int gecici_deger;

            int yukseklik = Orjinal.Image.Height;
            int genislik = Orjinal.Image.Width;

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    yeni_renk = DuzenlenecekResim.GetPixel(x, y);
                    gecici_deger = (yeni_renk.R + yeni_renk.G + yeni_renk.B) / 3;

                    gecici_deger = renkDerinlikDegistir(gecici_deger, GriRenkDerinligiListesi.SelectedIndex + 1);


                    yeni_renk = Color.FromArgb(gecici_deger, gecici_deger, gecici_deger);

                    DuzenlenecekResim.SetPixel(x, y, yeni_renk);
                }
            }

            Degistirilmis.Image = null;
            Degistirilmis.Image = DuzenlenecekResim;
            ButonlariAktifEt();
            return;
        }

        private void resimNormalRenkDerinligiDegistir()
        {
            Bitmap DuzenlenecekResim = new(Orjinal.Image);
            Color yeni_renk;

            int gecici_R, gecici_G, gecici_B;

            int yukseklik = Orjinal.Image.Height;
            int genislik = Orjinal.Image.Width;

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    yeni_renk = DuzenlenecekResim.GetPixel(x, y);
                    gecici_R = renkDerinlikDegistir(yeni_renk.R, NormalRenkDerinligiListesi.SelectedIndex + 1);
                    gecici_G = renkDerinlikDegistir(yeni_renk.G, NormalRenkDerinligiListesi.SelectedIndex + 1);
                    gecici_B = renkDerinlikDegistir(yeni_renk.B, NormalRenkDerinligiListesi.SelectedIndex + 1);

                    yeni_renk = Color.FromArgb(gecici_R, gecici_G, gecici_B);

                    DuzenlenecekResim.SetPixel(x, y, yeni_renk);
                }
            }

            Degistirilmis.Image = null;
            Degistirilmis.Image = DuzenlenecekResim;
            ButonlariAktifEt();
            return;
        }

        private void resimMozaiklestirDestek(ref Bitmap girdi, int genislik, int yukseklik)
        {
            int ornekleme_sikligi = int.Parse(MozaiklemeListesi.SelectedItem.ToString());
            int gecici_deger;

            int[,] cikti_matrisi = new int[(genislik / ornekleme_sikligi) + 1, (yukseklik / ornekleme_sikligi) + 1];

            Bitmap cikti = new(genislik / ornekleme_sikligi, yukseklik / ornekleme_sikligi);
            Color yeni_renk;

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    yeni_renk = girdi.GetPixel(x, y);
                    cikti_matrisi[x / ornekleme_sikligi, y / ornekleme_sikligi] += yeni_renk.R;
                }
            }

            for (int y = 0; y < yukseklik / ornekleme_sikligi; y++)
            {
                for (int x = 0; x < genislik / ornekleme_sikligi; x++)
                {
                    gecici_deger = cikti_matrisi[x, y] / (ornekleme_sikligi * ornekleme_sikligi);
                    yeni_renk = Color.FromArgb(gecici_deger, gecici_deger, gecici_deger);
                    cikti.SetPixel(x, y, yeni_renk);
                }
            }

            Degistirilmis.Image = null;
            Degistirilmis.Image = cikti;
            ButonlariAktifEt();
            return;
        }
        private void resmiGriMozaiklestir()
        {
            Bitmap DuzenlenecekResim = new(Orjinal.Image);
            Color yeni_renk;
            double gri_ton;

            int yukseklik = Orjinal.Image.Height;
            int genislik = Orjinal.Image.Width;


            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    yeni_renk = DuzenlenecekResim.GetPixel(x, y);

                    gri_ton = (yeni_renk.R + yeni_renk.G + yeni_renk.B) / (double)3;

                    yeni_renk = Color.FromArgb((int)gri_ton, (int)gri_ton, (int)gri_ton);

                    DuzenlenecekResim.SetPixel(x, y, yeni_renk);
                }
            }

            resimMozaiklestirDestek(ref DuzenlenecekResim, genislik, yukseklik);
            return;
        }

        private void ResmiKaydetButonu_Click(object sender, EventArgs e)
        {
            GI.ResimKaydet(Degistirilmis);
            return;
        }
        private void ResimSecButonu_Click(object sender, EventArgs e)
        {
            GI.ResimAc(Orjinal);
            ButonlariAktifEt();
            return;
        }
        private void NegatifAlmaButonu_Click(object sender, EventArgs e)
        {
            GI.ResimDegistir(Degistirilmis, GI.ResminNegatifiniAl(Orjinal));
            ButonlariAktifEt();
            return;
        }
        private void GriSkalaButonu_Click(object sender, EventArgs e)
        {
            int skala_boyutu = (int)GriSkalaDegerKutusu.Value;

            GI.ResimDegistir(Orjinal, GI.GriSkalaOlustur(skala_boyutu));
            ButonlariAktifEt();
            return;
        }
        private void DaireButonu_Click(object sender, EventArgs e)
        {
            int daire_cozunurluk = (int)DaireCozunurlukDegerKutusu.Value;

            GI.ResimDegistir(Orjinal, GI.DaireOlustur(daire_cozunurluk));
            ButonlariAktifEt();
            return;
        }

        private void OrneklemeButonu_Click(object sender, EventArgs e)
        {
            resmiOrnekle();
        }

        private void GriyeCevirButonu_Click(object sender, EventArgs e)
        {
            resmiTekBantYap();

            return;
        }

        private void OlceklemeRadyoButonlari_CheckedChanged(object sender, EventArgs e)
        {
            if (NormalButonu.Checked)
            {
                Degistirilmis.SizeMode = PictureBoxSizeMode.Normal;
            }
            else if (YakinlastirButonu.Checked)
            {
                Degistirilmis.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (SigdirButonu.Checked)
            {
                Degistirilmis.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                Degistirilmis.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            return;
        }


        private void BantDegisimButonu_Click(object sender, EventArgs e)
        {
            resimBandiniDegistir();
            return;
        }

        private void RenkDerinligiButonu_Click(object sender, EventArgs e)
        {
            resimGriRenkDerinligiDegistir();
            return;
        }

        private void NormalRenkDerinligiDegistirButonu_Click(object sender, EventArgs e)
        {
            resimNormalRenkDerinligiDegistir();
            return;
        }

        private void MozaiklestirmeButonu_Click(object sender, EventArgs e)
        {
            resmiGriMozaiklestir();
            return;
        }
    }
}