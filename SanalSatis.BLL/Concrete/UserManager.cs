using SanalSatis.BLL.Abstract;
using SanalSatis.DAL.Abstract;
using SanalSatis.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanalSatis.BLL.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public User GetByNameAndPassword(string UserName, string Password)
        {
            return _userDal.GetByNameAndPassword(p => p.UserName == UserName && p.PassWord == Password);
        }
    }
}
