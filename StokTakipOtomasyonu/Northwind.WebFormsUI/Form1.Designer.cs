namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.kategoriCbx = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.urunAdiTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gcGuncelle = new DevExpress.XtraEditors.GroupControl();
            this.silBtn = new System.Windows.Forms.Button();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.guncelleKategoriCbx = new System.Windows.Forms.ComboBox();
            this.guncelleBirimTxt = new System.Windows.Forms.TextBox();
            this.guncelleStokTxt = new System.Windows.Forms.TextBox();
            this.guncelleFiyatTxt = new System.Windows.Forms.TextBox();
            this.guncelleUrunAdi = new System.Windows.Forms.TextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.gCEkle = new DevExpress.XtraEditors.GroupControl();
            this.urunEkleBtn = new System.Windows.Forms.Button();
            this.ekleUrunCbx = new System.Windows.Forms.ComboBox();
            this.ekleUrunBirim = new System.Windows.Forms.TextBox();
            this.ekleUrunStok = new System.Windows.Forms.TextBox();
            this.ekleUrunFiyat = new System.Windows.Forms.TextBox();
            this.ekleUrunAd = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunAdiTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGuncelle)).BeginInit();
            this.gcGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCEkle)).BeginInit();
            this.gCEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.kategoriCbx);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(0, 237);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(402, 83);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Kategoriye Göre Ara";
            // 
            // kategoriCbx
            // 
            this.kategoriCbx.FormattingEnabled = true;
            this.kategoriCbx.Location = new System.Drawing.Point(76, 42);
            this.kategoriCbx.Name = "kategoriCbx";
            this.kategoriCbx.Size = new System.Drawing.Size(316, 21);
            this.kategoriCbx.TabIndex = 1;
            this.kategoriCbx.SelectedIndexChanged += new System.EventHandler(this.kategoriCbx_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kategori :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.urunAdiTxt);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(403, 237);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(419, 83);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Ürün Adına Göre Ara";
            // 
            // urunAdiTxt
            // 
            this.urunAdiTxt.Location = new System.Drawing.Point(75, 43);
            this.urunAdiTxt.Name = "urunAdiTxt";
            this.urunAdiTxt.Size = new System.Drawing.Size(310, 20);
            this.urunAdiTxt.TabIndex = 1;
            this.urunAdiTxt.EditValueChanged += new System.EventHandler(this.urunAdiTxt_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Ürün Adı :";
            // 
            // gcGuncelle
            // 
            this.gcGuncelle.Controls.Add(this.silBtn);
            this.gcGuncelle.Controls.Add(this.guncelleBtn);
            this.gcGuncelle.Controls.Add(this.guncelleKategoriCbx);
            this.gcGuncelle.Controls.Add(this.guncelleBirimTxt);
            this.gcGuncelle.Controls.Add(this.guncelleStokTxt);
            this.gcGuncelle.Controls.Add(this.guncelleFiyatTxt);
            this.gcGuncelle.Controls.Add(this.guncelleUrunAdi);
            this.gcGuncelle.Controls.Add(this.labelControl8);
            this.gcGuncelle.Controls.Add(this.labelControl9);
            this.gcGuncelle.Controls.Add(this.labelControl10);
            this.gcGuncelle.Controls.Add(this.labelControl11);
            this.gcGuncelle.Controls.Add(this.labelControl12);
            this.gcGuncelle.Location = new System.Drawing.Point(276, 321);
            this.gcGuncelle.Name = "gcGuncelle";
            this.gcGuncelle.Size = new System.Drawing.Size(546, 215);
            this.gcGuncelle.TabIndex = 2;
            this.gcGuncelle.Text = "Ürün Güncelleme Sekmesi";
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(291, 186);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(170, 23);
            this.silBtn.TabIndex = 29;
            this.silBtn.Text = "Bu Ürünü Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(127, 187);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(157, 23);
            this.guncelleBtn.TabIndex = 28;
            this.guncelleBtn.Text = "Bu Ürünü Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // guncelleKategoriCbx
            // 
            this.guncelleKategoriCbx.FormattingEnabled = true;
            this.guncelleKategoriCbx.Location = new System.Drawing.Point(176, 65);
            this.guncelleKategoriCbx.Name = "guncelleKategoriCbx";
            this.guncelleKategoriCbx.Size = new System.Drawing.Size(264, 21);
            this.guncelleKategoriCbx.TabIndex = 27;
            // 
            // guncelleBirimTxt
            // 
            this.guncelleBirimTxt.Location = new System.Drawing.Point(176, 151);
            this.guncelleBirimTxt.Name = "guncelleBirimTxt";
            this.guncelleBirimTxt.Size = new System.Drawing.Size(264, 21);
            this.guncelleBirimTxt.TabIndex = 23;
            // 
            // guncelleStokTxt
            // 
            this.guncelleStokTxt.Location = new System.Drawing.Point(176, 122);
            this.guncelleStokTxt.Name = "guncelleStokTxt";
            this.guncelleStokTxt.Size = new System.Drawing.Size(264, 21);
            this.guncelleStokTxt.TabIndex = 24;
            // 
            // guncelleFiyatTxt
            // 
            this.guncelleFiyatTxt.Location = new System.Drawing.Point(176, 93);
            this.guncelleFiyatTxt.Name = "guncelleFiyatTxt";
            this.guncelleFiyatTxt.Size = new System.Drawing.Size(264, 21);
            this.guncelleFiyatTxt.TabIndex = 25;
            // 
            // guncelleUrunAdi
            // 
            this.guncelleUrunAdi.Location = new System.Drawing.Point(176, 38);
            this.guncelleUrunAdi.Name = "guncelleUrunAdi";
            this.guncelleUrunAdi.Size = new System.Drawing.Size(264, 21);
            this.guncelleUrunAdi.TabIndex = 26;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(97, 154);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 13);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "Birim Adedi :";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(97, 125);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(58, 13);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "Stok Adedi :";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(97, 96);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(31, 13);
            this.labelControl10.TabIndex = 20;
            this.labelControl10.Text = "Fiyat :";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(97, 69);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(47, 13);
            this.labelControl11.TabIndex = 21;
            this.labelControl11.Text = "Kategori :";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(97, 38);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(48, 13);
            this.labelControl12.TabIndex = 22;
            this.labelControl12.Text = "Ürün Adı :";
            // 
            // gCEkle
            // 
            this.gCEkle.Controls.Add(this.urunEkleBtn);
            this.gCEkle.Controls.Add(this.ekleUrunCbx);
            this.gCEkle.Controls.Add(this.ekleUrunBirim);
            this.gCEkle.Controls.Add(this.ekleUrunStok);
            this.gCEkle.Controls.Add(this.ekleUrunFiyat);
            this.gCEkle.Controls.Add(this.ekleUrunAd);
            this.gCEkle.Controls.Add(this.labelControl7);
            this.gCEkle.Controls.Add(this.labelControl6);
            this.gCEkle.Controls.Add(this.labelControl5);
            this.gCEkle.Controls.Add(this.labelControl4);
            this.gCEkle.Controls.Add(this.labelControl3);
            this.gCEkle.Location = new System.Drawing.Point(5, 321);
            this.gCEkle.Name = "gCEkle";
            this.gCEkle.Size = new System.Drawing.Size(265, 215);
            this.gCEkle.TabIndex = 2;
            this.gCEkle.Text = "Ürün Ekleme Sekmesi";
            // 
            // urunEkleBtn
            // 
            this.urunEkleBtn.Location = new System.Drawing.Point(86, 186);
            this.urunEkleBtn.Name = "urunEkleBtn";
            this.urunEkleBtn.Size = new System.Drawing.Size(157, 23);
            this.urunEkleBtn.TabIndex = 17;
            this.urunEkleBtn.Text = "Bu Ürünü Ekle";
            this.urunEkleBtn.UseVisualStyleBackColor = true;
            this.urunEkleBtn.Click += new System.EventHandler(this.urunEkleBtn_Click);
            // 
            // ekleUrunCbx
            // 
            this.ekleUrunCbx.FormattingEnabled = true;
            this.ekleUrunCbx.Location = new System.Drawing.Point(86, 62);
            this.ekleUrunCbx.Name = "ekleUrunCbx";
            this.ekleUrunCbx.Size = new System.Drawing.Size(157, 21);
            this.ekleUrunCbx.TabIndex = 16;
            // 
            // ekleUrunBirim
            // 
            this.ekleUrunBirim.Location = new System.Drawing.Point(86, 148);
            this.ekleUrunBirim.Name = "ekleUrunBirim";
            this.ekleUrunBirim.Size = new System.Drawing.Size(157, 21);
            this.ekleUrunBirim.TabIndex = 15;
            // 
            // ekleUrunStok
            // 
            this.ekleUrunStok.Location = new System.Drawing.Point(86, 119);
            this.ekleUrunStok.Name = "ekleUrunStok";
            this.ekleUrunStok.Size = new System.Drawing.Size(157, 21);
            this.ekleUrunStok.TabIndex = 15;
            // 
            // ekleUrunFiyat
            // 
            this.ekleUrunFiyat.Location = new System.Drawing.Point(86, 90);
            this.ekleUrunFiyat.Name = "ekleUrunFiyat";
            this.ekleUrunFiyat.Size = new System.Drawing.Size(157, 21);
            this.ekleUrunFiyat.TabIndex = 15;
            // 
            // ekleUrunAd
            // 
            this.ekleUrunAd.Location = new System.Drawing.Point(86, 35);
            this.ekleUrunAd.Name = "ekleUrunAd";
            this.ekleUrunAd.Size = new System.Drawing.Size(157, 21);
            this.ekleUrunAd.TabIndex = 15;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(7, 151);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(59, 13);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Birim Adedi :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(7, 122);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(58, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Stok Adedi :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 93);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Fiyat :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Kategori :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Ürün Adı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(825, 231);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gCEkle);
            this.Controls.Add(this.gcGuncelle);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Form1";
            this.Text = "Stok Takip Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunAdiTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcGuncelle)).EndInit();
            this.gcGuncelle.ResumeLayout(false);
            this.gcGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCEkle)).EndInit();
            this.gCEkle.ResumeLayout(false);
            this.gCEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit urunAdiTxt;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox kategoriCbx;
        private DevExpress.XtraEditors.GroupControl gcGuncelle;
        private DevExpress.XtraEditors.GroupControl gCEkle;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button urunEkleBtn;
        private System.Windows.Forms.ComboBox ekleUrunCbx;
        private System.Windows.Forms.TextBox ekleUrunBirim;
        private System.Windows.Forms.TextBox ekleUrunStok;
        private System.Windows.Forms.TextBox ekleUrunFiyat;
        private System.Windows.Forms.TextBox ekleUrunAd;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.ComboBox guncelleKategoriCbx;
        private System.Windows.Forms.TextBox guncelleBirimTxt;
        private System.Windows.Forms.TextBox guncelleStokTxt;
        private System.Windows.Forms.TextBox guncelleFiyatTxt;
        private System.Windows.Forms.TextBox guncelleUrunAdi;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button silBtn;
    }
}

