﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorWebApplication.CalculatorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sylvia.net/webservices", ConfigurationName="CalculatorService.CalculatorWebService2Soap")]
    public interface CalculatorWebService2Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sylvia.net/webservices/Add", ReplyAction="*")]
        int Add(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sylvia.net/webservices/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorWebService2SoapChannel : CalculatorWebApplication.CalculatorService.CalculatorWebService2Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorWebService2SoapClient : System.ServiceModel.ClientBase<CalculatorWebApplication.CalculatorService.CalculatorWebService2Soap>, CalculatorWebApplication.CalculatorService.CalculatorWebService2Soap {
        
        public CalculatorWebService2SoapClient() {
        }
        
        public CalculatorWebService2SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorWebService2SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorWebService2SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorWebService2SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int x, int y) {
            return base.Channel.Add(x, y);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int x, int y) {
            return base.Channel.AddAsync(x, y);
        }
    }
}