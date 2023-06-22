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
    internal class AdminIslem
    {
        Baglan b = new Baglan();
        public DataTable AdminGetir(string KullaniciAdi, string Sifre)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection baglanti = b.BaglantiOlustur())
                {
                    using (SqlCommand komut = new SqlCommand("admin_kontrol_usp", baglanti))
                    {

                        komut.CommandType = CommandType.StoredProcedure;
                        komut.Parameters.AddWithValue("@kadi", KullaniciAdi);
                        komut.Parameters.AddWithValue("@sifre", Sifre);
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
    }
}
