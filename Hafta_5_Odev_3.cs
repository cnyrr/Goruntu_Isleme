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
    public partial class Hafta_5_Odev_3 : Form
    {

        public Hafta_5_Odev_3()
        {
            InitializeComponent();
        }

        private Point startPoint;
        private Point endPoint;
        private bool isDrawing;
        private int x_baslangic_noktasi, y_baslangic_noktasi;
        private int x_bitme_noktasi, y_bitme_noktasi;



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


        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            endPoint = e.Location;
            isDrawing = true;


            (sender as PictureBox).Invalidate();
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;


                (sender as PictureBox).Invalidate();
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing)
            {

                using (Pen pen = new Pen(Color.Red, 2))
                {
                    e.Graphics.DrawRectangle(pen, GetCropRectangle());
                }
            }
        }

        private Rectangle GetCropRectangle()
        {
            int x = Math.Min(startPoint.X, endPoint.X);
            x_baslangic_noktasi = x;
            int y = Math.Min(startPoint.Y, endPoint.Y);
            y_baslangic_noktasi = y;
            int width = Math.Abs(startPoint.X - endPoint.X);
            x_bitme_noktasi = x + width;
            int height = Math.Abs(startPoint.Y - endPoint.Y);
            y_bitme_noktasi = y + height;
            return new Rectangle(x, y, width, height);
        }

        private void CropImage(PictureBox pictureBox)
        {

            Rectangle cropRectangle = GetCropRectangle();
            Bitmap originalImage = new Bitmap(pictureBox1.Image);
            Bitmap croppedImage = originalImage.Clone(cropRectangle, originalImage.PixelFormat);



            pictureBox2.Image = croppedImage;


            pictureBox2.Size = cropRectangle.Size;


        }








        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.MouseDown += PictureBox_MouseDown;
            pictureBox1.MouseMove += PictureBox_MouseMove;
            pictureBox1.MouseUp += PictureBox_MouseUp;
            pictureBox1.Paint += PictureBox_Paint;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApplySimpleBlur(pictureBox2.Image);
            //textbox içerisine tek haneli değer girilmelidir.//
        }


        







        private void ApplySimpleBlur( Image girdi )
        {




            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(pictureBox1.Image);
            int SablonBoyutu = Convert.ToInt32(textBox1.Text); //şablon boyutu 3 den büyük tek rakam olmalıdır (3,5,7 gibi).
            int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;

            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    if (x < x_baslangic_noktasi || x > x_bitme_noktasi || y < y_baslangic_noktasi || y > y_bitme_noktasi)
                    {
                        continue;
                    }

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
            pictureBox2.Image = CikisResmi;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
