using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace EuropeAndFuture.Northwind.Business.ServiceContracts.Wcf
{
    [ServiceContract]
    public interface IProducDetailService
    {
        [OperationContract]
        List<Product> GetAll();
    }
}
