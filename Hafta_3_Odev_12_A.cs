namespace Görüntü_İşleme
{
    public partial class Hafta_3_Odev_12_A : Form
    {
        public Hafta_3_Odev_12_A()
        {
            InitializeComponent();
        }
        public Bitmap Dondurme()
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int Aci = Convert.ToInt16(textBox1.Text);
            double RadyanAci = Aci * 2 * Math.PI / 360;
            double x2 = 0, y2 = 0;
            //Resim merkezini buluyor. Resim merkezi etrafýnda döndürecek.
            int x0 = ResimGenisligi / 2;
            int y0 = ResimYuksekligi / 2;
            for (int x1 = 0; x1 < (ResimGenisligi); x1++)
            {
                for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);
                    //Döndürme Formülleri
                    x2 = Math.Cos(RadyanAci) * (x1 - x0) - Math.Sin(RadyanAci) * (y1 - y0) + x0;
                    y2 = Math.Sin(RadyanAci) * (x1 - x0) + Math.Cos(RadyanAci) * (y1 - y0) + y0;
                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }
            return CikisResmi;
        }


        public Bitmap Dondurme_Alias()
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int Aci = Convert.ToInt16(textBox1.Text);
            double RadyanAci = Aci * 2 * Math.PI / 360;
            double x2 = 0, y2 = 0;
            //Resim merkezini buluyor. Resim merkezi etrafýnda döndürecek.
            int x0 = ResimGenisligi / 2;
            int y0 = ResimYuksekligi / 2;
            for (int x1 = 0; x1 < (ResimGenisligi); x1++)
            {
                for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);
                    //Aliaslý Döndürme -Saða Kaydýrma
                    x2 = (x1 - x0) - Math.Tan(RadyanAci / 2) * (y1 - y0) + x0;
                    y2 = (y1 - y0) + y0;
                    x2 = Convert.ToInt16(x2);
                    y2 = Convert.ToInt16(y2);
                    //Aliaslý Döndürme -Aþaðý kaydýrma
                    x2 = (x2 - x0) + x0;
                    y2 = Math.Sin(RadyanAci) * (x2 - x0) + (y2 - y0) + y0;
                    x2 = Convert.ToInt16(x2);
                    y2 = Convert.ToInt16(y2);
                    //Aliaslý Döndürme -Saða Kaydýrma
                    x2 = (x2 - x0) - Math.Tan(RadyanAci / 2) * (y2 - y0) + x0;
                    y2 = (y2 - y0) + y0;
                    x2 = Convert.ToInt16(x2);
                    y2 = Convert.ToInt16(y2);
                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }


            return CikisResmi;
        }


        public Color GetAverageColor(Bitmap image, int x, int y)
        {
            int totalRed = 0;
            int totalGreen = 0;
            int totalBlue = 0;

            for (int offsetY = -1; offsetY <= 1; offsetY++)
            {
                for (int offsetX = -1; offsetX <= 1; offsetX++)
                {
                    Color neighborColor = image.GetPixel(x + offsetX, y + offsetY);

                    totalRed += neighborColor.R;
                    totalGreen += neighborColor.G;
                    totalBlue += neighborColor.B;
                }
            }

            // Ortalamayý al
            int averageRed = totalRed / 9;
            int averageGreen = totalGreen / 9;
            int averageBlue = totalBlue / 9;

            return Color.FromArgb(averageRed, averageGreen, averageBlue);
        }




        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Dondurme();
            Bitmap cks_rsm = new Bitmap(pictureBox2.Image);
            for (int i = 1; i < pictureBox2.Image.Width - 1; i++)
            {
                for (int j = 1; j < pictureBox2.Image.Height - 1; j++)
                {
                    Color pixel_color = cks_rsm.GetPixel(i, j);

                    if (pixel_color.R == 0 && pixel_color.G == 0 && pixel_color.B == 0)
                    {
                        Color avgcolor = GetAverageColor(cks_rsm, i, j);
                        cks_rsm.SetPixel(i, j, avgcolor);

                    }

                }
            }


            pictureBox3.Image = cks_rsm;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyasý |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }
    }
}
