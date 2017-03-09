using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public enum Type
{
    Car=0,
    Motor=1,

}
namespace MVCCRUD_Simple.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string VehicleBrand { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleAge { get; set; }
        public double RentPrice { get; set; }
        public Type VehicleType { get; set; }
        
        public bool IsDeleted { get; set; }
        public string LicencePlate { get; set; }
    }
}