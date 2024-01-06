namespace Görüntü_İşleme
{
    partial class Hafta_2_Odev_4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DegistirilmisHistogram = new PictureBox();
            Degistirilmis = new PictureBox();
            KontrolGrubu = new GroupBox();
            GriKontrastGrubu = new GroupBox();
            TavanDegerKutusu = new NumericUpDown();
            TabanDegerKutusu = new NumericUpDown();
            TavanDegerMetni = new Label();
            TabanDegerMetni = new Label();
            PikselBilgiGrubu = new GroupBox();
            MaviDegerMetni = new Label();
            YesilDegerMetni = new Label();
            KirmiziDegerMetni = new Label();
            KoordinatMetni = new Label();
            KarsitlikDegistirButonu = new Button();
            ResmiKaydetButonu = new Button();
            ResimAcButonu = new Button();
            OrjinalHistogram = new PictureBox();
            Orjinal = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DegistirilmisHistogram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Degistirilmis).BeginInit();
            KontrolGrubu.SuspendLayout();
            GriKontrastGrubu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TavanDegerKutusu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TabanDegerKutusu).BeginInit();
            PikselBilgiGrubu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrjinalHistogram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Orjinal).BeginInit();
            SuspendLayout();
            // 
            // DegistirilmisHistogram
            // 
            DegistirilmisHistogram.BorderStyle = BorderStyle.FixedSingle;
            DegistirilmisHistogram.Location = new Point(274, 274);
            DegistirilmisHistogram.Name = "DegistirilmisHistogram";
            DegistirilmisHistogram.Size = new Size(768, 256);
            DegistirilmisHistogram.TabIndex = 29;
            DegistirilmisHistogram.TabStop = false;
            DegistirilmisHistogram.MouseDown += OrjinalHistogram_MouseDown;
            // 
            // Degistirilmis
            // 
            Degistirilmis.BorderStyle = BorderStyle.FixedSingle;
            Degistirilmis.Location = new Point(12, 274);
            Degistirilmis.Name = "Degistirilmis";
            Degistirilmis.Size = new Size(256, 256);
            Degistirilmis.SizeMode = PictureBoxSizeMode.Zoom;
            Degistirilmis.TabIndex = 28;
            Degistirilmis.TabStop = false;
            Degistirilmis.MouseUp += PikselBilgisi_MouseUp;
            // 
            // KontrolGrubu
            // 
            KontrolGrubu.Controls.Add(GriKontrastGrubu);
            KontrolGrubu.Controls.Add(PikselBilgiGrubu);
            KontrolGrubu.Controls.Add(KarsitlikDegistirButonu);
            KontrolGrubu.Controls.Add(ResmiKaydetButonu);
            KontrolGrubu.Controls.Add(ResimAcButonu);
            KontrolGrubu.Location = new Point(1048, 12);
            KontrolGrubu.Name = "KontrolGrubu";
            KontrolGrubu.Size = new Size(337, 518);
            KontrolGrubu.TabIndex = 27;
            KontrolGrubu.TabStop = false;
            // 
            // GriKontrastGrubu
            // 
            GriKontrastGrubu.Controls.Add(TavanDegerKutusu);
            GriKontrastGrubu.Controls.Add(TabanDegerKutusu);
            GriKontrastGrubu.Controls.Add(TavanDegerMetni);
            GriKontrastGrubu.Controls.Add(TabanDegerMetni);
            GriKontrastGrubu.Location = new Point(6, 76);
            GriKontrastGrubu.Name = "GriKontrastGrubu";
            GriKontrastGrubu.Size = new Size(325, 111);
            GriKontrastGrubu.TabIndex = 35;
            GriKontrastGrubu.TabStop = false;
            GriKontrastGrubu.Text = "Seçilen Sınır Değerleri:";
            // 
            // TavanDegerKutusu
            // 
            TavanDegerKutusu.Enabled = false;
            TavanDegerKutusu.Location = new Point(90, 68);
            TavanDegerKutusu.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            TavanDegerKutusu.Name = "TavanDegerKutusu";
            TavanDegerKutusu.Size = new Size(61, 23);
            TavanDegerKutusu.TabIndex = 3;
            TavanDegerKutusu.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // TabanDegerKutusu
            // 
            TabanDegerKutusu.Enabled = false;
            TabanDegerKutusu.Location = new Point(90, 23);
            TabanDegerKutusu.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            TabanDegerKutusu.Name = "TabanDegerKutusu";
            TabanDegerKutusu.Size = new Size(61, 23);
            TabanDegerKutusu.TabIndex = 2;
            // 
            // TavanDegerMetni
            // 
            TavanDegerMetni.AutoSize = true;
            TavanDegerMetni.Location = new Point(7, 70);
            TavanDegerMetni.Name = "TavanDegerMetni";
            TavanDegerMetni.Size = new Size(77, 15);
            TavanDegerMetni.TabIndex = 1;
            TavanDegerMetni.Text = "Tavan Değeri:";
            // 
            // TabanDegerMetni
            // 
            TabanDegerMetni.AutoSize = true;
            TabanDegerMetni.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TabanDegerMetni.Location = new Point(6, 25);
            TabanDegerMetni.Name = "TabanDegerMetni";
            TabanDegerMetni.Size = new Size(78, 15);
            TabanDegerMetni.TabIndex = 0;
            TabanDegerMetni.Text = "Taban Değeri:";
            // 
            // PikselBilgiGrubu
            // 
            PikselBilgiGrubu.Controls.Add(MaviDegerMetni);
            PikselBilgiGrubu.Controls.Add(YesilDegerMetni);
            PikselBilgiGrubu.Controls.Add(KirmiziDegerMetni);
            PikselBilgiGrubu.Controls.Add(KoordinatMetni);
            PikselBilgiGrubu.Location = new Point(6, 401);
            PikselBilgiGrubu.Name = "PikselBilgiGrubu";
            PikselBilgiGrubu.Size = new Size(151, 111);
            PikselBilgiGrubu.TabIndex = 34;
            PikselBilgiGrubu.TabStop = false;
            PikselBilgiGrubu.Text = "Seçilen Pixel Değerleri";
            // 
            // MaviDegerMetni
            // 
            MaviDegerMetni.AutoSize = true;
            MaviDegerMetni.Location = new Point(6, 73);
            MaviDegerMetni.Name = "MaviDegerMetni";
            MaviDegerMetni.Size = new Size(36, 15);
            MaviDegerMetni.TabIndex = 37;
            MaviDegerMetni.Text = "Mavi:";
            // 
            // YesilDegerMetni
            // 
            YesilDegerMetni.AutoSize = true;
            YesilDegerMetni.Location = new Point(6, 58);
            YesilDegerMetni.Name = "YesilDegerMetni";
            YesilDegerMetni.Size = new Size(33, 15);
            YesilDegerMetni.TabIndex = 36;
            YesilDegerMetni.Text = "Yeşil:";
            // 
            // KirmiziDegerMetni
            // 
            KirmiziDegerMetni.AutoSize = true;
            KirmiziDegerMetni.Location = new Point(6, 43);
            KirmiziDegerMetni.Name = "KirmiziDegerMetni";
            KirmiziDegerMetni.Size = new Size(46, 15);
            KirmiziDegerMetni.TabIndex = 35;
            KirmiziDegerMetni.Text = "Kırmızı:";
            // 
            // KoordinatMetni
            // 
            KoordinatMetni.AutoSize = true;
            KoordinatMetni.Location = new Point(6, 19);
            KoordinatMetni.Name = "KoordinatMetni";
            KoordinatMetni.Size = new Size(62, 15);
            KoordinatMetni.TabIndex = 0;
            KoordinatMetni.Text = "Koordinat:";
            // 
            // KarsitlikDegistirButonu
            // 
            KarsitlikDegistirButonu.Enabled = false;
            KarsitlikDegistirButonu.Location = new Point(203, 22);
            KarsitlikDegistirButonu.Name = "KarsitlikDegistirButonu";
            KarsitlikDegistirButonu.Size = new Size(128, 48);
            KarsitlikDegistirButonu.TabIndex = 12;
            KarsitlikDegistirButonu.Text = "Renkleri Gerdir/Sıkıştır";
            KarsitlikDegistirButonu.UseVisualStyleBackColor = true;
            KarsitlikDegistirButonu.Click += KarsitlikDegistirButonu_Click;
            // 
            // ResmiKaydetButonu
            // 
            ResmiKaydetButonu.Enabled = false;
            ResmiKaydetButonu.Location = new Point(203, 464);
            ResmiKaydetButonu.Name = "ResmiKaydetButonu";
            ResmiKaydetButonu.Size = new Size(128, 48);
            ResmiKaydetButonu.TabIndex = 7;
            ResmiKaydetButonu.Text = "Resmi Kaydet";
            ResmiKaydetButonu.UseVisualStyleBackColor = true;
            ResmiKaydetButonu.Click += ResmiKaydetButonu_Click;
            // 
            // ResimAcButonu
            // 
            ResimAcButonu.Location = new Point(6, 22);
            ResimAcButonu.Name = "ResimAcButonu";
            ResimAcButonu.Size = new Size(128, 48);
            ResimAcButonu.TabIndex = 6;
            ResimAcButonu.Text = "Resim Aç";
            ResimAcButonu.UseVisualStyleBackColor = true;
            ResimAcButonu.Click += ResimAcButonu_Click;
            // 
            // OrjinalHistogram
            // 
            OrjinalHistogram.BorderStyle = BorderStyle.FixedSingle;
            OrjinalHistogram.Location = new Point(274, 12);
            OrjinalHistogram.Name = "OrjinalHistogram";
            OrjinalHistogram.Size = new Size(768, 256);
            OrjinalHistogram.TabIndex = 26;
            OrjinalHistogram.TabStop = false;
            OrjinalHistogram.MouseDown += OrjinalHistogram_MouseDown;
            // 
            // Orjinal
            // 
            Orjinal.BorderStyle = BorderStyle.FixedSingle;
            Orjinal.Location = new Point(12, 12);
            Orjinal.Name = "Orjinal";
            Orjinal.Size = new Size(256, 256);
            Orjinal.SizeMode = PictureBoxSizeMode.Zoom;
            Orjinal.TabIndex = 25;
            Orjinal.TabStop = false;
            Orjinal.MouseUp += PikselBilgisi_MouseUp;
            // 
            // Hafta_2_Odev_4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 536);
            Controls.Add(DegistirilmisHistogram);
            Controls.Add(Degistirilmis);
            Controls.Add(KontrolGrubu);
            Controls.Add(OrjinalHistogram);
            Controls.Add(Orjinal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Hafta_2_Odev_4";
            Text = "Hafta_2_Odev_4";
            ((System.ComponentModel.ISupportInitialize)DegistirilmisHistogram).EndInit();
            ((System.ComponentModel.ISupportInitialize)Degistirilmis).EndInit();
            KontrolGrubu.ResumeLayout(false);
            GriKontrastGrubu.ResumeLayout(false);
            GriKontrastGrubu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TavanDegerKutusu).EndInit();
            ((System.ComponentModel.ISupportInitialize)TabanDegerKutusu).EndInit();
            PikselBilgiGrubu.ResumeLayout(false);
            PikselBilgiGrubu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrjinalHistogram).EndInit();
            ((System.ComponentModel.ISupportInitialize)Orjinal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox DegistirilmisHistogram;
        private PictureBox Degistirilmis;
        private GroupBox KontrolGrubu;
        private GroupBox GriKontrastGrubu;
        private Label TabanDegerMetni;
        private GroupBox PikselBilgiGrubu;
        private Label MaviDegerMetni;
        private Label YesilDegerMetni;
        private Label KoordinatMetni;
        private Button KarsitlikDegistirButonu;
        private Button ResmiKaydetButonu;
        private Button ResimAcButonu;
        private PictureBox OrjinalHistogram;
        private PictureBox Orjinal;
        private Label TavanDegerMetni;
        private Label KirmiziDegerMetni;
        private NumericUpDown TavanDegerKutusu;
        private NumericUpDown TabanDegerKutusu;
    }
}