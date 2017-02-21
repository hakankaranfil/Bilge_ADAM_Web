using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm_CRUD.Models;

namespace WebForm_CRUD
{
    public partial class MusteriGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["ID"]);
                using (BakkalDB1Entities db = new BakkalDB1Entities())
                {
                    var result = db.Customers.Find(id);
                    TextBox1ad.Text = result.CustomerName;
                    TextBoxsoyad.Text = result.CustomerSurname;
                    TextBoxtel.Text = result.Phone;
                    Textadres.Text = result.Adress;
                }
            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            using (BakkalDB1Entities db = new BakkalDB1Entities())
            {
                int id = int.Parse(Request.QueryString["ID"]);
                var result = db.Customers.Find(id);
                result.CustomerName = TextBox1ad.Text;
                result.CustomerSurname = TextBoxsoyad.Text;
                result.Phone = TextBoxtel.Text;
                result.Adress = Textadres.Text;
                db.SaveChanges();

                Response.Redirect("Musteriler.aspx");


            }
        }
    }
}