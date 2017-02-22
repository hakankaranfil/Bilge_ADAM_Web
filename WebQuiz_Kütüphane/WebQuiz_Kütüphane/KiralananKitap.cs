using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebQuiz_Kütüphane
{
    public class KiralananKitap
    {
        public int KiralananKitapID { get; set; }
        public int KitapID { get; set; }
        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string KitapAdi { get; set; }
        public string KitapKonu { get; set; }
        public string KitapSayfa { get; set; }
        
        public DateTime AlisTarihi { get; set; }

        public DateTime IadeTarihi { get; set; }

        public Kullanici kullanici { get; set; }
        public Kitap Kitap { get; set; }

    }
}