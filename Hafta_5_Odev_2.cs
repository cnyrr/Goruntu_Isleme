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
    public partial class Hafta_5_Odev_2 : Form
    {
        public Hafta_5_Odev_2()
        {
            InitializeComponent();
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
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int red = 0, blue = 0, green = 0, alpha = 0;
        int blurPixelCount = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bmp2, pictureBox1.ClientRectangle);
            Bitmap blurimg = new Bitmap(pictureBox2.Width, pictureBox2.Height);

            for (int i = Convert.ToInt32(textBox1.Text); i < bmp2.Width - Convert.ToInt32(textBox1.Text); i++)
            {

                for (int j = Convert.ToInt32(textBox1.Text); j < bmp2.Height - Convert.ToInt32(textBox1.Text); j++)
                {

                    Color clr = new Color();
                    for (int k = i - Convert.ToInt32(textBox1.Text); k <= i + Convert.ToInt32(textBox1.Text); k++)
                    {
                        for (int l = j - Convert.ToInt32(textBox1.Text); l <= j + Convert.ToInt32(textBox1.Text); l++)
                        {
                            red += bmp2.GetPixel(k, l).R;
                            green += bmp2.GetPixel(k, l).G;
                            blue += bmp2.GetPixel(k, l).B;
                            //test
                            blurPixelCount++;

                        }
                    }
                    red = red / blurPixelCount;
                    green = green / blurPixelCount;
                    blue = blue / blurPixelCount;
                    clr = Color.FromArgb(red, green, blue);
                    blurimg.SetPixel(i, j, clr);
                    red = 0;
                    blue = 0; green = 0; alpha = 0; blurPixelCount = 0;

                }
            }
            pictureBox2.Image = (Image)blurimg;
        }
    }
}
