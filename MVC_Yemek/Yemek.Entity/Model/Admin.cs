﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
namespace Yemek.Entity.Model
{
  public  class Admin
    {
        public int AdminID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
