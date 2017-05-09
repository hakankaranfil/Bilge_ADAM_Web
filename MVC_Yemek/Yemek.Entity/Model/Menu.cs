using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemek.Entity.Model
{
  public  class Menu
    {
        public int MenuID { get; set; }
        List<Dessert> Dessert { get; set;}
        List<MainCourse> MainCourse = new List<MainCourse>();
        List<Salad> Salad { get; set; }
        List<Soup> Soup { get; set; }
        



    }
}
