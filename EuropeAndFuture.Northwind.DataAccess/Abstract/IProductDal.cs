using EuropeAndFuture.Core.DataAccess;
using EuropeAndFuture.Northwind.Entities.Concrete;
using System.Collections.Generic;
using EuropeAndFuture.Northwind.Entities.ComplexTypes;

namespace EuropeAndFuture.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}
