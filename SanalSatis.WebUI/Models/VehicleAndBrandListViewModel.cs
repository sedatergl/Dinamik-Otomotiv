using SanalSatis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanalSatis.WebUI.Models
{
    public class VehicleAndBrandListViewModel
    {
        public int CurrentCategory { get; internal set; }
        public int CurrentPage { get; internal set; }
        public int PageCount { get; internal set; }
        public int PageSize { get; internal set; }
        public List<BrandVehicle> Vehicles { get; internal set; }
    }
}
