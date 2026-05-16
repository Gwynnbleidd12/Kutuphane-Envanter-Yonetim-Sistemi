using System;
using System.Windows.Forms;

namespace KutuphaneEnvanterSistemi
{
    public partial class Form1 : Form
    {

        private KitapYonetici yonetici = new KitapYonetici();

        private bool girisYapildiMi = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Kitap yeniKitap = new Kitap();
                yeniKitap.Ad = txtAd.Text;
                yeniKitap.Yazar = txtYazar.Text;
                yeniKitap.Yayinevi = txtYayinevi.Text;
                yeniKitap.YayinYili = Convert.ToInt32(txtYayinYili.Text);
                yeniKitap.Stok = Convert.ToInt32(txtStok.Text);


                yonetici.KitapEkle(yeniKitap);

                MessageBox.Show("Kitabı envantere eklediniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAd.Clear();
                txtYazar.Clear();
                txtYayinevi.Clear();
                txtYayinYili.Clear();
                txtStok.Clear();
                txtAd.Focus();

                ListeyiGuncelle();

                yonetici.VerileriKaydet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alanları kontrol edip tekrar denesen iyi olur dostum.\n\nHata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListeyiGuncelle()
        {

            dgvKitaplar.Rows.Clear();

            dgvKitaplar.ColumnCount = 5;
            dgvKitaplar.Columns[0].Name = "Kitap Adı";
            dgvKitaplar.Columns[1].Name = "Yazar";
            dgvKitaplar.Columns[2].Name = "Yayınevi";
            dgvKitaplar.Columns[3].Name = "Yıl";
            dgvKitaplar.Columns[4].Name = "Stok";


            KitapDugumu gecici = yonetici.Baslangic;

            while (gecici != null)
            {
                dgvKitaplar.Rows.Add(gecici.Veri.Ad, gecici.Veri.Yazar, gecici.Veri.Yayinevi, gecici.Veri.YayinYili, gecici.Veri.Stok);
                gecici = gecici.Sonraki;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yonetici.VerileriYukle();
            ListeyiGuncelle();

            button1.Enabled = false;
            btnSil.Enabled = false;
        }


        private void btnAra_Click(object sender, EventArgs e)
        {
            // --- ÖZEL EASTER EGG ---
            if (txtIslem.Text.ToLower() == "schecter" || txtIslem.Text.ToLower() == "focusrite")
            {
                MessageBox.Show("Geliştirici Notu: Kod yazmaktan parmaklar yorulduysa, biraz gitar çalma vakti gelmiştir! \n\n- Burak",
                                "Gizli Mesaj Bulundu!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Asterisk);
                txtIslem.Clear();
                return;
            }
            

            if (string.IsNullOrWhiteSpace(txtIslem.Text))
            {
                MessageBox.Show("Öncelikle bir kitap ismi eklesen iyi olur");
                ListeyiGuncelle();
                return;
            }

            KitapDugumu bulunan = yonetici.KitapAra(txtIslem.Text);

            if (bulunan != null)
            {

                dgvKitaplar.Rows.Clear();
                dgvKitaplar.Rows.Add(bulunan.Veri.Ad, bulunan.Veri.Yazar, bulunan.Veri.Yayinevi, bulunan.Veri.YayinYili, bulunan.Veri.Stok);
            }
            else
            {
                MessageBox.Show("Envanterde senin kitabı bulamadık kingo", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIslem.Text))
            {
                MessageBox.Show("Silmek istediğin kitabın adını gir lütfen.");
                return;
            }


            bool silindiMi = yonetici.KitapSil(txtIslem.Text);

            if (silindiMi)
            {
                yonetici.VerileriKaydet();
                ListeyiGuncelle();
                MessageBox.Show("Kitabı sistemden sildin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIslem.Clear();
            }
            else
            {
                MessageBox.Show("Silinecek kitap bul.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOduncAl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOduncKitapAdi.Text)) return;


            string sonuc = yonetici.OduncAl(txtOduncKitapAdi.Text);
            MessageBox.Show(sonuc, "İşlem Sonucu");


            yonetici.VerileriKaydet();
            ListeyiGuncelle();
            txtOduncKitapAdi.Clear();
        }

        private void btnIadeEt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOduncKitapAdi.Text)) return;

            string sonuc = yonetici.IadeEt(txtOduncKitapAdi.Text);
            MessageBox.Show(sonuc, "İşlem Sonucu");

            yonetici.VerileriKaydet();
            ListeyiGuncelle();
            txtOduncKitapAdi.Clear();
        }


        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "burak" && txtSifre.Text == "1207")
            {
                girisYapildiMi = true;
                MessageBox.Show("Personel olarak giriş yaptınız. Tüm yetkiler açıldı, keyfinize bakın");

                button1.Enabled = true; 
                btnSil.Enabled = true;   
                
                txtKullaniciAdi.Enabled = false;
                txtSifre.Enabled = false;
                btnGiris.Enabled = false;
            }
            
            else if (txtKullaniciAdi.Text == "polat" && txtSifre.Text == "1122")
            {
                girisYapildiMi = true;
                MessageBox.Show("Öğrenci olarak giriş yaptınız. Kitap ödünç alabilir ya da iade edebilirsiniz.", "Kısıtlı Yetki", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                
                button1.Enabled = false;
                btnSil.Enabled = false;   

                txtKullaniciAdi.Enabled = false;
                txtSifre.Enabled = false;
                btnGiris.Enabled = false;
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre! Seni tanıyamadık kral", "Hata");
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {

            if (!girisYapildiMi && e.TabPageIndex != 0)
            {
                e.Cancel = true;
                MessageBox.Show("Giriş yapmadan burayı elleyemezsin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}