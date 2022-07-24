
namespace Etut
{
    partial class Ogrenci_Anasayfasi
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
            this.buttonEtutAL = new System.Windows.Forms.Button();
            this.buttonEtutTakvimi = new System.Windows.Forms.Button();
            this.buttonOgrenciCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEtutAL
            // 
            this.buttonEtutAL.BackColor = System.Drawing.Color.Tan;
            this.buttonEtutAL.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEtutAL.Location = new System.Drawing.Point(94, 12);
            this.buttonEtutAL.Name = "buttonEtutAL";
            this.buttonEtutAL.Size = new System.Drawing.Size(281, 94);
            this.buttonEtutAL.TabIndex = 0;
            this.buttonEtutAL.Text = "ETÜT AL";
            this.buttonEtutAL.UseVisualStyleBackColor = false;
            this.buttonEtutAL.Click += new System.EventHandler(this.buttonEtutAL_Click);
            // 
            // buttonEtutTakvimi
            // 
            this.buttonEtutTakvimi.BackColor = System.Drawing.Color.Tan;
            this.buttonEtutTakvimi.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEtutTakvimi.Location = new System.Drawing.Point(94, 135);
            this.buttonEtutTakvimi.Name = "buttonEtutTakvimi";
            this.buttonEtutTakvimi.Size = new System.Drawing.Size(281, 94);
            this.buttonEtutTakvimi.TabIndex = 1;
            this.buttonEtutTakvimi.Text = "ETÜT TAKVİMİ";
            this.buttonEtutTakvimi.UseVisualStyleBackColor = false;
            this.buttonEtutTakvimi.Click += new System.EventHandler(this.buttonEtutTakvimi_Click);
            // 
            // buttonOgrenciCikis
            // 
            this.buttonOgrenciCikis.BackColor = System.Drawing.Color.Tan;
            this.buttonOgrenciCikis.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOgrenciCikis.Location = new System.Drawing.Point(94, 256);
            this.buttonOgrenciCikis.Name = "buttonOgrenciCikis";
            this.buttonOgrenciCikis.Size = new System.Drawing.Size(281, 94);
            this.buttonOgrenciCikis.TabIndex = 2;
            this.buttonOgrenciCikis.Text = "ÇIKIŞ";
            this.buttonOgrenciCikis.UseVisualStyleBackColor = false;
            this.buttonOgrenciCikis.Click += new System.EventHandler(this.buttonOgrenciCikis_Click);
            // 
            // Ogrenci_Anasayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 405);
            this.Controls.Add(this.buttonOgrenciCikis);
            this.Controls.Add(this.buttonEtutTakvimi);
            this.Controls.Add(this.buttonEtutAL);
            this.Name = "Ogrenci_Anasayfasi";
            this.Text = "Ogrenci_Anasayfasi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEtutAL;
        private System.Windows.Forms.Button buttonEtutTakvimi;
        private System.Windows.Forms.Button buttonOgrenciCikis;
    }
}