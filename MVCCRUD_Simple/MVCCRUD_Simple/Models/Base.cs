using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCRUD_Simple.Models
{
    public class Base
    {
        public bool IsRented { get; set; }
        public bool IsDeleted { get; set; }
    }
}