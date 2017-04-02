using Protein.Entity;
using Protein.Entity.Model;
using Protein.Entity.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protein.DAL
{
  public  class ProductRepo
    {
        public static List<Product> GetAllForHome()
        {
            using (ProteinDBContext db=new ProteinDBContext())
            {
                return db.Product.ToList();
            }
        }
        public static ViewProductForDetails Get(int id)
        {
            using (ProteinDBContext db = new ProteinDBContext())
            {
                return db.Product.Where(b => b.ProductID == id)
                    .Select(b => new ViewProductForDetails
                    {
                        ProductID = b.ProductID,
                        Brand=b.Brand.BrandName,
                        ProductName=b.ProductName,
                        Price=b.Price,
                        ProductContent=b.ProductContent,
                        ProductPhoto=b.ProductPhoto,               
                    }).FirstOrDefault();
            }
        }
    }
}
