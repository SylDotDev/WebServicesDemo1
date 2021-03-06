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
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://sylvia.net/webservices", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sylvia.net/webservices", ConfigurationName="CalculatorService.CalculatorWebService2Soap")]
    public interface CalculatorWebService2Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sylvia.net/webservices/Add", ReplyAction="*")]
        int Add(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sylvia.net/webservices/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int x, int y);
        
        // CODEGEN: Generating message contract since element name GetCalculationsResult from namespace http://sylvia.net/webservices is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sylvia.net/webservices/GetCalculations", ReplyAction="*")]
        CalculatorWebApplication.CalculatorService.GetCalculationsResponse GetCalculations(CalculatorWebApplication.CalculatorService.GetCalculationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sylvia.net/webservices/GetCalculations", ReplyAction="*")]
        System.Threading.Tasks.Task<CalculatorWebApplication.CalculatorService.GetCalculationsResponse> GetCalculationsAsync(CalculatorWebApplication.CalculatorService.GetCalculationsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalculationsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalculations", Namespace="http://sylvia.net/webservices", Order=0)]
        public CalculatorWebApplication.CalculatorService.GetCalculationsRequestBody Body;
        
        public GetCalculationsRequest() {
        }
        
        public GetCalculationsRequest(CalculatorWebApplication.CalculatorService.GetCalculationsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetCalculationsRequestBody {
        
        public GetCalculationsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalculationsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalculationsResponse", Namespace="http://sylvia.net/webservices", Order=0)]
        public CalculatorWebApplication.CalculatorService.GetCalculationsResponseBody Body;
        
        public GetCalculationsResponse() {
        }
        
        public GetCalculationsResponse(CalculatorWebApplication.CalculatorService.GetCalculationsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sylvia.net/webservices")]
    public partial class GetCalculationsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CalculatorWebApplication.CalculatorService.ArrayOfString GetCalculationsResult;
        
        public GetCalculationsResponseBody() {
        }
        
        public GetCalculationsResponseBody(CalculatorWebApplication.CalculatorService.ArrayOfString GetCalculationsResult) {
            this.GetCalculationsResult = GetCalculationsResult;
        }
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
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CalculatorWebApplication.CalculatorService.GetCalculationsResponse CalculatorWebApplication.CalculatorService.CalculatorWebService2Soap.GetCalculations(CalculatorWebApplication.CalculatorService.GetCalculationsRequest request) {
            return base.Channel.GetCalculations(request);
        }
        
        public CalculatorWebApplication.CalculatorService.ArrayOfString GetCalculations() {
            CalculatorWebApplication.CalculatorService.GetCalculationsRequest inValue = new CalculatorWebApplication.CalculatorService.GetCalculationsRequest();
            inValue.Body = new CalculatorWebApplication.CalculatorService.GetCalculationsRequestBody();
            CalculatorWebApplication.CalculatorService.GetCalculationsResponse retVal = ((CalculatorWebApplication.CalculatorService.CalculatorWebService2Soap)(this)).GetCalculations(inValue);
            return retVal.Body.GetCalculationsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CalculatorWebApplication.CalculatorService.GetCalculationsResponse> CalculatorWebApplication.CalculatorService.CalculatorWebService2Soap.GetCalculationsAsync(CalculatorWebApplication.CalculatorService.GetCalculationsRequest request) {
            return base.Channel.GetCalculationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CalculatorWebApplication.CalculatorService.GetCalculationsResponse> GetCalculationsAsync() {
            CalculatorWebApplication.CalculatorService.GetCalculationsRequest inValue = new CalculatorWebApplication.CalculatorService.GetCalculationsRequest();
            inValue.Body = new CalculatorWebApplication.CalculatorService.GetCalculationsRequestBody();
            return ((CalculatorWebApplication.CalculatorService.CalculatorWebService2Soap)(this)).GetCalculationsAsync(inValue);
        }
    }
}
