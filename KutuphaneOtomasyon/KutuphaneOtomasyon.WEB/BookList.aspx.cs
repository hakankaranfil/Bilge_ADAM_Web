﻿using KutuphaneOtomasyon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KutuphaneOtomasyon.WEB
{
    public partial class BookList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Repeater1.DataSource = BookRepositery.GetALLBooks();
            Repeater1.DataBind();
            
              
        }
    }
}