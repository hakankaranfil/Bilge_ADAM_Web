using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web_Form_Listbox2.Models;

namespace Web_Form_Listbox2
{
    public partial class listbox_2 : System.Web.UI.Page
    {
        void CategoryListele()
        {
            using (NorthwindEntities db = new NorthwindEntities())
            {
                Droplist.DataSource = db.Categories.ToList();
                Droplist.DataTextField = "CategoryName";
                Droplist.DataValueField = "CategoryID";
                Droplist.DataBind();
            }
        }
        void UrubGetir(int catID)
        {
            using(NorthwindEntities db=new NorthwindEntities())
            {
                ListUrun.DataSource = db.Products.Where(u => u.CategoryID == catID).ToList();
                ListUrun.DataTextField = "ProductName";
                ListUrun.DataBind();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
        
            CategoryListele();
            
        }

        protected void Droplist_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrubGetir(int.Parse(Droplist.SelectedItem.Value));
        }
    }
}