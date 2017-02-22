using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebQuiz_Kütüphane
{
    public partial class KullaniciEkle : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.KullaniciAdi = TextBoxKullanıcıad.Text;
            kullanici.KullaniciNo =int.Parse( TextBoxKullaniciNo.Text);
            kullanici.KullaniciAdres = TextBoxAdres.Text;
            kullanici.KullaniciTel = TextBoxTel.Text;
            using (Kutuphane db=new Kutuphane())
            {
                db.Kullanici.Add(kullanici);
                db.SaveChanges();
                Response.Redirect("Web_Kitap.aspx");
            }


         

        }
    }
}