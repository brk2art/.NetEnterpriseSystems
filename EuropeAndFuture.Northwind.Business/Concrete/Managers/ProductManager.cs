using EuropeAndFuture.Core.Aspects.Postsharp.CacheAspects;
using EuropeAndFuture.Core.Aspects.Postsharp.PerformanceAspects;
using EuropeAndFuture.Core.Aspects.Postsharp.TransactionAspects;
using EuropeAndFuture.Core.Aspects.Postsharp.ValidationAspects;
using EuropeAndFuture.Core.CrossCuttingConcerns.Caching.Microsoft;
using EuropeAndFuture.Northwind.Business.Abstract;
using EuropeAndFuture.Northwind.Business.ValidationRules.FluentValidation;
using EuropeAndFuture.Northwind.DataAccess.Abstract;
using EuropeAndFuture.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace EuropeAndFuture.Northwind.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private IMapper _mapper;

        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        [CacheAspect(typeof(MemoryCacheManager),120)]
        [PerformanceCounterAspect(2)]
        [SecuredOperation(Roles="Admin,Editor,Student")]
        public List<Product> GetAll()
        {
            var products = mapper.Map<List<Product>>(_productDal.GetList());
            return products;
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        [FluentValidationAspect(typeof(ProductValidator))]
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }

        [TransactionScopeAspect]
        [FluentValidationAspect(typeof(ProductValidator))]
        public void TransactionalOperation(Product productOld, Product productNew)
        {
            _productDal.Add(productOld);
            //Business Codes
            _productDal.Update(productNew);
        }
    }
}
