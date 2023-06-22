using Guna.UI2.WinForms;
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
    public partial class Hastalar : Form
    {
        DialogResult Kontrol = new DialogResult();
        HastaIslem hastaislem = new HastaIslem();
        public Hastalar()
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

        private void ptbTestler_Click(object sender, EventArgs e)
        {
            Testler Test = new Testler();   
            Test.Show();
            this.Hide();
        }

        private void ptbSonuçlar_Click(object sender, EventArgs e)
        {
            Teshisler teshis = new Teshisler();
            teshis.Show();
            this.Hide();
        }
    
        private void Hastalar_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt=hastaislem.hastaGetir(int.Parse(Giris.hID));
            lblHastaID.Text = Giris.hID;
            tbxAd.Text = dt.Rows[0][0].ToString();
            tbxCinsiyet.Text = dt.Rows[0][1].ToString();
            tbxDogum.Text = dt.Rows[0][2].ToString();
            maskTelefon.Text = dt.Rows[0][3].ToString();
            tbxAdres.Text = dt.Rows[0][4].ToString();

            HastaDataGridView.DataSource = hastaislem.TamaminiGetir(Giris.hID);
        }

        private void HastaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

       
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            HastaDataGridView.DataSource = hastaislem.TeshisAradk(guna2TextBox1.Text,int.Parse(this.lblHastaID.Text));
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            HastaSecimFormu h = new HastaSecimFormu();
            h.Show();
            this.Hide();
        }
    }
}
