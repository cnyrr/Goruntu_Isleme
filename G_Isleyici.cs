using System.Xml.Serialization;

class Goruntu_Isleyici
{
    public static void resimAc(PictureBox Secilen_Kutu)
    {
        OpenFileDialog DosyaAcici = new()
        {
            DefaultExt = ".png",
            Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
        };

        DosyaAcici.ShowDialog();

        if (DosyaAcici.FileName != "")
        {
            resimDegistir(Secilen_Kutu, Image.FromFile(DosyaAcici.FileName));   
        }

        DosyaAcici.Dispose();

        return;
    }
    public static void resimDegistir(PictureBox Degisecek_Kutu, Image Yeni_Resim)
    {
        Image Gecici_resim = Degisecek_Kutu.Image;
        Degisecek_Kutu.Image = Yeni_Resim;

        if (Gecici_resim != null)
        {
            Gecici_resim.Dispose();
        }

        return;
    }
    public static Bitmap resminNegatifiniAl(PictureBox Orjinal)
    {
        Bitmap DuzenlenecekResim = new(Orjinal.Image);
        Color yeni_renk;
        byte R, G, B;

        for (int y = 0; y < Orjinal.Image.Height; y++)
        {
            for (int x = 0; x < Orjinal.Image.Width; x++)
            {
                yeni_renk = DuzenlenecekResim.GetPixel(x, y);

                R = (byte)~yeni_renk.R;
                G = (byte)~yeni_renk.G;
                B = (byte)~yeni_renk.B;

                yeni_renk = Color.FromArgb(R, G, B);

                DuzenlenecekResim.SetPixel(x, y, yeni_renk);
            }
        }

        return DuzenlenecekResim;
    }
}