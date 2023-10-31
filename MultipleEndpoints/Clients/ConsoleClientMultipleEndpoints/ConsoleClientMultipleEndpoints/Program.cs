using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientMultipleEndpoints
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWCF_SvcRef.HelloWCFClient proxy = new HelloWCF_SvcRef.HelloWCFClient();
            Console.WriteLine(proxy.GetMessage("Nitesh Kumar"));
        }
    }
}
