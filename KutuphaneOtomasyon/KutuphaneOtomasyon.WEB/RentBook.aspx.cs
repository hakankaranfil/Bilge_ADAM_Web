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
    public partial class RentBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                textboxname=.text=
                DropUser.DataSource = UsersRespositery.GetAllUser();
                DropUser.DataTextField = "WriterName";
                DropUser.DataValueField = "WriterID";
                DropUser.DataBind();
            }
        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            Rent rent = new Rent();
            rent.BookID = int.Parse(Request.QueryString["ID"]);
            rent.UserID = int.Parse(DropUser.SelectedItem.Value);
            rent.RentDate = DateTime.Now;
            rent.ReturnDate = DateTime.Now.AddMonths(1);
            //RentRespositery.a
            
        }
    }
}