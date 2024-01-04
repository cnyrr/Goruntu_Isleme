namespace Görüntü_İşleme
{
    partial class Hafta_2_Odev_1
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
            Degistirilmis = new PictureBox();
            ParlaklikBar = new TrackBar();
            ParlaklikMetin = new Label();
            ResimAcButonu = new Button();
            ResmiKaydetButonu = new Button();
            GrupKutusu = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)Orjinal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Degistirilmis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ParlaklikBar).BeginInit();
            GrupKutusu.SuspendLayout();
            SuspendLayout();
            // 
            // Orjinal
            // 
            Orjinal.BorderStyle = BorderStyle.FixedSingle;
            Orjinal.Location = new Point(12, 12);
            Orjinal.Name = "Orjinal";
            Orjinal.Size = new Size(512, 512);
            Orjinal.SizeMode = PictureBoxSizeMode.Zoom;
            Orjinal.TabIndex = 0;
            Orjinal.TabStop = false;
            // 
            // Degistirilmis
            // 
            Degistirilmis.BorderStyle = BorderStyle.FixedSingle;
            Degistirilmis.Location = new Point(530, 12);
            Degistirilmis.Name = "Degistirilmis";
            Degistirilmis.Size = new Size(512, 512);
            Degistirilmis.SizeMode = PictureBoxSizeMode.Zoom;
            Degistirilmis.TabIndex = 1;
            Degistirilmis.TabStop = false;
            // 
            // ParlaklikBar
            // 
            ParlaklikBar.BackColor = SystemColors.Control;
            ParlaklikBar.Enabled = false;
            ParlaklikBar.Location = new Point(518, 49);
            ParlaklikBar.Maximum = 255;
            ParlaklikBar.Minimum = -255;
            ParlaklikBar.Name = "ParlaklikBar";
            ParlaklikBar.Size = new Size(506, 45);
            ParlaklikBar.TabIndex = 4;
            ParlaklikBar.TickStyle = TickStyle.None;
            ParlaklikBar.MouseUp += ParlaklikBar_MouseUp;
            // 
            // ParlaklikMetin
            // 
            ParlaklikMetin.AutoSize = true;
            ParlaklikMetin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ParlaklikMetin.Location = new Point(518, 18);
            ParlaklikMetin.Name = "ParlaklikMetin";
            ParlaklikMetin.Size = new Size(108, 15);
            ParlaklikMetin.TabIndex = 5;
            ParlaklikMetin.Text = "Parlaklık Değişimi:";
            // 
            // ResimAcButonu
            // 
            ResimAcButonu.Location = new Point(6, 18);
            ResimAcButonu.Name = "ResimAcButonu";
            ResimAcButonu.Size = new Size(128, 48);
            ResimAcButonu.TabIndex = 6;
            ResimAcButonu.Text = "Resim Aç";
            ResimAcButonu.UseVisualStyleBackColor = true;
            ResimAcButonu.Click += ResimAcButonu_Click;
            // 
            // ResmiKaydetButonu
            // 
            ResmiKaydetButonu.Enabled = false;
            ResmiKaydetButonu.Location = new Point(896, 110);
            ResmiKaydetButonu.Name = "ResmiKaydetButonu";
            ResmiKaydetButonu.Size = new Size(128, 48);
            ResmiKaydetButonu.TabIndex = 7;
            ResmiKaydetButonu.Text = "Resmi Kaydet";
            ResmiKaydetButonu.UseVisualStyleBackColor = true;
            ResmiKaydetButonu.Click += ResmiKaydetButonu_Click;
            // 
            // GrupKutusu
            // 
            GrupKutusu.Controls.Add(ParlaklikMetin);
            GrupKutusu.Controls.Add(ResmiKaydetButonu);
            GrupKutusu.Controls.Add(ParlaklikBar);
            GrupKutusu.Controls.Add(ResimAcButonu);
            GrupKutusu.Location = new Point(12, 530);
            GrupKutusu.Name = "GrupKutusu";
            GrupKutusu.Size = new Size(1030, 164);
            GrupKutusu.TabIndex = 8;
            GrupKutusu.TabStop = false;
            // 
            // Hafta_2_Odev_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 706);
            Controls.Add(Degistirilmis);
            Controls.Add(Orjinal);
            Controls.Add(GrupKutusu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Hafta_2_Odev_1";
            ShowIcon = false;
            Text = "Hafta 2 Ödev 1";
            ((System.ComponentModel.ISupportInitialize)Orjinal).EndInit();
            ((System.ComponentModel.ISupportInitialize)Degistirilmis).EndInit();
            ((System.ComponentModel.ISupportInitialize)ParlaklikBar).EndInit();
            GrupKutusu.ResumeLayout(false);
            GrupKutusu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Orjinal;
        private PictureBox Degistirilmis;
        private TrackBar ParlaklikBar;
        private Label ParlaklikMetin;
        private Button ResimAcButonu;
        private Button ResmiKaydetButonu;
        private GroupBox GrupKutusu;
    }
}