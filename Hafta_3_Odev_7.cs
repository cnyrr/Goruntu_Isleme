using Microsoft.VisualBasic.Devices;
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
    public partial class Hafta_3_Odev_7 : Form
    {
        List<int> coords = new List<int>();
        private Point kareNoktasi = Point.Empty;
        private List<Point> plusSymbolPoints = new List<Point>();
        public Hafta_3_Odev_7()
        {
            InitializeComponent();
            pictureBox1.Paint += PictureBox_Paint;
            pictureBox1.MouseClick += PictureBox1_MouseClick;

        }

        private void Hafta_3_Odev_7_Load(object sender, EventArgs e)
        {

        }

        
        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the mouse click coordinates
            int mouseX = e.X;
            int mouseY = e.Y;

            coords.Add(mouseX);
            coords.Add(mouseY);
            plusSymbolPoints.Add(new Point(mouseX, mouseY));
            kareNoktasi = e.Location;

            // PictureBox'ı yeniden çiz
            ((PictureBox)sender).Invalidate();
            
            
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Pen pen = new Pen(Color.AntiqueWhite, 2))
            {
                // Set the length of the plus symbol arms
                int armLength = 20;

                // Draw plus symbols at the stored points
                foreach (Point point in plusSymbolPoints)
                {
                    // Draw horizontal arm
                    g.DrawLine(pen, point.X - 10, point.Y, point.X + 10, point.Y);

                    // Draw vertical arm
                    g.DrawLine(pen, point.X, point.Y - 10, point.X, point.Y+10);
                }
            }

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

            //Resim merkezini buluyor. Resim merkezi etrafında döndürecek
            int x0 = coords[0];
            int y0 = coords[1];

            for (int x1 = 0; x1 < ResimGenisligi; x1++)
            {
                for (int y1 = 0; y1 < ResimYuksekligi; y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);
                    //Döndürme Formülleri
                    x2 = Math.Cos(RadyanAci) * (x1 - x0) - Math.Sin(RadyanAci) * (y1 - y0) + x0;
                    y2 = Math.Sin(RadyanAci) * (x1 - x0) + Math.Cos(RadyanAci) * (y1 - y0) + y0;

                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }
            pictureBox1.Image = CikisResmi;
            return CikisResmi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                pictureBox1.Cursor = Cursors.Hand;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Dondurme_Alias();
            plusSymbolPoints.Clear();
        }
    }
}
