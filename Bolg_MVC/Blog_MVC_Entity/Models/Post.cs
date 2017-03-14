using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_MVC_Entity.Models
{
  public  class Post:Base
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Concent { get; set; }
        public int AdminID { get; set; }
        public DateTime PostDate { get; set; }
        public int CategoryID { get; set; }
        public List<Tag> Tags { get; set; }
        public Admin Admin { get; set; }
        public Category Category { get; set; }

    }
}
