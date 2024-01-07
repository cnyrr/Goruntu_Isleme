namespace Görüntü_İşleme
{
    partial class Hafta_5_Odev_5
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
            components = new System.ComponentModel.Container();
            mean = new Button();
            resim_sec = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mean
            // 
            mean.Location = new Point(11, 76);
            mean.Margin = new Padding(2);
            mean.Name = "mean";
            mean.Size = new Size(74, 21);
            mean.TabIndex = 1;
            mean.Text = "Mean";
            mean.UseVisualStyleBackColor = true;
            mean.Click += mean_Click;
            // 
            // resim_sec
            // 
            resim_sec.Location = new Point(11, 11);
            resim_sec.Margin = new Padding(2);
            resim_sec.Name = "resim_sec";
            resim_sec.Size = new Size(85, 21);
            resim_sec.TabIndex = 2;
            resim_sec.Text = "resim sec";
            resim_sec.UseVisualStyleBackColor = true;
            resim_sec.Click += resim_sec_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(626, 11);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(512, 512);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(100, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 512);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 49);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(79, 23);
            textBox1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Hafta_5_Odev_5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1173, 530);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(resim_sec);
            Controls.Add(mean);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Hafta_5_Odev_5";
            Text = "Form17";
            Load += Form17_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button mean;
        private System.Windows.Forms.Button resim_sec;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}