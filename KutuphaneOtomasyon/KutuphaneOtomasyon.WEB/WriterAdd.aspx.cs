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
    public partial class WriterAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null && !IsPostBack )
            {
                int id = int.Parse(Request.QueryString["ID"]);
                var result = WriterRespositery.GetWriter(id);
                BtnKaydet.CssClass = "btn-btn-success btn-block";
                BtnKaydet.Text = "Update";

            }
        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            Writer writer = new Writer();
            writer.WriterName = TextBoxWriterName.Text;
            if (BtnKaydet.Text=="Güncelle")
            {
                int id = int.Parse(Request.QueryString["ID"]);
                WriterRespositery.UpdateWriter(id,TextBoxWriterName.Text);
                else
	{
                    WriterRespositery.AddWriter(writer);
                    Response.Redirect("WriterList.aspx");
                }
            }
           
        }
    }
}