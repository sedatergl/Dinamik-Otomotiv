using SanalSatis.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanalSatis.Entities.Concrete
{
    public class User:IEntity
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserRealName { get; set; }
        public string PassWord { get; set; }
    }
}
