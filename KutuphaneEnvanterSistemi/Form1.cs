using System;
using System.Windows.Forms;

namespace KutuphaneEnvanterSistemi
{
    public partial class Form1 : Form
    {
        
        private KitapYonetici yonetici = new KitapYonetici();

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
    }
}