using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebQuiz_Kütüphane
{
    public partial class Kiralanan : System.Web.UI.Page
    {
        DateTime bugun, bitis;
        KiralananKitap kira = new KiralananKitap();
        protected void Page_Load(object sender, EventArgs e)
        {


            TextBoxAlisTarih.Text = DateTime.Now.ToShortDateString();
            bugun = Convert.ToDateTime(TextBoxAlisTarih.Text);
            bitis = bugun.AddMonths(1);
            TextBoxİadeTarih.Text = bitis.ToShortDateString();
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["ID"]);
                using (Kutuphane db = new Kutuphane())
                {
                    var result = db.Kitap.Find(id);
                    TextBoxKitapadi.Text = result.KitapAdi;
                    TextBoxKitapKonu.Text = result.KitapKonu;
                    TextBoxKitapSayfa.Text = result.KitapSayfa;
                    TextBoxKitapNO.Text = result.KitapID.ToString();


                }

            }


        }

        protected void BtnKirala_Click(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    int id = int.Parse(Request.QueryString["ID"]);
                using (Kutuphane db = new Kutuphane())
                {
                //var result = db.Kitap.Find(id);
                kira.KitapID = int.Parse(TextBoxKitapNO.Text);
                kira.KullaniciID = int.Parse(TextBoxkullanicino.Text);
                kira.KitapAdi = TextBoxKitapadi.Text;
                    kira.KitapKonu = TextBoxKitapKonu.Text;
                    kira.KitapKonu = TextBoxKitapSayfa.Text;
                    kira.KullaniciAdi = TextBoxKullanıcıAd.Text;
                    kira.AlisTarihi = Convert.ToDateTime(TextBoxAlisTarih.Text);
                    kira.IadeTarihi = Convert.ToDateTime(TextBoxİadeTarih.Text);
                    db.KiralananKitap.Add(kira);
                    db.SaveChanges();
                    Response.Redirect("Web_Kitap.aspx");

                }
            }
        }
    }
//}

      
       
    
