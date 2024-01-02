namespace Görüntü_İşleme
{
    partial class Hafta_1_Odev_1
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
            YakinlastirButonu = new RadioButton();
            MerkezleButonu = new RadioButton();
            NormalButonu = new RadioButton();
            SigdirButonu = new RadioButton();
            GoruntuOlusturmaGrupKutusu = new GroupBox();
            GriSkalaDegerKutusu = new NumericUpDown();
            GriSkalaButonu = new Button();
            ((System.ComponentModel.ISupportInitialize)Orjinal).BeginInit();
            GoruntuOlusturmaGrupKutusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GriSkalaDegerKutusu).BeginInit();
            SuspendLayout();
            // 
            // Orjinal
            // 
            Orjinal.BorderStyle = BorderStyle.FixedSingle;
            Orjinal.Location = new Point(12, 12);
            Orjinal.Name = "Orjinal";
            Orjinal.Size = new Size(512, 512);
            Orjinal.SizeMode = PictureBoxSizeMode.Zoom;
            Orjinal.TabIndex = 4;
            Orjinal.TabStop = false;
            // 
            // YakinlastirButonu
            // 
            YakinlastirButonu.AutoSize = true;
            YakinlastirButonu.Location = new Point(428, 97);
            YakinlastirButonu.Name = "YakinlastirButonu";
            YakinlastirButonu.RightToLeft = RightToLeft.Yes;
            YakinlastirButonu.Size = new Size(78, 19);
            YakinlastirButonu.TabIndex = 3;
            YakinlastirButonu.TabStop = true;
            YakinlastirButonu.Text = "Yakınlaştır";
            YakinlastirButonu.UseVisualStyleBackColor = true;
            YakinlastirButonu.CheckedChanged += YakinlastirButonu_CheckedChanged;
            // 
            // MerkezleButonu
            // 
            MerkezleButonu.AutoSize = true;
            MerkezleButonu.Location = new Point(434, 72);
            MerkezleButonu.Name = "MerkezleButonu";
            MerkezleButonu.RightToLeft = RightToLeft.Yes;
            MerkezleButonu.Size = new Size(72, 19);
            MerkezleButonu.TabIndex = 1;
            MerkezleButonu.TabStop = true;
            MerkezleButonu.Text = "Merkezle";
            MerkezleButonu.UseVisualStyleBackColor = true;
            MerkezleButonu.CheckedChanged += MerkezleButonu_CheckedChanged;
            // 
            // NormalButonu
            // 
            NormalButonu.AutoSize = true;
            NormalButonu.Location = new Point(441, 22);
            NormalButonu.Name = "NormalButonu";
            NormalButonu.RightToLeft = RightToLeft.Yes;
            NormalButonu.Size = new Size(65, 19);
            NormalButonu.TabIndex = 0;
            NormalButonu.TabStop = true;
            NormalButonu.Text = "Normal";
            NormalButonu.UseVisualStyleBackColor = true;
            NormalButonu.CheckedChanged += NormalButonu_CheckedChanged;
            // 
            // SigdirButonu
            // 
            SigdirButonu.AutoSize = true;
            SigdirButonu.Location = new Point(451, 47);
            SigdirButonu.Name = "SigdirButonu";
            SigdirButonu.RightToLeft = RightToLeft.Yes;
            SigdirButonu.Size = new Size(55, 19);
            SigdirButonu.TabIndex = 2;
            SigdirButonu.TabStop = true;
            SigdirButonu.Text = "Sığdır";
            SigdirButonu.UseVisualStyleBackColor = true;
            SigdirButonu.CheckedChanged += SigdirButonu_CheckedChanged;
            // 
            // GoruntuOlusturmaGrupKutusu
            // 
            GoruntuOlusturmaGrupKutusu.Controls.Add(YakinlastirButonu);
            GoruntuOlusturmaGrupKutusu.Controls.Add(MerkezleButonu);
            GoruntuOlusturmaGrupKutusu.Controls.Add(GriSkalaDegerKutusu);
            GoruntuOlusturmaGrupKutusu.Controls.Add(NormalButonu);
            GoruntuOlusturmaGrupKutusu.Controls.Add(GriSkalaButonu);
            GoruntuOlusturmaGrupKutusu.Controls.Add(SigdirButonu);
            GoruntuOlusturmaGrupKutusu.Location = new Point(12, 530);
            GoruntuOlusturmaGrupKutusu.Name = "GoruntuOlusturmaGrupKutusu";
            GoruntuOlusturmaGrupKutusu.Size = new Size(512, 130);
            GoruntuOlusturmaGrupKutusu.TabIndex = 23;
            GoruntuOlusturmaGrupKutusu.TabStop = false;
            GoruntuOlusturmaGrupKutusu.Text = "Görüntü Oluştur";
            // 
            // GriSkalaDegerKutusu
            // 
            GriSkalaDegerKutusu.Location = new Point(117, 22);
            GriSkalaDegerKutusu.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            GriSkalaDegerKutusu.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            GriSkalaDegerKutusu.Name = "GriSkalaDegerKutusu";
            GriSkalaDegerKutusu.Size = new Size(60, 23);
            GriSkalaDegerKutusu.TabIndex = 9;
            GriSkalaDegerKutusu.Value = new decimal(new int[] { 128, 0, 0, 0 });
            // 
            // GriSkalaButonu
            // 
            GriSkalaButonu.Location = new Point(6, 22);
            GriSkalaButonu.Name = "GriSkalaButonu";
            GriSkalaButonu.Size = new Size(105, 23);
            GriSkalaButonu.TabIndex = 10;
            GriSkalaButonu.Text = "Gri Skala Oluştur";
            GriSkalaButonu.UseVisualStyleBackColor = true;
            GriSkalaButonu.Click += GriSkalaButonu_Click;
            // 
            // Hafta_1_Odev_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 674);
            Controls.Add(GoruntuOlusturmaGrupKutusu);
            Controls.Add(Orjinal);
            Name = "Hafta_1_Odev_1";
            Text = "Hafta_1_Odev_1";
            ((System.ComponentModel.ISupportInitialize)Orjinal).EndInit();
            GoruntuOlusturmaGrupKutusu.ResumeLayout(false);
            GoruntuOlusturmaGrupKutusu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GriSkalaDegerKutusu).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox Orjinal;
        private RadioButton YakinlastirButonu;
        private RadioButton MerkezleButonu;
        private RadioButton NormalButonu;
        private RadioButton SigdirButonu;
        private GroupBox GoruntuOlusturmaGrupKutusu;
        private NumericUpDown GriSkalaDegerKutusu;
        private Button GriSkalaButonu;
    }
}