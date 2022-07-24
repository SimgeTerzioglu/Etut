
namespace Etut
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.buttonOgrenci = new System.Windows.Forms.Button();
            this.buttonOgretmen = new System.Windows.Forms.Button();
            this.buttonPersonel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelGirisYazisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOgrenci
            // 
            this.buttonOgrenci.BackColor = System.Drawing.Color.Thistle;
            this.buttonOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOgrenci.Location = new System.Drawing.Point(45, 277);
            this.buttonOgrenci.Name = "buttonOgrenci";
            this.buttonOgrenci.Size = new System.Drawing.Size(140, 90);
            this.buttonOgrenci.TabIndex = 0;
            this.buttonOgrenci.Text = "Öğrenci Girişi";
            this.buttonOgrenci.UseVisualStyleBackColor = false;
            this.buttonOgrenci.Click += new System.EventHandler(this.buttonOgrenci_Click);
            // 
            // buttonOgretmen
            // 
            this.buttonOgretmen.BackColor = System.Drawing.Color.LightPink;
            this.buttonOgretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOgretmen.Location = new System.Drawing.Point(279, 277);
            this.buttonOgretmen.Name = "buttonOgretmen";
            this.buttonOgretmen.Size = new System.Drawing.Size(140, 90);
            this.buttonOgretmen.TabIndex = 1;
            this.buttonOgretmen.Text = "Öğretmen Girişi";
            this.buttonOgretmen.UseVisualStyleBackColor = false;
            this.buttonOgretmen.Click += new System.EventHandler(this.buttonOgretmen_Click);
            // 
            // buttonPersonel
            // 
            this.buttonPersonel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPersonel.Location = new System.Drawing.Point(513, 277);
            this.buttonPersonel.Name = "buttonPersonel";
            this.buttonPersonel.Size = new System.Drawing.Size(140, 90);
            this.buttonPersonel.TabIndex = 2;
            this.buttonPersonel.Text = "Personel Girişi";
            this.buttonPersonel.UseVisualStyleBackColor = false;
            this.buttonPersonel.Click += new System.EventHandler(this.buttonPersonel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(292, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(525, 132);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 112);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // labelGirisYazisi
            // 
            this.labelGirisYazisi.AutoSize = true;
            this.labelGirisYazisi.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGirisYazisi.Location = new System.Drawing.Point(44, 40);
            this.labelGirisYazisi.Name = "labelGirisYazisi";
            this.labelGirisYazisi.Size = new System.Drawing.Size(594, 35);
            this.labelGirisYazisi.TabIndex = 6;
            this.labelGirisYazisi.Text = "ETÜT MERKEZİNE HOŞGELDİNİZ";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 399);
            this.Controls.Add(this.labelGirisYazisi);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPersonel);
            this.Controls.Add(this.buttonOgretmen);
            this.Controls.Add(this.buttonOgrenci);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOgrenci;
        private System.Windows.Forms.Button buttonOgretmen;
        private System.Windows.Forms.Button buttonPersonel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelGirisYazisi;
    }
}