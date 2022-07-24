
namespace Etut
{
    partial class Personel_Giris_Sayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personel_Giris_Sayfasi));
            this.txtPersonelPin = new System.Windows.Forms.TextBox();
            this.txtPersonelEmail = new System.Windows.Forms.TextBox();
            this.lblPersonel_Pin = new System.Windows.Forms.Label();
            this.lblPersonelEmail = new System.Windows.Forms.Label();
            this.buttonPersonelGiris = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonelPin
            // 
            this.txtPersonelPin.Location = new System.Drawing.Point(214, 258);
            this.txtPersonelPin.Name = "txtPersonelPin";
            this.txtPersonelPin.Size = new System.Drawing.Size(138, 22);
            this.txtPersonelPin.TabIndex = 16;
            // 
            // txtPersonelEmail
            // 
            this.txtPersonelEmail.Location = new System.Drawing.Point(214, 210);
            this.txtPersonelEmail.Name = "txtPersonelEmail";
            this.txtPersonelEmail.Size = new System.Drawing.Size(138, 22);
            this.txtPersonelEmail.TabIndex = 15;
            // 
            // lblPersonel_Pin
            // 
            this.lblPersonel_Pin.AutoSize = true;
            this.lblPersonel_Pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonel_Pin.Location = new System.Drawing.Point(156, 263);
            this.lblPersonel_Pin.Name = "lblPersonel_Pin";
            this.lblPersonel_Pin.Size = new System.Drawing.Size(41, 17);
            this.lblPersonel_Pin.TabIndex = 14;
            this.lblPersonel_Pin.Text = "Pin: ";
            // 
            // lblPersonelEmail
            // 
            this.lblPersonelEmail.AutoSize = true;
            this.lblPersonelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelEmail.Location = new System.Drawing.Point(47, 210);
            this.lblPersonelEmail.Name = "lblPersonelEmail";
            this.lblPersonelEmail.Size = new System.Drawing.Size(143, 17);
            this.lblPersonelEmail.TabIndex = 13;
            this.lblPersonelEmail.Text = "Personel E-posta: ";
            // 
            // buttonPersonelGiris
            // 
            this.buttonPersonelGiris.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPersonelGiris.Location = new System.Drawing.Point(214, 314);
            this.buttonPersonelGiris.Name = "buttonPersonelGiris";
            this.buttonPersonelGiris.Size = new System.Drawing.Size(138, 38);
            this.buttonPersonelGiris.TabIndex = 12;
            this.buttonPersonelGiris.Text = "Giriş Yap";
            this.buttonPersonelGiris.UseVisualStyleBackColor = false;
            this.buttonPersonelGiris.Click += new System.EventHandler(this.buttonPersonelGiris_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(224, 64);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(112, 112);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // Personel_Giris_Sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 430);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtPersonelPin);
            this.Controls.Add(this.txtPersonelEmail);
            this.Controls.Add(this.lblPersonel_Pin);
            this.Controls.Add(this.lblPersonelEmail);
            this.Controls.Add(this.buttonPersonelGiris);
            this.Name = "Personel_Giris_Sayfasi";
            this.Text = "Personel_Giris_Sayfasi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPersonelPin;
        private System.Windows.Forms.TextBox txtPersonelEmail;
        private System.Windows.Forms.Label lblPersonel_Pin;
        private System.Windows.Forms.Label lblPersonelEmail;
        private System.Windows.Forms.Button buttonPersonelGiris;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}