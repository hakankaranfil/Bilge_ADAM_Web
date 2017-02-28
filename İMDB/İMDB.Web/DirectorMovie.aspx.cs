using İMDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace İMDB.Web
{
    public partial class DirectorMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null && !IsPostBack)
            {
                int id = int.Parse(Request.QueryString["ID"]);
                Repeater1.DataSource = MovieRepositery.GetAllDMovies(id);
                Repeater1.DataBind();


            }
        }
    }
}
