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

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            director.DirectorName = txtDirectorName.Text;
            DirectorRepository.AddDirector(director);
            
            Response.Redirect("HomePage.aspx");
        }
    }
}