namespace Görüntü_İşleme
{
    partial class Hafta_2_Odev_2
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
            Orjinal = new PictureBox();
            OrjinalHistogramR = new PictureBox();
            GrupKutusu = new GroupBox();
            RenkModuKutusu = new CheckBox();
            BTavanEsikMetin = new Label();
            BTavanEsikBar = new TrackBar();
            BTabanEsikMetin = new Label();
            BTabanEsikBar = new TrackBar();
            GTavanEsikMetin = new Label();
            GTavanEsikBar = new TrackBar();
            GTabanEsikMetin = new Label();
            GTabanEsikBar = new TrackBar();
            ResimEsikleButonu = new Button();
            ResmiKaydetButonu = new Button();
            ResimAcButonu = new Button();
            GriveRTavanEsikBar = new TrackBar();
            GriveRTavanEsikMetin = new Label();
            GriveRTabanEsikBar = new TrackBar();
            GriveRTabanEsikMetin = new Label();
            Degistirilmis = new PictureBox();
            DegistirilmisHistogramR = new PictureBox();
            OrjinalHistogramG = new PictureBox();
            OrjinalHistogramB = new PictureBox();
            DegistirilmisHistogramG = new PictureBox();
            DegistirilmisHistogramB = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Orjinal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrjinalHistogramR).BeginInit();
            GrupKutusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BTavanEsikBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BTabanEsikBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GTavanEsikBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GTabanEsikBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GriveRTavanEsikBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GriveRTabanEsikBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Degistirilmis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DegistirilmisHistogramR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrjinalHistogramG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrjinalHistogramB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DegistirilmisHistogramG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DegistirilmisHistogramB).BeginInit();
            SuspendLayout();
            // 
            // Orjinal
            // 
            Orjinal.BorderStyle = BorderStyle.FixedSingle;
            Orjinal.Location = new Point(12, 12);
            Orjinal.Name = "Orjinal";
            Orjinal.Size = new Size(256, 256);
            Orjinal.SizeMode = PictureBoxSizeMode.Zoom;
            Orjinal.TabIndex = 0;
            Orjinal.TabStop = false;
            // 
            // OrjinalHistogramR
            // 
            OrjinalHistogramR.BorderStyle = BorderStyle.FixedSingle;
            OrjinalHistogramR.Location = new Point(274, 12);
            OrjinalHistogramR.Name = "OrjinalHistogramR";
            OrjinalHistogramR.Size = new Size(256, 256);
            OrjinalHistogramR.SizeMode = PictureBoxSizeMode.CenterImage;
            OrjinalHistogramR.TabIndex = 1;
            OrjinalHistogramR.TabStop = false;
            // 
            // GrupKutusu
            // 
            GrupKutusu.Controls.Add(RenkModuKutusu);
            GrupKutusu.Controls.Add(BTavanEsikMetin);
            GrupKutusu.Controls.Add(BTavanEsikBar);
            GrupKutusu.Controls.Add(BTabanEsikMetin);
            GrupKutusu.Controls.Add(BTabanEsikBar);
            GrupKutusu.Controls.Add(GTavanEsikMetin);
            GrupKutusu.Controls.Add(GTavanEsikBar);
            GrupKutusu.Controls.Add(GTabanEsikMetin);
            GrupKutusu.Controls.Add(GTabanEsikBar);
            GrupKutusu.Controls.Add(ResimEsikleButonu);
            GrupKutusu.Controls.Add(ResmiKaydetButonu);
            GrupKutusu.Controls.Add(ResimAcButonu);
            GrupKutusu.Controls.Add(GriveRTavanEsikBar);
            GrupKutusu.Controls.Add(GriveRTavanEsikMetin);
            GrupKutusu.Controls.Add(GriveRTabanEsikBar);
            GrupKutusu.Controls.Add(GriveRTabanEsikMetin);
            GrupKutusu.Location = new Point(1064, 12);
            GrupKutusu.Name = "GrupKutusu";
            GrupKutusu.Size = new Size(321, 518);
            GrupKutusu.TabIndex = 9;
            GrupKutusu.TabStop = false;
            // 
            // RenkModuKutusu
            // 
            RenkModuKutusu.AutoSize = true;
            RenkModuKutusu.Checked = true;
            RenkModuKutusu.CheckState = CheckState.Checked;
            RenkModuKutusu.Location = new Point(6, 464);
            RenkModuKutusu.Name = "RenkModuKutusu";
            RenkModuKutusu.Size = new Size(83, 19);
            RenkModuKutusu.TabIndex = 25;
            RenkModuKutusu.Text = "RGB Modu";
            RenkModuKutusu.UseVisualStyleBackColor = true;
            RenkModuKutusu.CheckedChanged += RenkModuKutusu_CheckedChanged;
            // 
            // BTavanEsikMetin
            // 
            BTavanEsikMetin.AutoSize = true;
            BTavanEsikMetin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BTavanEsikMetin.Location = new Point(6, 283);
            BTavanEsikMetin.Name = "BTavanEsikMetin";
            BTavanEsikMetin.Size = new Size(181, 15);
            BTavanEsikMetin.TabIndex = 24;
            BTavanEsikMetin.Text = "Mavi Ton Tavan Eşik Değer: 255";
            // 
            // BTavanEsikBar
            // 
            BTavanEsikBar.BackColor = SystemColors.Control;
            BTavanEsikBar.Enabled = false;
            BTavanEsikBar.Location = new Point(6, 301);
            BTavanEsikBar.Maximum = 255;
            BTavanEsikBar.Name = "BTavanEsikBar";
            BTavanEsikBar.Size = new Size(310, 45);
            BTavanEsikBar.TabIndex = 23;
            BTavanEsikBar.TickStyle = TickStyle.None;
            BTavanEsikBar.Value = 255;
            BTavanEsikBar.ValueChanged += BTavanEsikBar_ValueChanged;
            // 
            // BTabanEsikMetin
            // 
            BTabanEsikMetin.AutoSize = true;
            BTabanEsikMetin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BTabanEsikMetin.Location = new Point(6, 245);
            BTabanEsikMetin.Name = "BTabanEsikMetin";
            BTabanEsikMetin.Size = new Size(167, 15);
            BTabanEsikMetin.TabIndex = 22;
            BTabanEsikMetin.Text = "Mavi Ton Taban Eşik Değer: 0";
            // 
            // BTabanEsikBar
            // 
            BTabanEsikBar.BackColor = SystemColors.Control;
            BTabanEsikBar.Enabled = false;
            BTabanEsikBar.Location = new Point(6, 263);
            BTabanEsikBar.Maximum = 255;
            BTabanEsikBar.Name = "BTabanEsikBar";
            BTabanEsikBar.Size = new Size(310, 45);
            BTabanEsikBar.TabIndex = 21;
            BTabanEsikBar.TickStyle = TickStyle.None;
            BTabanEsikBar.ValueChanged += BTabanEsikBar_ValueChanged;
            // 
            // GTavanEsikMetin
            // 
            GTavanEsikMetin.AutoSize = true;
            GTavanEsikMetin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GTavanEsikMetin.Location = new Point(6, 197);
            GTavanEsikMetin.Name = "GTavanEsikMetin";
            GTavanEsikMetin.Size = new Size(181, 15);
            GTavanEsikMetin.TabIndex = 20;
            GTavanEsikMetin.Text = "Yeşil Ton Tavan Eşik Değer:  255";
            // 
            // GTavanEsikBar
            // 
            GTavanEsikBar.BackColor = SystemColors.Control;
            GTavanEsikBar.Enabled = false;
            GTavanEsikBar.Location = new Point(6, 215);
            GTavanEsikBar.Maximum = 255;
            GTavanEsikBar.Name = "GTavanEsikBar";
            GTavanEsikBar.Size = new Size(310, 45);
            GTavanEsikBar.TabIndex = 19;
            GTavanEsikBar.TickStyle = TickStyle.None;
            GTavanEsikBar.Value = 255;
            GTavanEsikBar.ValueChanged += GTavanEsikBar_ValueChanged;
            // 
            // GTabanEsikMetin
            // 
            GTabanEsikMetin.AutoSize = true;
            GTabanEsikMetin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GTabanEsikMetin.Location = new Point(6, 159);
            GTabanEsikMetin.Name = "GTabanEsikMetin";
            GTabanEsikMetin.Size = new Size(164, 15);
            GTabanEsikMetin.TabIndex = 18;
            GTabanEsikMetin.Text = "Yeşil Ton Taban Eşik Değer: 0";
            // 
            // GTabanEsikBar
            // 
            GTabanEsikBar.BackColor = SystemColors.Control;
            GTabanEsikBar.Enabled = false;
            GTabanEsikBar.Location = new Point(6, 177);
            GTabanEsikBar.Maximum = 255;
            GTabanEsikBar.Name = "GTabanEsikBar";
            GTabanEsikBar.Size = new Size(310, 45);
            GTabanEsikBar.TabIndex = 17;
            GTabanEsikBar.TickStyle = TickStyle.None;
            GTabanEsikBar.ValueChanged += GTabanEsikBar_ValueChanged;
            // 
            // ResimEsikleButonu
            // 
            ResimEsikleButonu.Location = new Point(187, 22);
            ResimEsikleButonu.Name = "ResimEsikleButonu";
            ResimEsikleButonu.Size = new Size(128, 48);
            ResimEsikleButonu.TabIndex = 12;
            ResimEsikleButonu.Text = "Resmi Eşikle";
            ResimEsikleButonu.UseVisualStyleBackColor = true;
            ResimEsikleButonu.Click += ResimEsikleButonu_Click;
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
            // GriveRTavanEsikBar
            // 
            GriveRTavanEsikBar.BackColor = SystemColors.Control;
            GriveRTavanEsikBar.Enabled = false;
            GriveRTavanEsikBar.Location = new Point(6, 129);
            GriveRTavanEsikBar.Maximum = 255;
            GriveRTavanEsikBar.Name = "GriveRTavanEsikBar";
            GriveRTavanEsikBar.Size = new Size(310, 45);
            GriveRTavanEsikBar.TabIndex = 28;
            GriveRTavanEsikBar.TickStyle = TickStyle.None;
            GriveRTavanEsikBar.Value = 255;
            GriveRTavanEsikBar.ValueChanged += GriveRTavanEsikBar_ValueChanged;
            // 
            // GriveRTavanEsikMetin
            // 
            GriveRTavanEsikMetin.AutoSize = true;
            GriveRTavanEsikMetin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GriveRTavanEsikMetin.Location = new Point(9, 111);
            GriveRTavanEsikMetin.Name = "GriveRTavanEsikMetin";
            GriveRTavanEsikMetin.Size = new Size(193, 15);
            GriveRTavanEsikMetin.TabIndex = 29;
            GriveRTavanEsikMetin.Text = "Kırmızı Ton Tavan Eşik Değer: 255";
            // 
            // GriveRTabanEsikBar
            // 
            GriveRTabanEsikBar.BackColor = SystemColors.Control;
            GriveRTabanEsikBar.Enabled = false;
            GriveRTabanEsikBar.Location = new Point(5, 91);
            GriveRTabanEsikBar.Maximum = 255;
            GriveRTabanEsikBar.Name = "GriveRTabanEsikBar";
            GriveRTabanEsikBar.Size = new Size(310, 45);
            GriveRTabanEsikBar.TabIndex = 26;
            GriveRTabanEsikBar.TickStyle = TickStyle.None;
            GriveRTabanEsikBar.ValueChanged += GriveRTabanEsikBar_ValueChanged;
            // 
            // GriveRTabanEsikMetin
            // 
            GriveRTabanEsikMetin.AutoSize = true;
            GriveRTabanEsikMetin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GriveRTabanEsikMetin.Location = new Point(5, 73);
            GriveRTabanEsikMetin.Name = "GriveRTabanEsikMetin";
            GriveRTabanEsikMetin.Size = new Size(179, 15);
            GriveRTabanEsikMetin.TabIndex = 27;
            GriveRTabanEsikMetin.Text = "Kırmızı Ton Taban Eşik Değer: 0";
            // 
            // Degistirilmis
            // 
            Degistirilmis.BorderStyle = BorderStyle.FixedSingle;
            Degistirilmis.Location = new Point(12, 274);
            Degistirilmis.Name = "Degistirilmis";
            Degistirilmis.Size = new Size(256, 256);
            Degistirilmis.SizeMode = PictureBoxSizeMode.Zoom;
            Degistirilmis.TabIndex = 10;
            Degistirilmis.TabStop = false;
            // 
            // DegistirilmisHistogramR
            // 
            DegistirilmisHistogramR.BorderStyle = BorderStyle.FixedSingle;
            DegistirilmisHistogramR.Location = new Point(274, 274);
            DegistirilmisHistogramR.Name = "DegistirilmisHistogramR";
            DegistirilmisHistogramR.Size = new Size(256, 256);
            DegistirilmisHistogramR.SizeMode = PictureBoxSizeMode.CenterImage;
            DegistirilmisHistogramR.TabIndex = 11;
            DegistirilmisHistogramR.TabStop = false;
            // 
            // OrjinalHistogramG
            // 
            OrjinalHistogramG.BorderStyle = BorderStyle.FixedSingle;
            OrjinalHistogramG.Location = new Point(536, 12);
            OrjinalHistogramG.Name = "OrjinalHistogramG";
            OrjinalHistogramG.Size = new Size(256, 256);
            OrjinalHistogramG.SizeMode = PictureBoxSizeMode.CenterImage;
            OrjinalHistogramG.TabIndex = 12;
            OrjinalHistogramG.TabStop = false;
            // 
            // OrjinalHistogramB
            // 
            OrjinalHistogramB.BorderStyle = BorderStyle.FixedSingle;
            OrjinalHistogramB.Location = new Point(798, 12);
            OrjinalHistogramB.Name = "OrjinalHistogramB";
            OrjinalHistogramB.Size = new Size(256, 256);
            OrjinalHistogramB.SizeMode = PictureBoxSizeMode.CenterImage;
            OrjinalHistogramB.TabIndex = 13;
            OrjinalHistogramB.TabStop = false;
            // 
            // DegistirilmisHistogramG
            // 
            DegistirilmisHistogramG.BorderStyle = BorderStyle.FixedSingle;
            DegistirilmisHistogramG.Location = new Point(536, 274);
            DegistirilmisHistogramG.Name = "DegistirilmisHistogramG";
            DegistirilmisHistogramG.Size = new Size(256, 256);
            DegistirilmisHistogramG.SizeMode = PictureBoxSizeMode.CenterImage;
            DegistirilmisHistogramG.TabIndex = 14;
            DegistirilmisHistogramG.TabStop = false;
            // 
            // DegistirilmisHistogramB
            // 
            DegistirilmisHistogramB.BorderStyle = BorderStyle.FixedSingle;
            DegistirilmisHistogramB.Location = new Point(798, 274);
            DegistirilmisHistogramB.Name = "DegistirilmisHistogramB";
            DegistirilmisHistogramB.Size = new Size(256, 256);
            DegistirilmisHistogramB.SizeMode = PictureBoxSizeMode.CenterImage;
            DegistirilmisHistogramB.TabIndex = 15;
            DegistirilmisHistogramB.TabStop = false;
            // 
            // Hafta_2_Odev_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 539);
            Controls.Add(DegistirilmisHistogramB);
            Controls.Add(DegistirilmisHistogramG);
            Controls.Add(OrjinalHistogramB);
            Controls.Add(OrjinalHistogramG);
            Controls.Add(DegistirilmisHistogramR);
            Controls.Add(Degistirilmis);
            Controls.Add(GrupKutusu);
            Controls.Add(OrjinalHistogramR);
            Controls.Add(Orjinal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Hafta_2_Odev_2";
            Text = "Hafta_2_Odev_2";
            ((System.ComponentModel.ISupportInitialize)Orjinal).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrjinalHistogramR).EndInit();
            GrupKutusu.ResumeLayout(false);
            GrupKutusu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BTavanEsikBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BTabanEsikBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)GTavanEsikBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)GTabanEsikBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)GriveRTavanEsikBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)GriveRTabanEsikBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Degistirilmis).EndInit();
            ((System.ComponentModel.ISupportInitialize)DegistirilmisHistogramR).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrjinalHistogramG).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrjinalHistogramB).EndInit();
            ((System.ComponentModel.ISupportInitialize)DegistirilmisHistogramG).EndInit();
            ((System.ComponentModel.ISupportInitialize)DegistirilmisHistogramB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Orjinal;
        private PictureBox OrjinalHistogramR;
        private GroupBox GrupKutusu;
        private Button ResmiKaydetButonu;
        private Button ResimAcButonu;
        private PictureBox Degistirilmis;
        private PictureBox DegistirilmisHistogramR;
        private Button ResimEsikleButonu;
        private PictureBox OrjinalHistogramG;
        private PictureBox OrjinalHistogramB;
        private PictureBox DegistirilmisHistogramG;
        private PictureBox DegistirilmisHistogramB;
        private Label BTavanEsikMetin;
        private TrackBar BTavanEsikBar;
        private Label BTabanEsikMetin;
        private TrackBar BTabanEsikBar;
        private Label GTavanEsikMetin;
        private TrackBar GTavanEsikBar;
        private Label GTabanEsikMetin;
        private TrackBar GTabanEsikBar;
        private CheckBox RenkModuKutusu;
        private Label GriveRTavanEsikMetin;
        private Label GriveRTabanEsikMetin;
        private TrackBar GriveRTabanEsikBar;
        private TrackBar GriveRTavanEsikBar;
    }
}