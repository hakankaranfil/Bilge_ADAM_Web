using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm_CRUD.Models;

namespace WebForm_CRUD
{
    public partial class Musteriler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (BakkalDB1Entities db=new BakkalDB1Entities())
            {
                Repeater1.DataSource = db.Customers.ToList();
                Repeater1.DataBind();
            }

            if (Request.QueryString["ID"]!=null)
            {
                int id = int.Parse(Request.QueryString["ID"]);
                using (BakkalDB1Entities db=new BakkalDB1Entities())
                {
                    var result = db.Customers.Find(id);
                    db.Customers.Remove(result);
                    db.SaveChanges();
                    Response.Redirect("Musteriler.aspx");
                }

            }
        }
    }
}