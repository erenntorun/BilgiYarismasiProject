using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ProjeSorular
{
    public class SorularVT
    {
        public static int KategoriId { get; set; } 

        public static string KategoriAdiGetir(int KategoriId)
        {
            string KategoriAdi = "";

            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select KategoriAdi from Kategoriler where Id = @KategoriId";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = connection;

            SqlParameter prm = new SqlParameter("@KategoriId",System.Data.SqlDbType.Int);
            prm.Value = KategoriId;
            cmd.Parameters.Add(prm);


            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                KategoriAdi = dr["KategoriAdi"] is DBNull ? string.Empty : dr["KategoriAdi"].ToString();
            }
            connection.Close();

            return KategoriAdi;
        }


        public static List<SorularTablosu> SorulariGetirZ1(int KategoriId)
        {
            List<SorularTablosu> list = new List<SorularTablosu>();

            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select Top 3 * from Sorular where KategoriId = @KategoriId And ZorlukId = 1 
                                Order By NEWID()";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection =connection;


            SqlParameter prm = new SqlParameter("@KategoriId",System.Data.SqlDbType.Int);
            prm.Value =KategoriId;
            cmd.Parameters.Add(prm);


            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SorularTablosu soru = new SorularTablosu();
                soru.SoruId = dr["SoruId"] is DBNull ? 0 : Convert.ToInt32(dr["SoruId"]);
                soru.KategoriId = dr["KategoriId"] is DBNull ? 0 : Convert.ToInt32(dr["KategoriId"]);
                soru.soru = dr["soru"] is DBNull ? string.Empty : dr["soru"].ToString();
                soru.a = dr["a"] is DBNull ? string.Empty : dr["a"].ToString();
                soru.b = dr["b"] is DBNull ? string.Empty : dr["b"].ToString();
                soru.c = dr["c"] is DBNull ? string.Empty : dr["c"].ToString();
                soru.d = dr["d"] is DBNull ? string.Empty : dr["d"].ToString();
                soru.Dogru = dr["Dogru"] is DBNull ? string.Empty : dr["Dogru"].ToString();
                soru.Puan = dr["Puan"] is DBNull ? 0 : Convert.ToInt32(dr["Puan"]);
                soru.ZorlukId = dr["ZorlukId"] is DBNull ? 0 : Convert.ToInt32(dr["ZorlukId"]);

                list.Add(soru);
            }
            connection.Close();


            return list;
        }


        public static List<SorularTablosu> SorulariGetirZ2(int KategoriId)
        {
            List<SorularTablosu> list = new List<SorularTablosu>();

            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select Top 3 * from Sorular where KategoriId = @KategoriId And ZorlukId = 2
                                Order By NEWID()";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = connection;

            SqlParameter prm = new SqlParameter("@KategoriId", System.Data.SqlDbType.Int);
            prm.Value = KategoriId;
            cmd.Parameters.Add(prm);

            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SorularTablosu soru = new SorularTablosu();
                soru.SoruId = dr["SoruId"] is DBNull ? 0 : Convert.ToInt32(dr["SoruId"]);
                soru.KategoriId = dr["KategoriId"] is DBNull ? 0 : Convert.ToInt32(dr["KategoriId"]);
                soru.soru = dr["soru"] is DBNull ? string.Empty : dr["soru"].ToString();
                soru.a = dr["a"] is DBNull ? string.Empty : dr["a"].ToString();
                soru.b = dr["b"] is DBNull ? string.Empty : dr["b"].ToString();
                soru.c = dr["c"] is DBNull ? string.Empty : dr["c"].ToString();
                soru.d = dr["d"] is DBNull ? string.Empty : dr["d"].ToString();
                soru.Dogru = dr["Dogru"] is DBNull ? string.Empty : dr["Dogru"].ToString();
                soru.Puan = dr["Puan"] is DBNull ? 0 : Convert.ToInt32(dr["Puan"]);
                soru.ZorlukId = dr["ZorlukId"] is DBNull ? 0 : Convert.ToInt32(dr["ZorlukId"]);

                list.Add(soru);
            }
            connection.Close();


            return list;
        }

        public static List<SorularTablosu> SorulariGetirZ3(int KategoriId)
        {
            List<SorularTablosu> list = new List<SorularTablosu>();

            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select Top 3 * from Sorular where KategoriId = @KategoriId And ZorlukId = 3
                                Order By NEWID()";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = connection;

            SqlParameter prm = new SqlParameter("@KategoriId", System.Data.SqlDbType.Int);
            prm.Value = KategoriId;
            cmd.Parameters.Add(prm);

            connection.Open();       
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SorularTablosu soru = new SorularTablosu();
                soru.SoruId = dr["SoruId"] is DBNull ? 0 : Convert.ToInt32(dr["SoruId"]);
                soru.KategoriId = dr["KategoriId"] is DBNull ? 0 : Convert.ToInt32(dr["KategoriId"]);
                soru.soru = dr["soru"] is DBNull ? string.Empty : dr["soru"].ToString();
                soru.a = dr["a"] is DBNull ? string.Empty : dr["a"].ToString();
                soru.b = dr["b"] is DBNull ? string.Empty : dr["b"].ToString();
                soru.c = dr["c"] is DBNull ? string.Empty : dr["c"].ToString();
                soru.d = dr["d"] is DBNull ? string.Empty : dr["d"].ToString();
                soru.Dogru = dr["Dogru"] is DBNull ? string.Empty : dr["Dogru"].ToString();
                soru.Puan = dr["Puan"] is DBNull ? 0 : Convert.ToInt32(dr["Puan"]);
                soru.ZorlukId = dr["ZorlukId"] is DBNull ? 0 : Convert.ToInt32(dr["ZorlukId"]);

                list.Add(soru);
            }
            connection.Close();


            return list;
        }

        public static List<SorularTablosu> SorulariGetirZ4(int KategoriId)
        {
            List<SorularTablosu> list = new List<SorularTablosu>();

            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Select Top 3 * from Sorular where KategoriId = @KategoriId And ZorlukId = 4
                                Order By NEWID()";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = connection;

            SqlParameter prm = new SqlParameter("@KategoriId", System.Data.SqlDbType.Int);
            prm.Value = KategoriId;
            cmd.Parameters.Add(prm);

            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SorularTablosu soru = new SorularTablosu();
                soru.SoruId = dr["SoruId"] is DBNull ? 0 : Convert.ToInt32(dr["SoruId"]);
                soru.KategoriId = dr["KategoriId"] is DBNull ? 0 : Convert.ToInt32(dr["KategoriId"]);
                soru.soru = dr["soru"] is DBNull ? string.Empty : dr["soru"].ToString();
                soru.a = dr["a"] is DBNull ? string.Empty : dr["a"].ToString();
                soru.b = dr["b"] is DBNull ? string.Empty : dr["b"].ToString();
                soru.c = dr["c"] is DBNull ? string.Empty : dr["c"].ToString();
                soru.d = dr["d"] is DBNull ? string.Empty : dr["d"].ToString();
                soru.Dogru = dr["Dogru"] is DBNull ? string.Empty : dr["Dogru"].ToString();
                soru.Puan = dr["Puan"] is DBNull ? 0 : Convert.ToInt32(dr["Puan"]);
                soru.ZorlukId = dr["ZorlukId"] is DBNull ? 0 : Convert.ToInt32(dr["ZorlukId"]);

                list.Add(soru);
            }
            connection.Close();


            return list;
        }


        public static List<SorularTablosu> SorulariGetirToplam(int KategoriId)
        {
            List<SorularTablosu> list = new List<SorularTablosu>();

            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SorularSP";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = connection;


            SqlParameter prm = new SqlParameter("@KategoriId", System.Data.SqlDbType.Int);
            prm.Value = KategoriId;
            cmd.Parameters.Add(prm);


            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SorularTablosu soru = new SorularTablosu();
                soru.SoruId = dr["SoruId"] is DBNull ? 0 : Convert.ToInt32(dr["SoruId"]);
                soru.KategoriId = dr["KategoriId"] is DBNull ? 0 : Convert.ToInt32(dr["KategoriId"]);
                soru.soru = dr["soru"] is DBNull ? string.Empty : dr["soru"].ToString();
                soru.a = dr["a"] is DBNull ? string.Empty : dr["a"].ToString();
                soru.b = dr["b"] is DBNull ? string.Empty : dr["b"].ToString();
                soru.c = dr["c"] is DBNull ? string.Empty : dr["c"].ToString();
                soru.d = dr["d"] is DBNull ? string.Empty : dr["d"].ToString();
                soru.Dogru = dr["Dogru"] is DBNull ? string.Empty : dr["Dogru"].ToString();
                soru.Puan = dr["Puan"] is DBNull ? 0 : Convert.ToInt32(dr["Puan"]);
                soru.ZorlukId = dr["ZorlukId"] is DBNull ? 0 : Convert.ToInt32(dr["ZorlukId"]);

                list.Add(soru);
            }
            connection.Close();


            return list;
        }


        public static List<string> SiklariListeyeEkleme(SorularTablosu item)
        {
            List<string> list = new List<string>();
            list.Add(item.a.ToString());
            list.Add(item.b.ToString());
            list.Add(item.c.ToString());
            list.Add(item.d.ToString());

            return list;
        }

        public static int previousRandomNumber = -1;

        public static int RastgeleFarkliSayiUret(int min, int max)
        {
            int rastgeleSayi;
            Random rand = new Random();
            do
            {
                rastgeleSayi = rand.Next(min, max + 1);
            } while (rastgeleSayi == previousRandomNumber);

            previousRandomNumber = rastgeleSayi;
            return rastgeleSayi;
        }


        public static bool PuanTablosuVeriEkleme(string KategoriAdi, string AdSoyad, int Puan)
        {
            bool islem = false;

            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into PuanTablosu(KategoriAdi,AdSoyad,Puan) Values (@KategoriAdi,@AdSoyad,@Puan)";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = connection;


            SqlParameter prm = new SqlParameter("@KategoriAdi", System.Data.SqlDbType.VarChar);
            prm.Value = KategoriAdi;
            cmd.Parameters.Add(prm);

            SqlParameter prm1 = new SqlParameter("@AdSoyad",System.Data.SqlDbType.VarChar);
            prm1.Value = AdSoyad;
            cmd.Parameters.Add(prm1);

            SqlParameter prm2 = new SqlParameter("@Puan",System.Data.SqlDbType.SmallInt);
            prm2.Value = Puan;
            cmd.Parameters.Add(prm2);


            connection.Open();
            int islemsayisi = cmd.ExecuteNonQuery();
            if (islemsayisi > 0) { islem = true; } else { islem = false; }                 
            connection.Close();


            return islem;
        }


        public static List<PuanTablosu> PuanlarıListeleme()
        {
            List<PuanTablosu> list = new List<PuanTablosu>();

            SqlConnection connection = new SqlConnection(Connection.ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from PuanTablosu Order By Puan DESC";
            cmd.Connection = connection;

            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                PuanTablosu puanlar = new PuanTablosu();
                puanlar.Id = dr["Id"] is DBNull ? 0 : Convert.ToInt32(dr["Id"]);
                puanlar.KategoriAdi = dr["KategoriAdi"] is DBNull ? string.Empty : dr["KategoriAdi"].ToString();
                puanlar.AdSoyad = dr["AdSoyad"] is DBNull ? string.Empty : dr["AdSoyad"].ToString();
                puanlar.Puan = dr["Puan"] is DBNull ? 0 : Convert.ToInt32(dr["Puan"]);

                list.Add(puanlar);
            }
            connection.Close();


            return list;
        }







    }
}
