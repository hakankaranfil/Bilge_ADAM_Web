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
                db.Kitap.ToList();
            }
        }
    }
}