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
    public partial class Ana_Ekran : Form
    {
        public Ana_Ekran()
        {
            InitializeComponent();
        }

        private void AltEkraniGoster(Form yeni_ekran)
        {
            yeni_ekran.FormClosed += new FormClosedEventHandler(AnaEkraniGoster);
            this.Hide();
            yeni_ekran.Show();
            return;
        }

        private void AnaEkraniGoster(object? sender, EventArgs e)
        {
            this.Show();
            return;
        }

        private void Ana_Ekran_Load(object sender, EventArgs e)
        {
            return;
        }

        private void HaftaBirButonu_Click(object sender, EventArgs e)
        {
            AltEkraniGoster(new Hafta_1());
            return;
        }

        private void HaftaIkiButonu_Click(object sender, EventArgs e)
        {
            AltEkraniGoster(new Hafta_2());
            return;
        }

        private void HaftaUcButonu_Click(object sender, EventArgs e)
        {
            AltEkraniGoster(new Hafta_3());
            return;
        }

        private void HaftaDortButonu_Click(object sender, EventArgs e)
        {
            AltEkraniGoster(new Hafta_4());
            return;
        }

        private void HaftaBesButonu_Click(object sender, EventArgs e)
        {
            AltEkraniGoster(new Hafta_5());
            return;
        }

        private void HaftaAltiButonu_Click(object sender, EventArgs e)
        {
            AltEkraniGoster(new Hafta_6());
            return;
        }

        private void HaftaYediButonu_Click(object sender, EventArgs e)
        {
            AltEkraniGoster(new Hafta_7());
            return;
        }

        private void HaftaSekizButonu_Click(object sender, EventArgs e)
        {
            AltEkraniGoster(new Hafta_8());
            return;
        }

        private void HaftaDokuzButonu_Click(object sender, EventArgs e)
        {
            AltEkraniGoster(new Hafta_8());
            return;
        }

        private void HaftaBirButonu_Click_1(object sender, EventArgs e)
        {

        }
    }
}
