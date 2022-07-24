
namespace Etut
{
    partial class Ogretmen_Giris_Sayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogretmen_Giris_Sayfasi));
            this.buttonOgretmenGiris = new System.Windows.Forms.Button();
            this.lblOgretmenEmail = new System.Windows.Forms.Label();
            this.lblOgretmen_sifre = new System.Windows.Forms.Label();
            this.txtOgretmenEmail = new System.Windows.Forms.TextBox();
            this.txtOgretmenPin = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOgretmenGiris
            // 
            this.buttonOgretmenGiris.BackColor = System.Drawing.Color.Pink;
            this.buttonOgretmenGiris.Location = new System.Drawing.Point(237, 309);
            this.buttonOgretmenGiris.Name = "buttonOgretmenGiris";
            this.buttonOgretmenGiris.Size = new System.Drawing.Size(138, 38);
            this.buttonOgretmenGiris.TabIndex = 6;
            this.buttonOgretmenGiris.Text = "Giriş Yap";
            this.buttonOgretmenGiris.UseVisualStyleBackColor = false;
            this.buttonOgretmenGiris.Click += new System.EventHandler(this.buttonOgretmenGiris_Click);
            // 
            // lblOgretmenEmail
            // 
            this.lblOgretmenEmail.AutoSize = true;
            this.lblOgretmenEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgretmenEmail.Location = new System.Drawing.Point(70, 205);
            this.lblOgretmenEmail.Name = "lblOgretmenEmail";
            this.lblOgretmenEmail.Size = new System.Drawing.Size(150, 17);
            this.lblOgretmenEmail.TabIndex = 7;
            this.lblOgretmenEmail.Text = "Öğretmen E-posta: ";
            // 
            // lblOgretmen_sifre
            // 
            this.lblOgretmen_sifre.AutoSize = true;
            this.lblOgretmen_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgretmen_sifre.Location = new System.Drawing.Point(179, 258);
            this.lblOgretmen_sifre.Name = "lblOgretmen_sifre";
            this.lblOgretmen_sifre.Size = new System.Drawing.Size(41, 17);
            this.lblOgretmen_sifre.TabIndex = 8;
            this.lblOgretmen_sifre.Text = "Pin: ";
            // 
            // txtOgretmenEmail
            // 
            this.txtOgretmenEmail.Location = new System.Drawing.Point(237, 205);
            this.txtOgretmenEmail.Name = "txtOgretmenEmail";
            this.txtOgretmenEmail.Size = new System.Drawing.Size(138, 22);
            this.txtOgretmenEmail.TabIndex = 9;
            // 
            // txtOgretmenPin
            // 
            this.txtOgretmenPin.Location = new System.Drawing.Point(237, 253);
            this.txtOgretmenPin.Name = "txtOgretmenPin";
            this.txtOgretmenPin.Size = new System.Drawing.Size(138, 22);
            this.txtOgretmenPin.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(249, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Ogretmen_Giris_Sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 429);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtOgretmenPin);
            this.Controls.Add(this.txtOgretmenEmail);
            this.Controls.Add(this.lblOgretmen_sifre);
            this.Controls.Add(this.lblOgretmenEmail);
            this.Controls.Add(this.buttonOgretmenGiris);
            this.Name = "Ogretmen_Giris_Sayfasi";
            this.Text = "Ogretmen_Giris_Sayfasi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOgretmenGiris;
        private System.Windows.Forms.Label lblOgretmenEmail;
        private System.Windows.Forms.Label lblOgretmen_sifre;
        private System.Windows.Forms.TextBox txtOgretmenEmail;
        private System.Windows.Forms.TextBox txtOgretmenPin;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}