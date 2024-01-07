namespace Görüntü_İşleme
{
    // 2)
    public partial class Hafta_3_Odev_2 : Form
    {
        public Hafta_3_Odev_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                pictureBox1.Cursor = Cursors.Hand;
            }
            pictureBox1.Image = Egme_Kaydirma();
        }
        
        public Bitmap Egme_Kaydirma()
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);

            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;

            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

            //Taşımamesafelerini atıyor
            double EgmeKatsayisi = 0.2;
            double x2 = 0, y2 = 0;

            for (int x1 = 0; x1 < ResimGenisligi; x1++)
            {
                for (int y1 = 0; y1 < ResimYuksekligi; y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);

                    //+X ekseni yönünde
                    //x2 = x1 + EgmeKatsayisi*y1;
                    //y2=y1;
                    //
                    // -X ekseni yönünde
                    //x2 = x1 - EgmeKatsayisi*y1;
                    //y2=y1;
                    //
                    //+Y ekseni yönünde
                    //x2=x1;
                    //y2 = EgmeKatsayisi*x1 + y1;
                    // -Y ekseni yönünde
                    x2=x1;
                    y2 = EgmeKatsayisi*x1 + y1;

                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }
            return CikisResmi;
        }
        

    }
}
