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
    public partial class UsersAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = TextBoxUserName.Text;
            user.Address = TextBoxAddress.Text;
            UsersRespositery.UserAdd(user);
            Response.Redirect("UserList.aspx");
        }
    }
}