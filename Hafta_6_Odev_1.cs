using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Görüntü_İşleme
{
    public partial class Hafta_6_Odev_1 : Form
    {

        public Hafta_6_Odev_1()
        {
            InitializeComponent();
        }

        private void resimyukle_Click(object sender, EventArgs e)
        {
            DosyaAc();
        }
        public void DosyaAc()
        {
            try
            {
                openFileDialog1.DefaultExt = ".jpg";
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                string ResminYolu = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(ResminYolu);
            }
            catch { }
        }

        private void resimkaydet_Click(object sender, EventArgs e)
        {
            ResmiKaydet();
        }
        public void ResmiKaydet()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Jpeg Resmi|*.jpg|Bitmap Resmi|*.bmp|Gif Resmi|*.gif";
            saveFileDialog1.Title = "Resmi Kaydet";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "") //Dosya adı boş değilse kaydedecek.
            {
                // FileStream nesnesi ile kayıtı gerçekleştirecek.
                FileStream DosyaAkisi = (FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        pictureBox2.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Jpeg); break;
                    case 2:
                        pictureBox2.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Bmp); break;
                    case 3:
                        pictureBox2.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Gif); break;
                }
                DosyaAkisi.Close();
            }
        }




        private void uygula_Click(object sender, EventArgs e)
        {
            if (mean.Checked == true)
            {
                Bitmap OrjinalResim = new Bitmap(pictureBox1.Image);
                Bitmap BulanikResim = meanFiltresi();
                //Bitmap BulanikResim = GaussFiltresi();
                Bitmap KenarGoruntusu = OrjianalResimdenBulanikResmiCikarma(OrjinalResim, BulanikResim);
                Bitmap NetlesmisResim = KenarGoruntusuIleOrjinalResmiBirlestir(OrjinalResim, KenarGoruntusu);
                pictureBox2.Image = NetlesmisResim;
            }
            else if (median.Checked == true)
            {
                Bitmap filteredImage = ApplyMedianFilter((Bitmap)pictureBox1.Image);
                pictureBox2.Image = filteredImage;

            }
            else if (gauss.Checked == true)
            {

                // Resmi Gauss filtresi ile netleştir
                Bitmap sharpenedImage = ApplyGaussianBlur((Bitmap)pictureBox1.Image, 5); // 5, filtre boyutunu temsil eder
                pictureBox2.Image = sharpenedImage;
            }
            else
            {

                MessageBox.Show("Yöntem Seçiniz");
            }
        }
        static Bitmap ApplyMedianFilter(Bitmap inputImage)
        {
            int width = inputImage.Width;
            int height = inputImage.Height;

            Bitmap outputImage = new Bitmap(width, height);

            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    Color[] neighbors = GetNeighbors(inputImage, x, y);
                    Color medianColor = GetMedianColor(neighbors);

                    outputImage.SetPixel(x, y, medianColor);
                }
            }

            return outputImage;
        }
        public Bitmap meanFiltresi()
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int SablonBoyutu = Convert.ToInt32(textBox1.Text); //şablon boyutu 3 den büyük tek rakam olmalıdır (3,5,7 gibi).
            int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;
            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    toplamR = 0;
                    toplamG = 0;
                    toplamB = 0;
                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                            toplamR = toplamR + OkunanRenk.R;
                            toplamG = toplamG + OkunanRenk.G;
                            toplamB = toplamB + OkunanRenk.B;
                        }
                    }
                    ortalamaR = toplamR / (SablonBoyutu * SablonBoyutu);
                    ortalamaG = toplamG / (SablonBoyutu * SablonBoyutu);
                    ortalamaB = toplamB / (SablonBoyutu * SablonBoyutu);
                    CikisResmi.SetPixel(x, y, Color.FromArgb(ortalamaR, ortalamaG, ortalamaB));
                }
            }
            return CikisResmi;
        }


        public Bitmap OrjianalResimdenBulanikResmiCikarma(Bitmap OrjinalResim, Bitmap BulanikResim)
        {
            Color OkunanRenk1, OkunanRenk2, DonusenRenk; Bitmap CikisResmi;
            int ResimGenisligi = OrjinalResim.Width;
            int ResimYuksekligi = OrjinalResim.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int R, G, B;
            double Olcekleme = 2; //Keskin kenaları daha iyi görmek için değerini artırıyoruz. 
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk1 = OrjinalResim.GetPixel(x, y); OkunanRenk2 = BulanikResim.GetPixel(x, y);
                    R = Convert.ToInt16(Olcekleme * Math.Abs(OkunanRenk1.R - OkunanRenk2.R));
                    G = Convert.ToInt16(Olcekleme * Math.Abs(OkunanRenk1.G - OkunanRenk2.G));
                    B = Convert.ToInt16(Olcekleme * Math.Abs(OkunanRenk1.B - OkunanRenk2.B));
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (R < 0) R = 0; if (G < 0) G = 0; if (B < 0) B = 0;
                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            return CikisResmi;
        }

        public Bitmap KenarGoruntusuIleOrjinalResmiBirlestir(Bitmap OrjinalResim, Bitmap KenarGoruntusu)
        {
            Color OkunanRenk1, OkunanRenk2, DonusenRenk; Bitmap CikisResmi;
            int ResimGenisligi = OrjinalResim.Width; int ResimYuksekligi = OrjinalResim.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int R, G, B;
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk1 = OrjinalResim.GetPixel(x, y);
                    OkunanRenk2 = KenarGoruntusu.GetPixel(x, y);
                    R = OkunanRenk1.R + OkunanRenk2.R;
                    G = OkunanRenk1.G + OkunanRenk2.G;
                    B = OkunanRenk1.B + OkunanRenk2.B;
                    //DİKKAT: Burada sınırı aşan değerler NORMALİZASYON yaparak programlanmalıdır.
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;
                    //================================================================
                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            return CikisResmi;
        }
        static Color[] GetNeighbors(Bitmap image, int x, int y)
        {
            Color[] neighbors = new Color[9];

            int index = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    neighbors[index] = image.GetPixel(x + i, y + j);
                    index++;
                }
            }

            return neighbors;
        }

        static Color GetMedianColor(Color[] colors)
        {
            Array.Sort(colors, (a, b) => a.GetBrightness().CompareTo(b.GetBrightness()));

            return colors[colors.Length / 2];
        }
        static Bitmap ApplyCustomFilter(Bitmap inputImage, double[,] kernel)
        {
            // Verilen özel filtreyi uygula
            int kernelSize = kernel.GetLength(0);
            int radius = kernelSize / 2;

            int width = inputImage.Width;
            int height = inputImage.Height;

            Bitmap outputImage = new Bitmap(width, height);

            for (int x = radius; x < width - radius; x++)
            {
                for (int y = radius; y < height - radius; y++)
                {
                    Color newColor = ApplyFilterAtPixel(inputImage, x, y, kernel);
                    outputImage.SetPixel(x, y, newColor);
                }
            }

            return outputImage;
        }

        static Color ApplyFilterAtPixel(Bitmap image, int x, int y, double[,] kernel)
        {
            int kernelSize = kernel.GetLength(0);
            int radius = kernelSize / 2;

            double red = 0.0, green = 0.0, blue = 0.0;

            for (int i = 0; i < kernelSize; i++)
            {
                for (int j = 0; j < kernelSize; j++)
                {
                    Color pixelColor = image.GetPixel(x - radius + i, y - radius + j);
                    double weight = kernel[i, j];

                    red += pixelColor.R * weight;
                    green += pixelColor.G * weight;
                    blue += pixelColor.B * weight;
                }
            }

            red = Math.Min(Math.Max(red, 0), 255);
            green = Math.Min(Math.Max(green, 0), 255);
            blue = Math.Min(Math.Max(blue, 0), 255);

            return Color.FromArgb((int)red, (int)green, (int)blue);
        }
        private Bitmap ApplyGaussianBlur(Bitmap image, int matrixSize)
        {
            Bitmap resultImage = new Bitmap(image);

            int halfMatrixSize = matrixSize / 2;

            double[,] filterMatrix = new double[matrixSize, matrixSize];
            double filterSum = 0;

            // Gauss filtresi oluştur
            for (int x = -halfMatrixSize; x <= halfMatrixSize; x++)
            {
                for (int y = -halfMatrixSize; y <= halfMatrixSize; y++)
                {
                    double value = Math.Exp(-(x * x + y * y) / (2.0 * halfMatrixSize * halfMatrixSize));
                    filterMatrix[x + halfMatrixSize, y + halfMatrixSize] = value;
                    filterSum += value;
                }
            }

            // Normalize et
            for (int x = 0; x < matrixSize; x++)
            {
                for (int y = 0; y < matrixSize; y++)
                {
                    filterMatrix[x, y] /= filterSum;
                }
            }

            // Resmi filtrele
            for (int i = halfMatrixSize; i < image.Width - halfMatrixSize; i++)
            {
                for (int j = halfMatrixSize; j < image.Height - halfMatrixSize; j++)
                {
                    double red = 0, green = 0, blue = 0;

                    for (int x = -halfMatrixSize; x <= halfMatrixSize; x++)
                    {
                        for (int y = -halfMatrixSize; y <= halfMatrixSize; y++)
                        {
                            Color pixel = image.GetPixel(i + x, j + y);
                            red += pixel.R * filterMatrix[x + halfMatrixSize, y + halfMatrixSize];
                            green += pixel.G * filterMatrix[x + halfMatrixSize, y + halfMatrixSize];
                            blue += pixel.B * filterMatrix[x + halfMatrixSize, y + halfMatrixSize];
                        }
                    }

                    red = Math.Min(255, Math.Max(0, red));
                    green = Math.Min(255, Math.Max(0, green));
                    blue = Math.Min(255, Math.Max(0, blue));

                    resultImage.SetPixel(i, j, Color.FromArgb((int)red, (int)green, (int)blue));
                }
            }

            return resultImage;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(pictureBox2.Image);
            Bitmap normalizedImage = NormalizeBitmap(originalImage);
            pictureBox2.Image = normalizedImage;
        }

        private Bitmap NormalizeBitmap(Bitmap inputImage)
        {
            int width = inputImage.Width;
            int height = inputImage.Height;

            Bitmap normalizedImage = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixelColor = inputImage.GetPixel(x, y);

                    float normalizedRed = pixelColor.R / 255.0f;
                    float normalizedGreen = pixelColor.G / 255.0f;
                    float normalizedBlue = pixelColor.B / 255.0f;

                    normalizedImage.SetPixel(x, y, Color.FromArgb((int)(normalizedRed * 255), (int)(normalizedGreen * 255), (int)(normalizedBlue * 255)));
                }
            }

            return normalizedImage;
        }
    }
}

