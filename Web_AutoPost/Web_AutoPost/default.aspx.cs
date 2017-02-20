using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_AutoPost
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("İzmir");
                DropDownList1.Items.Add("İstanbul");
                DropDownList1.Items.Add("Ankara");

                DropDownList2.Items.Add("ilçe Seçiniz");

                DropDownList2.Enabled = false;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Enabled = true;
            if (DropDownList1.SelectedIndex==0)
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("Konak");
                DropDownList2.Items.Add("Karşıyaka");
            }
        else    if (DropDownList1.SelectedIndex==1)
            {
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("Beşiktaş");
                DropDownList2.Items.Add("şişli");
            }
        }
    }
}