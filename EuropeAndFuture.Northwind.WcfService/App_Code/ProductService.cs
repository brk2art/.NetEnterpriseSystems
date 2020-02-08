using EuropeAndFuture.Northwind.Business.Abstract;
using EuropeAndFuture.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using EuropeAndFuture.Northwind.Business.Concrete.Managers;
using EuropeAndFuture.Northwind.Business.DependencyResolvers.Ninject;

/// <summary>
/// Summary description for ProductService
/// </summary>
public class ProductService:IProductService
{
    public ProductService()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private IProductService _productService = InstanceFactory.GetInstance<IProductService>();

    public List<Product> GetAll()
    {
       return _productService.GetAll();
    }

    public Product GetById(int id)
    {
        return _productService.GetById(id);
    }

    public Product Add(Product product)
    {
        return _productService.Add(product);
    }

    public Product Update(Product product)
    {
        return _productService.Update(product);
    }

    public void TransactionalOperation(Product productOld, Product productNew)
    {
        return _productService.TransactionalOperation(productOld,productNew);
    }
}