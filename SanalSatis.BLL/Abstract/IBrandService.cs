using SanalSatis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanalSatis.BLL.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(int brandId);
        Brand GetById(int productId);
    }
}
