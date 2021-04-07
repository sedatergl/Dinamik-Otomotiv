using SanalSatis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanalSatis.BLL.Abstract
{
    public interface IUserService
    {
        User GetByNameAndPassword(string userName,string Password);
    }
}
