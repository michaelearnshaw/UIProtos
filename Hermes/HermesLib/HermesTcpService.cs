
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.

using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.ServiceModel;
using HermesLib;

namespace HermesLib
{
    // Define a service contract.
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface IEntityLoaderService
    {
        [OperationContract]
        Employee GetEmployee();
        [OperationContract]
        ObservableCollection<Employee> GetEmployees();

    }

    // Service class which implements the service contract.
    // Added code to write output to the console window
    public class EntityLoaderService : IEntityLoaderService
    {
        public Employee GetEmployee()
        {
            return new Employee();
        }

        public ObservableCollection<Employee> GetEmployees()
        {
            return new ObservableCollection<Employee> {new Employee(1), new Employee(2)};
        }
    }
}
