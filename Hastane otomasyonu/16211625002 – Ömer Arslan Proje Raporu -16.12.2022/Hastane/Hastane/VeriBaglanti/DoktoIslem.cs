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
    internal class DoktoIslem
    {
        Baglan b = new Baglan();

        public DataTable DoktorGetir(string ID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("doktor_yazdir_usp", baglanti))
                    {

                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@id", ID);
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "Admin");
                        dt = ds.Tables["Admin"];
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
        public DataTable DoktorListesi()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("doktor_listele_usp", baglanti))
                    {

                        komut.CommandType = CommandType.StoredProcedure;
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "Doktorlar");
                        dt = ds.Tables["Doktorlar"];
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
        public DataTable DoktorKontrol(string kullaniciAdi)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("doktor_kontrol_usp", baglanti))
                    {

                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@kadi", kullaniciAdi);
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "DoktorK");
                        dt = ds.Tables["DoktorK"];
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
        public bool DoktorEkle(string AdSoyad, string brans, string DogumTarihi, string eposta, string tel, string KullaniciAdi, string Sifre)
        {
            bool hataOlustuMu = false;

            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("doktor_ekle_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@ad", AdSoyad);
                        komut.Parameters.AddWithValue("@brans", brans);
                        komut.Parameters.AddWithValue("@dogum", DogumTarihi);
                        komut.Parameters.AddWithValue("@eposta", eposta);
                        komut.Parameters.AddWithValue("@tel", tel);
                        komut.Parameters.AddWithValue("@kadi", KullaniciAdi);
                        komut.Parameters.AddWithValue("@sifre", Sifre);
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
        public bool DoktorGuncelle(int id,string AdSoyad, string brans, string DogumTarihi, string eposta, string tel, string KullaniciAdi, string Sifre)
        {
            bool hataOlustuMu = false;

            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("doktor_guncelle_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@id", id);
                        komut.Parameters.AddWithValue("@ad", AdSoyad);
                        komut.Parameters.AddWithValue("@brans", brans);
                        komut.Parameters.AddWithValue("@dogum", DogumTarihi);
                        komut.Parameters.AddWithValue("@eposta", eposta);
                        komut.Parameters.AddWithValue("@tel", tel);
                        komut.Parameters.AddWithValue("@kadi", KullaniciAdi);
                        komut.Parameters.AddWithValue("@sifre", Sifre);
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
        public bool DoktorSil(int id)
        {
            bool hataOlustuMu = false;

            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("doktor_sil_usp", baglanti))
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
        public DataTable DoktorAra(string parametre)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("doktor_ara_usp", baglanti))
                    {

                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@ad", parametre);
                        komut.Parameters.AddWithValue("@brans", parametre);
                        komut.Parameters.AddWithValue("@eposta", parametre);
                        komut.Parameters.AddWithValue("@tel", parametre);
                        komut.Parameters.AddWithValue("@kadi", parametre);
                        komut.Parameters.AddWithValue("@sifre", parametre);
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "DoktorA");
                        //dt = ds.Tables[0];
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
        
    }
}
