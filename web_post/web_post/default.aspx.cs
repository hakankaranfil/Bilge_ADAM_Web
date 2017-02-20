using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_post
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("aytekin");
                DropDownList1.Items.Add("çeyiz");
                DropDownList1.Items.Add("hakan");
                DropDownList1.Items.Add("bengisu");
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("atakan");
        }
    }
}