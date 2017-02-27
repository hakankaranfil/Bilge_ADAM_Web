using KutuphaneOtomasyon.DAL;
using KutuphaneOtomasyon.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KutuphaneOtomasyon.WEB
{
    public partial class WriterList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"]!=null)
            {
                int id = int.Parse(Request.QueryString["ID"]);
                WriterRespositery.DeleteWriter(id);
                Response.Redirect("WriterList.Aspx");
            }
            Repeater1.DataSource = WriterRespositery.GetAllWriter();
            Repeater1.DataBind();

        }
    }
}