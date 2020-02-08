using EuropeAndFuture.Core.DataAccess.NHibernate;
using EuropeAndFuture.Northwind.DataAccess.Abstract;
using EuropeAndFuture.Northwind.Entities.Concrete;

namespace EuropeAndFuture.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhCategoryDal:NhEntityRepositoryBase<Category>, ICategoryDal
    {
        public NhCategoryDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {

        }
    }
}
