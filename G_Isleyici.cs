public class GI
{
    public enum RenkKanallari { Kirmizi, Yesil, Mavi, Gri, TumKanallar};
    public static void ResimAc(PictureBox Secilen_Kutu)
    {
        OpenFileDialog DosyaAcici = new()
        {
            Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*",
            Title = "Resim Seç"
        };

        // Don't do anything if user didn't pick a file.
        if (DosyaAcici.ShowDialog() == DialogResult.OK)
        {
            // Create a FileStream from specified path.
            FileStream DosyaAkisi = new(DosyaAcici.FileName, FileMode.Open);


            // Get Image from FileStream.
            Image DosyadanResim = Image.FromStream(DosyaAkisi);

            // Put the Image to the heap.
            Bitmap HafizadanResim = new(DosyadanResim);

            // Release the Image and close the FileStream.
            DosyadanResim.Dispose();
            DosyaAkisi.Close();

            // Finally set the dynamically allocated image to Picturebox.
            ResimDegistir(Secilen_Kutu, HafizadanResim);
        }

        // Release resources.
        DosyaAcici.Dispose();

        return;
    }
    public static void ResimKaydet(PictureBox Secilen_Kutu)
    {
        SaveFileDialog DosyaKaydedici = new()
        {
            DefaultExt = "\".PNG\"",
            Filter = "\"Jpeg Resmi|*.jpg|Bitmap Resmi|*.bmp|Gif Resmi|*.gif|Png Resmi|*.png\"",
            Title = "Resmi Kaydet"
        };

        // Don't do anything if user didn't pick a location.
        if (DosyaKaydedici.ShowDialog() == DialogResult.OK)
        {
            // Create a FileStream from specified path.
            FileStream DosyaAkisi = new(DosyaKaydedici.FileName, FileMode.Create);

            switch (DosyaKaydedici.FilterIndex)
            {
                case 1:
                        Secilen_Kutu.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Jpeg); break;
                case 2:
                        Secilen_Kutu.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Bmp); break;
                case 3:
                        Secilen_Kutu.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Gif); break;
                case 4:
                        Secilen_Kutu.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Png); break;
            }

            // Close the stream. 
            DosyaAkisi.Close();
        }

        // Release resources.
        DosyaKaydedici.Dispose();

        return;
    }
    public static void ResimDegistir(PictureBox Degisecek_Kutu, Image Yeni_Resim)
    {
        // Get reference of Image from selected PictureBox.
        Image Gecici_resim = Degisecek_Kutu.Image;

        // Change the PictureBox content.
        Degisecek_Kutu.Image = Yeni_Resim;

        // Release previous Image.
        Gecici_resim?.Dispose();

        return;
    }
    public static Bitmap ResminNegatifiniAl(PictureBox Orjinal)
    {
        // Create a Bitmap of original image to be used in function.
        Bitmap DuzenlenecekResim = new(Orjinal.Image);

        // Create a Color to use in function.
        Color yeni_renk;


        // Define loop parameters outside for performance.
        int x, y;
        int x_limit = Orjinal.Image.Width;
        int y_limit = Orjinal.Image.Height;
        

        for (y = 0; y < y_limit; y++)
        {
            for (x = 0; x < x_limit; x++)
            {
                // Get the pixel.
                yeni_renk = DuzenlenecekResim.GetPixel(x, y);

                // Get the inverse of that pixel.
                yeni_renk = Color.FromArgb((byte)~yeni_renk.R, (byte)~yeni_renk.G, (byte)~yeni_renk.B);

                // Set the new pixel.
                DuzenlenecekResim.SetPixel(x, y, yeni_renk);
            }
        }

        // Return the dynamically allocated Bitmap.
        return DuzenlenecekResim;
    }
    public static Bitmap GriSkalaOlustur(int skala_boyutu)
    {
        // Create a Bitmap of original image to be used in function.
        Bitmap GriSkalaResmi = new(skala_boyutu, skala_boyutu);

        // Create a Color to use in function.
        Color gri_tonu = Color.FromArgb(0, 0, 0);

        // Initial color value.
        decimal gri_degeri = 0;

        // Calculate color increment.
        decimal artis_miktari = 255 / (decimal)skala_boyutu;

        // Define loop parameters outside for performance.
        int x, y;

        for (x = 0; x < skala_boyutu; x++)
        {
            for (y = 0; y < skala_boyutu; y++)
            {
                // Set the pixel.
                GriSkalaResmi.SetPixel(x, y, gri_tonu);
            }

            // Increment the color.
            if (gri_degeri < 255) 
            {
                // Increment the color.
                gri_degeri += artis_miktari;

                // Update the color.
                gri_tonu = Color.FromArgb((int)gri_degeri, (int)gri_degeri, (int)gri_degeri);
            }
        }

        // Return the dynamically allocated Bitmap.
        return GriSkalaResmi;
    }
    public static Bitmap DaireOlustur(int daire_cozunurluk)
    {
        // Create Bitmap of specified size.
        Bitmap DaireResmi = new(daire_cozunurluk, daire_cozunurluk);

        for (int y = 0; y < daire_cozunurluk; y++)
        {
            for (int x = 0; x < daire_cozunurluk; x++)
            {
                // Apply mathematical function.
                if (Math.Pow(Math.Abs(x - (double)daire_cozunurluk / 2), 2) + Math.Pow(Math.Abs(y - (double)daire_cozunurluk / 2), 2) < 10000)
                {
                    // Place white if its on the circle. 
                    DaireResmi.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
                else
                {
                    // Place black if its outside the circle. 
                    DaireResmi.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                }
            }
        }

        // Return the dynamically allocated Bitmap.
        return DaireResmi;
    }
    /*
    public static Bitmap ResmiOrnekle(PictureBox Orjinal , int ornekleme_sikligi, int renk_ornekleme_sikligi)
    {
        // Define local function to not clutter rest of the function.
        Color renkOrnekle(Color girdi, renk_ornekleme_sikligi)
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
        
        // Create a Bitmap of original image to be used in function.
        Bitmap OrjinalResim = new(Orjinal.Image);

        // Variables to not clutter the function.
        int genislik = Orjinal.Image.Width;
        int yukseklik = Orjinal.Image.Height;

        // Create the result Bitmap.
        Bitmap OrneklenmisResim = new(genislik / ornekleme_sikligi, yukseklik / ornekleme_sikligi);

        // Create a Color to use in function.
        Color orneklenecek_renk;

        // Define loop parameters outside for performance.
        int x, y;

        for (y = 0; y < yukseklik / ornekleme_sikligi; y++)
        {
            for (x = 0; x < genislik / ornekleme_sikligi; x++)
            {
                orneklenecek_renk = OrjinalResim.GetPixel(x * ornekleme_sikligi, y * ornekleme_sikligi);

                OrneklenmisResim.SetPixel(x, y, renkOrnekle(orneklenecek_renk));
            }
        }

        // Release the resources.
        OrjinalResim.Dispose();

        // Return the dynamically allocated Bitmap.
        return OrneklenmisResim;
    }
    */

    public static Bitmap ParlaklikDegistir(PictureBox DegisecekKutu, int Parlaklik_Degeri)
    {
        // Create a Bitmap of original image to be used in function.
        Bitmap DuzenlenecekResim = new(DegisecekKutu.Image);

        // Create a Color to use in function.
        Color yeni_renk;
        int R, G, B;

        // Define loop parameters outside for performance.
        int x, y;
        int x_limit = DegisecekKutu.Image.Width;
        int y_limit = DegisecekKutu.Image.Height;
        

        for (y = 0; y < y_limit; y++)
        {
            for (x = 0; x < x_limit; x++)
            {
                // Get the pixel.
                yeni_renk = DuzenlenecekResim.GetPixel(x, y);

                // Get the altered values.
                R = yeni_renk.R + Parlaklik_Degeri;
                G = yeni_renk.G + Parlaklik_Degeri;
                B = yeni_renk.B + Parlaklik_Degeri;

                // Check if the values are in range.
                if (R > 255) { R = 255; } else if (R < 0) { R = 0; }
                if (G > 255) { G = 255; } else if (G < 0) { G = 0; }
                if (B > 255) { B = 255; } else if (B < 0) { B = 0; }
                
                // Set the new pixel.
                DuzenlenecekResim.SetPixel(x, y, Color.FromArgb(R, G, B));
            }
        }

        // Return the dynamically allocated Bitmap.
        return DuzenlenecekResim;
    }
    public static Bitmap HistogramOlustur(PictureBox KaynakKutu, PictureBox HedefKutu, RenkKanallari KanalSecimi)
    {

        // Create a Bitmap of original image to be used in function.
        Bitmap DuzenlenecekResim = new(KaynakKutu.Image);
        Bitmap HistogramResmi = new(HedefKutu.Width, HedefKutu.Height);

        // Create a Color to use in function.
        Color yeni_renk;

        // Various definitions.
        int[] ayni_ton_piksel_sayisi = new int[256];
        int histogram_yuksekligi = 0;
        

        // Iterate every pixel on the image and get the grey tone amount.
        for (int y = 0; y < DuzenlenecekResim.Height; y++)
        {
            for (int x = 0; x < DuzenlenecekResim.Width; x++)
            {
                yeni_renk = DuzenlenecekResim.GetPixel(x, y);

                switch (KanalSecimi)
                {
                    case RenkKanallari.Kirmizi:
                        ayni_ton_piksel_sayisi[yeni_renk.R]++;
                        break;
                    case RenkKanallari.Yesil:
                        ayni_ton_piksel_sayisi[yeni_renk.G]++;
                        break;
                    case RenkKanallari.Mavi:
                        ayni_ton_piksel_sayisi[yeni_renk.B]++;
                        break;
                    case RenkKanallari.Gri:
                        ayni_ton_piksel_sayisi[(yeni_renk.R + yeni_renk.G + yeni_renk.B) / 3]++;
                        break;
                }
            }
        }

        /*
        // Iterate over indices to find our histograms height.
        for (int x = 1; x < 255; x++)
        {
            if (ayni_ton_piksel_sayisi[x] > histogram_yuksekligi)
            {
                histogram_yuksekligi = ayni_ton_piksel_sayisi[x];
            }
        }
        */

        // Define our pens and drawboard.
        Graphics HistogramCizimi = Graphics.FromImage(HistogramResmi);
        Pen OlcekKalemi = new(Color.Red, 1);
        Pen Degerkalemi = new(Color.Black, 1);

        // Define our scales.
        double OlcekY = 8192 / HedefKutu.Height; // 500 was histogram_yuksekligi.
        double OlcekX = HedefKutu.Width / 256;

        // Draw the histogram.
        for (int x = 0; x < 256; x++)
        {
            if (x % 63 == 0)
            {
                // Red lines every 64 pixels.
                HistogramCizimi.DrawLine(OlcekKalemi, (int) (x * OlcekX), 0, (int)(x * OlcekX), HedefKutu.Width);
            }

            // Actual histogram drawing.
            HistogramCizimi.DrawLine(Degerkalemi, (int)(x * OlcekX), HedefKutu.Height, (int)(x * OlcekX), HedefKutu.Height - (int)(ayni_ton_piksel_sayisi[x] / OlcekY));         
        }

        // Free the resources.
        HistogramCizimi.Dispose();
        OlcekKalemi.Dispose();
        Degerkalemi.Dispose();

        return HistogramResmi;
    }
    public static Bitmap ResmiEsikle(PictureBox KaynakKutu, int kirmizi_taban_esik, int kirmizi_tavan_esik
                                                          , int yesil_taban_esik, int yesil_tavan_esik
                                                          , int mavi_taban_esik, int mavi_tavan_esik      
                                                          , RenkKanallari KanalSecimi)
    {
        // Create a Bitmap of original image to be used in function.
        Bitmap DuzenlenecekResim = new(KaynakKutu.Image);

        // Create a Color to use in function.
        Color yeni_renk;

        // Define loop parameters outside for performance.
        int x, y;
        int x_limit = KaynakKutu.Image.Width;
        int y_limit = KaynakKutu.Image.Height;
        int R, G, B;


        for (y = 0; y < y_limit; y++)
        {
            for (x = 0; x < x_limit; x++)
            {
                // Get the pixel.
                yeni_renk = DuzenlenecekResim.GetPixel(x, y);

                R = yeni_renk.R;
                G = yeni_renk.G;
                B = yeni_renk.B;

                switch (KanalSecimi)
                {
                    case RenkKanallari.Kirmizi:
                        // Set the channel to 0 if its not within thresholds.
                        if (yeni_renk.R < kirmizi_taban_esik || yeni_renk.R > kirmizi_tavan_esik) R = 0;

                        // Set the pixel black if its not within thresholds.
                        DuzenlenecekResim.SetPixel(x, y, Color.FromArgb(R, G, B));
                        break;

                    case RenkKanallari.Yesil:
                        // Set the channel to 0 if its not within thresholds.
                        if (yeni_renk.G < kirmizi_taban_esik || yeni_renk.G > kirmizi_tavan_esik) G = 0;

                        // Set the pixel black if its not within thresholds.
                        DuzenlenecekResim.SetPixel(x, y, Color.FromArgb(R, G, B));
                        break;

                    case RenkKanallari.Mavi:
                        // Set the channel to 0 if its not within thresholds.
                        if (yeni_renk.B < kirmizi_taban_esik || yeni_renk.B > kirmizi_tavan_esik) B = 0;

                        // Set the pixel black if its not within thresholds.
                        DuzenlenecekResim.SetPixel(x, y, Color.FromArgb(R, G, B));
                        break;

                    case RenkKanallari.Gri:
                        // Assuming R = G = B.
                        if (yeni_renk.R < kirmizi_taban_esik || yeni_renk.R > kirmizi_tavan_esik) R = 0;

                        // Set the pixel black if its not within thresholds.
                        DuzenlenecekResim.SetPixel(x, y, Color.FromArgb(R, R, R));
                        break;

                    case RenkKanallari.TumKanallar:

                        // Compare against thresholds then set the color black if its not within thresholds.
                        if (yeni_renk.R < kirmizi_taban_esik || yeni_renk.R > kirmizi_tavan_esik) R = 0;
                        if (yeni_renk.G < yesil_taban_esik || yeni_renk.G > yesil_tavan_esik) G = 0;
                        if (yeni_renk.B < mavi_taban_esik || yeni_renk.B > mavi_tavan_esik) B = 0;

                        // Set the pixel with new values.
                        DuzenlenecekResim.SetPixel(x, y, Color.FromArgb(R, G, B));
                        break;
                }
            }
        }

        // Return the dynamically allocated Bitmap.
        return DuzenlenecekResim;
    }
}