using EuropeAndFuture.Northwind.Entities.Concrete;
using System.Collections.Generic;
using System.Web.Mvc;
using EuropeAndFuture.Northwind.Business.Abstract;

namespace EuropeAndFuture.Northwind.WebApi.Controllers
{
    public class ProductsController : Controller
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Get()
        {
           return _productService.GetAll();
        }
    }
}