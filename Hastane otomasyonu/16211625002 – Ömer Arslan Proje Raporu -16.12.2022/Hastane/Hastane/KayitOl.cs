using Hastane.VeriBaglanti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class KayitOl : Form
    {
        DialogResult Kontrol=new DialogResult();
        KullaniciLogin kullaniciLogin = new KullaniciLogin();

        public KayitOl()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Giris g1=new Giris();
            g1.Show();
            this.Hide();

        }

        private void GirisKapatbtn_Click(object sender, EventArgs e)
        {
            Kontrol = MessageBox.Show("Programı Kapatmak İstediğinize Eminmisiniz", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (Kontrol == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnKayitol_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = kullaniciLogin.KullaniciGetir2(tbxKullaniciAdi.Text);
            if (tbxAdSoyad.Text==""|| tbxKullaniciAdi.Text == "" || cmbCinsiyet.Text == "" ||
                guna2DateTimePicker1.Text == "" || maskTelefon.Text == "" || tbxAdres.Text == "" ||
                tbxSifre.Text == "" || tbxSifreTekrar.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları  Doldurun");

            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Kayıtlı Kullanıcı");
                }
                else
                {
                    if (tbxSifre.Text== tbxSifreTekrar.Text)
                    {
                        bool hata = kullaniciLogin.KullaniciEkle(tbxAdSoyad.Text, cmbCinsiyet.Text, guna2DateTimePicker1.Text,
                            maskTelefon.Text, tbxAdres.Text, tbxKullaniciAdi.Text, tbxSifre.Text);
                        if (hata == false)
                        {
                            MessageBox.Show("Kayıt Başarıyla Eklendi");
                        }
                        else
                        {
                            MessageBox.Show("Kaydınız yapılamadı.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmamaktadır");

                    }

                }
            }
            
        }
    }
}
