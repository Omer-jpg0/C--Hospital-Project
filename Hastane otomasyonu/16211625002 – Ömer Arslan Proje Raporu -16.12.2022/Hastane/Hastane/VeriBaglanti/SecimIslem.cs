using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.VeriBaglanti
{
    internal class SecimIslem
    {
        Baglan b = new Baglan();
        public DataTable DoktorAdKodGetir()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("doktor_ad_kod_getir_usp", baglanti))
                    {
                        //komut.CommandText = "kullanici_getir_usp";
                        //komut.Connection = baglanti;
                        komut.CommandType = CommandType.StoredProcedure;
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "Doktor");
                        //dt = ds.Tables[0];
                        dt = ds.Tables["Doktor"];
                        baglanti.Close();
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            return dt;


        }
        public DataTable TestAdKodGetir()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("test_ad_kod_getir_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "TestAd");
                        dt = ds.Tables["TestAd"];
                        baglanti.Close();
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            return dt;
        }
        public DataTable TestFiyatiGetir(string id)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("test_fiyatı_yaz_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@tID",id);
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "TestFiyat");
                        dt = ds.Tables["TestFiyat"];
                        baglanti.Close();
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            return dt;
        }
        public DataTable DoktorKodGetir(string ad)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("doktor_isme_gore_kod_getir_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@ad", ad);
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "DoktorA");
                        dt = ds.Tables["DoktorA"];
                        baglanti.Close();
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            return dt;
        }
        public bool TeshisEkle(string tarih,int hID, int tID, string maliyet, int dID)
        {
            bool hataOlustuMu = false;

            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("teshis_ekle_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@tarih", tarih);
                        komut.Parameters.AddWithValue("@hID", hID);
                        komut.Parameters.AddWithValue("@tID", tID);
                        komut.Parameters.AddWithValue("@maliyet", maliyet);
                        komut.Parameters.AddWithValue("@dID", dID);


                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                hataOlustuMu = true;
            }
            return hataOlustuMu;

        }
        public DataTable TestKodGetir(string ad)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("test_kod_yaz_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@tID", ad);
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "TestA");
                        dt = ds.Tables["TestA"];
                        baglanti.Close();
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            return dt;
        }

    }
}
