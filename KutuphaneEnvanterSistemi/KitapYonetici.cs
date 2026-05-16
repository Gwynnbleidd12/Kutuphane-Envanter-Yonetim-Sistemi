using System;
using System.Collections.Generic;
using System.IO; 

namespace KutuphaneEnvanterSistemi
{
    
    public struct Kitap
    {
        public string Ad;
        public string Yazar;
        public string Yayinevi;
        public int YayinYili;
        public int Stok;
    }

    
    public class KitapDugumu
    {
        public Kitap Veri;
        public KitapDugumu Sonraki;

        public KitapDugumu(Kitap kitap)
        {
            Veri = kitap;
            Sonraki = null;
        }
    }

   
    public class KitapYonetici
    {
       
        private KitapDugumu kitapListesiBaslangic = null;

       
        private string dosyaYolu = "kitaplar.txt";

        public KitapDugumu Baslangic
        {
            get { return kitapListesiBaslangic; }
        }

       
        public void KitapEkle(Kitap yeniKitap)
        {
            KitapDugumu yeniDugum = new KitapDugumu(yeniKitap);

            if (kitapListesiBaslangic == null)
            {
                kitapListesiBaslangic = yeniDugum;
            }
            else
            {
                yeniDugum.Sonraki = kitapListesiBaslangic;
                kitapListesiBaslangic = yeniDugum;
            }
        }

       
       
        public void VerileriKaydet()
        {
            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                KitapDugumu gecici = kitapListesiBaslangic;
                while (gecici != null)
                {
                    
                    sw.WriteLine($"{gecici.Veri.Ad}|{gecici.Veri.Yazar}|{gecici.Veri.Yayinevi}|{gecici.Veri.YayinYili}|{gecici.Veri.Stok}");
                    gecici = gecici.Sonraki;
                }
            }
        }

        
        public void VerileriYukle()
        {
            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);

                
                for (int i = satirlar.Length - 1; i >= 0; i--)
                {
                    string[] parcalar = satirlar[i].Split('|'); 

                    if (parcalar.Length == 5)
                    {
                        Kitap k = new Kitap();
                        k.Ad = parcalar[0];
                        k.Yazar = parcalar[1];
                        k.Yayinevi = parcalar[2];
                        k.YayinYili = Convert.ToInt32(parcalar[3]);
                        k.Stok = Convert.ToInt32(parcalar[4]);

                        KitapEkle(k);
                    }
                }
            }
        }
       
        public KitapDugumu KitapAra(string arananAd)
        {
            KitapDugumu gecici = kitapListesiBaslangic;
            while (gecici != null)
            {
                
                if (gecici.Veri.Ad.ToLower() == arananAd.ToLower())
                {
                    return gecici; 
                }
                gecici = gecici.Sonraki;
            }
            return null; 
        }

        
        public bool KitapSil(string silinecekAd)
        {
            if (kitapListesiBaslangic == null) return false;

           
            if (kitapListesiBaslangic.Veri.Ad.ToLower() == silinecekAd.ToLower())
            {
                kitapListesiBaslangic = kitapListesiBaslangic.Sonraki; 
                return true;
            }

            
            KitapDugumu gecici = kitapListesiBaslangic;
            while (gecici.Sonraki != null)
            {
                if (gecici.Sonraki.Veri.Ad.ToLower() == silinecekAd.ToLower())
                {
                    gecici.Sonraki = gecici.Sonraki.Sonraki; 
                    return true;
                }
                gecici = gecici.Sonraki;
            }
            return false;
        }

        
        public string OduncAl(string kitapAd)
        {
            KitapDugumu dugum = KitapAra(kitapAd); 
            if (dugum != null)
            {
                if (dugum.Veri.Stok > 0)
                {
                    
                    Kitap guncelKitap = dugum.Veri;
                    guncelKitap.Stok--;
                    dugum.Veri = guncelKitap;

                    return "Başarılı: Kitap ödünç alındı. Kalan Stok: " + dugum.Veri.Stok;
                }
                else
                {
                    return "Hata: Maalesef bu kitabın stoğu tükenmiş.";
                }
            }
            return "Hata: Sistemde böyle bir kitap bulunamadı.";
        }

       
        public string IadeEt(string kitapAd)
        {
            KitapDugumu dugum = KitapAra(kitapAd);
            if (dugum != null)
            {
                Kitap guncelKitap = dugum.Veri;
                guncelKitap.Stok++;
                dugum.Veri = guncelKitap;

                return "Başarılı: Kitap iade edildi. Yeni Stok: " + dugum.Veri.Stok;
            }
            return "Hata: Bu kitap envanterimize ait değil (Bulunamadı).";
        }
    }
}