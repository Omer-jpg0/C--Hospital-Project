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
    public partial class Form1 : Form
    {
        DoktoIslem dislem = new DoktoIslem();
        public Form1()
        {
            InitializeComponent();
        }

       
        AdminIslem aislem=new AdminIslem();
       

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        void temizle()
        {
            lblid.Text = "-1";
            tbxAdSoyad.Clear();
            tbxBrans.Clear();
            tbxEposta.Clear();
            tbxKadi.Clear();
            tbxSifre.Clear();
            maskTelefon.Clear();
            datedgm.Value = DateTime.Now;
        }
        void veriGetir()
        {
            DataTable dt = new DataTable();
            dt = dislem.DoktorListesi();
            guna2DataGridView1.DataSource = dt;
        }
        void parcala()
        {
            lblid.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxAdSoyad.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxBrans.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            datedgm.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxEposta.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            maskTelefon.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbxKadi.Text = guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbxSifre.Text = guna2DataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            veriGetir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dislem.DoktorKontrol(tbxKadi.Text);
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("Kayıtlı Doktor");
                temizle();
            }
            else
            {
                if (tbxAdSoyad.Text!=""||tbxBrans.Text!=""||tbxEposta.Text!=""||tbxKadi.Text!=""||tbxSifre.Text!=""||datedgm.Value!=DateTime.Now)
                {
                    bool hata = dislem.DoktorEkle(tbxAdSoyad.Text,tbxBrans.Text,datedgm.Value.ToString("yyyy-MM-dd"),tbxEposta.Text,maskTelefon.Text,tbxKadi.Text,tbxSifre.Text);
                    MessageBox.Show("Doktor Başarıyla Eklendi");
                    temizle();
                    veriGetir();
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");

                }
            }
        }

        private void guna2DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            parcala();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblid.Text);
            if (id>0)
            {
                if (tbxAdSoyad.Text != "" || tbxBrans.Text != "" || tbxEposta.Text != "" || tbxKadi.Text != "" || tbxSifre.Text != "" || datedgm.Value != DateTime.Now)
                {
                    bool hata = dislem.DoktorGuncelle(int.Parse(lblid.Text), tbxAdSoyad.Text, tbxBrans.Text, datedgm.Value.ToString("yyyy-MM-dd"), tbxEposta.Text, maskTelefon.Text, tbxKadi.Text, tbxSifre.Text);
                    MessageBox.Show("Doktor Başarıyla Güncellendi");
                    temizle();
                    veriGetir();
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");

                }
            }
            else
            {
                MessageBox.Show("Lütfen Güncellenecek Kaydı Seçiniz");

            }
        }
        DialogResult d = new DialogResult();
        private void btnSil_Click(object sender, EventArgs e)
        {
           d= MessageBox.Show("Silme İşlemine Devam Etmek İstediğinize Eminmisisz işlem Gerçekleşirse Doktora ait Farklı veriler Silinecektir"
                ,"Silme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            int id = int.Parse(lblid.Text);
            if (d == DialogResult.Yes)
            {
                if (id > 0)
                {
                    dislem.DoktorSil(int.Parse(lblid.Text));
                    veriGetir();
                    temizle();
                    MessageBox.Show("Kayıt Başarılı bir Şekilde Silindi");
                }
                else
                {
                    MessageBox.Show("Lütfen Silinecek Kaydı Seçiniz");

                }
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi","İptal Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = dislem.DoktorAra(guna2TextBox1.Text);
        }
    }
}
