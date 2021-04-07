using System;
using System.Collections.Generic;
using System.Text;

namespace SanalSatis.Entities.Concrete
{
    public class BrandVehicle
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string VehicleName { get; set; }
        public string Country { get; set; }
        public string Locasyon { get; set; }
        public decimal MarketValue { get; set; }
        public string BestSeller { get; set; }
        public int PersonelCount { get; set; }
    }
}
