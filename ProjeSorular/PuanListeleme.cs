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
    public partial class PuanListeleme : Form
    {
        public PuanListeleme()
        {
            InitializeComponent();
        }

        private void PuanListeleme_Load(object sender, EventArgs e)
        {

            List<PuanTablosu> list = SorularVT.PuanlarıListeleme();

            foreach(PuanTablosu item in list)
            {
                ListViewItem lvitem = new ListViewItem();

                lvitem.Text = item.Id.ToString();
                lvitem.SubItems.Add(item.KategoriAdi);
                lvitem.SubItems.Add(item.AdSoyad);
                lvitem.SubItems.Add(item.Puan.ToString());

                listView1.Items.Add(lvitem);
            }


        }
    }
}
