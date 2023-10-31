using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleEndpoints
{
    public class HelloWCF : IHelloWCF
    {
        #region IHelloWCF Members

        string IHelloWCF.GetMessage(string name)
        {
            return "Hey ! " + name;
        }

        #endregion
    }
}
