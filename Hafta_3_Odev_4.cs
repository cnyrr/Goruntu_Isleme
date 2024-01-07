using System.Windows.Forms;
// 4)
namespace Görüntü_İşleme
{
    public partial class Hafta_3_Odev_4 : Form
    {
        public Hafta_3_Odev_4()
        {
            InitializeComponent();
        }

        public void label1_Click(object sender, EventArgs e)
        {

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

        public Bitmap Yakinlastirma()
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int BuyutmeKatsayisi = Convert.ToInt32(textBox1.Text);
            int x2 = 0, y2 = 0;

            for (int x1 = 0; x1 < ResimGenisligi; x1++)
            {
                for (int y1 = 0; y1 < ResimYuksekligi; y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);
                    for (int i = 0; i < BuyutmeKatsayisi; i++)
                    {
                        for (int j = 0; j < BuyutmeKatsayisi; j++)
                        {
                            x2 = x1 * BuyutmeKatsayisi + i;
                            y2 = y1 * BuyutmeKatsayisi + j;
                            if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                                CikisResmi.SetPixel(x2, y2, OkunanRenk);
                        }
                    }
                }
                pictureBox2.Image = CikisResmi;   
            }
            return CikisResmi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Yakinlastirma();
        }
    }
}