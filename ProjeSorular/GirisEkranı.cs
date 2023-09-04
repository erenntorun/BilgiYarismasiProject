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
    public partial class GirisEkranı : Form
    {
        public GirisEkranı()
        {
            InitializeComponent();
        }




        private void GirisEkranı_Load(object sender, EventArgs e)
        {
            SorularVT.KategoriId = 0;
        }

        private void btnGenelKultur_Click(object sender, EventArgs e)
        {
            SorularVT.KategoriId = 1;
            Sorular yeni = new Sorular();
            yeni.ShowDialog();
        }

        private void btnBilimTeknoloji_Click(object sender, EventArgs e)
        {
            SorularVT.KategoriId = 2;
            Sorular yeni = new Sorular();
            yeni.ShowDialog();
        }

        private void btnSpor_Click(object sender, EventArgs e)
        {
            SorularVT.KategoriId = 3;
            Sorular yeni = new Sorular();
            yeni.ShowDialog();
        }

        private void btnSinemaTv_Click(object sender, EventArgs e)
        {
            SorularVT.KategoriId = 4;
            Sorular yeni = new Sorular();
            yeni.ShowDialog();
        }

        private void btnTarih_Click(object sender, EventArgs e)
        {
            SorularVT.KategoriId = 5;
            Sorular yeni = new Sorular();
            yeni.ShowDialog();
        }

        private void btnEdebiyat_Click(object sender, EventArgs e)
        {
            SorularVT.KategoriId = 6;
            Sorular yeni = new Sorular();
            yeni.ShowDialog();
        }

        private void btnSanatMüzik_Click(object sender, EventArgs e)
        {
            SorularVT.KategoriId = 7;
            Sorular yeni = new Sorular();
            yeni.ShowDialog();
        }

        private void btnEglence_Click(object sender, EventArgs e)
        {
            SorularVT.KategoriId = 8;
            Sorular yeni = new Sorular();
            yeni.ShowDialog();
        }

        private void btnFelsefe_Click(object sender, EventArgs e)
        {
            SorularVT.KategoriId = 9;
            Sorular yeni = new Sorular();
            yeni.ShowDialog();
        }

        private void btnCografya_Click(object sender, EventArgs e)
        {
            SorularVT.KategoriId = 10;
            Sorular yeni = new Sorular();
            yeni.ShowDialog();
        }

        private void btnPsikoloji_Click(object sender, EventArgs e)
        {
            SorularVT.KategoriId = 11;
            Sorular yeni = new Sorular();
            yeni.ShowDialog();
        }

        private void btnYemekMutfak_Click(object sender, EventArgs e)
        {
            SorularVT.KategoriId = 12;
            Sorular yeni = new Sorular();
            yeni.ShowDialog();
        }



    }
}
