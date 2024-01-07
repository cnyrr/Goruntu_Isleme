using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Görüntü_İşleme
{
    public partial class Hafta_9_Odev_8 : Form
    {
        public Hafta_9_Odev_8()
        {
            InitializeComponent();
        }

        private void AktifEt()
        {
            ResmiKaydetButonu.Enabled = true;
            ResmeEkleButonu.Enabled = true;

            return;
        }

        private void ResimAcButonu_Click(object sender, EventArgs e)
        {
            GI.ResimAc(Orjinal);

            if (Orjinal.Image != null)
            {
                GI.ResimDegistir(Yazili, (System.Drawing.Image)Orjinal.Image.Clone());
                AktifEt();
            }

            return;
        }

        private void ResmeEkleButonu_Click(object sender, EventArgs e)
        {
            Bitmap DuzenlenecekResim = new(Yazili.Image);
            GI.ResimDegistir(Yazili, AddCrossedText(DuzenlenecekResim, YazilacakMetin.Text, Color.FromArgb(128, 255, 255, 255), 45));
        }

        static Bitmap AddCrossedText(Bitmap image, string text, Color textColor, float angle)
        {
            using (Graphics g = Graphics.FromImage(image))
            {
                Font font = new Font("Arial", 150, FontStyle.Bold, GraphicsUnit.Pixel);
                SizeF textSize = g.MeasureString(text, font);

                float x = (image.Width - textSize.Width) / 2;
                float y = (image.Height - textSize.Height) / 2;
                PointF point = new PointF(x, y);
                g.TranslateTransform(point.X + textSize.Width / 2, point.Y + textSize.Height / 2);
                g.RotateTransform(angle);
                using (Brush transparentBrush = new SolidBrush(textColor))
                {
                    g.DrawString(text, font, transparentBrush, new PointF(-textSize.Width / 2, -textSize.Height / 2));
                }
            }
            return image;
        }
    }
}
