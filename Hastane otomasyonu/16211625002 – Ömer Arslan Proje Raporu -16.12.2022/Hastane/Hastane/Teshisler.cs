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

    public partial class Teshisler : Form
    {
        DialogResult Kontrol = new DialogResult();
        public Teshisler()
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


        private void ptbDoktorlar_Click(object sender, EventArgs e)
        {

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

        private void ptbTestler_Click(object sender, EventArgs e)
        {
            Testler Test = new Testler();
            Test.Show();
            this.Hide();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Doktorlar d1 = new Doktorlar();
            d1.Show();
            this.Hide();
        }

        private void Teshisler_Load(object sender, EventArgs e)
        {
            cmbTest.DataSource = t.TestAdGetir();
            cmbTest.DisplayMember = "TestAdı";
            cmbTest.ValueMember = "TestAdı";
            veriGetir();
        }
        void temizle()
        {
            lblDoktorID.Text = "-1";
            lblHastaID.Text = "-1";
            lblTeshisID.Text = "-1";
            tbHastaAd.Clear();
            tbxSonuc.Text = "Bekliyor";
            tbxSonuc.ReadOnly = true;
            tbxTestFiyat.Clear();
            datetestTarih.Value= DateTime.Now;
            cmbTest.SelectedIndex = 0;

        }
        public static string id;

        TeshisIslem t = new TeshisIslem();
        private void veriGetir()
        {

            TestlerDataGridView1.DataSource = t.DoktaraGoreTeshisGetir(int.Parse(Giris.dID));
        }
        private void btnHastaSec_Click(object sender, EventArgs e)
        {
            HastaSecimFormu h = new HastaSecimFormu();
            h.ShowDialog();
        }

        private void DoktorBilgileri_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void TestlerDataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Parcala();
        }

        private void Parcala()
        {
            tbxSonuc.ReadOnly = false;
            lblDoktorID.Text = TestlerDataGridView1.CurrentRow.Cells[0].Value.ToString();
            lblHastaID.Text = TestlerDataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblTeshisID.Text = TestlerDataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbHastaAd.Text = TestlerDataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbTest.Text = TestlerDataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbxSonuc.Text = TestlerDataGridView1.CurrentRow.Cells[6].Value.ToString();
            datetestTarih.Text= TestlerDataGridView1.CurrentRow.Cells[7].Value.ToString();
            tbxTestFiyat.Text= TestlerDataGridView1.CurrentRow.Cells[8].Value.ToString();


        }

        private void btnTestGuncelle_Click(object sender, EventArgs e)
        {
            int hID = int.Parse(lblHastaID.Text); 
            int dID = int.Parse(lblDoktorID.Text);
            int tID = int.Parse(lblTeshisID.Text);

            if (hID>0&& dID>0&& tID>0)
            {
               
                bool hata = t.DoktaraGoreTeshisGuncelle(int.Parse(lblDoktorID.Text), int.Parse(lblHastaID.Text), int.Parse(lblTeshisID.Text),tbxSonuc.Text);
                veriGetir();
                temizle();
                
                MessageBox.Show("Teşis Güncelleme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Teşis Güncelleme İşlemi Hatalı");

            }


        }

        private void Teshisler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                temizle();
            }
        }

        private void btnTestsil_Click(object sender, EventArgs e)
        {

        }
    }
    
}
