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
        enum HaftaSecim
        {
            Tek_Parça,
            Ödev_1, Ödev_1_A, Ödev_1_B, Ödev_1_C, Ödev_1_D,
            Ödev_2, Ödev_2_A, Ödev_2_B, Ödev_2_C, Ödev_2_D,
            Ödev_3, Ödev_3_A, Ödev_3_B, Ödev_3_C, Ödev_3_D,
            Ödev_4, Ödev_4_A, Ödev_4_B, Ödev_4_C, Ödev_4_D,
            Ödev_5, Ödev_5_A, Ödev_5_B, Ödev_5_C, Ödev_5_D,
            Ödev_6, Ödev_6_A, Ödev_6_B, Ödev_6_C, Ödev_6_D,
            Ödev_7, Ödev_7_A, Ödev_7_B, Ödev_7_C, Ödev_7_D,
            Ödev_8, Ödev_8_A, Ödev_8_B, Ödev_8_C, Ödev_8_D,
            Ödev_9, Ödev_9_A, Ödev_9_B, Ödev_9_C, Ödev_9_D,
            Ödev_10, Ödev_10_A, Ödev_10_B, Ödev_10_C, Ödev_10_D,
            Ödev_11, Ödev_11_A, Ödev_11_B, Ödev_11_C, Ödev_11_D,
            Ödev_12, Ödev_12_A, Ödev_12_B, Ödev_12_C, Ödev_12_D,
        }

        public Ana_Ekran()
        {
            InitializeComponent();
            // 1. Hafta Ödev Tanımlaması:
            HaftaBirSecimKutusu.Items.Add(HaftaSecim.Tek_Parça);

            // 2. Hafta Ödev Tanımlaması:
            HaftaIkiSecimKutusu.Items.Add(HaftaSecim.Ödev_1);
            HaftaIkiSecimKutusu.Items.Add(HaftaSecim.Ödev_2);
            HaftaIkiSecimKutusu.Items.Add(HaftaSecim.Ödev_3);
            HaftaIkiSecimKutusu.Items.Add(HaftaSecim.Ödev_4);
            HaftaIkiSecimKutusu.Items.Add(HaftaSecim.Ödev_5);
            HaftaIkiSecimKutusu.Items.Add(HaftaSecim.Ödev_6);
            HaftaIkiSecimKutusu.Items.Add(HaftaSecim.Ödev_7);
            HaftaIkiSecimKutusu.Items.Add(HaftaSecim.Ödev_8);

            // 3. Hafta Ödev Tanımlaması:
            // 4. Hafta Ödev Tanımlaması:
            // 5. Hafta Ödev Tanımlaması:
            // 6. Hafta Ödev Tanımlaması:
            // 7. Hafta Ödev Tanımlaması:
            // 8. Hafta Ödev Tanımlaması:
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
            switch (HaftaIkiSecimKutusu.SelectedItem)
            {
                case HaftaSecim.Ödev_1:
                    AltEkraniGoster(new Hafta_2_Odev_1());
                    break;
                case HaftaSecim.Ödev_2:
                    AltEkraniGoster(new Hafta_2_Odev_2());
                    break;
                case HaftaSecim.Ödev_3:
                    AltEkraniGoster(new Hafta_2_Odev_3());
                    break;
                case HaftaSecim.Ödev_4:
                    AltEkraniGoster(new Hafta_2_Odev_4());
                    break;
                case HaftaSecim.Ödev_5:
                    // AltEkraniGoster(new Hafta_2_Odev_5());
                    //break;
                case HaftaSecim.Ödev_6:
                    // AltEkraniGoster(new Hafta_2_Odev_6());
                    //break;
                case HaftaSecim.Ödev_7:
                    // AltEkraniGoster(new Hafta_2_Odev_7());
                    //break;
                case HaftaSecim.Ödev_8:
                    // AltEkraniGoster(new Hafta_2_Odev_8());
                    //break;
                case HaftaSecim.Ödev_9:
                    // AltEkraniGoster(new Hafta_2_Odev_9());
                    //break;
                    MessageBox.Show("Daha eklenmedi.", "Hata!");
                    break;
            }
            return;
        }

        private void HaftaUcButonu_Click(object sender, EventArgs e)
        {
            AltEkraniGoster(new Hafta_3_Odev_7());
            return;
        }

        private void HaftaDortButonu_Click(object sender, EventArgs e)
        {
            // Not implemented.
            return;
        }

        private void HaftaBesButonu_Click(object sender, EventArgs e)
        {
            //AltEkraniGoster(new Hafta_5_Odev_1());
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
