using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yemek.Entity.Model;

namespace Yemek.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (YemekDBContext db=new YemekDBContext())
            {
                Student s = new Student();
                Staff st = new Staff();
                s.StudentName = "Hakan";
                s.StudentNumber = "11";
                s.StudentPassword = "1234";
                s.StudentEmail = "hakan.karanfil@outlook.com";
                s.StartingDate = DateTime.Now;
                s.DueDate = DateTime.Now;
                s.StudentSurName = "KARANFİL";
                db.Students.Add(s);
                st.StaffEmail = "a@hotmail.com";
                st.StaffName = "Emre";
                st.StaffPassword = "1234";
                db.Staffs.Add(st);
                db.SaveChanges();
            }
        }
    }
}
