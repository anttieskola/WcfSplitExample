﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.One {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="One.IBookServiceOne")]
    public interface IBookServiceOne {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookServiceOne/GetAll", ReplyAction="http://tempuri.org/IBookServiceOne/GetAllResponse")]
        Data.Book[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookServiceOne/GetAll", ReplyAction="http://tempuri.org/IBookServiceOne/GetAllResponse")]
        System.Threading.Tasks.Task<Data.Book[]> GetAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookServiceOneChannel : Client.One.IBookServiceOne, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookServiceOneClient : System.ServiceModel.ClientBase<Client.One.IBookServiceOne>, Client.One.IBookServiceOne {
        
        public BookServiceOneClient() {
        }
        
        public BookServiceOneClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookServiceOneClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceOneClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceOneClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Data.Book[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Data.Book[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
    }
}