using System.Collections.Generic;
using EuropeAndFuture.Northwind.Entities.ComplexTypes;
using EuropeAndFuture.Northwind.Entities.Concrete;

namespace EuropeAndFuture.Northwind.Business.Abstract
{
    public interface IUserService
    {
        User GetByUserNameAndPassword(string userName, string password);
        List<UserRoleItem> GetUserRoles(User user);
    }
}
