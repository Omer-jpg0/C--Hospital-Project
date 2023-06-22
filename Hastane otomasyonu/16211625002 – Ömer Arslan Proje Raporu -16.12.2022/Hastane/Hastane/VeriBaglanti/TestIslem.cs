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
    internal class TestIslem
    {
        Baglan b = new Baglan();
        public DataTable TestKontrol(string ad)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("test_kontrol_usp", baglanti))
                    {

                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@ad", ad);
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "Testler");
                        dt = ds.Tables["Testler"];
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
        public bool TestEkle(string ad, string maliyet)
        {
            bool hataOlustuMu = false;

            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("test_ekle_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@ad", ad);
                        komut.Parameters.AddWithValue("@maliyet", maliyet);
                        
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
        public DataTable TestListesi()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("test_listele_usp", baglanti))
                    {

                        komut.CommandType = CommandType.StoredProcedure;
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "TestlerL");
                        dt = ds.Tables["TestlerL"];
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

        public bool TestGuncelle(int id, string ad,string maliyet)
        {
            bool hataOlustuMu = false;

            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("test_guncelle_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@id", id);
                        komut.Parameters.AddWithValue("@ad", ad);
                        komut.Parameters.AddWithValue("@maliyet", maliyet);
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
        public bool TestSil(int id)
        {
            bool hataOlustuMu = false;

            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("test_sil_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@id", id);
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
        public DataTable TestAra(string parametre)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("test_ara_usp", baglanti))
                    {

                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@ad", parametre);
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "TestA");
                        //dt = ds.Tables[0];
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
