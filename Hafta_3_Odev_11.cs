using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Görüntü_İşleme
{
    public partial class Hafta_3_Odev_11 : Form
    {



        public Hafta_3_Odev_11()
        {
            InitializeComponent();
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
            for (int x1 = 0; x1 < ResimGenisligi; x1++)
            {
                for (int y1 = 0; y1 < ResimYuksekligi; y1++)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Dondurme_Alias();
            Bitmap cks_rsm = new Bitmap(pictureBox2.Image);
            for (int i = 1; i < pictureBox2.Image.Width - 1; i++)
            {
                for (int j = 1; j < pictureBox2.Image.Height - 1; j++)
                {
                    Color pixel_color = cks_rsm.GetPixel(i, j);



                }
            }


            pictureBox2.Image = cks_rsm;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            button2.Enabled = false;
            button1.Enabled = true;


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            button2.Enabled = true;
            button1.Enabled = false;
        }
        public Bitmap Dondurme_Alias_angle()
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int Aci = 50;
            double RadyanAci = Aci * 2 * Math.PI / 360;
            double x2 = 0, y2 = 0;
            //Resim merkezini buluyor. Resim merkezi etrafýnda döndürecek.
            int x0 = ResimGenisligi / 2;
            int y0 = ResimYuksekligi / 2;
            for (int x1 = 0; x1 < ResimGenisligi; x1++)
            {
                for (int y1 = 0; y1 < ResimYuksekligi; y1++)
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
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Dondurme_Alias_angle();
            Bitmap cks_rsm = new Bitmap(pictureBox2.Image);
            for (int i = 1; i < pictureBox2.Image.Width - 1; i++)
            {
                for (int j = 1; j < pictureBox2.Image.Height - 1; j++)
                {
                    Color pixel_color = cks_rsm.GetPixel(i, j);



                }
            }


            pictureBox2.Image = cks_rsm;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyasý |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";

            if (dosya.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = dosya.FileName;
                pictureBox1.ImageLocation = DosyaYolu;
            }
        }
    }
}
