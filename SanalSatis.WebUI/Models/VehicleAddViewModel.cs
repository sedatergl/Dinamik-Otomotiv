using SanalSatis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanalSatis.WebUI.Models
{
    public class VehicleAddViewModel
    {
        public Brand Brand { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
