using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Divide : IDivide
    {
        #region IDivide Members

        public int DivideNumber(int a, int b)
        {
            return a / b;
        }

        #endregion
    }
}
