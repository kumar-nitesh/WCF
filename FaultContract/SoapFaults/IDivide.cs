using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SoapFaults
{
    [ServiceContract]
    interface IDivide
    {
        [FaultContract(typeof(DivideByZeroFault))]
        [OperationContract]
        int DivideNumbers(int a, int b);
    }
}
