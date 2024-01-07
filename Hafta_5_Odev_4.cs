using System.Drawing.Imaging;

namespace Görüntü_İşleme
{
    public partial class Hafta_5_Odev_4 : Form
    {
        private Bitmap originalImage;

        public Hafta_5_Odev_4()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları|*.bmp;*.jpg;*.jpeg;*.png;*.gif|Tüm Dosyalar|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen resmi PictureBox'a yükle
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (double sigma in new double[] { 3.0 })   // İstenilen tek tam sayı değeri girilebirlir.
            {
                Bitmap filteredImage = ApplyGaussianFilter(originalImage, sigma);
                filteredImage.Save($"output_image_sigma_{sigma}.jpg", ImageFormat.Jpeg);
            }

            MessageBox.Show("İşlem tamamlandı. Çıkış görüntüleri kaydedildi.");


        }

        private Bitmap ApplyGaussianFilter(Bitmap image, double sigma)
        {
            Bitmap Girişresmi;
            image = new Bitmap(pictureBox1.Image);
            int width = image.Width;
            int height = image.Height;



            Bitmap filteredImage = new Bitmap(width, height);

            // Görüntüyü işlemek için veri dizileri
            double[,] kernel = GenerateGaussianKernel(sigma);
            int kernelSize = kernel.GetLength(0);
            int radius = kernelSize / 2;

            // Görüntüyü döngüyle tarayarak Gauss filtresini uygula
            for (int x = radius; x < width - radius; x++)
            {
                for (int y = radius; y < height - radius; y++)
                {
                    double sum = 0;

                    // Konvolüsyon işlemi
                    for (int i = 0; i < kernelSize; i++)
                    {
                        for (int j = 0; j < kernelSize; j++)
                        {
                            Color pixelColor = image.GetPixel(x + i - radius, y + j - radius);
                            sum += kernel[i, j] * pixelColor.R; // Sadece kırmızı kanal üzerinde işlem yapılıyor
                        }
                    }

                    // Yeni piksel değerini atanıyor
                    int newValue = (int)Math.Min(Math.Max(sum, 0), 255);
                    filteredImage.SetPixel(x, y, Color.FromArgb(newValue, newValue, newValue));
                }
            }
            pictureBox2.Image = filteredImage;
            return (Bitmap)pictureBox2.Image;
        }
        static double[,] GenerateGaussianKernel(double sigma)
        {
            int size = (int)(6 * sigma) + 1;
            size = (size % 2 == 0) ? size + 1 : size; // Kernel boyutunu tek sayı yap

            double[,] kernel = new double[size, size];
            int halfSize = size / 2;

            double sum = 0;

            for (int i = -halfSize; i <= halfSize; i++)
            {
                for (int j = -halfSize; j <= halfSize; j++)
                {
                    kernel[i + halfSize, j + halfSize] = Math.Exp(-(i * i + j * j) / (2 * sigma * sigma)) / (2 * Math.PI * sigma * sigma);
                    sum += kernel[i + halfSize, j + halfSize];
                }
            }

            // Normalize et
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    kernel[i, j] /= sum;
                }
            }

            return kernel;
            //standart sapma değer arttıkça resim bulanıklaşıyor.
        }
    }
}
