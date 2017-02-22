using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebQuiz_Kütüphane
{
    public partial class KitapEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.KitapAdi = TextBoxKitapad.Text;
            kitap.KitapKonu = TextBoxKonu.Text;
            kitap.KitapSayfa = TextBoxsayfa.Text;
            using (Kutuphane db=new Kutuphane())
            {
                db.Kitap.Add(kitap);
                db.SaveChanges();
                Response.Redirect("Web_Kitap.aspx");
            }
        }
    }
}