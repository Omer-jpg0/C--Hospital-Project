using Hastane.VeriBaglanti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Hastane
{
    public partial class Giris : Form
    {
        DialogResult Kontrol = new DialogResult();
        KullaniciLogin kullaniciLogin = new KullaniciLogin();
        AdminIslem a = new AdminIslem();
        HastaSecimFormu h2 = new HastaSecimFormu();
        public Giris()
        {
            InitializeComponent();
        }
        public static string ID;
        public static string DoktorID;

        private void label5_Click(object sender, EventArgs e)
        {
            KayitOl g1=new KayitOl();
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
        Hastalar h = new Hastalar();
        Doktorlar d=new Doktorlar();
        public static string hID;
        public static string dID;

        private void btnGiris_Click(object sender, EventArgs e)
        {

           
            if (guna2ToggleSwitch1.Checked==true)
            {

                if (tbxKullaniciAdi.Text == "" || tbxSifre.Text == "")
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun");

                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = a.AdminGetir(tbxKullaniciAdi.Text, tbxSifre.Text);
                    if (dt.Rows.Count > 0)
                    {
                        DoktorID = dt.Rows[0][0].ToString();
                        Form1 admin = new Form1();
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Admin Bulunamadı.");
                    }
                }
            }
            else
            {
                if (Doktorum.Checked == false)
                {
                    if (tbxKullaniciAdi.Text == "" || tbxSifre.Text == "")
                    {
                        MessageBox.Show("Lütfen Tüm Alanları Doldurun");

                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt = kullaniciLogin.KullaniciGetir(tbxKullaniciAdi.Text, tbxSifre.Text);
                        if (dt.Rows.Count > 0)
                        {
                            hID = dt.Rows[0][0].ToString();
                         
                            Hastalar HastaForm = new Hastalar();
                            HastaForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Hasta Bulunamadı.");
                        }
                    }
                }
                else
                {
                    if (tbxKullaniciAdi.Text == "" || tbxSifre.Text == "")
                    {
                        MessageBox.Show("Lütfen Tüm Alanları Doldurun");

                    }
                    else
                    {
                        DataTable dt = new DataTable();
                        dt = kullaniciLogin.DoktorGetir(tbxKullaniciAdi.Text, tbxSifre.Text);
                        if (dt.Rows.Count > 0)
                        {
                            dID= dt.Rows[0][0].ToString();
                            Doktorlar DoktorForm = new Doktorlar();
                            DoktorForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Doktor Bulunamadı.");
                        }
                    }
                }
            }
            
           
           
        }
      
        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked == true)
            {
                Doktorum.Checked = false;
                this.BackColor = Color.Gray;
            }
            else
            {
                this.BackColor = Color.White;

            }

        }

        private void Doktorum_CheckedChanged(object sender, EventArgs e)
        {
            if (Doktorum.Checked == true)
            {
                guna2ToggleSwitch1.Checked = false;
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
