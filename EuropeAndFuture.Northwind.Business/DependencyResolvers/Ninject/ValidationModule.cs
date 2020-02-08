using EuropeAndFuture.Northwind.Business.ValidationRules.FluentValidation;
using FluentValidation;
using Ninject.Modules;

namespace EuropeAndFuture.Northwind.Business.DependencyResolvers.Ninject
{
    public class ValidationModule: NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Product>>().To<ProductValidator>().InSingletonScope();
        }
    }
}
