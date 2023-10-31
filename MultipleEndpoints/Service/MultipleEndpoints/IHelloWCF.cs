using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MultipleEndpoints
{
    [ServiceContract]
    public interface IHelloWCF
    {
        [OperationContract]
        string GetMessage(string name);        
    }
}
