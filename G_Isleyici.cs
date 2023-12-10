public class G_Isleyici
{
    public static void ResimAc(PictureBox Secilen_Kutu)
    {
        // Create a OpenFileDialog.
        OpenFileDialog DosyaAcici = new()
        {
            DefaultExt = ".png",
            Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
        };
        
        // Show it.
        DosyaAcici.ShowDialog();

        // Don't do anything if user didn't pick a file.
        if (DosyaAcici.FileName != "")
        {
            try
            {
                ResimDegistir(Secilen_Kutu, Image.FromFile(DosyaAcici.FileName));
            }
            catch
            { 
                // Do nothing if it fails.
            }
        }

        // Release the resources.
        DosyaAcici.Dispose();

        return;
    }

    public static void ResimKaydet(PictureBox Secilen_Kutu)
    {
        // Create a SaveFileDialog.
        SaveFileDialog DosyaKaydedici = new()
        {
            DefaultExt = ".PNG",
            Filter = "Jpeg Resmi|*.jpg|Bitmap Resmi|*.bmp|Gif Resmi|*.gif|Png Resmi|*.png",
            Title = "Resmi Kaydet"
        };

        // Show it.
        DosyaKaydedici.ShowDialog();

        // Don't do anything if user didn't pick a location.
        if (DosyaKaydedici.FileName != "")
        {
            // Create a FileStream or specified path.
            FileStream DosyaAkisi = (FileStream)DosyaKaydedici.OpenFile();

            // Do nothing if stream doesn't have write access.
            if (DosyaAkisi.CanWrite)
            {
                switch (DosyaKaydedici.FilterIndex)
                {
                    case 0:
                        Secilen_Kutu.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Jpeg); break;
                    case 1:
                        Secilen_Kutu.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Bmp); break;
                    case 2:
                        Secilen_Kutu.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Gif); break;
                    case 3:
                        Secilen_Kutu.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Png); break;
                }
            }

            // Close the stream. 
            DosyaAkisi.Close();
        }

        // Release the resources.
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
}