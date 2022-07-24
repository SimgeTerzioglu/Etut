
namespace Etut
{
    partial class Ogrenci_Giris_Sayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci_Giris_Sayfasi));
            this.buttonOgrenciGiris = new System.Windows.Forms.Button();
            this.lblOgrEmail = new System.Windows.Forms.Label();
            this.lblOgrenci_Pin = new System.Windows.Forms.Label();
            this.txtOgrenciEmail = new System.Windows.Forms.TextBox();
            this.txtOgrenciPin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOgrenciGiris
            // 
            this.buttonOgrenciGiris.BackColor = System.Drawing.Color.Thistle;
            this.buttonOgrenciGiris.Location = new System.Drawing.Point(265, 315);
            this.buttonOgrenciGiris.Name = "buttonOgrenciGiris";
            this.buttonOgrenciGiris.Size = new System.Drawing.Size(138, 38);
            this.buttonOgrenciGiris.TabIndex = 0;
            this.buttonOgrenciGiris.Text = "Giriş Yap";
            this.buttonOgrenciGiris.UseVisualStyleBackColor = false;
            this.buttonOgrenciGiris.Click += new System.EventHandler(this.buttonOgrenciGiris_Click);
            // 
            // lblOgrEmail
            // 
            this.lblOgrEmail.AutoSize = true;
            this.lblOgrEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrEmail.Location = new System.Drawing.Point(98, 211);
            this.lblOgrEmail.Name = "lblOgrEmail";
            this.lblOgrEmail.Size = new System.Drawing.Size(136, 17);
            this.lblOgrEmail.TabIndex = 1;
            this.lblOgrEmail.Text = "Öğrenci E-posta: ";
            // 
            // lblOgrenci_Pin
            // 
            this.lblOgrenci_Pin.AutoSize = true;
            this.lblOgrenci_Pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrenci_Pin.Location = new System.Drawing.Point(193, 262);
            this.lblOgrenci_Pin.Name = "lblOgrenci_Pin";
            this.lblOgrenci_Pin.Size = new System.Drawing.Size(41, 17);
            this.lblOgrenci_Pin.TabIndex = 2;
            this.lblOgrenci_Pin.Text = "Pin: ";
            // 
            // txtOgrenciEmail
            // 
            this.txtOgrenciEmail.Location = new System.Drawing.Point(265, 211);
            this.txtOgrenciEmail.Name = "txtOgrenciEmail";
            this.txtOgrenciEmail.Size = new System.Drawing.Size(138, 22);
            this.txtOgrenciEmail.TabIndex = 3;
            // 
            // txtOgrenciPin
            // 
            this.txtOgrenciPin.Location = new System.Drawing.Point(265, 259);
            this.txtOgrenciPin.Name = "txtOgrenciPin";
            this.txtOgrenciPin.Size = new System.Drawing.Size(138, 22);
            this.txtOgrenciPin.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(278, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Ogrenci_Giris_Sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(591, 426);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtOgrenciPin);
            this.Controls.Add(this.txtOgrenciEmail);
            this.Controls.Add(this.lblOgrenci_Pin);
            this.Controls.Add(this.lblOgrEmail);
            this.Controls.Add(this.buttonOgrenciGiris);
            this.Name = "Ogrenci_Giris_Sayfasi";
            this.Text = "Ogrenci_Giris_Sayfasi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOgrenciGiris;
        private System.Windows.Forms.Label lblOgrEmail;
        private System.Windows.Forms.Label lblOgrenci_Pin;
        private System.Windows.Forms.TextBox txtOgrenciEmail;
        private System.Windows.Forms.TextBox txtOgrenciPin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}