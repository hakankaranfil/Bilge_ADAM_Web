using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm_CRUD.Models;

namespace WebForm_CRUD
{
    public partial class MusteriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            using (BakkalDB1Entities db =new BakkalDB1Entities())
            {

                Customer customer = new Customer();
                customer.CustomerName = TextBox1ad.Text;
                customer.CustomerSurname = TextBoxsoyad.Text;
                customer.Phone = TextBoxtel.Text;
                customer.Adress = Textadres.Text;

                db.Customers.Add(customer);
                db.SaveChanges();

                Response.Redirect("Musteriler.aspx");

            }
        }
    }
}

