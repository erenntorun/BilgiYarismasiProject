using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeSorular
{
    public partial class Puanlar : Form
    {
        public Puanlar()
        {
            InitializeComponent();
        }

        public string KategoriAdi { get; set; }

        public string AdSoyad { get; set; }

        public int Puan { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {

            if (lblAdSoyad.Text != string.Empty)
            {
                KategoriAdi = SorularVT.KategoriAdiGetir(SorularVT.KategoriId);
                AdSoyad = lblAdSoyad.Text;
                

                bool islemyapildi = SorularVT.PuanTablosuVeriEkleme(KategoriAdi, AdSoyad, Puan);

                if (islemyapildi)
                {
                    PuanListeleme yeni = new PuanListeleme();
                    yeni.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Skor Eklenemedi!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Lütfen Kayıt Edilecek İsmi Giriniz!!", "Uyarı!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
