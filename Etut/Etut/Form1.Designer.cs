
namespace Etut
{
    partial class Etut_Olustur
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDers = new System.Windows.Forms.Label();
            this.lblOgretmen = new System.Windows.Forms.Label();
            this.comboBoxDers = new System.Windows.Forms.ComboBox();
            this.comboBoxOgretmen = new System.Windows.Forms.ComboBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSaat = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.buttonEtutOlustur = new System.Windows.Forms.Button();
            this.labelGirisYazisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDers
            // 
            this.lblDers.AutoSize = true;
            this.lblDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDers.Location = new System.Drawing.Point(43, 45);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(52, 17);
            this.lblDers.TabIndex = 0;
            this.lblDers.Text = "Ders: ";
            // 
            // lblOgretmen
            // 
            this.lblOgretmen.AutoSize = true;
            this.lblOgretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgretmen.Location = new System.Drawing.Point(6, 84);
            this.lblOgretmen.Name = "lblOgretmen";
            this.lblOgretmen.Size = new System.Drawing.Size(89, 17);
            this.lblOgretmen.TabIndex = 1;
            this.lblOgretmen.Text = "Öğretmen: ";
            // 
            // comboBoxDers
            // 
            this.comboBoxDers.FormattingEnabled = true;
            this.comboBoxDers.Location = new System.Drawing.Point(111, 37);
            this.comboBoxDers.Name = "comboBoxDers";
            this.comboBoxDers.Size = new System.Drawing.Size(223, 24);
            this.comboBoxDers.TabIndex = 2;
            this.comboBoxDers.SelectedIndexChanged += new System.EventHandler(this.comboBoxDers_SelectedIndexChanged);
            // 
            // comboBoxOgretmen
            // 
            this.comboBoxOgretmen.FormattingEnabled = true;
            this.comboBoxOgretmen.Location = new System.Drawing.Point(111, 81);
            this.comboBoxOgretmen.Name = "comboBoxOgretmen";
            this.comboBoxOgretmen.Size = new System.Drawing.Size(223, 24);
            this.comboBoxOgretmen.TabIndex = 3;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(39, 131);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(56, 17);
            this.lblTarih.TabIndex = 4;
            this.lblTarih.Text = "Tarih: ";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(44, 176);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(51, 17);
            this.lblSaat.TabIndex = 5;
            this.lblSaat.Text = "Saat: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txtOgrNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxSaat);
            this.groupBox1.Controls.Add(this.dateTimePickerTarih);
            this.groupBox1.Controls.Add(this.buttonEtutOlustur);
            this.groupBox1.Controls.Add(this.lblDers);
            this.groupBox1.Controls.Add(this.lblOgretmen);
            this.groupBox1.Controls.Add(this.lblSaat);
            this.groupBox1.Controls.Add(this.comboBoxDers);
            this.groupBox1.Controls.Add(this.lblTarih);
            this.groupBox1.Controls.Add(this.comboBoxOgretmen);
            this.groupBox1.Location = new System.Drawing.Point(46, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 316);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxSaat
            // 
            this.comboBoxSaat.FormattingEnabled = true;
            this.comboBoxSaat.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.comboBoxSaat.Location = new System.Drawing.Point(111, 173);
            this.comboBoxSaat.Name = "comboBoxSaat";
            this.comboBoxSaat.Size = new System.Drawing.Size(223, 24);
            this.comboBoxSaat.TabIndex = 10;
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(111, 131);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(223, 22);
            this.dateTimePickerTarih.TabIndex = 9;
            // 
            // buttonEtutOlustur
            // 
            this.buttonEtutOlustur.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonEtutOlustur.Location = new System.Drawing.Point(111, 251);
            this.buttonEtutOlustur.Name = "buttonEtutOlustur";
            this.buttonEtutOlustur.Size = new System.Drawing.Size(223, 34);
            this.buttonEtutOlustur.TabIndex = 8;
            this.buttonEtutOlustur.Text = "Etüt Oluştur";
            this.buttonEtutOlustur.UseVisualStyleBackColor = false;
            this.buttonEtutOlustur.Click += new System.EventHandler(this.buttonEtutOluştur_Click);
            // 
            // labelGirisYazisi
            // 
            this.labelGirisYazisi.AutoSize = true;
            this.labelGirisYazisi.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGirisYazisi.Location = new System.Drawing.Point(97, 44);
            this.labelGirisYazisi.Name = "labelGirisYazisi";
            this.labelGirisYazisi.Size = new System.Drawing.Size(253, 37);
            this.labelGirisYazisi.TabIndex = 9;
            this.labelGirisYazisi.Text = "ETÜT SEÇİMİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Öğrenci No:";
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(111, 209);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(223, 22);
            this.txtOgrNo.TabIndex = 12;
            // 
            // Etut_Olustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(436, 441);
            this.Controls.Add(this.labelGirisYazisi);
            this.Controls.Add(this.groupBox1);
            this.Name = "Etut_Olustur";
            this.Load += new System.EventHandler(this.Etut_Olustur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDers;
        private System.Windows.Forms.Label lblOgretmen;
        private System.Windows.Forms.ComboBox comboBoxDers;
        private System.Windows.Forms.ComboBox comboBoxOgretmen;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEtutOlustur;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.ComboBox comboBoxSaat;
        private System.Windows.Forms.Label labelGirisYazisi;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.Label label1;
    }
}

