namespace ProjeSorular
{
    partial class GirisEkranı
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenelKultur = new System.Windows.Forms.Button();
            this.btnBilimTeknoloji = new System.Windows.Forms.Button();
            this.btnSpor = new System.Windows.Forms.Button();
            this.btnSinemaTv = new System.Windows.Forms.Button();
            this.btnEglence = new System.Windows.Forms.Button();
            this.btnSanatMüzik = new System.Windows.Forms.Button();
            this.btnEdebiyat = new System.Windows.Forms.Button();
            this.btnTarih = new System.Windows.Forms.Button();
            this.btnCografya = new System.Windows.Forms.Button();
            this.btnFelsefe = new System.Windows.Forms.Button();
            this.btnYemekMutfak = new System.Windows.Forms.Button();
            this.btnPsikoloji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen Yarışmak İstediğiniz Kategoriyi Seçiniz.";
            // 
            // btnGenelKultur
            // 
            this.btnGenelKultur.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGenelKultur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenelKultur.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenelKultur.ForeColor = System.Drawing.Color.White;
            this.btnGenelKultur.Location = new System.Drawing.Point(43, 120);
            this.btnGenelKultur.Name = "btnGenelKultur";
            this.btnGenelKultur.Size = new System.Drawing.Size(154, 89);
            this.btnGenelKultur.TabIndex = 1;
            this.btnGenelKultur.Text = "Genel Kültür";
            this.btnGenelKultur.UseVisualStyleBackColor = false;
            this.btnGenelKultur.Click += new System.EventHandler(this.btnGenelKultur_Click);
            // 
            // btnBilimTeknoloji
            // 
            this.btnBilimTeknoloji.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBilimTeknoloji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilimTeknoloji.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilimTeknoloji.ForeColor = System.Drawing.Color.White;
            this.btnBilimTeknoloji.Location = new System.Drawing.Point(232, 120);
            this.btnBilimTeknoloji.Name = "btnBilimTeknoloji";
            this.btnBilimTeknoloji.Size = new System.Drawing.Size(154, 89);
            this.btnBilimTeknoloji.TabIndex = 2;
            this.btnBilimTeknoloji.Text = "Bilim ve Teknoloji";
            this.btnBilimTeknoloji.UseVisualStyleBackColor = false;
            this.btnBilimTeknoloji.Click += new System.EventHandler(this.btnBilimTeknoloji_Click);
            // 
            // btnSpor
            // 
            this.btnSpor.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSpor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpor.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpor.ForeColor = System.Drawing.Color.White;
            this.btnSpor.Location = new System.Drawing.Point(422, 120);
            this.btnSpor.Name = "btnSpor";
            this.btnSpor.Size = new System.Drawing.Size(154, 89);
            this.btnSpor.TabIndex = 3;
            this.btnSpor.Text = "Spor";
            this.btnSpor.UseVisualStyleBackColor = false;
            this.btnSpor.Click += new System.EventHandler(this.btnSpor_Click);
            // 
            // btnSinemaTv
            // 
            this.btnSinemaTv.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSinemaTv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinemaTv.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinemaTv.ForeColor = System.Drawing.Color.White;
            this.btnSinemaTv.Location = new System.Drawing.Point(610, 120);
            this.btnSinemaTv.Name = "btnSinemaTv";
            this.btnSinemaTv.Size = new System.Drawing.Size(154, 89);
            this.btnSinemaTv.TabIndex = 4;
            this.btnSinemaTv.Text = "Sinema ve Televizyon";
            this.btnSinemaTv.UseVisualStyleBackColor = false;
            this.btnSinemaTv.Click += new System.EventHandler(this.btnSinemaTv_Click);
            // 
            // btnEglence
            // 
            this.btnEglence.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEglence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEglence.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEglence.ForeColor = System.Drawing.Color.White;
            this.btnEglence.Location = new System.Drawing.Point(610, 274);
            this.btnEglence.Name = "btnEglence";
            this.btnEglence.Size = new System.Drawing.Size(154, 89);
            this.btnEglence.TabIndex = 8;
            this.btnEglence.Text = "Eğlence";
            this.btnEglence.UseVisualStyleBackColor = false;
            this.btnEglence.Click += new System.EventHandler(this.btnEglence_Click);
            // 
            // btnSanatMüzik
            // 
            this.btnSanatMüzik.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSanatMüzik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanatMüzik.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanatMüzik.ForeColor = System.Drawing.Color.White;
            this.btnSanatMüzik.Location = new System.Drawing.Point(422, 274);
            this.btnSanatMüzik.Name = "btnSanatMüzik";
            this.btnSanatMüzik.Size = new System.Drawing.Size(154, 89);
            this.btnSanatMüzik.TabIndex = 7;
            this.btnSanatMüzik.Text = "Sanat ve Müzik";
            this.btnSanatMüzik.UseVisualStyleBackColor = false;
            this.btnSanatMüzik.Click += new System.EventHandler(this.btnSanatMüzik_Click);
            // 
            // btnEdebiyat
            // 
            this.btnEdebiyat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEdebiyat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdebiyat.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdebiyat.ForeColor = System.Drawing.Color.White;
            this.btnEdebiyat.Location = new System.Drawing.Point(232, 274);
            this.btnEdebiyat.Name = "btnEdebiyat";
            this.btnEdebiyat.Size = new System.Drawing.Size(154, 89);
            this.btnEdebiyat.TabIndex = 6;
            this.btnEdebiyat.Text = "Edebiyat";
            this.btnEdebiyat.UseVisualStyleBackColor = false;
            this.btnEdebiyat.Click += new System.EventHandler(this.btnEdebiyat_Click);
            // 
            // btnTarih
            // 
            this.btnTarih.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTarih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarih.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarih.ForeColor = System.Drawing.Color.White;
            this.btnTarih.Location = new System.Drawing.Point(43, 274);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Size = new System.Drawing.Size(154, 89);
            this.btnTarih.TabIndex = 5;
            this.btnTarih.Text = "Tarih";
            this.btnTarih.UseVisualStyleBackColor = false;
            this.btnTarih.Click += new System.EventHandler(this.btnTarih_Click);
            // 
            // btnCografya
            // 
            this.btnCografya.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCografya.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCografya.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCografya.ForeColor = System.Drawing.Color.White;
            this.btnCografya.Location = new System.Drawing.Point(232, 426);
            this.btnCografya.Name = "btnCografya";
            this.btnCografya.Size = new System.Drawing.Size(154, 89);
            this.btnCografya.TabIndex = 10;
            this.btnCografya.Text = "Coğrafya";
            this.btnCografya.UseVisualStyleBackColor = false;
            this.btnCografya.Click += new System.EventHandler(this.btnCografya_Click);
            // 
            // btnFelsefe
            // 
            this.btnFelsefe.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFelsefe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFelsefe.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFelsefe.ForeColor = System.Drawing.Color.White;
            this.btnFelsefe.Location = new System.Drawing.Point(43, 426);
            this.btnFelsefe.Name = "btnFelsefe";
            this.btnFelsefe.Size = new System.Drawing.Size(154, 89);
            this.btnFelsefe.TabIndex = 9;
            this.btnFelsefe.Text = "Felsefe";
            this.btnFelsefe.UseVisualStyleBackColor = false;
            this.btnFelsefe.Click += new System.EventHandler(this.btnFelsefe_Click);
            // 
            // btnYemekMutfak
            // 
            this.btnYemekMutfak.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnYemekMutfak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYemekMutfak.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYemekMutfak.ForeColor = System.Drawing.Color.White;
            this.btnYemekMutfak.Location = new System.Drawing.Point(610, 426);
            this.btnYemekMutfak.Name = "btnYemekMutfak";
            this.btnYemekMutfak.Size = new System.Drawing.Size(154, 89);
            this.btnYemekMutfak.TabIndex = 12;
            this.btnYemekMutfak.Text = "Yemek ve Mutfak";
            this.btnYemekMutfak.UseVisualStyleBackColor = false;
            this.btnYemekMutfak.Click += new System.EventHandler(this.btnYemekMutfak_Click);
            // 
            // btnPsikoloji
            // 
            this.btnPsikoloji.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPsikoloji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPsikoloji.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPsikoloji.ForeColor = System.Drawing.Color.White;
            this.btnPsikoloji.Location = new System.Drawing.Point(422, 426);
            this.btnPsikoloji.Name = "btnPsikoloji";
            this.btnPsikoloji.Size = new System.Drawing.Size(154, 89);
            this.btnPsikoloji.TabIndex = 11;
            this.btnPsikoloji.Text = "Psikoloji";
            this.btnPsikoloji.UseVisualStyleBackColor = false;
            this.btnPsikoloji.Click += new System.EventHandler(this.btnPsikoloji_Click);
            // 
            // GirisEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(816, 577);
            this.Controls.Add(this.btnYemekMutfak);
            this.Controls.Add(this.btnPsikoloji);
            this.Controls.Add(this.btnCografya);
            this.Controls.Add(this.btnFelsefe);
            this.Controls.Add(this.btnEglence);
            this.Controls.Add(this.btnSanatMüzik);
            this.Controls.Add(this.btnEdebiyat);
            this.Controls.Add(this.btnTarih);
            this.Controls.Add(this.btnSinemaTv);
            this.Controls.Add(this.btnSpor);
            this.Controls.Add(this.btnBilimTeknoloji);
            this.Controls.Add(this.btnGenelKultur);
            this.Controls.Add(this.label1);
            this.Name = "GirisEkranı";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.GirisEkranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenelKultur;
        private System.Windows.Forms.Button btnBilimTeknoloji;
        private System.Windows.Forms.Button btnSpor;
        private System.Windows.Forms.Button btnSinemaTv;
        private System.Windows.Forms.Button btnEglence;
        private System.Windows.Forms.Button btnSanatMüzik;
        private System.Windows.Forms.Button btnEdebiyat;
        private System.Windows.Forms.Button btnTarih;
        private System.Windows.Forms.Button btnCografya;
        private System.Windows.Forms.Button btnFelsefe;
        private System.Windows.Forms.Button btnYemekMutfak;
        private System.Windows.Forms.Button btnPsikoloji;
    }
}

