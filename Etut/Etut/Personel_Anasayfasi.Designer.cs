
namespace Etut
{
    partial class Personel_Anasayfasi
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
            this.buttonOgrenciCikis1 = new System.Windows.Forms.Button();
            this.buttonEtutTakvimi1 = new System.Windows.Forms.Button();
            this.buttonOgrenciEkle = new System.Windows.Forms.Button();
            this.buttonOgretmenEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOgrenciCikis1
            // 
            this.buttonOgrenciCikis1.BackColor = System.Drawing.Color.Tan;
            this.buttonOgrenciCikis1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOgrenciCikis1.Location = new System.Drawing.Point(348, 187);
            this.buttonOgrenciCikis1.Name = "buttonOgrenciCikis1";
            this.buttonOgrenciCikis1.Size = new System.Drawing.Size(281, 94);
            this.buttonOgrenciCikis1.TabIndex = 5;
            this.buttonOgrenciCikis1.Text = "ÇIKIŞ";
            this.buttonOgrenciCikis1.UseVisualStyleBackColor = false;
            this.buttonOgrenciCikis1.Click += new System.EventHandler(this.buttonOgrenciCikis1_Click);
            // 
            // buttonEtutTakvimi1
            // 
            this.buttonEtutTakvimi1.BackColor = System.Drawing.Color.Tan;
            this.buttonEtutTakvimi1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEtutTakvimi1.Location = new System.Drawing.Point(24, 187);
            this.buttonEtutTakvimi1.Name = "buttonEtutTakvimi1";
            this.buttonEtutTakvimi1.Size = new System.Drawing.Size(281, 94);
            this.buttonEtutTakvimi1.TabIndex = 4;
            this.buttonEtutTakvimi1.Text = "ETÜT TAKVİMİ";
            this.buttonEtutTakvimi1.UseVisualStyleBackColor = false;
            this.buttonEtutTakvimi1.Click += new System.EventHandler(this.buttonEtutTakvimi1_Click);
            // 
            // buttonOgrenciEkle
            // 
            this.buttonOgrenciEkle.BackColor = System.Drawing.Color.Tan;
            this.buttonOgrenciEkle.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOgrenciEkle.Location = new System.Drawing.Point(24, 50);
            this.buttonOgrenciEkle.Name = "buttonOgrenciEkle";
            this.buttonOgrenciEkle.Size = new System.Drawing.Size(281, 94);
            this.buttonOgrenciEkle.TabIndex = 3;
            this.buttonOgrenciEkle.Text = "ÖĞRENCİ EKLE";
            this.buttonOgrenciEkle.UseVisualStyleBackColor = false;
            this.buttonOgrenciEkle.Click += new System.EventHandler(this.buttonOgrenciEkle_Click);
            // 
            // buttonOgretmenEkle
            // 
            this.buttonOgretmenEkle.BackColor = System.Drawing.Color.Tan;
            this.buttonOgretmenEkle.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOgretmenEkle.Location = new System.Drawing.Point(348, 50);
            this.buttonOgretmenEkle.Name = "buttonOgretmenEkle";
            this.buttonOgretmenEkle.Size = new System.Drawing.Size(281, 94);
            this.buttonOgretmenEkle.TabIndex = 6;
            this.buttonOgretmenEkle.Text = "ÖĞRETMEN EKLE";
            this.buttonOgretmenEkle.UseVisualStyleBackColor = false;
            this.buttonOgretmenEkle.Click += new System.EventHandler(this.buttonOgretmenEkle_Click);
            // 
            // Personel_Anasayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 346);
            this.Controls.Add(this.buttonOgretmenEkle);
            this.Controls.Add(this.buttonOgrenciCikis1);
            this.Controls.Add(this.buttonEtutTakvimi1);
            this.Controls.Add(this.buttonOgrenciEkle);
            this.Name = "Personel_Anasayfasi";
            this.Text = "Personel_Anasayfasi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOgrenciCikis1;
        private System.Windows.Forms.Button buttonEtutTakvimi1;
        private System.Windows.Forms.Button buttonOgrenciEkle;
        private System.Windows.Forms.Button buttonOgretmenEkle;
    }
}