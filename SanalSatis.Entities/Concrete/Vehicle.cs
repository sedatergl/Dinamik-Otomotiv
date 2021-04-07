using SanalSatis.Core.Entities;

namespace SanalSatis.Entities.Concrete
{
    public class Vehicle : IEntity
    {
        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
        public int BrandId { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
