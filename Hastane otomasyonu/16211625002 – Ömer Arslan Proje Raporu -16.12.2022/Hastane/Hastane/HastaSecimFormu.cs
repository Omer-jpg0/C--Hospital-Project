using Hastane.VeriBaglanti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class HastaSecimFormu : Form
    {
        public HastaSecimFormu()
        {
            InitializeComponent();
        }
        HastaIslem hastaislem=new HastaIslem();
        TeshisIslem test = new TeshisIslem();
        SecimIslem s = new SecimIslem();
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            veriGetir();
        }
        string id = Giris.DoktorID;
       
        private void veriGetir()
        {
          




        }

        private void HastaSecimFormu_Load(object sender, EventArgs e)
        {
            cmbDoktorAd.DataSource=s.DoktorAdKodGetir();
            cmbDoktorAd.DisplayMember = "DoktorAdSoyad";
           
            cmbTestAd.DataSource = s.TestAdKodGetir();
            cmbTestAd.DisplayMember = "TestAdı";
            lblHastaID.Text = Giris.hID;
           
        }
       
        private void DataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
    
        }

        private void parcala()
        {
           
        }

        Teshisler t = new Teshisler();
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Hide();
        }

        private void DataGridView_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            parcala2();
        }

        private void parcala2()
        {
            throw new NotImplementedException();
        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int hastaid = int.Parse(lblHastaID.Text);
            
          
             if (hastaid > 0)
             {
              bool hataolustumu = s.TeshisEkle(DateTestTarihi.Value.ToString("yyyy-MM-dd"), int.Parse(lblHastaID.Text), int.Parse(cmbTestID.Text), guna2ComboBox1.Text, int.Parse(cmbDoktorKod.Text));
              MessageBox.Show("Teşhis Eklendi");
             }
            
            else
            {
                MessageBox.Show("Lütfen Seçim Yapınız");

            }

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            guna2ComboBox1.DataSource = s.TestFiyatiGetir(cmbTestAd.Text);
            guna2ComboBox1.DisplayMember = "TestMaliyeti";
            cmbDoktorKod.DataSource = s.DoktorKodGetir(cmbDoktorAd.Text);
            cmbDoktorKod.DisplayMember = "DoktorKod";
            cmbTestID.DataSource = s.TestKodGetir(cmbTestAd.Text);
            cmbTestID.DisplayMember = "TestKodu";

        }

        private void ptbHastalar_Click(object sender, EventArgs e)
        {
            Hastalar h = new Hastalar();
            h.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
