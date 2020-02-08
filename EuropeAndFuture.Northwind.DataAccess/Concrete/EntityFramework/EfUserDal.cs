using System.Collections.Generic;
using EuropeAndFuture.Core.DataAccess.EntityFramework;
using EuropeAndFuture.Northwind.DataAccess.Abstract;
using EuropeAndFuture.Northwind.Entities.ComplexTypes;
using EuropeAndFuture.Northwind.Entities.Concrete;

namespace EuropeAndFuture.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from ur in context.UserRoles
                             join r in context.Roles
                             on ur.UserId equals user.Id
                             where ur.UserId == user.Id
                             select new UserRoleItem {RoleName = r.Name};
                return result.ToList();
            }
        }
    }
}
