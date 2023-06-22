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
    public partial class Doktorlar : Form
    {
        DialogResult Kontrol = new DialogResult();
        public Doktorlar()
        {
            InitializeComponent();
        }

        private void GirisKapatbtn_Click(object sender, EventArgs e)
        {
            Kontrol = MessageBox.Show("Programı Kapatmak İstediğinize Eminmisiniz", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (Kontrol == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ptbHastalar_Click(object sender, EventArgs e)
        {
            Hastalar h1=new Hastalar();
            h1.Show();
            this.Hide();
        }

        private void ptbTestler_Click(object sender, EventArgs e)
        {
            Testler test=new Testler();
            test.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Kontrol = MessageBox.Show("Oturumu Kapatmak İstediğinize Eminmisiniz", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (Kontrol == DialogResult.Yes)
            {
                Giris Out = new Giris();
                Out.Show();
                this.Hide();
            }
        }

        private void ptbSonuçlar_Click(object sender, EventArgs e)
        {
            Teshisler teshis = new Teshisler();
            teshis.Show();
            this.Hide();
        }
        DoktoIslem di = new DoktoIslem();
        HastaIslem hasta = new HastaIslem();    
        void veriGeitir()
        {
            DataTable dt=new DataTable();
            dt = hasta.hastaListesi();
            DataGridView.DataSource = dt;
        }
        private void Doktorlar_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt =di.DoktorGetir(Giris.dID.ToString());
            lblDoktorAd.Text = dt.Rows[0][1].ToString();
            veriGeitir();


        }
        void temizle()
        {
            tbxAdres.Clear();
            tbxAdSoyad.Clear();
            tbxKadi.Clear();
            tbxSifre.Clear();
            maskTelefon.Clear();
            datedgm.Value = DateTime.Now;
            cmbCinsiyet.SelectedIndex = 0;
            lblid.Text = "-1";
        }
        private void DataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            parcala();
        }
        void parcala()
        {
            lblid.Text = DataGridView.CurrentRow.Cells[0].Value.ToString();
            tbxAdSoyad.Text = DataGridView.CurrentRow.Cells[1].Value.ToString();
            cmbCinsiyet.Text = DataGridView.CurrentRow.Cells[2].Value.ToString();
            datedgm.Text = DataGridView.CurrentRow.Cells[3].Value.ToString();
            maskTelefon.Text = DataGridView.CurrentRow.Cells[4].Value.ToString();
            tbxAdres.Text = DataGridView.CurrentRow.Cells[5].Value.ToString();
            tbxKadi.Text = DataGridView.CurrentRow.Cells[6].Value.ToString();
            tbxSifre.Text = DataGridView.CurrentRow.Cells[7].Value.ToString();
        }
        int id;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            id = int.Parse(lblid.Text);
            if (id>0)
            {
                bool hata =  hasta.HastaGuncelle(int.Parse(lblid.Text),tbxAdSoyad.Text,cmbCinsiyet.Text,datedgm.Text,maskTelefon.Text,tbxAdres.Text,tbxKadi.Text,tbxSifre.Text);
                if (hata==false)
                {
                    MessageBox.Show("Güncelleme Başarılı");
                    veriGeitir();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Güncellenecek Kaydı Seçiniz");

                }
            }
            
        }
        KullaniciLogin kullaniciLogin=new KullaniciLogin();
       
        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            DataTable dt = new DataTable();
            dt = kullaniciLogin.KullaniciGetir2(tbxKadi.Text);
            if (tbxAdres.Text != "" || tbxAdSoyad.Text != "" || tbxKadi.Text != "" || tbxSifre.Text != "" || cmbCinsiyet.Text != "" || maskTelefon.Text != "" ||datedgm.Value!=DateTime.Today) 
            {
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Kayıtlı Hasta");
                    temizle();
                    veriGeitir();
                }
                else
                {
                    bool hata = kullaniciLogin.KullaniciEkle(tbxAdSoyad.Text, cmbCinsiyet.Text, datedgm.Text, maskTelefon.Text, tbxAdres.Text, tbxKadi.Text, tbxSifre.Text);
                    if (hata == false)
                    {
                        MessageBox.Show("Hasta Ekleme İşlemi Başarılı");
                        temizle();
                        veriGeitir();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }
            

        }
        DialogResult d=new DialogResult();
        private void btnSil_Click(object sender, EventArgs e)
        {
            d = MessageBox.Show("Silme İşlemine Devam Etmek İstediğinize Eminmisisz işlem Gerçekleşirse Hastaya ait Farklı veriler Silinecektir"
                , "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            int id = int.Parse(lblid.Text);
            if (d==DialogResult.Yes)
            {
                if (id > 0)
                {
                    hasta.HastaSil(int.Parse(lblid.Text));
                    MessageBox.Show("Silme İşlemi Tamamlandı");
                    veriGeitir();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Silinecek Kaydı Seçiniz");
                }
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi", "İptal Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ptbDoktorlar_Click(object sender, EventArgs e)
        {
         
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataGridView.DataSource = hasta.HastaAra(guna2TextBox1.Text);
        }
    }
}
