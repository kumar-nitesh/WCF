﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SoapFaults
{
    [DataContract]
    public class DivideByZeroFault
    {
        [DataMember]
        public string Error { get; set; }

        [DataMember]
        public string Details { get; set; }
    }
}
