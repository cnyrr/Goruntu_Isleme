using System.Net;
// 5)
namespace Görüntü_İşleme
{   
    public partial class Hafta_3_Odev_5 : Form
    {
        List<int> coords = new List<int>();
 
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing;
        public Hafta_3_Odev_5()
        {
            InitializeComponent();
            
            pictureBox1.Paint += PictureBox_Paint;

        }
        
        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the mouse click coordinates
            int mouseX = e.X;
            int mouseY = e.Y;

            coords.Add(mouseX);
            coords.Add(mouseY);

            // PictureBox'ı yeniden çiz
            ((PictureBox)sender).Invalidate();
            // Display the coordinates (you can use them as needed)
            //MessageBox.Show($"Mouse Click Coordinates: X={mouseX}, Y={mouseY}");
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {


            if (isDrawing)
            {
                Rectangle kare = GetCropRectangle();
                e.Graphics.DrawRectangle(Pens.Blue, kare);
                //using (Pen pen = new Pen(Color.Red, 2))
                //{
                //Rectangle kare = new Rectangle(kareNoktasi.X - kareBoyutu / 2, kareNoktasi.Y - kareBoyutu / 2, kareBoyutu, kareBoyutu);
                //e.Graphics.DrawRectangle(pen, GetCropRectangle());

                //}
            }
        }

        private Rectangle GetCropRectangle()
        {
            int x_1 = coords[0];
            int y_1 = coords[1];
            int x_2 = coords[2];
            int y_2 = coords[3];

            int mesafeX = (x_2 - x_1);
            int mesafeY = (y_2 - y_1);

            int x = Math.Min(x_1, x_2);
            int y = Math.Min(y_1, y_2);
            int width = Math.Abs(mesafeX);
            int height = Math.Abs(mesafeY);

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
        private void button1_Click(object sender, EventArgs e)
        {
            CropImage(pictureBox1);
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
    }
}
