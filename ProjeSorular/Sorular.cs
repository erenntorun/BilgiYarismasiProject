using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeSorular
{
    public partial class Sorular : Form
    {
        public Sorular()
        {
            InitializeComponent();
        }

        public string KategoriAdi { get; set; }

        public int SoruId { get; set; }

        public string Dogru { get; set; }

        public int Puan { get; set; }

        public int PuanToplam { get; set; }

        public int SoruNo { get; set; }


        public List<SorularTablosu> list = new List<SorularTablosu>();


        private void SorularıGetir()
        {
            
            SorularTablosu item = list[SoruNo];
            SoruId = item.SoruId;
            textBox1.Text = item.soru;

            //btnA.Text = item.a.ToString();
            //btnB.Text = item.b.ToString();
            //btnC.Text = item.c.ToString();
            //btnD.Text = item.d.ToString();
            List<string>KarisikSiklar = SorularVT.SiklariListeyeEkleme(item);

            for (int i = 0; i < KarisikSiklar.Count; i++)
            {
                int randomIndex = SorularVT.RastgeleFarkliSayiUret(0, KarisikSiklar.Count - 1);
                string temp = KarisikSiklar[i];
                KarisikSiklar[i] = KarisikSiklar[randomIndex];
                KarisikSiklar[randomIndex] = temp;
            }
            btnA.Text = KarisikSiklar[0].ToString();
            btnB.Text = KarisikSiklar[1].ToString();
            btnC.Text = KarisikSiklar[2].ToString();
            btnD.Text = KarisikSiklar[3].ToString();

            Dogru = item.Dogru;
            Puan = item.Puan;
            SoruNo++;
        }


        private void Sorular_Load(object sender, EventArgs e)
        {

            KategoriAdi = SorularVT.KategoriAdiGetir(SorularVT.KategoriId);
            lblKategoriAdi.Text = KategoriAdi.ToString() + " Kategorisinde Yarışıyorsunuz Başarılar :)";

            SoruNo = 0;
            PuanToplam = 0;
            btnBasla.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            list = SorularVT.SorulariGetirToplam(SorularVT.KategoriId);

            zaman = 360;




        }

        private void btnBasla_Click(object sender, EventArgs e)
        { 
            timerSorular.Enabled = true;
            btnBasla.Enabled = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;

            SorularıGetir();
            lblSoruNo.Text = SoruNo.ToString() + ". Soru ";
            textBox1.Focus();
        }


        private void btnA_Click(object sender, EventArgs e)
        {            
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            if(btnA.Text == Dogru.ToString())
            {
                PuanToplam += Puan;
                lblPuan.Text = PuanToplam.ToString();
                btnA.BackColor = Color.Green;
            }
            else
            {
                btnA.BackColor = Color.Red;
                if(btnB.Text == Dogru.ToString())
                {
                    btnB.BackColor = Color.Green;
                }
                else if(btnC.Text == Dogru.ToString())
                {
                    btnC.BackColor = Color.Green;
                }
                else if(btnD.Text == Dogru.ToString())
                {
                    btnD.BackColor = Color.Green;
                }        
            }
            Application.DoEvents();
            Thread.Sleep(2000);
            
            if (SoruNo <= 11)
            {
                SorularıGetir();
                lblSoruNo.Text = SoruNo.ToString() + ". Soru ";
                btnA.BackColor = Color.White;
                btnB.BackColor = Color.White;
                btnC.BackColor = Color.White;
                btnD.BackColor = Color.White;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                button1.Focus();    // D şıkkı kalın gözüküyordu en son TabIndex onda kaldığı için küçük gözükmeyen bir buton oluşturup onda kalmasını sağladım.
            }
            else
            {
                timerSorular.Enabled = false;
                MessageBox.Show("Yarışma Bitmiştir Tebrikler!! " + "Puanınız: " + PuanToplam, "Tebrikler!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Puanlar puan = new Puanlar();
                puan.Puan = PuanToplam;
                puan.Show();
                this.Hide();
            }


        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            if (btnB.Text == Dogru.ToString())
            {
                PuanToplam += Puan;
                lblPuan.Text = PuanToplam.ToString();
                btnB.BackColor = Color.Green;
            }
            else
            {
                btnB.BackColor = Color.Red;
                if (btnA.Text == Dogru.ToString())
                {
                    btnA.BackColor = Color.Green;
                }
                else if (btnC.Text == Dogru.ToString())
                {
                    btnC.BackColor = Color.Green;
                }
                else if (btnD.Text == Dogru.ToString())
                {
                    btnD.BackColor = Color.Green;
                }
            }

            Application.DoEvents();
            Thread.Sleep(2000);
            if (SoruNo <= 11)
            {
                SorularıGetir();
                lblSoruNo.Text = SoruNo.ToString() + ". Soru ";
                btnA.BackColor = Color.White;
                btnB.BackColor = Color.White;
                btnC.BackColor = Color.White;
                btnD.BackColor = Color.White;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                button1.Focus();    // D şıkkı kalın gözüküyordu en son TabIndex onda kaldığı için küçük gözükmeyen bir buton oluşturup onda kalmasını sağladım.
            }
            else
            {
                timerSorular.Enabled = false;
                MessageBox.Show("Yarışma Bitmiştir Tebrikler!! " + "Puanınız: " + PuanToplam, "Tebrikler!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Puanlar puan = new Puanlar();
                puan.Puan = PuanToplam;
                puan.Show();
                this.Hide();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            if (btnC.Text == Dogru.ToString())
            {
                PuanToplam += Puan;
                lblPuan.Text = PuanToplam.ToString();
                btnC.BackColor = Color.Green;
            }
            else
            {
                btnC.BackColor = Color.Red;
                if (btnB.Text == Dogru.ToString())
                {
                    btnB.BackColor = Color.Green;
                }
                else if (btnA.Text == Dogru.ToString())
                {
                    btnA.BackColor = Color.Green;
                }
                else if (btnD.Text == Dogru.ToString())
                {
                    btnD.BackColor = Color.Green;
                }
            }

            Application.DoEvents();
            Thread.Sleep(2000);
            if (SoruNo <= 11)
            {
                SorularıGetir();
                lblSoruNo.Text = SoruNo.ToString() + ". Soru ";
                btnA.BackColor = Color.White;
                btnB.BackColor = Color.White;
                btnC.BackColor = Color.White;
                btnD.BackColor = Color.White;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                button1.Focus();    // D şıkkı kalın gözüküyordu en son TabIndex onda kaldığı için küçük gözükmeyen bir buton oluşturup onda kalmasını sağladım.
            }
            else
            {
                timerSorular.Enabled = false;
                MessageBox.Show("Yarışma Bitmiştir Tebrikler!! " + "Puanınız: " + PuanToplam, "Tebrikler!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Puanlar puan = new Puanlar();
                puan.Puan = PuanToplam;
                puan.Show();
                this.Hide();
            }
        }

        private async void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            if (btnD.Text == Dogru.ToString())
            {
                PuanToplam += Puan;
                lblPuan.Text = PuanToplam.ToString();
                btnD.BackColor = Color.Green;
            }
            else
            {
                btnD.BackColor = Color.Red;
                if (btnB.Text == Dogru.ToString())
                {
                    btnB.BackColor = Color.Green;
                }
                else if (btnC.Text == Dogru.ToString())
                {
                    btnC.BackColor = Color.Green;
                }
                else if (btnA.Text == Dogru.ToString())
                {
                    btnA.BackColor = Color.Green;
                }
            }
            
            await Task.Delay(2000);

            if (SoruNo <= 11)
            {
                SorularıGetir();
                lblSoruNo.Text = SoruNo.ToString() + ". Soru ";
                btnA.BackColor = Color.White;
                btnB.BackColor = Color.White;
                btnC.BackColor = Color.White;
                btnD.BackColor = Color.White;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                button1.Focus();    // D şıkkı kalın gözüküyordu en son TabIndex onda kaldığı için küçük gözükmeyen bir buton oluşturup onda kalmasını sağladım.
            }
            else
            {
                timerSorular.Enabled = false;                
                MessageBox.Show("Yarışma Bitmiştir Tebrikler!! " + "Puanınız: " + PuanToplam, "Tebrikler!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Puanlar puan = new Puanlar();
                puan.Puan = PuanToplam;
                puan.Show();
                this.Hide();
            }
        }



        public int zaman;

        private void timerSorular_Tick(object sender, EventArgs e)
        {

            zaman--;
            int dakika = (zaman/60);
            int saniye = (zaman % 60);
            
            

            if (dakika < 10)
            {
                lblSüre.Text = "0" + dakika.ToString() + " : " + saniye.ToString();
            }
            if (saniye < 10)
            {
                lblSüre.Text = dakika.ToString() + " : " + "0" + saniye.ToString();
            }
            if(dakika > 9 && saniye > 9)
            {
                lblSüre.Text = dakika.ToString() + " : " + saniye.ToString();
            }
            if(dakika < 10 && saniye < 10)
            {
                lblSüre.Text = "0" + dakika.ToString() + " : " + "0" + saniye.ToString();
            }


            if( dakika == 0 && saniye == 0)
            {
                MessageBox.Show("Süreniz doldu testi bitiremediniz!!","Süre Doldu!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                timerSorular.Enabled = false;
                this.Close();
            }




        }

        


    }
}
