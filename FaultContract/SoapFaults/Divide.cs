using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SoapFaults
{
    public class Divide : IDivide
    {
        #region IDivide Members

        public int DivideNumbers(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch(DivideByZeroException ex)
            {
                DivideByZeroFault fault = new DivideByZeroFault();
                fault.Error = ex.Message;
                fault.Details = "Denominator cannot be zero.";

                throw new FaultException<DivideByZeroFault>(fault);
            }
        }

        #endregion
    }
}
