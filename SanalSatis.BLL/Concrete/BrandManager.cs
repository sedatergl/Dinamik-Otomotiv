using SanalSatis.BLL.Abstract;
using SanalSatis.DAL.Abstract;
using SanalSatis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanalSatis.BLL.Concrete
{
    public class BrandManager : IBrandService
    {
        private IBrandDal _categoryDal;

        public BrandManager(IBrandDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Brand> GetAll()
        {
            return _categoryDal.GetList();
        }
        public void Add(Brand brand)
        {
            _categoryDal.Add(brand);
        }

        public void Update(Brand brand)
        {
            _categoryDal.Update(brand);
        }
        public void Delete(int brandId)
        {
            _categoryDal.Delete(new Brand { BrandId = brandId });
        }
        public Brand GetById(int productId)
        {
            return _categoryDal.Get(p => p.BrandId == productId);
        }
    }
}
