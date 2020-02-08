using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EuropeAndFuture.Core.Utilities.Common;
using EuropeAndFuture.Northwind.Business.Abstract;
using Ninject.Modules;

namespace EuropeAndFuture.Northwind.Business.DependencyResolvers.Ninject
{
    public class ServiceModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().ToConstant(WcfProxy<IProductService>.CreateChannel());
        }
    }
}
