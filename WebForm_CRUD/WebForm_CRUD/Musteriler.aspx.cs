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
            using(BakkalDBEntities db=new BakkalDBEntities())
            {
                Repeater1.DataSource=db.
            }
        }
    }
}