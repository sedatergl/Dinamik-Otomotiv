using SanalSatis.Core.DataAccess;
using SanalSatis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanalSatis.DAL.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
    }
}
