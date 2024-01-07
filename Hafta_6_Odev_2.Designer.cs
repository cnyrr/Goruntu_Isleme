namespace Görüntü_İşleme
{
    partial class Hafta_6_Odev_2
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
            Button uygula;
            button1 = new Button();
            resimkaydet = new Button();
            resimyukle = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            trackBar1 = new TrackBar();
            uygula = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // uygula
            // 
            uygula.Location = new Point(521, 319);
            uygula.Name = "uygula";
            uygula.Size = new Size(94, 29);
            uygula.TabIndex = 14;
            uygula.Text = "uygula";
            uygula.UseVisualStyleBackColor = true;
            uygula.Click += uygula_Click;
            // 
            // button1
            // 
            button1.Location = new Point(581, 363);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 21;
            button1.Text = "normalizasyon";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resimkaydet
            // 
            resimkaydet.Location = new Point(639, 319);
            resimkaydet.Name = "resimkaydet";
            resimkaydet.Size = new Size(106, 29);
            resimkaydet.TabIndex = 18;
            resimkaydet.Text = "resim kaydet";
            resimkaydet.UseVisualStyleBackColor = true;
            resimkaydet.Click += resimkaydet_Click;
            // 
            // resimyukle
            // 
            resimyukle.Location = new Point(120, 319);
            resimyukle.Name = "resimyukle";
            resimyukle.Size = new Size(94, 29);
            resimyukle.TabIndex = 13;
            resimyukle.Text = "resim yükle";
            resimyukle.UseVisualStyleBackColor = true;
            resimyukle.Click += resimyukle_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(440, 48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(264, 235);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(55, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(315, 329);
            trackBar1.Maximum = 13;
            trackBar1.Minimum = 5;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(130, 56);
            trackBar1.SmallChange = 2;
            trackBar1.TabIndex = 22;
            trackBar1.Value = 5;
            // 
            // Odev2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBar1);
            Controls.Add(button1);
            Controls.Add(resimkaydet);
            Controls.Add(uygula);
            Controls.Add(resimyukle);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Odev2";
            Text = "Odev2";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button resimkaydet;
        private Button resimyukle;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private TrackBar trackBar1;
    }
}