namespace Hastane
{
    partial class Testler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Testler));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbTestler = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ptbDoktorlar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TestBilgiPanel = new System.Windows.Forms.Panel();
            this.DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DoktorBilgileri = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTestID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTestsil = new Guna.UI2.WinForms.Guna2Button();
            this.btnTestGuncelle = new Guna.UI2.WinForms.Guna2Button();
            this.btnTestEkle = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTestFiyati = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxTestAdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.GirisKapatbtn = new System.Windows.Forms.PictureBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTestler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDoktorlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.TestBilgiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.DoktorBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GirisKapatbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.ptbTestler);
            this.panel1.Controls.Add(this.ptbDoktorlar);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 611);
            this.panel1.TabIndex = 10;
            // 
            // ptbTestler
            // 
            this.ptbTestler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbTestler.Image = global::Hastane.Properties.Resources.flask;
            this.ptbTestler.ImageRotate = 0F;
            this.ptbTestler.Location = new System.Drawing.Point(21, 58);
            this.ptbTestler.Name = "ptbTestler";
            this.ptbTestler.Size = new System.Drawing.Size(32, 32);
            this.ptbTestler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbTestler.TabIndex = 10;
            this.ptbTestler.TabStop = false;
            // 
            // ptbDoktorlar
            // 
            this.ptbDoktorlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbDoktorlar.Image = global::Hastane.Properties.Resources.doctor;
            this.ptbDoktorlar.ImageRotate = 0F;
            this.ptbDoktorlar.Location = new System.Drawing.Point(21, 304);
            this.ptbDoktorlar.Name = "ptbDoktorlar";
            this.ptbDoktorlar.Size = new System.Drawing.Size(32, 32);
            this.ptbDoktorlar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbDoktorlar.TabIndex = 10;
            this.ptbDoktorlar.TabStop = false;
            this.ptbDoktorlar.Click += new System.EventHandler(this.ptbDoktorlar_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox1.Image = global::Hastane.Properties.Resources.emergency_exit;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(21, 567);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(32, 32);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // TestBilgiPanel
            // 
            this.TestBilgiPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TestBilgiPanel.Controls.Add(this.DataGridView1);
            this.TestBilgiPanel.Controls.Add(this.DoktorBilgileri);
            this.TestBilgiPanel.Location = new System.Drawing.Point(151, 57);
            this.TestBilgiPanel.Name = "TestBilgiPanel";
            this.TestBilgiPanel.Size = new System.Drawing.Size(903, 552);
            this.TestBilgiPanel.TabIndex = 13;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight = 22;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.Location = new System.Drawing.Point(0, 215);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.Size = new System.Drawing.Size(900, 337);
            this.DataGridView1.TabIndex = 1;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.Gray;
            this.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView1.ThemeStyle.HeaderStyle.Height = 22;
            this.DataGridView1.ThemeStyle.ReadOnly = true;
            this.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Silver;
            this.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseDoubleClick);
            // 
            // DoktorBilgileri
            // 
            this.DoktorBilgileri.BackColor = System.Drawing.Color.White;
            this.DoktorBilgileri.Controls.Add(this.label2);
            this.DoktorBilgileri.Controls.Add(this.guna2TextBox1);
            this.DoktorBilgileri.Controls.Add(this.label3);
            this.DoktorBilgileri.Controls.Add(this.lblTestID);
            this.DoktorBilgileri.Controls.Add(this.label1);
            this.DoktorBilgileri.Controls.Add(this.btnTestsil);
            this.DoktorBilgileri.Controls.Add(this.btnTestGuncelle);
            this.DoktorBilgileri.Controls.Add(this.btnTestEkle);
            this.DoktorBilgileri.Controls.Add(this.label8);
            this.DoktorBilgileri.Controls.Add(this.label6);
            this.DoktorBilgileri.Controls.Add(this.label5);
            this.DoktorBilgileri.Controls.Add(this.tbxTestFiyati);
            this.DoktorBilgileri.Controls.Add(this.tbxTestAdi);
            this.DoktorBilgileri.Location = new System.Drawing.Point(0, 0);
            this.DoktorBilgileri.Name = "DoktorBilgileri";
            this.DoktorBilgileri.Size = new System.Drawing.Size(903, 209);
            this.DoktorBilgileri.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(471, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ara";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.guna2TextBox1.BackColor = System.Drawing.Color.White;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(370, 171);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(244, 32);
            this.guna2TextBox1.TabIndex = 16;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(792, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Test Listesi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTestID
            // 
            this.lblTestID.AutoSize = true;
            this.lblTestID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTestID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTestID.Location = new System.Drawing.Point(83, 5);
            this.lblTestID.Name = "lblTestID";
            this.lblTestID.Size = new System.Drawing.Size(21, 18);
            this.lblTestID.TabIndex = 14;
            this.lblTestID.Text = "-1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Test ID : ";
            // 
            // btnTestsil
            // 
            this.btnTestsil.BorderRadius = 6;
            this.btnTestsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestsil.FillColor = System.Drawing.Color.DarkRed;
            this.btnTestsil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTestsil.ForeColor = System.Drawing.Color.White;
            this.btnTestsil.Location = new System.Drawing.Point(682, 57);
            this.btnTestsil.Name = "btnTestsil";
            this.btnTestsil.Size = new System.Drawing.Size(128, 45);
            this.btnTestsil.TabIndex = 12;
            this.btnTestsil.Text = "Sil";
            this.btnTestsil.Click += new System.EventHandler(this.btnTestsil_Click);
            // 
            // btnTestGuncelle
            // 
            this.btnTestGuncelle.BorderRadius = 6;
            this.btnTestGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestGuncelle.FillColor = System.Drawing.Color.Indigo;
            this.btnTestGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTestGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnTestGuncelle.Location = new System.Drawing.Point(514, 57);
            this.btnTestGuncelle.Name = "btnTestGuncelle";
            this.btnTestGuncelle.Size = new System.Drawing.Size(128, 45);
            this.btnTestGuncelle.TabIndex = 11;
            this.btnTestGuncelle.Text = "Güncelle";
            this.btnTestGuncelle.Click += new System.EventHandler(this.btnTestGuncelle_Click);
            // 
            // btnTestEkle
            // 
            this.btnTestEkle.BorderRadius = 6;
            this.btnTestEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestEkle.FillColor = System.Drawing.Color.ForestGreen;
            this.btnTestEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTestEkle.ForeColor = System.Drawing.Color.White;
            this.btnTestEkle.Location = new System.Drawing.Point(343, 57);
            this.btnTestEkle.Name = "btnTestEkle";
            this.btnTestEkle.Size = new System.Drawing.Size(128, 45);
            this.btnTestEkle.TabIndex = 10;
            this.btnTestEkle.Text = "Ekle";
            this.btnTestEkle.Click += new System.EventHandler(this.btnTestEkle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(163, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Test Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(163, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Test Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(365, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Testleri Yönet";
            // 
            // tbxTestFiyati
            // 
            this.tbxTestFiyati.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxTestFiyati.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbxTestFiyati.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxTestFiyati.DefaultText = "";
            this.tbxTestFiyati.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxTestFiyati.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxTestFiyati.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxTestFiyati.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxTestFiyati.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbxTestFiyati.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxTestFiyati.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTestFiyati.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxTestFiyati.Location = new System.Drawing.Point(105, 135);
            this.tbxTestFiyati.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxTestFiyati.Name = "tbxTestFiyati";
            this.tbxTestFiyati.PasswordChar = '\0';
            this.tbxTestFiyati.PlaceholderText = "";
            this.tbxTestFiyati.SelectedText = "";
            this.tbxTestFiyati.Size = new System.Drawing.Size(189, 32);
            this.tbxTestFiyati.TabIndex = 6;
            // 
            // tbxTestAdi
            // 
            this.tbxTestAdi.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.tbxTestAdi.BackColor = System.Drawing.Color.White;
            this.tbxTestAdi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbxTestAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxTestAdi.DefaultText = "";
            this.tbxTestAdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxTestAdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxTestAdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxTestAdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxTestAdi.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbxTestAdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxTestAdi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTestAdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxTestAdi.Location = new System.Drawing.Point(105, 70);
            this.tbxTestAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxTestAdi.Name = "tbxTestAdi";
            this.tbxTestAdi.PasswordChar = '\0';
            this.tbxTestAdi.PlaceholderText = "";
            this.tbxTestAdi.SelectedText = "";
            this.tbxTestAdi.Size = new System.Drawing.Size(189, 32);
            this.tbxTestAdi.TabIndex = 5;
            // 
            // GirisKapatbtn
            // 
            this.GirisKapatbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GirisKapatbtn.Image = global::Hastane.Properties.Resources.power;
            this.GirisKapatbtn.Location = new System.Drawing.Point(1012, -1);
            this.GirisKapatbtn.Name = "GirisKapatbtn";
            this.GirisKapatbtn.Size = new System.Drawing.Size(46, 40);
            this.GirisKapatbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GirisKapatbtn.TabIndex = 11;
            this.GirisKapatbtn.TabStop = false;
            this.GirisKapatbtn.Click += new System.EventHandler(this.GirisKapatbtn_Click);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Testler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 609);
            this.ControlBox = false;
            this.Controls.Add(this.TestBilgiPanel);
            this.Controls.Add(this.GirisKapatbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Testler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testler";
            this.Load += new System.EventHandler(this.Testler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTestler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDoktorlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.TestBilgiPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.DoktorBilgileri.ResumeLayout(false);
            this.DoktorBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GirisKapatbtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox ptbTestler;
        private Guna.UI2.WinForms.Guna2PictureBox ptbDoktorlar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel TestBilgiPanel;
        private System.Windows.Forms.Panel DoktorBilgileri;
        private Guna.UI2.WinForms.Guna2Button btnTestsil;
        private Guna.UI2.WinForms.Guna2Button btnTestGuncelle;
        private Guna.UI2.WinForms.Guna2Button btnTestEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox tbxTestFiyati;
        private Guna.UI2.WinForms.Guna2TextBox tbxTestAdi;
        private System.Windows.Forms.PictureBox GirisKapatbtn;
        private System.Windows.Forms.Label lblTestID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}