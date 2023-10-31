using MultipleInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalculateHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Calculate);

            using(ServiceHost host = new ServiceHost(type))
            {
                host.Open();
                Console.WriteLine("Calculate Service Hosted !!!");
                Console.ReadLine();
            }
        }
    }
}
