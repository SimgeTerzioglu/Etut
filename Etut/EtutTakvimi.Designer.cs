
namespace Etut
{
    partial class EtutTakvimi
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dERSHANEDataSet1 = new Etut.DERSHANEDataSet1();
            this.dERSHANEDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelGirisYazisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dERSHANEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dERSHANEDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dERSHANEDataSet1
            // 
            this.dERSHANEDataSet1.DataSetName = "DERSHANEDataSet1";
            this.dERSHANEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dERSHANEDataSet1BindingSource
            // 
            this.dERSHANEDataSet1BindingSource.DataSource = this.dERSHANEDataSet1;
            this.dERSHANEDataSet1BindingSource.Position = 0;
            // 
            // labelGirisYazisi
            // 
            this.labelGirisYazisi.AutoSize = true;
            this.labelGirisYazisi.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGirisYazisi.Location = new System.Drawing.Point(384, 20);
            this.labelGirisYazisi.Name = "labelGirisYazisi";
            this.labelGirisYazisi.Size = new System.Drawing.Size(278, 37);
            this.labelGirisYazisi.TabIndex = 10;
            this.labelGirisYazisi.Text = "ETÜT TAKVİMİ";
            // 
            // EtutTakvimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 450);
            this.Controls.Add(this.labelGirisYazisi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EtutTakvimi";
            this.Text = "Etüt Takvimi";
            this.Load += new System.EventHandler(this.EtutTakvimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dERSHANEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dERSHANEDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dERSHANEDataSet1BindingSource;
        private DERSHANEDataSet1 dERSHANEDataSet1;
        private System.Windows.Forms.Label labelGirisYazisi;
    }
}