namespace Görüntü_İşleme
{
    partial class Hafta_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hafta_2));
            CiktiOlcegiButonKutusu = new GroupBox();
            YakinlastirButonu = new RadioButton();
            MerkezleButonu = new RadioButton();
            NormalButonu = new RadioButton();
            SigdirButonu = new RadioButton();
            HistogramResmi = new PictureBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            OrjinalResim = new PictureBox();
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            ResimSecToolbar = new ToolStripMenuItem();
            hazırlıkToolStripMenuItem = new ToolStripMenuItem();
            filtrelerToolStripMenuItem = new ToolStripMenuItem();
            IslemlerGrupKutusu = new GroupBox();
            MozaiklemeListesi = new ComboBox();
            MozaiklestirmeButonu = new Button();
            NormalRenkDerinligiListesi = new ComboBox();
            NormalRenkDerinligiDegistirButonu = new Button();
            GriRenkDerinligiListesi = new ComboBox();
            GriRenkDerinligiButonu = new Button();
            BantDegisimListesi = new ComboBox();
            BantDegisimButonu = new Button();
            NegatifAlmaButonu = new Button();
            RenkveGriCevirListesi = new ComboBox();
            ResmiKaydetButonu = new Button();
            OrneklemeButonu = new Button();
            RenkCevirButonu = new Button();
            OrneklemeListesi = new ComboBox();
            RenkOrneklemeListesi = new ComboBox();
            GoruntuOlusturmaGrupKutusu = new GroupBox();
            ResimSecButonu = new Button();
            GriSkalaMaxDegerKutusu = new NumericUpDown();
            DaireCozunurlukDegerKutusu = new NumericUpDown();
            GriSkalaButonu = new Button();
            DaireButonu = new Button();
            DegistirilmisResim = new PictureBox();
            CiktiOlcegiButonKutusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HistogramResmi).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrjinalResim).BeginInit();
            menuStrip1.SuspendLayout();
            IslemlerGrupKutusu.SuspendLayout();
            GoruntuOlusturmaGrupKutusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GriSkalaMaxDegerKutusu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DaireCozunurlukDegerKutusu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DegistirilmisResim).BeginInit();
            SuspendLayout();
            // 
            // CiktiOlcegiButonKutusu
            // 
            CiktiOlcegiButonKutusu.Controls.Add(YakinlastirButonu);
            CiktiOlcegiButonKutusu.Controls.Add(MerkezleButonu);
            CiktiOlcegiButonKutusu.Controls.Add(NormalButonu);
            CiktiOlcegiButonKutusu.Controls.Add(SigdirButonu);
            CiktiOlcegiButonKutusu.Location = new Point(271, 570);
            CiktiOlcegiButonKutusu.Name = "CiktiOlcegiButonKutusu";
            CiktiOlcegiButonKutusu.Size = new Size(253, 177);
            CiktiOlcegiButonKutusu.TabIndex = 29;
            CiktiOlcegiButonKutusu.TabStop = false;
            CiktiOlcegiButonKutusu.Text = "Çıktı Ölçeği";
            // 
            // YakinlastirButonu
            // 
            YakinlastirButonu.AutoSize = true;
            YakinlastirButonu.Location = new Point(6, 97);
            YakinlastirButonu.Name = "YakinlastirButonu";
            YakinlastirButonu.Size = new Size(78, 19);
            YakinlastirButonu.TabIndex = 3;
            YakinlastirButonu.TabStop = true;
            YakinlastirButonu.Text = "Yakınlaştır";
            YakinlastirButonu.UseVisualStyleBackColor = true;
            // 
            // MerkezleButonu
            // 
            MerkezleButonu.AutoSize = true;
            MerkezleButonu.Location = new Point(6, 72);
            MerkezleButonu.Name = "MerkezleButonu";
            MerkezleButonu.Size = new Size(72, 19);
            MerkezleButonu.TabIndex = 1;
            MerkezleButonu.TabStop = true;
            MerkezleButonu.Text = "Merkezle";
            MerkezleButonu.UseVisualStyleBackColor = true;
            // 
            // NormalButonu
            // 
            NormalButonu.AutoSize = true;
            NormalButonu.Location = new Point(6, 22);
            NormalButonu.Name = "NormalButonu";
            NormalButonu.Size = new Size(65, 19);
            NormalButonu.TabIndex = 0;
            NormalButonu.TabStop = true;
            NormalButonu.Text = "Normal";
            NormalButonu.UseVisualStyleBackColor = true;
            // 
            // SigdirButonu
            // 
            SigdirButonu.AutoSize = true;
            SigdirButonu.Location = new Point(6, 47);
            SigdirButonu.Name = "SigdirButonu";
            SigdirButonu.Size = new Size(55, 19);
            SigdirButonu.TabIndex = 2;
            SigdirButonu.TabStop = true;
            SigdirButonu.Text = "Sığdır";
            SigdirButonu.UseVisualStyleBackColor = true;
            // 
            // HistogramResmi
            // 
            HistogramResmi.BorderStyle = BorderStyle.FixedSingle;
            HistogramResmi.Location = new Point(532, 52);
            HistogramResmi.Name = "HistogramResmi";
            HistogramResmi.Size = new Size(512, 512);
            HistogramResmi.SizeMode = PictureBoxSizeMode.Zoom;
            HistogramResmi.TabIndex = 25;
            HistogramResmi.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1576, 25);
            toolStrip1.TabIndex = 26;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // OrjinalResim
            // 
            OrjinalResim.BorderStyle = BorderStyle.FixedSingle;
            OrjinalResim.Location = new Point(12, 52);
            OrjinalResim.Name = "OrjinalResim";
            OrjinalResim.Size = new Size(512, 512);
            OrjinalResim.SizeMode = PictureBoxSizeMode.Zoom;
            OrjinalResim.TabIndex = 24;
            OrjinalResim.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, hazırlıkToolStripMenuItem, filtrelerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1576, 24);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ResimSecToolbar });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(51, 20);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // ResimSecToolbar
            // 
            ResimSecToolbar.Name = "ResimSecToolbar";
            ResimSecToolbar.Size = new Size(127, 22);
            ResimSecToolbar.Text = "Resim Seç";
            // 
            // hazırlıkToolStripMenuItem
            // 
            hazırlıkToolStripMenuItem.Name = "hazırlıkToolStripMenuItem";
            hazırlıkToolStripMenuItem.Size = new Size(58, 20);
            hazırlıkToolStripMenuItem.Text = "Hazırlık";
            // 
            // filtrelerToolStripMenuItem
            // 
            filtrelerToolStripMenuItem.Name = "filtrelerToolStripMenuItem";
            filtrelerToolStripMenuItem.Size = new Size(58, 20);
            filtrelerToolStripMenuItem.Text = "Filtreler";
            // 
            // IslemlerGrupKutusu
            // 
            IslemlerGrupKutusu.Controls.Add(MozaiklemeListesi);
            IslemlerGrupKutusu.Controls.Add(MozaiklestirmeButonu);
            IslemlerGrupKutusu.Controls.Add(NormalRenkDerinligiListesi);
            IslemlerGrupKutusu.Controls.Add(NormalRenkDerinligiDegistirButonu);
            IslemlerGrupKutusu.Controls.Add(GriRenkDerinligiListesi);
            IslemlerGrupKutusu.Controls.Add(GriRenkDerinligiButonu);
            IslemlerGrupKutusu.Controls.Add(BantDegisimListesi);
            IslemlerGrupKutusu.Controls.Add(BantDegisimButonu);
            IslemlerGrupKutusu.Controls.Add(NegatifAlmaButonu);
            IslemlerGrupKutusu.Controls.Add(RenkveGriCevirListesi);
            IslemlerGrupKutusu.Controls.Add(ResmiKaydetButonu);
            IslemlerGrupKutusu.Controls.Add(OrneklemeButonu);
            IslemlerGrupKutusu.Controls.Add(RenkCevirButonu);
            IslemlerGrupKutusu.Controls.Add(OrneklemeListesi);
            IslemlerGrupKutusu.Controls.Add(RenkOrneklemeListesi);
            IslemlerGrupKutusu.Location = new Point(1052, 570);
            IslemlerGrupKutusu.Name = "IslemlerGrupKutusu";
            IslemlerGrupKutusu.Size = new Size(512, 177);
            IslemlerGrupKutusu.TabIndex = 27;
            IslemlerGrupKutusu.TabStop = false;
            IslemlerGrupKutusu.Text = "İşlemler";
            // 
            // MozaiklemeListesi
            // 
            MozaiklemeListesi.Enabled = false;
            MozaiklemeListesi.FormattingEnabled = true;
            MozaiklemeListesi.Items.AddRange(new object[] { "1", "2", "5", "10", "25", "50", "100" });
            MozaiklemeListesi.Location = new Point(441, 81);
            MozaiklemeListesi.Name = "MozaiklemeListesi";
            MozaiklemeListesi.Size = new Size(65, 23);
            MozaiklemeListesi.TabIndex = 26;
            // 
            // MozaiklestirmeButonu
            // 
            MozaiklestirmeButonu.Enabled = false;
            MozaiklestirmeButonu.Location = new Point(249, 81);
            MozaiklestirmeButonu.Name = "MozaiklestirmeButonu";
            MozaiklestirmeButonu.Size = new Size(186, 23);
            MozaiklestirmeButonu.TabIndex = 25;
            MozaiklestirmeButonu.Text = "Gri Mozaikleştir";
            MozaiklestirmeButonu.UseVisualStyleBackColor = true;
            // 
            // NormalRenkDerinligiListesi
            // 
            NormalRenkDerinligiListesi.Enabled = false;
            NormalRenkDerinligiListesi.FormattingEnabled = true;
            NormalRenkDerinligiListesi.Items.AddRange(new object[] { "7-bit", "6-bit", "5-bit", "4-bit", "3-bit", "2-bit", "1-bit" });
            NormalRenkDerinligiListesi.Location = new Point(441, 23);
            NormalRenkDerinligiListesi.Name = "NormalRenkDerinligiListesi";
            NormalRenkDerinligiListesi.Size = new Size(65, 23);
            NormalRenkDerinligiListesi.TabIndex = 24;
            // 
            // NormalRenkDerinligiDegistirButonu
            // 
            NormalRenkDerinligiDegistirButonu.Enabled = false;
            NormalRenkDerinligiDegistirButonu.Location = new Point(249, 23);
            NormalRenkDerinligiDegistirButonu.Name = "NormalRenkDerinligiDegistirButonu";
            NormalRenkDerinligiDegistirButonu.Size = new Size(186, 23);
            NormalRenkDerinligiDegistirButonu.TabIndex = 23;
            NormalRenkDerinligiDegistirButonu.Text = "Renk Derinliği Değiştir";
            NormalRenkDerinligiDegistirButonu.UseVisualStyleBackColor = true;
            // 
            // GriRenkDerinligiListesi
            // 
            GriRenkDerinligiListesi.Enabled = false;
            GriRenkDerinligiListesi.FormattingEnabled = true;
            GriRenkDerinligiListesi.Items.AddRange(new object[] { "7-bit", "6-bit", "5-bit", "4-bit", "3-bit", "2-bit", "1-bit" });
            GriRenkDerinligiListesi.Location = new Point(441, 52);
            GriRenkDerinligiListesi.Name = "GriRenkDerinligiListesi";
            GriRenkDerinligiListesi.Size = new Size(65, 23);
            GriRenkDerinligiListesi.TabIndex = 22;
            // 
            // GriRenkDerinligiButonu
            // 
            GriRenkDerinligiButonu.Enabled = false;
            GriRenkDerinligiButonu.Location = new Point(249, 52);
            GriRenkDerinligiButonu.Name = "GriRenkDerinligiButonu";
            GriRenkDerinligiButonu.Size = new Size(186, 23);
            GriRenkDerinligiButonu.TabIndex = 21;
            GriRenkDerinligiButonu.Text = "Gri Renk Derinliği Değiştir";
            GriRenkDerinligiButonu.UseVisualStyleBackColor = true;
            // 
            // BantDegisimListesi
            // 
            BantDegisimListesi.Enabled = false;
            BantDegisimListesi.FormattingEnabled = true;
            BantDegisimListesi.Items.AddRange(new object[] { "RBG", "GRB", "GBR", "BRG", "BGR" });
            BantDegisimListesi.Location = new Point(117, 81);
            BantDegisimListesi.Name = "BantDegisimListesi";
            BantDegisimListesi.Size = new Size(126, 23);
            BantDegisimListesi.TabIndex = 20;
            // 
            // BantDegisimButonu
            // 
            BantDegisimButonu.Enabled = false;
            BantDegisimButonu.Location = new Point(6, 81);
            BantDegisimButonu.Name = "BantDegisimButonu";
            BantDegisimButonu.Size = new Size(105, 23);
            BantDegisimButonu.TabIndex = 19;
            BantDegisimButonu.Text = "Bant Değiştir";
            BantDegisimButonu.UseVisualStyleBackColor = true;
            // 
            // NegatifAlmaButonu
            // 
            NegatifAlmaButonu.Enabled = false;
            NegatifAlmaButonu.Location = new Point(6, 110);
            NegatifAlmaButonu.Name = "NegatifAlmaButonu";
            NegatifAlmaButonu.Size = new Size(105, 23);
            NegatifAlmaButonu.TabIndex = 6;
            NegatifAlmaButonu.Text = "Negatifini Al";
            NegatifAlmaButonu.UseVisualStyleBackColor = true;
            // 
            // RenkveGriCevirListesi
            // 
            RenkveGriCevirListesi.Enabled = false;
            RenkveGriCevirListesi.FormattingEnabled = true;
            RenkveGriCevirListesi.Items.AddRange(new object[] { "Kırmızı", "Yeşil", "Mavi", "Kırmızıdan Gri", "Yeşilden Gri", "Maviden Gri", "Gri" });
            RenkveGriCevirListesi.Location = new Point(117, 52);
            RenkveGriCevirListesi.Name = "RenkveGriCevirListesi";
            RenkveGriCevirListesi.Size = new Size(126, 23);
            RenkveGriCevirListesi.TabIndex = 18;
            // 
            // ResmiKaydetButonu
            // 
            ResmiKaydetButonu.Enabled = false;
            ResmiKaydetButonu.Location = new Point(401, 133);
            ResmiKaydetButonu.Name = "ResmiKaydetButonu";
            ResmiKaydetButonu.Size = new Size(105, 23);
            ResmiKaydetButonu.TabIndex = 7;
            ResmiKaydetButonu.Text = "Resmi Kaydet";
            ResmiKaydetButonu.UseVisualStyleBackColor = true;
            // 
            // OrneklemeButonu
            // 
            OrneklemeButonu.Enabled = false;
            OrneklemeButonu.Location = new Point(6, 23);
            OrneklemeButonu.Name = "OrneklemeButonu";
            OrneklemeButonu.Size = new Size(105, 23);
            OrneklemeButonu.TabIndex = 13;
            OrneklemeButonu.Text = "Örnekle";
            OrneklemeButonu.UseVisualStyleBackColor = true;
            // 
            // RenkCevirButonu
            // 
            RenkCevirButonu.Enabled = false;
            RenkCevirButonu.Location = new Point(6, 52);
            RenkCevirButonu.Name = "RenkCevirButonu";
            RenkCevirButonu.Size = new Size(105, 23);
            RenkCevirButonu.TabIndex = 17;
            RenkCevirButonu.Text = "Renk Çevir";
            RenkCevirButonu.UseVisualStyleBackColor = true;
            // 
            // OrneklemeListesi
            // 
            OrneklemeListesi.Enabled = false;
            OrneklemeListesi.FormattingEnabled = true;
            OrneklemeListesi.Items.AddRange(new object[] { "1", "2", "5", "10", "25", "50" });
            OrneklemeListesi.Location = new Point(117, 23);
            OrneklemeListesi.Name = "OrneklemeListesi";
            OrneklemeListesi.Size = new Size(60, 23);
            OrneklemeListesi.TabIndex = 15;
            // 
            // RenkOrneklemeListesi
            // 
            RenkOrneklemeListesi.Enabled = false;
            RenkOrneklemeListesi.FormattingEnabled = true;
            RenkOrneklemeListesi.Items.AddRange(new object[] { "1", "5", "10", "25", "50", "100" });
            RenkOrneklemeListesi.Location = new Point(183, 23);
            RenkOrneklemeListesi.Name = "RenkOrneklemeListesi";
            RenkOrneklemeListesi.Size = new Size(60, 23);
            RenkOrneklemeListesi.TabIndex = 16;
            // 
            // GoruntuOlusturmaGrupKutusu
            // 
            GoruntuOlusturmaGrupKutusu.Controls.Add(ResimSecButonu);
            GoruntuOlusturmaGrupKutusu.Controls.Add(GriSkalaMaxDegerKutusu);
            GoruntuOlusturmaGrupKutusu.Controls.Add(DaireCozunurlukDegerKutusu);
            GoruntuOlusturmaGrupKutusu.Controls.Add(GriSkalaButonu);
            GoruntuOlusturmaGrupKutusu.Controls.Add(DaireButonu);
            GoruntuOlusturmaGrupKutusu.Location = new Point(12, 570);
            GoruntuOlusturmaGrupKutusu.Name = "GoruntuOlusturmaGrupKutusu";
            GoruntuOlusturmaGrupKutusu.Size = new Size(253, 177);
            GoruntuOlusturmaGrupKutusu.TabIndex = 30;
            GoruntuOlusturmaGrupKutusu.TabStop = false;
            GoruntuOlusturmaGrupKutusu.Text = "Görüntü Oluştur";
            // 
            // ResimSecButonu
            // 
            ResimSecButonu.Location = new Point(6, 22);
            ResimSecButonu.Name = "ResimSecButonu";
            ResimSecButonu.Size = new Size(105, 23);
            ResimSecButonu.TabIndex = 8;
            ResimSecButonu.Text = "Resim Seç";
            ResimSecButonu.UseVisualStyleBackColor = true;
            // 
            // GriSkalaMaxDegerKutusu
            // 
            GriSkalaMaxDegerKutusu.Location = new Point(117, 51);
            GriSkalaMaxDegerKutusu.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            GriSkalaMaxDegerKutusu.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            GriSkalaMaxDegerKutusu.Name = "GriSkalaMaxDegerKutusu";
            GriSkalaMaxDegerKutusu.Size = new Size(60, 23);
            GriSkalaMaxDegerKutusu.TabIndex = 9;
            GriSkalaMaxDegerKutusu.Value = new decimal(new int[] { 128, 0, 0, 0 });
            // 
            // DaireCozunurlukDegerKutusu
            // 
            DaireCozunurlukDegerKutusu.Location = new Point(117, 80);
            DaireCozunurlukDegerKutusu.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            DaireCozunurlukDegerKutusu.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            DaireCozunurlukDegerKutusu.Name = "DaireCozunurlukDegerKutusu";
            DaireCozunurlukDegerKutusu.Size = new Size(60, 23);
            DaireCozunurlukDegerKutusu.TabIndex = 12;
            DaireCozunurlukDegerKutusu.Value = new decimal(new int[] { 256, 0, 0, 0 });
            // 
            // GriSkalaButonu
            // 
            GriSkalaButonu.Location = new Point(6, 51);
            GriSkalaButonu.Name = "GriSkalaButonu";
            GriSkalaButonu.Size = new Size(105, 23);
            GriSkalaButonu.TabIndex = 10;
            GriSkalaButonu.Text = "Gri Skala Oluştur";
            GriSkalaButonu.UseVisualStyleBackColor = true;
            // 
            // DaireButonu
            // 
            DaireButonu.Location = new Point(6, 80);
            DaireButonu.Name = "DaireButonu";
            DaireButonu.Size = new Size(105, 23);
            DaireButonu.TabIndex = 11;
            DaireButonu.Text = "Daire Oluştur";
            DaireButonu.UseVisualStyleBackColor = true;
            // 
            // DegistirilmisResim
            // 
            DegistirilmisResim.BorderStyle = BorderStyle.FixedSingle;
            DegistirilmisResim.Location = new Point(1052, 52);
            DegistirilmisResim.Name = "DegistirilmisResim";
            DegistirilmisResim.Size = new Size(512, 512);
            DegistirilmisResim.SizeMode = PictureBoxSizeMode.Zoom;
            DegistirilmisResim.TabIndex = 31;
            DegistirilmisResim.TabStop = false;
            // 
            // Hafta_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1576, 764);
            Controls.Add(DegistirilmisResim);
            Controls.Add(GoruntuOlusturmaGrupKutusu);
            Controls.Add(CiktiOlcegiButonKutusu);
            Controls.Add(HistogramResmi);
            Controls.Add(toolStrip1);
            Controls.Add(OrjinalResim);
            Controls.Add(menuStrip1);
            Controls.Add(IslemlerGrupKutusu);
            Name = "Hafta_2";
            Text = "Hafta_2";
            CiktiOlcegiButonKutusu.ResumeLayout(false);
            CiktiOlcegiButonKutusu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HistogramResmi).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrjinalResim).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            IslemlerGrupKutusu.ResumeLayout(false);
            GoruntuOlusturmaGrupKutusu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GriSkalaMaxDegerKutusu).EndInit();
            ((System.ComponentModel.ISupportInitialize)DaireCozunurlukDegerKutusu).EndInit();
            ((System.ComponentModel.ISupportInitialize)DegistirilmisResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox CiktiOlcegiButonKutusu;
        private RadioButton YakinlastirButonu;
        private RadioButton MerkezleButonu;
        private RadioButton NormalButonu;
        private RadioButton SigdirButonu;
        private PictureBox HistogramResmi;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private PictureBox OrjinalResim;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem ResimSecToolbar;
        private ToolStripMenuItem hazırlıkToolStripMenuItem;
        private ToolStripMenuItem filtrelerToolStripMenuItem;
        private GroupBox IslemlerGrupKutusu;
        private ComboBox MozaiklemeListesi;
        private Button MozaiklestirmeButonu;
        private ComboBox NormalRenkDerinligiListesi;
        private Button NormalRenkDerinligiDegistirButonu;
        private ComboBox GriRenkDerinligiListesi;
        private Button GriRenkDerinligiButonu;
        private ComboBox BantDegisimListesi;
        private Button BantDegisimButonu;
        private Button NegatifAlmaButonu;
        private ComboBox RenkveGriCevirListesi;
        private Button ResmiKaydetButonu;
        private Button OrneklemeButonu;
        private Button RenkCevirButonu;
        private ComboBox OrneklemeListesi;
        private ComboBox RenkOrneklemeListesi;
        private GroupBox GoruntuOlusturmaGrupKutusu;
        private Button ResimSecButonu;
        private NumericUpDown GriSkalaMaxDegerKutusu;
        private NumericUpDown DaireCozunurlukDegerKutusu;
        private Button GriSkalaButonu;
        private Button DaireButonu;
        private PictureBox DegistirilmisResim;
    }
}