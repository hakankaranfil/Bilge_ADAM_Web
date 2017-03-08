using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCRUD_Simple.Models
{
    public class Motor:Base
    {
        public int MotorID { get; set; }
        public string MotorBrand { get; set; }
        public string MotorModel { get; set; }
        public string MotorAge { get; set; }
    }
}