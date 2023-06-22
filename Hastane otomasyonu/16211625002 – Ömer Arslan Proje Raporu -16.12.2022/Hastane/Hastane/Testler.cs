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
    public partial class Testler : Form
    {
        DialogResult Kontrol = new DialogResult();
        public Testler()
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

        private void ptbHastalar_Click(object sender, EventArgs e)
        {
            Hastalar h1 = new Hastalar();
            h1.Show();
            this.Hide();
        }

        private void ptbDoktorlar_Click(object sender, EventArgs e)
        {
            Doktorlar d1 = new Doktorlar();
            d1.Show();
            this.Hide();
        }

        private void ptbSonuçlar_Click(object sender, EventArgs e)
        {
            Teshisler teshis = new Teshisler();
            teshis.Show();
            this.Hide();
        }
        TestIslem test = new TestIslem();
        void veriGetir()
        {
            DataTable dt=new DataTable();
            dt = test.TestListesi();
            DataGridView1.DataSource = dt;
        }
        private void Testler_Load(object sender, EventArgs e)
        {
            veriGetir();
        }
        void temizle()
        {
            tbxTestAdi.Clear();
            tbxTestFiyati.Clear();
            lblTestID.Text = "-1";
        }
        private void btnTestEkle_Click(object sender, EventArgs e)
        {
            DataTable dt=new DataTable();
            dt = test.TestKontrol(tbxTestAdi.Text);
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("Aynı isimde İki Test Eklenemez");
            }
            else
            {
                if (tbxTestAdi.Text!=""&&tbxTestFiyati.Text!="")
                {
                    bool hata = test.TestEkle(tbxTestAdi.Text,(tbxTestFiyati.Text));
                    MessageBox.Show("TestEklendi");
                    veriGetir();
                    temizle();
                    
                }
                else
                {
                    MessageBox.Show("Lütfen Tum Alanları Doldurunuz");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            veriGetir();
        }
        void parcala()
        {
            lblTestID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxTestAdi.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxTestFiyati.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();

        }
        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            parcala();
        }

        private void btnTestGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblTestID.Text);
            if (id>0)
            {
                bool hata = test.TestGuncelle(int.Parse(lblTestID.Text),tbxTestAdi.Text,(tbxTestFiyati.Text));
                MessageBox.Show("Güncelleme Başarılı");
                veriGetir();
                temizle();
            }
            else
            {
                MessageBox.Show("Güncellenecek Kaydı Seçiniz");
            }
        }

        private void btnTestsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblTestID.Text);
            if (id>0)
            {
                test.TestSil(int.Parse(lblTestID.Text));
                MessageBox.Show("Silme Başarılı");
                veriGetir();
                temizle();
            }
            else
            {
                MessageBox.Show("Silinecek Kaydı Seçiniz");
            }
        }

      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            DataGridView1.DataSource = test.TestAra(guna2TextBox1.Text);
        }
    }
}
