using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebQuiz_Kütüphane
{
  
public partial class Web_Kitap : System.Web.UI.Page
    {
        
protected void Page_Load(object sender, EventArgs e)
        {
            using (Kutuphane db=new Kutuphane())
            {
                Repeater1.DataSource = db.Kitap.ToList();
                Repeater1.DataBind();
                if (Request.QueryString["ID"] != null)
                {
                    int id = int.Parse(Request.QueryString["ID"]);


                    var result = db.Kitap.Find(id);
                    db.Kitap.Remove(result);
                    db.SaveChanges();
                    Response.Redirect("Web_kitap.aspx");
                }

            }
          
                


            }
        }
}