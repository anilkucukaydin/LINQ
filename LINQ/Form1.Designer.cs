namespace LINQ
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
            this.siparisler_hepsi = new System.Windows.Forms.Button();
            this.sayilar_tumsayilar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sayilar_negatif = new System.Windows.Forms.Button();
            this.sayilar_pozitif = new System.Windows.Forms.Button();
            this.sayilar_cift = new System.Windows.Forms.Button();
            this.sayilar_tek = new System.Windows.Forms.Button();
            this.sayilar_enbuyuk = new System.Windows.Forms.Button();
            this.sayilar_enkucuk = new System.Windows.Forms.Button();
            this.sayilar_kactane = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.isimler_alfabetik = new System.Windows.Forms.Button();
            this.isimler_tersalfabetik = new System.Windows.Forms.Button();
            this.isimler_uzunluk = new System.Windows.Forms.Button();
            this.isimler_iBarindiran = new System.Windows.Forms.Button();
            this.isimler_N_ilebaslayanlar = new System.Windows.Forms.Button();
            this.siparisler_tarih = new System.Windows.Forms.Button();
            this.siparisler_ilk5 = new System.Windows.Forms.Button();
            this.siparisler_son5 = new System.Windows.Forms.Button();
            this.yangwang = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // siparisler_hepsi
            // 
            this.siparisler_hepsi.Location = new System.Drawing.Point(44, 99);
            this.siparisler_hepsi.Name = "siparisler_hepsi";
            this.siparisler_hepsi.Size = new System.Drawing.Size(101, 23);
            this.siparisler_hepsi.TabIndex = 0;
            this.siparisler_hepsi.Text = "Tüm Siparişler";
            this.siparisler_hepsi.UseVisualStyleBackColor = true;
            this.siparisler_hepsi.Click += new System.EventHandler(this.siparisler_hepsi_Click);
            // 
            // sayilar_tumsayilar
            // 
            this.sayilar_tumsayilar.Location = new System.Drawing.Point(44, 12);
            this.sayilar_tumsayilar.Name = "sayilar_tumsayilar";
            this.sayilar_tumsayilar.Size = new System.Drawing.Size(101, 23);
            this.sayilar_tumsayilar.TabIndex = 1;
            this.sayilar_tumsayilar.Text = "Tüm Sayılar";
            this.sayilar_tumsayilar.UseVisualStyleBackColor = true;
            this.sayilar_tumsayilar.Click += new System.EventHandler(this.sayilar_tumsayilar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(44, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Tüm İsimler";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(213, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 160);
            this.dataGridView1.TabIndex = 3;
            // 
            // sayilar_negatif
            // 
            this.sayilar_negatif.Location = new System.Drawing.Point(153, 12);
            this.sayilar_negatif.Name = "sayilar_negatif";
            this.sayilar_negatif.Size = new System.Drawing.Size(76, 23);
            this.sayilar_negatif.TabIndex = 4;
            this.sayilar_negatif.Text = "Negatif";
            this.sayilar_negatif.UseVisualStyleBackColor = true;
            this.sayilar_negatif.Click += new System.EventHandler(this.sayilar_negatif_Click);
            // 
            // sayilar_pozitif
            // 
            this.sayilar_pozitif.Location = new System.Drawing.Point(235, 12);
            this.sayilar_pozitif.Name = "sayilar_pozitif";
            this.sayilar_pozitif.Size = new System.Drawing.Size(76, 23);
            this.sayilar_pozitif.TabIndex = 5;
            this.sayilar_pozitif.Text = "Pozitif";
            this.sayilar_pozitif.UseVisualStyleBackColor = true;
            this.sayilar_pozitif.Click += new System.EventHandler(this.sayilar_pozitif_Click);
            // 
            // sayilar_cift
            // 
            this.sayilar_cift.Location = new System.Drawing.Point(399, 12);
            this.sayilar_cift.Name = "sayilar_cift";
            this.sayilar_cift.Size = new System.Drawing.Size(76, 23);
            this.sayilar_cift.TabIndex = 6;
            this.sayilar_cift.Text = "Çift";
            this.sayilar_cift.UseVisualStyleBackColor = true;
            this.sayilar_cift.Click += new System.EventHandler(this.sayilar_cift_Click);
            // 
            // sayilar_tek
            // 
            this.sayilar_tek.Location = new System.Drawing.Point(317, 12);
            this.sayilar_tek.Name = "sayilar_tek";
            this.sayilar_tek.Size = new System.Drawing.Size(76, 23);
            this.sayilar_tek.TabIndex = 7;
            this.sayilar_tek.Text = "Tek";
            this.sayilar_tek.UseVisualStyleBackColor = true;
            this.sayilar_tek.Click += new System.EventHandler(this.sayilar_tek_Click);
            // 
            // sayilar_enbuyuk
            // 
            this.sayilar_enbuyuk.Location = new System.Drawing.Point(481, 12);
            this.sayilar_enbuyuk.Name = "sayilar_enbuyuk";
            this.sayilar_enbuyuk.Size = new System.Drawing.Size(76, 23);
            this.sayilar_enbuyuk.TabIndex = 8;
            this.sayilar_enbuyuk.Text = "En Büyük";
            this.sayilar_enbuyuk.UseVisualStyleBackColor = true;
            this.sayilar_enbuyuk.Click += new System.EventHandler(this.sayilar_enbuyuk_Click);
            // 
            // sayilar_enkucuk
            // 
            this.sayilar_enkucuk.Location = new System.Drawing.Point(563, 12);
            this.sayilar_enkucuk.Name = "sayilar_enkucuk";
            this.sayilar_enkucuk.Size = new System.Drawing.Size(76, 23);
            this.sayilar_enkucuk.TabIndex = 9;
            this.sayilar_enkucuk.Text = "En Küçük";
            this.sayilar_enkucuk.UseVisualStyleBackColor = true;
            this.sayilar_enkucuk.Click += new System.EventHandler(this.sayilar_enkucuk_Click);
            // 
            // sayilar_kactane
            // 
            this.sayilar_kactane.Location = new System.Drawing.Point(645, 12);
            this.sayilar_kactane.Name = "sayilar_kactane";
            this.sayilar_kactane.Size = new System.Drawing.Size(76, 23);
            this.sayilar_kactane.TabIndex = 10;
            this.sayilar_kactane.Text = "Kaç Tane";
            this.sayilar_kactane.UseVisualStyleBackColor = true;
            this.sayilar_kactane.Click += new System.EventHandler(this.sayilar_kactane_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 166);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 160);
            this.listBox1.TabIndex = 11;
            // 
            // isimler_alfabetik
            // 
            this.isimler_alfabetik.Location = new System.Drawing.Point(153, 55);
            this.isimler_alfabetik.Name = "isimler_alfabetik";
            this.isimler_alfabetik.Size = new System.Drawing.Size(102, 23);
            this.isimler_alfabetik.TabIndex = 12;
            this.isimler_alfabetik.Text = "Alfabetik";
            this.isimler_alfabetik.UseVisualStyleBackColor = true;
            this.isimler_alfabetik.Click += new System.EventHandler(this.isimler_alfabetik_Click);
            // 
            // isimler_tersalfabetik
            // 
            this.isimler_tersalfabetik.Location = new System.Drawing.Point(260, 55);
            this.isimler_tersalfabetik.Name = "isimler_tersalfabetik";
            this.isimler_tersalfabetik.Size = new System.Drawing.Size(102, 23);
            this.isimler_tersalfabetik.TabIndex = 13;
            this.isimler_tersalfabetik.Text = "Alfabetik Ters";
            this.isimler_tersalfabetik.UseVisualStyleBackColor = true;
            this.isimler_tersalfabetik.Click += new System.EventHandler(this.isimler_tersalfabetik_Click);
            // 
            // isimler_uzunluk
            // 
            this.isimler_uzunluk.Location = new System.Drawing.Point(367, 55);
            this.isimler_uzunluk.Name = "isimler_uzunluk";
            this.isimler_uzunluk.Size = new System.Drawing.Size(102, 23);
            this.isimler_uzunluk.TabIndex = 14;
            this.isimler_uzunluk.Text = "Uzunluklar";
            this.isimler_uzunluk.UseVisualStyleBackColor = true;
            this.isimler_uzunluk.Click += new System.EventHandler(this.isimler_uzunluk_Click);
            // 
            // isimler_iBarindiran
            // 
            this.isimler_iBarindiran.Location = new System.Drawing.Point(475, 55);
            this.isimler_iBarindiran.Name = "isimler_iBarindiran";
            this.isimler_iBarindiran.Size = new System.Drawing.Size(102, 23);
            this.isimler_iBarindiran.TabIndex = 15;
            this.isimler_iBarindiran.Text = "i barındıran ";
            this.isimler_iBarindiran.UseVisualStyleBackColor = true;
            this.isimler_iBarindiran.Click += new System.EventHandler(this.isimler_iBarindiran_Click);
            // 
            // isimler_N_ilebaslayanlar
            // 
            this.isimler_N_ilebaslayanlar.Location = new System.Drawing.Point(583, 55);
            this.isimler_N_ilebaslayanlar.Name = "isimler_N_ilebaslayanlar";
            this.isimler_N_ilebaslayanlar.Size = new System.Drawing.Size(102, 23);
            this.isimler_N_ilebaslayanlar.TabIndex = 16;
            this.isimler_N_ilebaslayanlar.Text = "N ile başlayan";
            this.isimler_N_ilebaslayanlar.UseVisualStyleBackColor = true;
            this.isimler_N_ilebaslayanlar.Click += new System.EventHandler(this.isimler_N_ilebaslayanlar_Click);
            // 
            // siparisler_tarih
            // 
            this.siparisler_tarih.Location = new System.Drawing.Point(154, 99);
            this.siparisler_tarih.Name = "siparisler_tarih";
            this.siparisler_tarih.Size = new System.Drawing.Size(101, 23);
            this.siparisler_tarih.TabIndex = 17;
            this.siparisler_tarih.Text = "Sadece Tarihler";
            this.siparisler_tarih.UseVisualStyleBackColor = true;
            this.siparisler_tarih.Click += new System.EventHandler(this.siparisler_tarih_Click);
            // 
            // siparisler_ilk5
            // 
            this.siparisler_ilk5.Location = new System.Drawing.Point(261, 99);
            this.siparisler_ilk5.Name = "siparisler_ilk5";
            this.siparisler_ilk5.Size = new System.Drawing.Size(101, 23);
            this.siparisler_ilk5.TabIndex = 18;
            this.siparisler_ilk5.Text = "İlk 5";
            this.siparisler_ilk5.UseVisualStyleBackColor = true;
            this.siparisler_ilk5.Click += new System.EventHandler(this.siparisler_ilk5_Click);
            // 
            // siparisler_son5
            // 
            this.siparisler_son5.Location = new System.Drawing.Point(367, 99);
            this.siparisler_son5.Name = "siparisler_son5";
            this.siparisler_son5.Size = new System.Drawing.Size(101, 23);
            this.siparisler_son5.TabIndex = 19;
            this.siparisler_son5.Text = "Son 5";
            this.siparisler_son5.UseVisualStyleBackColor = true;
            this.siparisler_son5.Click += new System.EventHandler(this.siparisler_son5_Click);
            // 
            // yangwang
            // 
            this.yangwang.Location = new System.Drawing.Point(475, 99);
            this.yangwang.Name = "yangwang";
            this.yangwang.Size = new System.Drawing.Size(101, 23);
            this.yangwang.TabIndex = 20;
            this.yangwang.Text = "Yang Wang";
            this.yangwang.UseVisualStyleBackColor = true;
            this.yangwang.Click += new System.EventHandler(this.yangwang_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(582, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 23);
            this.button7.TabIndex = 21;
            this.button7.Text = "Siparis Sayısı";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.yangwang);
            this.Controls.Add(this.siparisler_son5);
            this.Controls.Add(this.siparisler_ilk5);
            this.Controls.Add(this.siparisler_tarih);
            this.Controls.Add(this.isimler_N_ilebaslayanlar);
            this.Controls.Add(this.isimler_iBarindiran);
            this.Controls.Add(this.isimler_uzunluk);
            this.Controls.Add(this.isimler_tersalfabetik);
            this.Controls.Add(this.isimler_alfabetik);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sayilar_kactane);
            this.Controls.Add(this.sayilar_enkucuk);
            this.Controls.Add(this.sayilar_enbuyuk);
            this.Controls.Add(this.sayilar_tek);
            this.Controls.Add(this.sayilar_cift);
            this.Controls.Add(this.sayilar_pozitif);
            this.Controls.Add(this.sayilar_negatif);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.sayilar_tumsayilar);
            this.Controls.Add(this.siparisler_hepsi);
            this.Name = "Form1";
            this.Text = "v";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button siparisler_hepsi;
        private System.Windows.Forms.Button sayilar_tumsayilar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sayilar_negatif;
        private System.Windows.Forms.Button sayilar_pozitif;
        private System.Windows.Forms.Button sayilar_cift;
        private System.Windows.Forms.Button sayilar_tek;
        private System.Windows.Forms.Button sayilar_enbuyuk;
        private System.Windows.Forms.Button sayilar_enkucuk;
        private System.Windows.Forms.Button sayilar_kactane;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button isimler_alfabetik;
        private System.Windows.Forms.Button isimler_tersalfabetik;
        private System.Windows.Forms.Button isimler_uzunluk;
        private System.Windows.Forms.Button isimler_iBarindiran;
        private System.Windows.Forms.Button isimler_N_ilebaslayanlar;
        private System.Windows.Forms.Button siparisler_tarih;
        private System.Windows.Forms.Button siparisler_ilk5;
        private System.Windows.Forms.Button siparisler_son5;
        private System.Windows.Forms.Button yangwang;
        private System.Windows.Forms.Button button7;
    }
}

