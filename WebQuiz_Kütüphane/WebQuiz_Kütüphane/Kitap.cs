using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebQuiz_Kütüphane
{
    public class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string KitapKonu{ get; set; }
        public bool Durum { get; set; }

        public string KitapSayfa { get; set; }
        public Kullanici KullaniciID { get; set; }

    }
}