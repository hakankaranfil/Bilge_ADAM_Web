﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemek.Entity.Model
{
   public class BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
