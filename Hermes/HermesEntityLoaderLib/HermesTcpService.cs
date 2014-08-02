
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.

using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.ServiceModel;
using HermesDataLib;

// Configure logging for this assembly using the 'SimpleApp.exe.log4net' file
[assembly: log4net.Config.XmlConfigurator(ConfigFileExtension = "log4net", Watch = true)]

namespace HermesEntityLoaderLib
{
    // Define a service contract.
    [ServiceContract(Namespace = "http://HermesEntityLoaderLib")]
    public interface IEntityLoaderService
    {
        [OperationContract]
        Employee GetEmployee();
        [OperationContract]
        ObservableCollection<Employee> GetEmployees();
        [OperationContract]
        ObservableCollection<Employee> GetNEmployees(int n);
    }

    // Service class which implements the service contract.
    // Added code to write output to the console window
    public class EntityLoaderService : IEntityLoaderService
    {
        // Create a logger for use in this class
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(
                                                    System.Reflection.MethodBase.GetCurrentMethod()
                                                    .DeclaringType);


        public Employee GetEmployee()
        {
            return new Employee();
        }

        public ObservableCollection<Employee> GetEmployees()
        {
            return new ObservableCollection<Employee> {new Employee(1), new Employee(2)};
        }

        public ObservableCollection<Employee> GetNEmployees(int n)
        {
            var emps = new ObservableCollection<Employee>();
            for (int i = 0; i < n; i++)
            {
                emps.Add(new Employee(i));
            }
            return emps;
        }

        // Host the service within this EXE console application.
        public static void Main(string[] args)
        {
            if (log.IsInfoEnabled) log.Info("args:"+args);
            log.Info("Starting EntityLoaderService...");

            // Create a ServiceHost for the CalculatorService type.
            using (ServiceHost serviceHost = new ServiceHost(typeof(EntityLoaderService)))
            {
                // Open the ServiceHost to create listeners and start listening for messages.
                log.Info("Open Service Host...");
                serviceHost.Open();

                // The service can now be accessed.
                log.Info("The service is ready.");
                log.Info("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();
            }
        }


    }
}
