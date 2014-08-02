﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HermesClient.EntityLoaderServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://HermesEntityLoaderLib", ConfigurationName="EntityLoaderServiceReference.IEntityLoaderService")]
    public interface IEntityLoaderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://HermesEntityLoaderLib/IEntityLoaderService/GetEmployee", ReplyAction="http://HermesEntityLoaderLib/IEntityLoaderService/GetEmployeeResponse")]
        HermesDataLib.Employee GetEmployee();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://HermesEntityLoaderLib/IEntityLoaderService/GetEmployee", ReplyAction="http://HermesEntityLoaderLib/IEntityLoaderService/GetEmployeeResponse")]
        System.Threading.Tasks.Task<HermesDataLib.Employee> GetEmployeeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://HermesEntityLoaderLib/IEntityLoaderService/GetEmployees", ReplyAction="http://HermesEntityLoaderLib/IEntityLoaderService/GetEmployeesResponse")]
        HermesDataLib.Employee[] GetEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://HermesEntityLoaderLib/IEntityLoaderService/GetEmployees", ReplyAction="http://HermesEntityLoaderLib/IEntityLoaderService/GetEmployeesResponse")]
        System.Threading.Tasks.Task<HermesDataLib.Employee[]> GetEmployeesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEntityLoaderServiceChannel : HermesClient.EntityLoaderServiceReference.IEntityLoaderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EntityLoaderServiceClient : System.ServiceModel.ClientBase<HermesClient.EntityLoaderServiceReference.IEntityLoaderService>, HermesClient.EntityLoaderServiceReference.IEntityLoaderService {
        
        public EntityLoaderServiceClient() {
        }
        
        public EntityLoaderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EntityLoaderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EntityLoaderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EntityLoaderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HermesDataLib.Employee GetEmployee() {
            return base.Channel.GetEmployee();
        }
        
        public System.Threading.Tasks.Task<HermesDataLib.Employee> GetEmployeeAsync() {
            return base.Channel.GetEmployeeAsync();
        }
        
        public HermesDataLib.Employee[] GetEmployees() {
            return base.Channel.GetEmployees();
        }
        
        public System.Threading.Tasks.Task<HermesDataLib.Employee[]> GetEmployeesAsync() {
            return base.Channel.GetEmployeesAsync();
        }
    }
}