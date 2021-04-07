using SanalSatis.Core.DataAccess.EntityFramework;
using SanalSatis.DAL.Abstract;
using SanalSatis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanalSatis.DAL.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, SanalSatisContext>, IUserDal
    {
    }
}
