﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IDivide")]
    public interface IDivide {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDivide/DivideNumber", ReplyAction="http://tempuri.org/IDivide/DivideNumberResponse")]
        int DivideNumber(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDivide/DivideNumber", ReplyAction="http://tempuri.org/IDivide/DivideNumberResponse")]
        System.Threading.Tasks.Task<int> DivideNumberAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDivideChannel : WebClient.ServiceReference.IDivide, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DivideClient : System.ServiceModel.ClientBase<WebClient.ServiceReference.IDivide>, WebClient.ServiceReference.IDivide {
        
        public DivideClient() {
        }
        
        public DivideClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DivideClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DivideClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DivideClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int DivideNumber(int a, int b) {
            return base.Channel.DivideNumber(a, b);
        }
        
        public System.Threading.Tasks.Task<int> DivideNumberAsync(int a, int b) {
            return base.Channel.DivideNumberAsync(a, b);
        }
    }
}
