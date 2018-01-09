namespace A8CFManyToMany
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lstOgrenci = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.nKredi = new System.Windows.Forms.NumericUpDown();
            this.btnDersKaydet = new System.Windows.Forms.Button();
            this.lstDersler = new System.Windows.Forms.ListBox();
            this.clstOgrenciDersleri = new System.Windows.Forms.CheckedListBox();
            this.lblToplamKredi = new System.Windows.Forms.Label();
            this.btnDersOnayla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nKredi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(122, 10);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(202, 22);
            this.txtAd.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(16, 128);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(308, 53);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Öğrenci Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lstOgrenci
            // 
            this.lstOgrenci.FormattingEnabled = true;
            this.lstOgrenci.ItemHeight = 16;
            this.lstOgrenci.Location = new System.Drawing.Point(16, 187);
            this.lstOgrenci.Name = "lstOgrenci";
            this.lstOgrenci.Size = new System.Drawing.Size(308, 228);
            this.lstOgrenci.TabIndex = 5;
            this.lstOgrenci.SelectedIndexChanged += new System.EventHandler(this.lstOgrenci_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(122, 38);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(202, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cinsiyet";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(122, 69);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(202, 22);
            this.dtpDogumTarihi.TabIndex = 2;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(122, 98);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(202, 24);
            this.cmbCinsiyet.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ders Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kredi";
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(438, 69);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(202, 22);
            this.txtDersAdi.TabIndex = 6;
            // 
            // nKredi
            // 
            this.nKredi.Location = new System.Drawing.Point(438, 97);
            this.nKredi.Name = "nKredi";
            this.nKredi.Size = new System.Drawing.Size(202, 22);
            this.nKredi.TabIndex = 7;
            this.nKredi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDersKaydet
            // 
            this.btnDersKaydet.Location = new System.Drawing.Point(372, 128);
            this.btnDersKaydet.Name = "btnDersKaydet";
            this.btnDersKaydet.Size = new System.Drawing.Size(268, 53);
            this.btnDersKaydet.TabIndex = 8;
            this.btnDersKaydet.Text = "Ders Kaydet";
            this.btnDersKaydet.UseVisualStyleBackColor = true;
            this.btnDersKaydet.Click += new System.EventHandler(this.btnDersKaydet_Click);
            // 
            // lstDersler
            // 
            this.lstDersler.FormattingEnabled = true;
            this.lstDersler.ItemHeight = 16;
            this.lstDersler.Location = new System.Drawing.Point(372, 187);
            this.lstDersler.Name = "lstDersler";
            this.lstDersler.Size = new System.Drawing.Size(268, 228);
            this.lstDersler.TabIndex = 9;
            this.lstDersler.SelectedIndexChanged += new System.EventHandler(this.lstDersler_SelectedIndexChanged);
            // 
            // clstOgrenciDersleri
            // 
            this.clstOgrenciDersleri.FormattingEnabled = true;
            this.clstOgrenciDersleri.Location = new System.Drawing.Point(16, 421);
            this.clstOgrenciDersleri.Name = "clstOgrenciDersleri";
            this.clstOgrenciDersleri.Size = new System.Drawing.Size(308, 225);
            this.clstOgrenciDersleri.TabIndex = 10;
            this.clstOgrenciDersleri.SelectedIndexChanged += new System.EventHandler(this.clstOgrenciDersleri_SelectedIndexChanged);
            // 
            // lblToplamKredi
            // 
            this.lblToplamKredi.AutoSize = true;
            this.lblToplamKredi.Font = new System.Drawing.Font("Monaco", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKredi.Location = new System.Drawing.Point(16, 653);
            this.lblToplamKredi.Name = "lblToplamKredi";
            this.lblToplamKredi.Size = new System.Drawing.Size(287, 35);
            this.lblToplamKredi.TabIndex = 11;
            this.lblToplamKredi.Text = "Toplam Kredi: 14";
            // 
            // btnDersOnayla
            // 
            this.btnDersOnayla.Font = new System.Drawing.Font("Monaco", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersOnayla.ForeColor = System.Drawing.Color.Crimson;
            this.btnDersOnayla.Location = new System.Drawing.Point(16, 692);
            this.btnDersOnayla.Name = "btnDersOnayla";
            this.btnDersOnayla.Size = new System.Drawing.Size(308, 53);
            this.btnDersOnayla.TabIndex = 12;
            this.btnDersOnayla.Text = "Ders Seçimini Onayla";
            this.btnDersOnayla.UseVisualStyleBackColor = true;
            this.btnDersOnayla.Click += new System.EventHandler(this.btnDersOnayla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 826);
            this.Controls.Add(this.btnDersOnayla);
            this.Controls.Add(this.lblToplamKredi);
            this.Controls.Add(this.clstOgrenciDersleri);
            this.Controls.Add(this.nKredi);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.lstDersler);
            this.Controls.Add(this.lstOgrenci);
            this.Controls.Add(this.btnDersKaydet);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDersAdi);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nKredi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox lstOgrenci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.NumericUpDown nKredi;
        private System.Windows.Forms.Button btnDersKaydet;
        private System.Windows.Forms.ListBox lstDersler;
        private System.Windows.Forms.CheckedListBox clstOgrenciDersleri;
        private System.Windows.Forms.Label lblToplamKredi;
        private System.Windows.Forms.Button btnDersOnayla;
    }
}

