using SanalSatis.Core.DataAccess.EntityFramework;
using SanalSatis.DAL.Abstract;
using SanalSatis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SanalSatis.DAL.Concrete.EntityFramework
{
    public class EfVehicleDal : EfEntityRepositoryBase<Vehicle, SanalSatisContext>, IVehicleDal
    {
        public List<BrandVehicle> GetAllVehicle()
        {
            using (SanalSatisContext context = new SanalSatisContext())
            {
                var query = (from B in context.Brands
                             join V in context.Vehicles.Cast<Vehicle>() on B.BestSeller equals V.VehicleId
                             select new BrandVehicle
                             {
                                 BrandId = B.BrandId,
                                 BrandName = B.BrandName,
                                 Country = B.Country,
                                 Locasyon = B.Locasyon,
                                 MarketValue = B.MarketValue,
                                 PersonelCount = B.PersonelCount,
                                 BestSeller=V.VehicleName
                             }).ToList();

                return query;
            }
        }

   
    }
}
