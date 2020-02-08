using System.Collections.Generic;
using EuropeAndFuture.Northwind.Business.Abstract;
using EuropeAndFuture.Northwind.DataAccess.Abstract;
using EuropeAndFuture.Northwind.Entities.ComplexTypes;
using EuropeAndFuture.Northwind.Entities.Concrete;

namespace EuropeAndFuture.Northwind.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public User GetByUserNameAndPassword(string userName, string password)
        {
            return _userDal.Get(u => u.UserName == userName && u.Password == password);
        }

        public List<UserRoleItem> GetUserRoles(User user)
        {
            return _userDal.GetUserRoles(user);
        }
    }
}
