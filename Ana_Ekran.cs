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
            HaftaBirSecimKutusu.SelectedIndex = 0;
            HaftaIkiSecimKutusu.SelectedIndex = 0;
            HaftaUcSecimKutusu.SelectedIndex = 0;
            HaftaDortSecimKutusu.SelectedIndex = 0;
            HaftaBesSecimKutusu.SelectedIndex = 0;
            HaftaAltiSecimKutusu.SelectedIndex = 0;
            HaftaYediSecimKutusu.SelectedIndex = 0;
            HaftaSekizSecimKutusu.SelectedIndex = 0;
            HaftaDokuzSecimKutusu.SelectedIndex = 0;
            HaftaOnSecimKutusu.SelectedIndex = 0;
            HaftaOnBirSecimKutusu.SelectedIndex = 0;
            HaftaOnIkiSecimKutusu.SelectedIndex = 0;
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
            // Not implemented.
            return;
        }

        private void HaftaBesButonu_Click(object sender, EventArgs e)
        {
            AltEkraniGoster(new Hafta_5());
            return;
        }

        private void HaftaAltiButonu_Click(object sender, EventArgs e)
        {
            // Not implemented.
            return;
        }

        private void HaftaYediButonu_Click(object sender, EventArgs e)
        {
            // Not implemented.
            return;
        }

        private void HaftaSekizButonu_Click(object sender, EventArgs e)
        {
            // Not implemented.
            return;
        }

        private void HaftaDokuzButonu_Click(object sender, EventArgs e)
        {
            // Not implemented.
            return;
        }

        private void HaftaOnButonu_Click(object sender, EventArgs e)
        {
            // Not implemented.
            return;
        }

        private void HaftaOnBirButonu_Click(object sender, EventArgs e)
        {
            // Not implemented.
            return;
        }

        private void HaftaOnIkiButonu_Click(object sender, EventArgs e)
        {
            // Not implemented.
            return;
        }
    }
}
