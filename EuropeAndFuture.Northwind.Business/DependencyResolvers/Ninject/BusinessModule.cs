using EuropeAndFuture.Core.DataAccess;
using EuropeAndFuture.Core.DataAccess.EntityFramework;
using EuropeAndFuture.Northwind.Business.Abstract;
using Ninject.Modules;
using EuropeAndFuture.Northwind.Business.Concrete.Managers;
using EuropeAndFuture.Northwind.DataAccess.Concrete.EntityFramework;
using EuropeAndFuture.Northwind.DataAccess.Abstract;
using System.Data.Entity;
using EuropeAndFuture.Core.DataAccess.NHibernate;
using EuropeAndFuture.Northwind.DataAccess.Concrete.NHibernate.Helpers;

namespace EuropeAndFuture.Northwind.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>();

            Bind<IUserService>().To<UserManager>();
            Bind<IUserDal>().To<EfUserDal>();



            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<NorthwindContext>();
            Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    }
}
