using SanalSatis.BLL.Abstract;
using SanalSatis.DAL.Abstract;
using SanalSatis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanalSatis.BLL.Concrete
{
    public class VehicleManager : IVehicleService
    {
        private IVehicleDal _productDal;

        public VehicleManager(IVehicleDal productDal)
        {
            _productDal = productDal;
        }

        public List<Vehicle> GetAll()
        {
            return _productDal.GetList();
        }

        public void Add(Vehicle product)
        {
            _productDal.Add(product);
        }

        public void Update(Vehicle product)
        {
            _productDal.Update(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(new Vehicle { VehicleId = productId });
        }

        public Vehicle GetById(int productId)
        {
            return _productDal.Get(p => p.VehicleId == productId);
        }

        public List<Vehicle> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.BrandId == categoryId || categoryId == 0);
        }

        public List<BrandVehicle> GetAllVehicle()
        {
            return _productDal.GetAllVehicle();
        }
    }
}
