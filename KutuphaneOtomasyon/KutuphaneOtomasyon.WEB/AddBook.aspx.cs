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
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropWriter.DataSource = WriterRespositery.GetAllWriter();
                DropWriter.DataTextField = "WriterName";
                DropWriter.DataValueField = "WriterID";
                DropWriter.DataBind();
            }
            
        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.BookName = TextBoxKitapName.Text;
            book.BookSubject = TextBoxSubject.Text;
            book.PageCount =int.Parse( TextBoxPageCount.Text);
            book.ShelfNumber = int.Parse(TextBoxShelfNumberf.Text);
            book.WriterID = int.Parse(DropWriter.SelectedItem.Value);
            BookRepositery.AddBook(book);
            Response.Redirect("BookList.aspx");
        }
    }
}