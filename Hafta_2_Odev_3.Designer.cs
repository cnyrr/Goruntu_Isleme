namespace Görüntü_İşleme
{
    partial class Hafta_2_Odev_3
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
            DegistirilmisHistogramB = new PictureBox();
            DegistirilmisHistogramG = new PictureBox();
            OrjinalHistogramB = new PictureBox();
            OrjinalHistogramG = new PictureBox();
            DegistirilmisHistogramR = new PictureBox();
            Degistirilmis = new PictureBox();
            KontrolGrubu = new GroupBox();
            PikselBilgiGrubu = new GroupBox();
            MaviDegerMetni = new Label();
            YesilDegerMetni = new Label();
            KirmiziDegerMetni = new Label();
            KoordinatMetni = new Label();
            KarsitlikDegistirButonu = new Button();
            ResmiKaydetButonu = new Button();
            ResimAcButonu = new Button();
            OrjinalUstDegerBari = new TrackBar();
            OrjinalUstDegerMetni = new Label();
            OrjinalAltDegerBari = new TrackBar();
            OrjinalAltDegerMetni = new Label();
            OrjinalHistogramR = new PictureBox();
            Orjinal = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DegistirilmisHistogramB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DegistirilmisHistogramG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrjinalHistogramB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrjinalHistogramG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DegistirilmisHistogramR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Degistirilmis).BeginInit();
            KontrolGrubu.SuspendLayout();
            PikselBilgiGrubu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrjinalUstDegerBari).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrjinalAltDegerBari).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrjinalHistogramR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Orjinal).BeginInit();
            SuspendLayout();
            // 
            // DegistirilmisHistogramB
            // 
            DegistirilmisHistogramB.BorderStyle = BorderStyle.FixedSingle;
            DegistirilmisHistogramB.Location = new Point(798, 274);
            DegistirilmisHistogramB.Name = "DegistirilmisHistogramB";
            DegistirilmisHistogramB.Size = new Size(256, 256);
            DegistirilmisHistogramB.TabIndex = 24;
            DegistirilmisHistogramB.TabStop = false;
            // 
            // DegistirilmisHistogramG
            // 
            DegistirilmisHistogramG.BorderStyle = BorderStyle.FixedSingle;
            DegistirilmisHistogramG.Location = new Point(536, 274);
            DegistirilmisHistogramG.Name = "DegistirilmisHistogramG";
            DegistirilmisHistogramG.Size = new Size(256, 256);
            DegistirilmisHistogramG.TabIndex = 23;
            DegistirilmisHistogramG.TabStop = false;
            // 
            // OrjinalHistogramB
            // 
            OrjinalHistogramB.BorderStyle = BorderStyle.FixedSingle;
            OrjinalHistogramB.Location = new Point(798, 12);
            OrjinalHistogramB.Name = "OrjinalHistogramB";
            OrjinalHistogramB.Size = new Size(256, 256);
            OrjinalHistogramB.TabIndex = 22;
            OrjinalHistogramB.TabStop = false;
            // 
            // OrjinalHistogramG
            // 
            OrjinalHistogramG.BorderStyle = BorderStyle.FixedSingle;
            OrjinalHistogramG.Location = new Point(536, 12);
            OrjinalHistogramG.Name = "OrjinalHistogramG";
            OrjinalHistogramG.Size = new Size(256, 256);
            OrjinalHistogramG.TabIndex = 21;
            OrjinalHistogramG.TabStop = false;
            // 
            // DegistirilmisHistogramR
            // 
            DegistirilmisHistogramR.BorderStyle = BorderStyle.FixedSingle;
            DegistirilmisHistogramR.Location = new Point(274, 274);
            DegistirilmisHistogramR.Name = "DegistirilmisHistogramR";
            DegistirilmisHistogramR.Size = new Size(256, 256);
            DegistirilmisHistogramR.TabIndex = 20;
            DegistirilmisHistogramR.TabStop = false;
            // 
            // Degistirilmis
            // 
            Degistirilmis.BorderStyle = BorderStyle.FixedSingle;
            Degistirilmis.Location = new Point(12, 274);
            Degistirilmis.Name = "Degistirilmis";
            Degistirilmis.Size = new Size(256, 256);
            Degistirilmis.SizeMode = PictureBoxSizeMode.Zoom;
            Degistirilmis.TabIndex = 19;
            Degistirilmis.TabStop = false;
            Degistirilmis.MouseUp += PikselBilgisi_MouseUp;
            // 
            // KontrolGrubu
            // 
            KontrolGrubu.Controls.Add(PikselBilgiGrubu);
            KontrolGrubu.Controls.Add(KarsitlikDegistirButonu);
            KontrolGrubu.Controls.Add(ResmiKaydetButonu);
            KontrolGrubu.Controls.Add(ResimAcButonu);
            KontrolGrubu.Controls.Add(OrjinalUstDegerBari);
            KontrolGrubu.Controls.Add(OrjinalUstDegerMetni);
            KontrolGrubu.Controls.Add(OrjinalAltDegerBari);
            KontrolGrubu.Controls.Add(OrjinalAltDegerMetni);
            KontrolGrubu.Location = new Point(1064, 12);
            KontrolGrubu.Name = "KontrolGrubu";
            KontrolGrubu.Size = new Size(321, 518);
            KontrolGrubu.TabIndex = 18;
            KontrolGrubu.TabStop = false;
            // 
            // PikselBilgiGrubu
            // 
            PikselBilgiGrubu.Controls.Add(MaviDegerMetni);
            PikselBilgiGrubu.Controls.Add(YesilDegerMetni);
            PikselBilgiGrubu.Controls.Add(KirmiziDegerMetni);
            PikselBilgiGrubu.Controls.Add(KoordinatMetni);
            PikselBilgiGrubu.Location = new Point(6, 412);
            PikselBilgiGrubu.Name = "PikselBilgiGrubu";
            PikselBilgiGrubu.Size = new Size(175, 100);
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
            KarsitlikDegistirButonu.Location = new Point(187, 22);
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
            ResmiKaydetButonu.Location = new Point(187, 464);
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
            // OrjinalUstDegerBari
            // 
            OrjinalUstDegerBari.BackColor = SystemColors.Control;
            OrjinalUstDegerBari.Enabled = false;
            OrjinalUstDegerBari.Location = new Point(5, 129);
            OrjinalUstDegerBari.Maximum = 255;
            OrjinalUstDegerBari.Name = "OrjinalUstDegerBari";
            OrjinalUstDegerBari.Size = new Size(310, 45);
            OrjinalUstDegerBari.TabIndex = 28;
            OrjinalUstDegerBari.TickStyle = TickStyle.None;
            OrjinalUstDegerBari.Value = 255;
            // 
            // OrjinalUstDegerMetni
            // 
            OrjinalUstDegerMetni.AutoSize = true;
            OrjinalUstDegerMetni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OrjinalUstDegerMetni.Location = new Point(5, 111);
            OrjinalUstDegerMetni.Name = "OrjinalUstDegerMetni";
            OrjinalUstDegerMetni.Size = new Size(181, 15);
            OrjinalUstDegerMetni.TabIndex = 29;
            OrjinalUstDegerMetni.Text = "Orjinal Kontrast Üst Deger: 255";
            // 
            // OrjinalAltDegerBari
            // 
            OrjinalAltDegerBari.BackColor = SystemColors.Control;
            OrjinalAltDegerBari.Enabled = false;
            OrjinalAltDegerBari.Location = new Point(5, 91);
            OrjinalAltDegerBari.Maximum = 255;
            OrjinalAltDegerBari.Name = "OrjinalAltDegerBari";
            OrjinalAltDegerBari.Size = new Size(310, 45);
            OrjinalAltDegerBari.TabIndex = 26;
            OrjinalAltDegerBari.TickStyle = TickStyle.None;
            // 
            // OrjinalAltDegerMetni
            // 
            OrjinalAltDegerMetni.AutoSize = true;
            OrjinalAltDegerMetni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OrjinalAltDegerMetni.Location = new Point(5, 73);
            OrjinalAltDegerMetni.Name = "OrjinalAltDegerMetni";
            OrjinalAltDegerMetni.Size = new Size(164, 15);
            OrjinalAltDegerMetni.TabIndex = 27;
            OrjinalAltDegerMetni.Text = "Orjinal Kontrast Alt Deger: 0";
            // 
            // OrjinalHistogramR
            // 
            OrjinalHistogramR.BorderStyle = BorderStyle.FixedSingle;
            OrjinalHistogramR.Location = new Point(274, 12);
            OrjinalHistogramR.Name = "OrjinalHistogramR";
            OrjinalHistogramR.Size = new Size(256, 256);
            OrjinalHistogramR.TabIndex = 17;
            OrjinalHistogramR.TabStop = false;
            // 
            // Orjinal
            // 
            Orjinal.BorderStyle = BorderStyle.FixedSingle;
            Orjinal.Location = new Point(12, 12);
            Orjinal.Name = "Orjinal";
            Orjinal.Size = new Size(256, 256);
            Orjinal.SizeMode = PictureBoxSizeMode.Zoom;
            Orjinal.TabIndex = 16;
            Orjinal.TabStop = false;
            Orjinal.MouseUp += PikselBilgisi_MouseUp;
            // 
            // Hafta_2_Odev_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 538);
            Controls.Add(DegistirilmisHistogramB);
            Controls.Add(DegistirilmisHistogramG);
            Controls.Add(OrjinalHistogramB);
            Controls.Add(OrjinalHistogramG);
            Controls.Add(DegistirilmisHistogramR);
            Controls.Add(Degistirilmis);
            Controls.Add(KontrolGrubu);
            Controls.Add(OrjinalHistogramR);
            Controls.Add(Orjinal);
            Name = "Hafta_2_Odev_3";
            Text = "Hafta_2_Odev_3";
            ((System.ComponentModel.ISupportInitialize)DegistirilmisHistogramB).EndInit();
            ((System.ComponentModel.ISupportInitialize)DegistirilmisHistogramG).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrjinalHistogramB).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrjinalHistogramG).EndInit();
            ((System.ComponentModel.ISupportInitialize)DegistirilmisHistogramR).EndInit();
            ((System.ComponentModel.ISupportInitialize)Degistirilmis).EndInit();
            KontrolGrubu.ResumeLayout(false);
            KontrolGrubu.PerformLayout();
            PikselBilgiGrubu.ResumeLayout(false);
            PikselBilgiGrubu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrjinalUstDegerBari).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrjinalAltDegerBari).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrjinalHistogramR).EndInit();
            ((System.ComponentModel.ISupportInitialize)Orjinal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox DegistirilmisHistogramB;
        private PictureBox DegistirilmisHistogramG;
        private PictureBox OrjinalHistogramB;
        private PictureBox OrjinalHistogramG;
        private PictureBox DegistirilmisHistogramR;
        private PictureBox Degistirilmis;
        private GroupBox KontrolGrubu;
        private Button KarsitlikDegistirButonu;
        private Button ResmiKaydetButonu;
        private Button ResimAcButonu;
        private TrackBar OrjinalUstDegerBari;
        private Label OrjinalUstDegerMetni;
        private TrackBar OrjinalAltDegerBari;
        private Label OrjinalAltDegerMetni;
        private PictureBox OrjinalHistogramR;
        private PictureBox Orjinal;
        private GroupBox PikselBilgiGrubu;
        private Label MaviDegerMetni;
        private Label YesilDegerMetni;
        private Label KirmiziDegerMetni;
        private Label KoordinatMetni;
    }
}