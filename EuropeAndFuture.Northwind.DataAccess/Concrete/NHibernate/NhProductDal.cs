using EuropeAndFuture.Core.DataAccess.NHibernate;
using EuropeAndFuture.Northwind.Entities.Concrete;
using EuropeAndFuture.Northwind.DataAccess.Abstract;
using EuropeAndFuture.Northwind.Entities.ComplexTypes;
using System.Linq;
using System.Collections.Generic;
using NHibernate.Linq;

namespace EuropeAndFuture.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal:NhEntityRepositoryBase<Product>, IProductDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<ProductDetail> GetProductDetails()
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                    join c in session.Query<Category>() on p.CategoryId equals c.CategoryId
                    select new ProductDetail
                    {
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        CategoryName = c.CategoryName
                    };

                return result.ToList();
            }
        }
    }
}
