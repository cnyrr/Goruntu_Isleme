namespace Görüntü_İşleme
{
    partial class Hafta_9_Odev_8
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
            Yazili = new PictureBox();
            ResimAcButonu = new Button();
            ResmiKaydetButonu = new Button();
            ResmeEkleButonu = new Button();
            YazilacakMetin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Orjinal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Yazili).BeginInit();
            SuspendLayout();
            // 
            // Orjinal
            // 
            Orjinal.Location = new Point(12, 12);
            Orjinal.Name = "Orjinal";
            Orjinal.Size = new Size(512, 512);
            Orjinal.SizeMode = PictureBoxSizeMode.Zoom;
            Orjinal.TabIndex = 0;
            Orjinal.TabStop = false;
            // 
            // Yazili
            // 
            Yazili.Location = new Point(530, 12);
            Yazili.Name = "Yazili";
            Yazili.Size = new Size(512, 512);
            Yazili.SizeMode = PictureBoxSizeMode.Zoom;
            Yazili.TabIndex = 1;
            Yazili.TabStop = false;
            // 
            // ResimAcButonu
            // 
            ResimAcButonu.Location = new Point(12, 599);
            ResimAcButonu.Name = "ResimAcButonu";
            ResimAcButonu.Size = new Size(120, 42);
            ResimAcButonu.TabIndex = 2;
            ResimAcButonu.Text = "Resim Aç";
            ResimAcButonu.UseVisualStyleBackColor = true;
            ResimAcButonu.Click += ResimAcButonu_Click;
            // 
            // ResmiKaydetButonu
            // 
            ResmiKaydetButonu.Location = new Point(922, 599);
            ResmiKaydetButonu.Name = "ResmiKaydetButonu";
            ResmiKaydetButonu.Size = new Size(120, 42);
            ResmiKaydetButonu.TabIndex = 3;
            ResmiKaydetButonu.Text = "Resmi Kaydet";
            ResmiKaydetButonu.UseVisualStyleBackColor = true;
            // 
            // ResmeEkleButonu
            // 
            ResmeEkleButonu.Location = new Point(922, 530);
            ResmeEkleButonu.Name = "ResmeEkleButonu";
            ResmeEkleButonu.Size = new Size(120, 42);
            ResmeEkleButonu.TabIndex = 4;
            ResmeEkleButonu.Text = "Metni Ekle";
            ResmeEkleButonu.UseVisualStyleBackColor = true;
            ResmeEkleButonu.Click += ResmeEkleButonu_Click;
            // 
            // YazilacakMetin
            // 
            YazilacakMetin.Location = new Point(530, 541);
            YazilacakMetin.Name = "YazilacakMetin";
            YazilacakMetin.Size = new Size(384, 23);
            YazilacakMetin.TabIndex = 5;
            // 
            // Hafta_9_Odev_8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 653);
            Controls.Add(YazilacakMetin);
            Controls.Add(ResmeEkleButonu);
            Controls.Add(ResmiKaydetButonu);
            Controls.Add(ResimAcButonu);
            Controls.Add(Yazili);
            Controls.Add(Orjinal);
            Name = "Hafta_9_Odev_8";
            Text = "Hafta_9_Odev_8";
            ((System.ComponentModel.ISupportInitialize)Orjinal).EndInit();
            ((System.ComponentModel.ISupportInitialize)Yazili).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Orjinal;
        private PictureBox Yazili;
        private Button ResimAcButonu;
        private Button ResmiKaydetButonu;
        private Button ResmeEkleButonu;
        private TextBox YazilacakMetin;
    }
}