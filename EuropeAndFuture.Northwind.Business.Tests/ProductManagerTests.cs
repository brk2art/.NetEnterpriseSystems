using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using EuropeAndFuture.Northwind.DataAccess.Abstract;
using EuropeAndFuture.Northwind.Business.Concrete.Managers;
using EuropeAndFuture.Northwind.Entities.Concrete;
using FluentValidation;

namespace EuropeAndFuture.Northwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDal> mock = new Mock<IProductDal>();
            ProductManager productManager = new ProductManager(mock.Object);
            productManager.Add(new Product());
        }
    }
}
