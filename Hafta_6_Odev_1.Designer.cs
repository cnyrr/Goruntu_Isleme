namespace Görüntü_İşleme
{
    partial class Hafta_6_Odev_1
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            resimyukle = new Button();
            mean = new RadioButton();
            gauss = new RadioButton();
            median = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            resimkaydet = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            uygula = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // uygula
            // 
            uygula.Location = new Point(528, 321);
            uygula.Name = "uygula";
            uygula.Size = new Size(94, 29);
            uygula.TabIndex = 3;
            uygula.Text = "uygula";
            uygula.UseVisualStyleBackColor = true;
            uygula.Click += uygula_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(62, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(447, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(264, 235);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // resimyukle
            // 
            resimyukle.Location = new Point(127, 321);
            resimyukle.Name = "resimyukle";
            resimyukle.Size = new Size(94, 29);
            resimyukle.TabIndex = 2;
            resimyukle.Text = "resim yükle";
            resimyukle.UseVisualStyleBackColor = true;
            resimyukle.Click += resimyukle_Click;
            // 
            // mean
            // 
            mean.AutoSize = true;
            mean.Location = new Point(277, 321);
            mean.Name = "mean";
            mean.Size = new Size(125, 24);
            mean.TabIndex = 4;
            mean.TabStop = true;
            mean.Text = "Mean Yöntemi";
            mean.UseVisualStyleBackColor = true;
            // 
            // gauss
            // 
            gauss.AutoSize = true;
            gauss.Location = new Point(277, 381);
            gauss.Name = "gauss";
            gauss.Size = new Size(126, 24);
            gauss.TabIndex = 5;
            gauss.TabStop = true;
            gauss.Text = "Gauss Yöntemi";
            gauss.UseVisualStyleBackColor = true;
            // 
            // median
            // 
            median.AutoSize = true;
            median.Location = new Point(276, 351);
            median.Name = "median";
            median.Size = new Size(138, 24);
            median.TabIndex = 6;
            median.TabStop = true;
            median.Text = "Median Yöntemi";
            median.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // resimkaydet
            // 
            resimkaydet.Location = new Point(646, 321);
            resimkaydet.Name = "resimkaydet";
            resimkaydet.Size = new Size(106, 29);
            resimkaydet.TabIndex = 7;
            resimkaydet.Text = "resim kaydet";
            resimkaydet.UseVisualStyleBackColor = true;
            resimkaydet.Click += resimkaydet_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(408, 323);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(59, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(303, 291);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 27);
            textBox2.TabIndex = 9;
            textBox2.Text = "Mean için şablon boyutu girin";
            // 
            // button1
            // 
            button1.Location = new Point(588, 365);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 10;
            button1.Text = "normalizasyon";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Odev1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(resimkaydet);
            Controls.Add(median);
            Controls.Add(gauss);
            Controls.Add(mean);
            Controls.Add(uygula);
            Controls.Add(resimyukle);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Odev1";
            Text = "Odev1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button resimyukle;
        private Button uygula;
        private RadioButton mean;
        private RadioButton gauss;
        private RadioButton median;
        private OpenFileDialog openFileDialog1;
        private Button resimkaydet;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}