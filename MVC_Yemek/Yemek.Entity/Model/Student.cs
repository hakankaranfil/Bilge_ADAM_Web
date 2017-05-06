using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemek.Entity.Model
{
  public  class Student
    {
        public  int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentSurName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentPassword { get; set; }
        public string StudentNumber { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime DueDate { get; set; }
        public int Balance { get; set; }
    }
}
