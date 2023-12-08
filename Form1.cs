using System.DirectoryServices;
using System.Windows.Forms;

namespace Görüntü_İşleme
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        enum renk_secimi
        {
            kirmizi = 0,
            yesil = 1,
            mavi = 2,
            kirmizidan_gri = 3,
            yesilden_gri = 4,
            maviden_gri = 5,
            gri = 6
        }

        enum bant_degisimi
        {
            RBG = 0,
            GRB = 1,
            GBR = 2,
            BRG = 3,
            BGR = 4
        }

        private void aktifEt()
        {
            NegatifAlmaButonu.Enabled = true;

            ResmiKaydetButonu.Enabled = true;

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
        private void resimAc()
        {
            OpenFileDialog DosyaAcici = new()
            {
                DefaultExt = ".jpg",
                Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
            };

            DosyaAcici.ShowDialog();

            if (DosyaAcici.FileName != "")
            {
                Image test = Image.FromFile(DosyaAcici.FileName);

                if (test.Width > 0 && test.Height > 0)
                {
                    OrjinalResim.Image = Image.FromFile(DosyaAcici.FileName);


                    aktifEt();
                    ResmiKaydetButonu.Enabled = false;

                    DegistirilmisResim.Image ??= OrjinalResim.Image;
                }

                test.Dispose();
            }

            DosyaAcici.Dispose();
        }

        private void resmiKaydet()
        {
            SaveFileDialog DosyaKaydedici = new()
            {
                Filter = "Jpeg Resmi|*.jpg|Bitmap Resmi|*.bmp|Gif Resmi|*.gif",
                Title = "Resmi Kaydet"
            };

            DosyaKaydedici.ShowDialog();

            if (DosyaKaydedici.FileName != "")
            {
                FileStream DosyaAkisi = (FileStream)DosyaKaydedici.OpenFile();
                switch (DosyaKaydedici.FilterIndex)
                {
                    case 1:
                        DegistirilmisResim.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Jpeg); break;
                    case 2:
                        DegistirilmisResim.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Bmp); break;
                    case 3:
                        DegistirilmisResim.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Gif); break;
                }
                DosyaAkisi.Close();
            }

            DosyaKaydedici.Dispose();
        }

        private void resminNegatifiniAl()
        {
            Bitmap DuzenlenecekResim = new(OrjinalResim.Image);

            int yukseklik = OrjinalResim.Image.Height;
            int genislik = OrjinalResim.Image.Width;

            Color yeni_renk;
            int R, G, B;

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    yeni_renk = DuzenlenecekResim.GetPixel(x, y);

                    R = (byte)~yeni_renk.R;
                    G = (byte)~yeni_renk.G;
                    B = (byte)~yeni_renk.B;

                    yeni_renk = Color.FromArgb(R, G, B);

                    DuzenlenecekResim.SetPixel(x, y, yeni_renk);
                }
            }

            DegistirilmisResim.Image = null;
            DegistirilmisResim.Image = DuzenlenecekResim;
            aktifEt();
            return;
        }

        private void griSkalaOlustur()
        {
            int skala_boyutu = (int)GriSkalaMaxDegerKutusu.Value;

            Bitmap gri_skala = new(skala_boyutu, skala_boyutu);
            Color gri_tonu = Color.FromArgb(0, 0, 0);

            double artis_miktari = 255 / (double)skala_boyutu;
            double gri_degeri = 0;

            for (int x = 0; x < skala_boyutu; x++)
            {
                for (int y = 0; y < skala_boyutu; y++)
                {
                    gri_skala.SetPixel(x, y, gri_tonu);
                }

                if (gri_degeri < 255)
                {
                    gri_degeri += artis_miktari;
                }

                gri_tonu = Color.FromArgb((int)gri_degeri, (int)gri_degeri, (int)gri_degeri);
            }

            OrjinalResim.Image = gri_skala;

            aktifEt();
            ResmiKaydetButonu.Enabled = false;
            return;
        }

        private void daireOlustur()
        {
            int daire_cozunurluk = (int)DaireCozunurlukDegerKutusu.Value;
            Bitmap daire = new(daire_cozunurluk, daire_cozunurluk);

            for (int y = 0; y < daire_cozunurluk; y++)
            {
                for (int x = 0; x < daire_cozunurluk; x++)
                {
                    if (Math.Pow(Math.Abs(x - (double)daire_cozunurluk/ 2), 2) + Math.Pow(Math.Abs(y - (double)daire_cozunurluk / 2), 2) < 10000)
                    {
                        daire.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        daire.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
            }

            OrjinalResim.Image = daire;

            aktifEt();
            ResmiKaydetButonu.Enabled = false;
            return;
        }

        private void resmiOrnekle()
        {
            int ornekleme_sikligi = int.Parse(OrneklemeListesi.SelectedItem.ToString());
            int renk_ornekleme_sikligi = int.Parse(RenkOrneklemeListesi.SelectedItem.ToString());

            int genislik = OrjinalResim.Image.Width;
            int yukseklik = OrjinalResim.Image.Height;

            int R, G, B;

            Bitmap orneklenecek_gorsel = new(OrjinalResim.Image);
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

            DegistirilmisResim.Image = null;
            DegistirilmisResim.Image = orneklenmis_gorsel;
            aktifEt();
            return;
        }

        private void resmiTekBantYap()
        {
            Bitmap DuzenlenecekResim = new(OrjinalResim.Image);
            Color yeni_renk;

            int yukseklik = OrjinalResim.Image.Height;
            int genislik = OrjinalResim.Image.Width;
            int gecici_deger;

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    yeni_renk = DuzenlenecekResim.GetPixel(x, y);

                    switch (RenkveGriCevirListesi.SelectedIndex)
                    {
                        case (int)renk_secimi.kirmizi:
                            yeni_renk = Color.FromArgb(yeni_renk.R, 0, 0);
                            break;
                        case (int)renk_secimi.yesil:
                            yeni_renk = Color.FromArgb(0, yeni_renk.G, 0);
                            break;
                        case (int)renk_secimi.mavi:
                            yeni_renk = Color.FromArgb(0, 0, yeni_renk.B);
                            break;
                        case (int)renk_secimi.kirmizidan_gri:
                            yeni_renk = Color.FromArgb(yeni_renk.R, yeni_renk.R, yeni_renk.R);
                            break;
                        case (int)renk_secimi.yesilden_gri:
                            yeni_renk = Color.FromArgb(yeni_renk.G, yeni_renk.G, yeni_renk.G);
                            break;
                        case (int)renk_secimi.maviden_gri:
                            yeni_renk = Color.FromArgb(yeni_renk.B, yeni_renk.B, yeni_renk.B);
                            break;
                        case (int)renk_secimi.gri:
                            gecici_deger = (yeni_renk.R + yeni_renk.G + yeni_renk.B) / 3;
                            yeni_renk = Color.FromArgb(gecici_deger, gecici_deger, gecici_deger);
                            break;
                    }
                    DuzenlenecekResim.SetPixel(x, y, yeni_renk);
                }
            }

            DegistirilmisResim.Image = null;
            DegistirilmisResim.Image = DuzenlenecekResim;
            aktifEt();
            return;
        }

        private void resimBandiniDegistir()
        {
            Bitmap DuzenlenecekResim = new(OrjinalResim.Image);
            Color yeni_renk;

            int yukseklik = OrjinalResim.Image.Height;
            int genislik = OrjinalResim.Image.Width;

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

            DegistirilmisResim.Image = null;
            DegistirilmisResim.Image = DuzenlenecekResim;
            aktifEt();
            return;
        }

        private void resimGriRenkDerinligiDegistir()
        {
            Bitmap DuzenlenecekResim = new(OrjinalResim.Image);
            Color yeni_renk;

            int gecici_deger;

            int yukseklik = OrjinalResim.Image.Height;
            int genislik = OrjinalResim.Image.Width;

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

            DegistirilmisResim.Image = null;
            DegistirilmisResim.Image = DuzenlenecekResim;
            aktifEt();
            return;
        }

        private void resimNormalRenkDerinligiDegistir()
        {
            Bitmap DuzenlenecekResim = new(OrjinalResim.Image);
            Color yeni_renk;

            int gecici_R, gecici_G, gecici_B;

            int yukseklik = OrjinalResim.Image.Height;
            int genislik = OrjinalResim.Image.Width;

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

            DegistirilmisResim.Image = null;
            DegistirilmisResim.Image = DuzenlenecekResim;
            aktifEt();
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

            DegistirilmisResim.Image = null;
            DegistirilmisResim.Image = cikti;
            aktifEt();
            return;
        }
        private void resmiGriMozaiklestir()
        {
            Bitmap DuzenlenecekResim = new(OrjinalResim.Image);
            Color yeni_renk;
            double gri_ton;

            int yukseklik = OrjinalResim.Image.Height;
            int genislik = OrjinalResim.Image.Width;


            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    yeni_renk = DuzenlenecekResim.GetPixel(x, y);

                    gri_ton = (yeni_renk.R + yeni_renk.G + yeni_renk.B) / (double) 3;

                    yeni_renk = Color.FromArgb((int)gri_ton, (int)gri_ton, (int)gri_ton);

                    DuzenlenecekResim.SetPixel(x, y, yeni_renk);
                }
            }

            resimMozaiklestirDestek(ref DuzenlenecekResim, genislik, yukseklik);
            return;
        }

        private void resimSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resimAc();
        }

        private void ResmiKaydetButonu_Click(object sender, EventArgs e)
        {
            resmiKaydet();
        }

        private void NegatifAlmaButonu_Click(object sender, EventArgs e)
        {
            resminNegatifiniAl();
        }

        private void ResimSecButonu_Click(object sender, EventArgs e)
        {
            resimAc();
        }

        private void GriSkalaButonu_Click(object sender, EventArgs e)
        {
            griSkalaOlustur();
        }

        private void DaireButonu_Click(object sender, EventArgs e)
        {
            daireOlustur();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DegistirilmisResim.SizeMode = PictureBoxSizeMode.Normal;

            return;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DegistirilmisResim.SizeMode = PictureBoxSizeMode.CenterImage;

            return;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            DegistirilmisResim.SizeMode = PictureBoxSizeMode.StretchImage;

            return;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            DegistirilmisResim.SizeMode = PictureBoxSizeMode.Zoom;

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