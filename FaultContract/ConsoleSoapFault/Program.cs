using ConsoleSoapFault.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSoapFault
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DivideClient proxy = new DivideClient();
                Console.WriteLine(proxy.DivideNumbers(10, 0));
                Console.ReadLine();               
            }
            catch(FaultException<DivideByZeroFault> fault)
            {
                Console.WriteLine(fault.Detail.Error + "\n" + fault.Detail.Details);
                Console.ReadLine();
            }
        }
    }
}
