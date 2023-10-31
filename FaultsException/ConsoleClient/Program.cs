using ConsoleClient.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
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
            catch(FaultException fault)
            {
                Console.WriteLine(fault.Message + "\n" + fault.Code.Name);
            }
        }
    }
}
