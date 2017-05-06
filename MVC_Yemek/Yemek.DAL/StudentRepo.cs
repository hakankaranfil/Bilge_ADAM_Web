using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yemek.Entity.Model;

namespace Yemek.DAL
{
  public  class StudentRepo
    {
        //public static Student Get(Student model)
        //{
        //    using (YemekDBContext db=new YemekDBContext())
        //    {
        //     return   db.Students.FirstOrDefault(s => s.StudentEmail == model.StudentName && s.StudentPassword == model.StudentPassword);
        //    }
        //}
        public static void Add(Student model)
        {
            using (YemekDBContext db=new YemekDBContext())
            {
                db.Students.Add(model);
                db.SaveChanges();
            }
        }
    }
}
