using İMDB.DAL;
using İMDB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace İMDB.Web
{
    public partial class DirectorAdd : System.Web.UI.Page
    {



        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null && !IsPostBack)
            {
                int id = int.Parse(Request.QueryString["ID"]);
                var result = DirectorRepository.GetDirector(id);
                txtDirectorName.Text = result.DirectorName;
                btnKaydet.CssClass = "btn btn-Info btn-block";
                btnKaydet.Text = "Güncelle";

            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            if (btnKaydet.Text == "Güncelle")
            {
                director.DirectorName = txtDirectorName.Text;
                int id = int.Parse(Request.QueryString["ID"]);
                DirectorRepository.UpdateDirector(id, txtDirectorName.Text);
                Response.Redirect("DirectorList.aspx");
            }
            director.DirectorName = txtDirectorName.Text;
            DirectorRepository.AddDirector(director);

            Response.Redirect("DirectorList.aspx");
        }
    }
}