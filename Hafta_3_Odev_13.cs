using System.Windows.Forms;
using System.Drawing;
using System.Net;

namespace Görüntü_İşleme
{
    public partial class Hafta_3_Odev_13 : Form
    {
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing;

        public Hafta_3_Odev_13()
        {
            InitializeComponent();
            pictureBox1.MouseDown += PictureBox_MouseDown;
            pictureBox1.MouseMove += PictureBox_MouseMove;
            pictureBox1.MouseUp += PictureBox_MouseUp;
            pictureBox1.Paint += PictureBox_Paint;
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
            int y = Math.Min(startPoint.Y, endPoint.Y);
            int width = Math.Abs(startPoint.X - endPoint.X);
            int height = Math.Abs(startPoint.Y - endPoint.Y);

            return new Rectangle(x, y, width, height);
        }

        private void CropImage(PictureBox pictureBox)
        {
            
            Rectangle cropRectangle = GetCropRectangle();
            Bitmap originalImage = new Bitmap(pictureBox.Image);
            Bitmap croppedImage = originalImage.Clone(cropRectangle, originalImage.PixelFormat);

            

            pictureBox2.Image = croppedImage;

            
            pictureBox2.Size = cropRectangle.Size;

            
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CropImage(pictureBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyasý |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            
            
            if(dosya.ShowDialog() == DialogResult.OK) {
                string DosyaYolu = dosya.FileName;
                pictureBox1.ImageLocation = DosyaYolu;
            }
            

        }
        
    }
}
