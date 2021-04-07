using SanalSatis.Core.Entities;

namespace SanalSatis.Entities.Concrete
{
    public class Brand : IEntity
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string Country { get; set; }
        public string Locasyon { get; set; }
        public decimal MarketValue { get; set; }
        public int BestSeller { get; set; }
        public int PersonelCount { get; set; }
    }
}
