using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MultipleEndpoints;


namespace HelloHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost selfHost = new ServiceHost(typeof(HelloWCF));

            selfHost.Open();

            Console.WriteLine("Hello WCF is hosted at the following endpoints :");

            foreach (var ep in selfHost.Description.Endpoints)
                Console.WriteLine(ep.Address);

            Console.ReadLine();
        }
    }
}
