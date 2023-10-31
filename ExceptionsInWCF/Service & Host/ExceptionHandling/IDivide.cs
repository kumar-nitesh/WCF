using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    [ServiceContract]
    public interface IDivide
    {
        [OperationContract]
        int DivideNumber(int a, int b);
    }
}
