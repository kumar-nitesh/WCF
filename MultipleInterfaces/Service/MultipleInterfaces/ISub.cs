using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    [ServiceContract]
    interface ISub
    {
        [OperationContract]
        int Sub(int a, int b);
    }
}
