namespace ProjeSorular
{
    partial class Sorular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sorular));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.lblKategoriAdi = new System.Windows.Forms.Label();
            this.lblSoruNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.timerSorular = new System.Windows.Forms.Timer(this.components);
            this.lblSüre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnD = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(30, 106);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(783, 208);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Soruların Gelmesi İçin Başla\' ya Tıklayın!";
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.White;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA.ForeColor = System.Drawing.Color.Black;
            this.btnA.Image = ((System.Drawing.Image)(resources.GetObject("btnA.Image")));
            this.btnA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnA.Location = new System.Drawing.Point(30, 337);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(361, 47);
            this.btnA.TabIndex = 1;
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnB.BackColor = System.Drawing.Color.White;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB.ForeColor = System.Drawing.Color.Black;
            this.btnB.Image = ((System.Drawing.Image)(resources.GetObject("btnB.Image")));
            this.btnB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnB.Location = new System.Drawing.Point(452, 337);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(361, 47);
            this.btnB.TabIndex = 2;
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.White;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.ForeColor = System.Drawing.Color.Black;
            this.btnC.Image = ((System.Drawing.Image)(resources.GetObject("btnC.Image")));
            this.btnC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnC.Location = new System.Drawing.Point(30, 414);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(361, 47);
            this.btnC.TabIndex = 3;
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBasla.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(660, 41);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(153, 52);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // lblKategoriAdi
            // 
            this.lblKategoriAdi.AutoSize = true;
            this.lblKategoriAdi.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblKategoriAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategoriAdi.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblKategoriAdi.Location = new System.Drawing.Point(30, 9);
            this.lblKategoriAdi.Name = "lblKategoriAdi";
            this.lblKategoriAdi.Size = new System.Drawing.Size(119, 28);
            this.lblKategoriAdi.TabIndex = 6;
            this.lblKategoriAdi.Text = "KategoriAdi";
            // 
            // lblSoruNo
            // 
            this.lblSoruNo.AutoSize = true;
            this.lblSoruNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoruNo.ForeColor = System.Drawing.Color.White;
            this.lblSoruNo.Location = new System.Drawing.Point(30, 65);
            this.lblSoruNo.Name = "lblSoruNo";
            this.lblSoruNo.Size = new System.Drawing.Size(53, 28);
            this.lblSoruNo.TabIndex = 8;
            this.lblSoruNo.Text = "Soru";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(228, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Puan:";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.Color.White;
            this.lblPuan.Location = new System.Drawing.Point(289, 65);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(34, 28);
            this.lblPuan.TabIndex = 10;
            this.lblPuan.Text = "00";
            // 
            // timerSorular
            // 
            this.timerSorular.Interval = 1000;
            this.timerSorular.Tick += new System.EventHandler(this.timerSorular_Tick);
            // 
            // lblSüre
            // 
            this.lblSüre.AutoSize = true;
            this.lblSüre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSüre.ForeColor = System.Drawing.Color.White;
            this.lblSüre.Location = new System.Drawing.Point(451, 65);
            this.lblSüre.Name = "lblSüre";
            this.lblSüre.Size = new System.Drawing.Size(89, 35);
            this.lblSüre.TabIndex = 12;
            this.lblSüre.Text = "06 : 00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(390, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Süre:";
            // 
            // btnD
            // 
            this.btnD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnD.BackColor = System.Drawing.Color.White;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnD.ForeColor = System.Drawing.Color.Black;
            this.btnD.Image = ((System.Drawing.Image)(resources.GetObject("btnD.Image")));
            this.btnD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnD.Location = new System.Drawing.Point(452, 414);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(361, 47);
            this.btnD.TabIndex = 4;
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1, 1);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Sorular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(854, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.lblSüre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSoruNo);
            this.Controls.Add(this.lblKategoriAdi);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.textBox1);
            this.Name = "Sorular";
            this.Text = "Sorular";
            this.Load += new System.EventHandler(this.Sorular_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblKategoriAdi;
        private System.Windows.Forms.Label lblSoruNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Timer timerSorular;
        private System.Windows.Forms.Label lblSüre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button button1;
    }
}