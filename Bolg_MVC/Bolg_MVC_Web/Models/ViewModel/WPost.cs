using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bolg_MVC_Web.Models.ViewModel
{
    public class WPost
    {
        
        public string Title { get; set; }
        public string Concent { get; set; }
        public string Category { get; set; }
        public string Tags { get; set; }
    }
}