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

                MessageBox.Show("Kitap başarıyla envantere eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Lütfen alanları kontrol edin.\n\nHata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }


        private void btnAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIslem.Text))
            {
                MessageBox.Show("Lütfen aramak istediğiniz kitabın adını girin.");
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
                MessageBox.Show("Kitap envanterde bulunamadı!", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIslem.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz kitabın adını girin.");
                return;
            }

            
            bool silindiMi = yonetici.KitapSil(txtIslem.Text);

            if (silindiMi)
            {
                yonetici.VerileriKaydet(); 
                ListeyiGuncelle();         
                MessageBox.Show("Kitap sistemden başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIslem.Clear();
            }
            else
            {
                MessageBox.Show("Silinecek kitap bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Sisteme başarıyla giriş yapıldı! Sekmeleri kullanabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                txtKullaniciAdi.Enabled = false;
                txtSifre.Enabled = false;
                btnGiris.Enabled = false;
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            
            if (!girisYapildiMi && e.TabPageIndex != 0)
            {
                e.Cancel = true; 
                MessageBox.Show("Sistemi kullanabilmek için önce giriş yapmalısınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}