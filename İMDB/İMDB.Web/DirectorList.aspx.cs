using İMDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace İMDB.Web
{
    public partial class DirectorList : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = DirectorRepository.GetAllDirector();
            Repeater1.DataBind();
        }
    }
}