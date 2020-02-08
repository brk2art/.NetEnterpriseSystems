using EuropeAndFuture.Core.DataAccess.EntityFramework;
using EuropeAndFuture.Northwind.DataAccess.Abstract;
using EuropeAndFuture.Northwind.Entities.Concrete;

namespace EuropeAndFuture.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>, ICategoryDal
    {

    }
}
