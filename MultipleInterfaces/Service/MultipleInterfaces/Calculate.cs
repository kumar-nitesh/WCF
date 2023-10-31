using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    public class Calculate : IAdd,ISub
    {
        #region IAdd Members

        int IAdd.Add(int a, int b)
        {
            return a + b;
        }

        #endregion

        #region ISub Members

        int ISub.Sub(int a, int b)
        {
            return a - b;
        }

        #endregion
    }
}
