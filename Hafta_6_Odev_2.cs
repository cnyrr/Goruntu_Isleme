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

namespace Görüntü_İşleme
{
    public partial class Hafta_6_Odev_2 : Form
    {
        public Hafta_6_Odev_2()
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
            ApplyBlurFilter(trackBar1.Value);
        }

        private void ApplyBlurFilter(int matrixSize)
        {
            if (pictureBox1 != null)
            {
                // Resmi kopyala
                Bitmap processedImage = new Bitmap(pictureBox1.Image);

                // Bulanıklık filtresi uygula
                using (Graphics g = Graphics.FromImage(processedImage))
                {
                    ColorMatrix colorMatrix = new ColorMatrix(GetBlurMatrix(matrixSize));
                    ImageAttributes attributes = new ImageAttributes();
                    attributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                    g.DrawImage(pictureBox1.Image, new Rectangle(0, 0, processedImage.Width, processedImage.Height),
                        0, 0, pictureBox1.Width, pictureBox1.Height, GraphicsUnit.Pixel, attributes);
                }

                // İşlenmiş resmi göster
                pictureBox2.Image = processedImage;
            }
            else
            {
                MessageBox.Show("Please select an image first.");
            }
        }

        private float[][] GetBlurMatrix(int matrixSize)
        {
            // Matris boyutunu temsil eden bir matris oluştur
            float[][] matrix = new float[matrixSize][];
            float value = 1.0f / (matrixSize * matrixSize);

            for (int i = 0; i < matrixSize; i++)
            {
                matrix[i] = new float[matrixSize];
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i][j] = value;
                }
            }

            return matrix;
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
