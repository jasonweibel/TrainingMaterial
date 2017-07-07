﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Namespaces needed for WCF
using System.Runtime.Serialization;
using System.ServiceModel;

// Project Contract Namespaces
using Northwind.WCFContracts.DataContract;
using Northwind.WCFContracts.ServiceContracts;
using Northwind.WCFContracts.FaultContracts;


namespace Northwind.WCFContracts.ServiceContracts
{
    [ServiceContract(Name = "NorthwindServiceContract", Namespace = "urn:training.com:schemas:test:training:2013-02-11")]
    public interface INorthwindServiceContract
    {

        /// <summary>
        /// Current Date Time of the server hosting the service.  This will be formatted like 6/15/2009 13:45:30.617. 
        /// </summary>
        /// <returns>If non-zero, the tenths of a second in a date and time value.</returns>
        [OperationContract(Name = "getTime", IsInitiating = false, IsOneWay = false, IsTerminating = false)]
        [FaultContract(typeof(CustomException))]
        string getTime();

        /// <summary>
        /// Gets the identity of the current training. 
        /// </summary>
        /// <returns>Name of Identity</returns>
        [OperationContract(Name = "whoAmI", IsInitiating = false, IsOneWay = false, IsTerminating = false)]
        [FaultContract(typeof(CustomException))]
        string whoAmI();

        /// <summary>
        /// Get Employee information for ID provided.
        /// </summary>
        /// <param name="employeeid">Employee ID</param>
        /// <returns>Employee Data Contract object; otherwise, Fault.</returns>
        [OperationContract(Name = "getEmployeeForId", IsInitiating = false, IsOneWay = false, IsTerminating = false)]
        [FaultContract(typeof(CustomException))]
        Employee getEmployeeForId(int employeeid);

        /// <summary>
        /// Get a collection of Employee Data Contract objects.
        /// </summary>
        /// <returns>Array of Employee Data Contract objects; otherwise, Fault.</returns>
        [OperationContract]
        [FaultContract(typeof(CustomException))]
        Employee[] getEmployees();

        /// <summary>
        /// Get Product Information for ID provided
        /// </summary>
        /// <param name="productID">Product ID</param>
        /// <returns>Product Data Contract object; otherwise, Fault.</returns>
        [OperationContract]
        [FaultContract(typeof(CustomException))]
        [FaultContract(typeof(ProductFaultException))]
        Product getProductForId(int productID);

        /// <summary>
        /// Get a collection of Product data contract objects.
        /// </summary>
        /// <returns>Array of Product Data Contract objects; otherwise, Fault.</returns>
        [OperationContract ]
        [FaultContract(typeof(CustomException))]
        [FaultContract(typeof(ProductFaultException))]
        Product[] getProducts();

        /// <summary>
        /// Get a collection of Employee Titles.
        /// </summary>
        /// <returns>Array of string; otherwise, Fault.</returns>
        [OperationContract]
        [FaultContract(typeof(CustomException))]
        string[] getEmployeeTitles();

        /// <summary>
        /// Get a collection of Employee data contract objects for Title provided.
        /// </summary>
        /// <param name="title">Title</param>
        /// <returns>Array of Employee Data Contract objects; otherwise, Fault.</returns>
        [OperationContract]
        [FaultContract(typeof(CustomException))]
        Employee[] getEmployeesForTitle(string title);

        /// <summary>
        /// Create a new Employee record.
        /// </summary>
        /// <param name="employee">Employee Data Contract</param>
        /// <returns>int; otherwise, Fault</returns>
        [OperationContract]
        [FaultContract(typeof(CustomException))]
        int postEmployee(Employee employee);

    }

}
