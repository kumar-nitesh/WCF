using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Faults
{
    [ServiceContract]
    interface IDivide
    {
        [OperationContract]
        int DivideNumbers(int a, int b);
    }
}
