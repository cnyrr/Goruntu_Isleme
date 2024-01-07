using Microsoft.VisualBasic.Devices;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Görüntü_İşleme
{
    // 3)
    public partial class Hafta_3_Odev_3 : Form
    {

        List<int> coords = new List<int>();

        public Hafta_3_Odev_3()
        {
            InitializeComponent();

            //MessageBox.Show($"Mouse Click Coordinates: {this.MouseClick}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                pictureBox1.Cursor = Cursors.Hand;
            }
        }
        
        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the mouse click coordinates
            int mouseX = e.X;
            int mouseY = e.Y;

            coords.Add(mouseX);
            coords.Add(mouseY);
            // Display the coordinates (you can use them as needed)
            //MessageBox.Show($"Mouse Click Coordinates: X={mouseX}, Y={mouseY}");
        }
        
        public Bitmap Aynalama()
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            double x_1 = coords[0];
            double y_1 = coords[1];
            double x_2 = coords[2];
            double y_2 = coords[3];

            double Aci = Math.Atan((y_2 - y_1) / (x_2 - x_1)) * 180 / Math.PI;
            //double Aci = Convert.ToDouble(textBox1.Text);
            double RadyanAci = Aci * 2 * Math.PI / 360;
            double x2 = 0, y2 = 0;

            //Resim merkezini buluyor. Resim merkezi etrafında döndürecek.
            int x0 = ResimGenisligi / 2;
            int y0 = ResimYuksekligi / 2;

            for (int x1 = 0; x1 < ResimGenisligi; x1++)
            {
                for (int y1 = 0; y1 < ResimYuksekligi; y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);
                    double Delta = (x1 - x0) * Math.Sin(RadyanAci) - (y1 - y0) * Math.Cos(RadyanAci);
                    x2 = Convert.ToInt16(x1 + 2 * Delta * (-Math.Sin(RadyanAci)));
                    y2 = Convert.ToInt16(y1 + 2 * Delta * (Math.Cos(RadyanAci)));

                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }
            pictureBox1.Image = CikisResmi;
            return CikisResmi;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Aynalama();

        }
    }
}
