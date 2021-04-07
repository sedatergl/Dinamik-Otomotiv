using SanalSatis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanalSatis.BLL.Abstract
{
    public interface IVehicleService
    {
        List<Vehicle> GetAll();
        List<BrandVehicle> GetAllVehicle();
        void Add(Vehicle product);
        void Update(Vehicle product);
        void Delete(int productId);
        List<Vehicle> GetByCategory(int categoryId);
        Vehicle GetById(int productId);
    }
}
