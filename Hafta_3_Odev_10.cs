using System.Windows.Forms;

namespace Görüntü_İşleme
{
    public partial class Hafta_3_Odev_10 : Form
    {

        private Point startPoint;
        private bool isMouseDown = false;
        private double initialAngle = 0.0;

        
        

        public Hafta_3_Odev_10()
        {
            InitializeComponent();
            
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
        }



        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                startPoint = e.Location;
                
            }
        }
        

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (isMouseDown)
            {
                Point currentPoint = e.Location;

                int deltaX = currentPoint.X - startPoint.X;
                int deltaY = currentPoint.Y - startPoint.Y;

                double angle = Math.Atan2(deltaY, deltaX) * 180.0 / Math.PI;
                Dondurme(angle-initialAngle);
                textBox1.Text= (angle).ToString();

                startPoint = currentPoint;
                initialAngle = angle;

                // PictureBox'u yeniden çiz
                pictureBox1.Invalidate();


            }


        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;

                
               
               
            }
            double a = Convert.ToDouble(textBox1.Text);
            pictureBox2.Image = Dondurme2(-a);



        }
        public Bitmap Dondurme2(double angle)
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int Aci = Convert.ToInt16(angle);
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
                    {
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);


                    }


                }
            }
            return CikisResmi;
        }

        private void Dondurme(double angle)
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int Aci = Convert.ToInt16(angle);
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
                    {
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);

                        
                    }


                }
            }
            Pen framePen = new Pen(Color.Red, 2);

            // PictureBox'a çerçeve çiz
            using (Graphics g = Graphics.FromImage(CikisResmi))
            {
                g.DrawRectangle(framePen, 0, 0, CikisResmi.Width - 1, CikisResmi.Height - 1);
            }

            pictureBox1.Image = CikisResmi;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyasý |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation= ofd.FileName;
            }
        }
    }
}
