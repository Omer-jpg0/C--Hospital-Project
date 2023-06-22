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
    public class KullaniciLogin
    {
                

        Baglan b = new Baglan();
        public DataTable KullaniciGetir(string KullaniciAdi, string Sifre)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("kullanici_getir_usp", baglanti))
                    {
                        
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                        komut.Parameters.AddWithValue("@Sifre", Sifre);
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "Kullanicilar");
                        dt = ds.Tables["Kullanicilar"];
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

        public DataTable KullaniciGetir2(string kullaniciAdi)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("kullanici_getir_usp2", baglanti))
                    {
                        
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        baglanti.Open();
                        SqlDataAdapter da;
                        DataSet ds = new DataSet();
                        da = new SqlDataAdapter(komut);
                        da.Fill(ds, "Kullanicilar");
                        dt = ds.Tables["Kullanicilar"];
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


        public bool KullaniciEkle(string AdSoyad,string Cinsiyet,string DogumTarihi,string Telefon,string Adres,string KullaniciAdi, string Sifre)
        {
            bool hataOlustuMu = false;

            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("kullanici_kayit_usp", baglanti))
                    {
                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@AdSoyad", AdSoyad);
                        komut.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
                        komut.Parameters.AddWithValue("@DogumTarihi", DogumTarihi);
                        komut.Parameters.AddWithValue("@Telefon", Telefon);
                        komut.Parameters.AddWithValue("@Adres", Adres);
                        komut.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                        komut.Parameters.AddWithValue("@Sifre", Sifre);
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

        public DataTable DoktorGetir(string KullaniciAdi, string Sifre)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("doktor_geti_usp", baglanti))
                    {

                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
                        komut.Parameters.AddWithValue("@Sifre", Sifre);
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
    }
}
