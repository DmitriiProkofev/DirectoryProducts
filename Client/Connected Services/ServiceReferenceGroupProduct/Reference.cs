﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReferenceGroupProduct {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceGroupProduct.IGroupProductService")]
    public interface IGroupProductService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupProductService/GetGroupProducts", ReplyAction="http://tempuri.org/IGroupProductService/GetGroupProductsResponse")]
        System.Collections.Generic.List<Core.Domain.GroupProduct> GetGroupProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGroupProductService/GetGroupProducts", ReplyAction="http://tempuri.org/IGroupProductService/GetGroupProductsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Core.Domain.GroupProduct>> GetGroupProductsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGroupProductServiceChannel : Client.ServiceReferenceGroupProduct.IGroupProductService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GroupProductServiceClient : System.ServiceModel.ClientBase<Client.ServiceReferenceGroupProduct.IGroupProductService>, Client.ServiceReferenceGroupProduct.IGroupProductService {
        
        public GroupProductServiceClient() {
        }
        
        public GroupProductServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GroupProductServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GroupProductServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GroupProductServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Core.Domain.GroupProduct> GetGroupProducts() {
            return base.Channel.GetGroupProducts();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Core.Domain.GroupProduct>> GetGroupProductsAsync() {
            return base.Channel.GetGroupProductsAsync();
        }
    }
}
