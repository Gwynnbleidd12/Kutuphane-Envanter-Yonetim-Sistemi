namespace KutuphaneEnvanterSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label9 = new Label();
            label8 = new Label();
            btnGiris = new Button();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            tabPage2 = new TabPage();
            btnSil = new Button();
            btnAra = new Button();
            txtIslem = new TextBox();
            dgvKitaplar = new DataGridView();
            button1 = new Button();
            label6 = new Label();
            txtStok = new TextBox();
            txtYayinYili = new TextBox();
            txtYayinevi = new TextBox();
            txtYazar = new TextBox();
            txtAd = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            label7 = new Label();
            btnIadeEt = new Button();
            btnOduncAl = new Button();
            txtOduncKitapAdi = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-7, -4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(814, 456);
            tabControl1.TabIndex = 0;
            tabControl1.Selecting += tabControl1_Selecting;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(btnGiris);
            tabPage1.Controls.Add(txtSifre);
            tabPage1.Controls.Add(txtKullaniciAdi);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(806, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kullanici Girisi";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(107, 130);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 4;
            label9.Text = "Sifre : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 74);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 3;
            label8.Text = "Kullanici Adi :";
            label8.Click += label8_Click;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(199, 200);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(120, 29);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giris Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(199, 127);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(120, 27);
            txtSifre.TabIndex = 1;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(199, 71);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(120, 27);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnSil);
            tabPage2.Controls.Add(btnAra);
            tabPage2.Controls.Add(txtIslem);
            tabPage2.Controls.Add(dgvKitaplar);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtStok);
            tabPage2.Controls.Add(txtYayinYili);
            tabPage2.Controls.Add(txtYayinevi);
            tabPage2.Controls.Add(txtYazar);
            tabPage2.Controls.Add(txtAd);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(806, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kitap Yonetimi";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(579, 350);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 15;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(579, 298);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(94, 29);
            btnAra.TabIndex = 14;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // txtIslem
            // 
            txtIslem.Location = new Point(401, 323);
            txtIslem.Name = "txtIslem";
            txtIslem.Size = new Size(125, 27);
            txtIslem.TabIndex = 13;
            // 
            // dgvKitaplar
            // 
            dgvKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplar.Location = new Point(333, 14);
            dgvKitaplar.Name = "dgvKitaplar";
            dgvKitaplar.RowHeadersWidth = 51;
            dgvKitaplar.Size = new Size(441, 255);
            dgvKitaplar.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(62, 261);
            button1.Name = "button1";
            button1.Size = new Size(134, 29);
            button1.TabIndex = 11;
            button1.Text = "Kitap Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 14);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 10;
            label6.Text = "1- KITAP BILGILERI";
            // 
            // txtStok
            // 
            txtStok.Location = new Point(147, 200);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(125, 27);
            txtStok.TabIndex = 9;
            // 
            // txtYayinYili
            // 
            txtYayinYili.Location = new Point(147, 166);
            txtYayinYili.Name = "txtYayinYili";
            txtYayinYili.Size = new Size(125, 27);
            txtYayinYili.TabIndex = 8;
            // 
            // txtYayinevi
            // 
            txtYayinevi.Location = new Point(147, 129);
            txtYayinevi.Name = "txtYayinevi";
            txtYayinevi.Size = new Size(125, 27);
            txtYayinevi.TabIndex = 7;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(147, 84);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(125, 27);
            txtYazar.TabIndex = 6;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(147, 51);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 200);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 4;
            label5.Text = "Stok :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 166);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 3;
            label4.Text = "Yayin Yili: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 129);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Yayinevi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 91);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Yazar :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 51);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad : ";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(btnIadeEt);
            tabPage3.Controls.Add(btnOduncAl);
            tabPage3.Controls.Add(txtOduncKitapAdi);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(806, 423);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Odunc ve Iade Islemleri";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 69);
            label7.Name = "label7";
            label7.Size = new Size(220, 20);
            label7.TabIndex = 3;
            label7.Text = "Islem Yapacaganiz Kitabin Ismi: ";
            // 
            // btnIadeEt
            // 
            btnIadeEt.Location = new Point(573, 64);
            btnIadeEt.Name = "btnIadeEt";
            btnIadeEt.Size = new Size(94, 29);
            btnIadeEt.TabIndex = 2;
            btnIadeEt.Text = "Iade Et";
            btnIadeEt.UseVisualStyleBackColor = true;
            btnIadeEt.Click += btnIadeEt_Click;
            // 
            // btnOduncAl
            // 
            btnOduncAl.Location = new Point(459, 64);
            btnOduncAl.Name = "btnOduncAl";
            btnOduncAl.Size = new Size(94, 29);
            btnOduncAl.TabIndex = 1;
            btnOduncAl.Text = "Odunc Al";
            btnOduncAl.UseVisualStyleBackColor = true;
            btnOduncAl.Click += btnOduncAl_Click;
            // 
            // txtOduncKitapAdi
            // 
            txtOduncKitapAdi.Location = new Point(278, 66);
            txtOduncKitapAdi.Name = "txtOduncKitapAdi";
            txtOduncKitapAdi.Size = new Size(113, 27);
            txtOduncKitapAdi.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplar).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button1;
        private Label label6;
        private TextBox txtStok;
        private TextBox txtYayinYili;
        private TextBox txtYayinevi;
        private TextBox txtYazar;
        private TextBox txtAd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvKitaplar;
        private Button btnSil;
        private Button btnAra;
        private TextBox txtIslem;
        private Button btnIadeEt;
        private Button btnOduncAl;
        private TextBox txtOduncKitapAdi;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label7;
        private Button btnGiris;
        private Label label9;
        private Label label8;
    }
}
