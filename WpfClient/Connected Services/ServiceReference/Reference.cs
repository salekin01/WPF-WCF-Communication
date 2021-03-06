﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfClient.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IWcfServer")]
    public interface IWcfServer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfServer/ConvertNumberToWord", ReplyAction="http://tempuri.org/IWcfServer/ConvertNumberToWordResponse")]
        string ConvertNumberToWord(string number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfServer/ConvertNumberToWord", ReplyAction="http://tempuri.org/IWcfServer/ConvertNumberToWordResponse")]
        System.Threading.Tasks.Task<string> ConvertNumberToWordAsync(string number);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfServerChannel : WpfClient.ServiceReference.IWcfServer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfServerClient : System.ServiceModel.ClientBase<WpfClient.ServiceReference.IWcfServer>, WpfClient.ServiceReference.IWcfServer {
        
        public WcfServerClient() {
        }
        
        public WcfServerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WcfServerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ConvertNumberToWord(string number) {
            return base.Channel.ConvertNumberToWord(number);
        }
        
        public System.Threading.Tasks.Task<string> ConvertNumberToWordAsync(string number) {
            return base.Channel.ConvertNumberToWordAsync(number);
        }
    }
}
