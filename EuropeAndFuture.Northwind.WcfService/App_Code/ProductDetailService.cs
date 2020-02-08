using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EuropeAndFuture.Northwind.Business.Abstract;
using EuropeAndFuture.Northwind.Business.DependencyResolvers.Ninject;

/// <summary>
/// Summary description for ProductDetailService
/// </summary>
public class ProductDetailService:IProductDetailService
{
    private IProductService _productService = InstanceFactory.GetInstance<IProductService>();

    public List<Product> GetAll()
    {
        return _productService.GetAll();
    }
}