namespace ProjeSorular
{
    partial class Puanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puanlar));
            this.lblKategoriAdi = new System.Windows.Forms.Label();
            this.lblSoruNo = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKategoriAdi
            // 
            this.lblKategoriAdi.AutoSize = true;
            this.lblKategoriAdi.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblKategoriAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategoriAdi.ForeColor = System.Drawing.Color.White;
            this.lblKategoriAdi.Location = new System.Drawing.Point(50, 45);
            this.lblKategoriAdi.Name = "lblKategoriAdi";
            this.lblKategoriAdi.Size = new System.Drawing.Size(398, 32);
            this.lblKategoriAdi.TabIndex = 7;
            this.lblKategoriAdi.Text = "Puanınız Hangi İsimle Kaydedilsin?";
            // 
            // lblSoruNo
            // 
            this.lblSoruNo.AutoSize = true;
            this.lblSoruNo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoruNo.ForeColor = System.Drawing.Color.White;
            this.lblSoruNo.Location = new System.Drawing.Point(51, 126);
            this.lblSoruNo.Name = "lblSoruNo";
            this.lblSoruNo.Size = new System.Drawing.Size(109, 30);
            this.lblSoruNo.TabIndex = 8;
            this.lblSoruNo.Text = "Ad Soyad:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(176, 129);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(188, 30);
            this.lblAdSoyad.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(176, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Puanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(492, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblSoruNo);
            this.Controls.Add(this.lblKategoriAdi);
            this.Name = "Puanlar";
            this.Text = "Puanlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKategoriAdi;
        private System.Windows.Forms.Label lblSoruNo;
        private System.Windows.Forms.TextBox lblAdSoyad;
        private System.Windows.Forms.Button button1;
    }
}