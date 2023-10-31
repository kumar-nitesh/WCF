using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Faults
{
    public class Divide : IDivide
    {
        #region IDivide Members

        public int DivideNumbers(int a, int b)
        {
            //// If you throw a .net exception instead of fault exception, then the channel will become faulty.
            //if (b == 0)
            //    throw new DivideByZeroException();

            // If you throw a fault exception, the service communication channel will not become faulty.
            if (b == 0)
                throw new FaultException("Denominator cannot be zero", new FaultCode("DivideByZero"));

            return a / b;
        }

        #endregion
    }
}
