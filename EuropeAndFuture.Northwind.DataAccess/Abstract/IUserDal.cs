using EuropeAndFuture.Core.DataAccess;
using EuropeAndFuture.Northwind.Entities.ComplexTypes;
using EuropeAndFuture.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace EuropeAndFuture.Northwind.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<UserRoleItem> GetUserRoles(User user);
    }
}
