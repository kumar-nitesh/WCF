﻿using ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(Divide)))
            {
                host.Open();
                Console.WriteLine("Hosted Started @" + DateTime.Now);
                Console.ReadLine();
            }
        }
    }
}
