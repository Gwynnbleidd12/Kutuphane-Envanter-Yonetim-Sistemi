using System;
using System.Collections.Generic;

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

        // İleride buraya KitapSil, KitapAra gibi fonksiyonları da ekleyerek 
        // her şeyi tek merkezden yöneteceğiz.
    }

}