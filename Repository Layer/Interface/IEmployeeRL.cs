namespace RepoLayer.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CommonLayer.Models;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    ///  Interface class
    /// </summary>
    public interface IEmployeeRL
    {

        EmployeeModel AddEmployee(EmployeeModel employee);


        EmployeeModel Updateemployee(EmployeeModel employee);


        bool Deleteemployee(int employeeId);


        EmployeeModel GetemployeeByemployeeId(int employeeId);


        List<EmployeeModel> GetAllemployees();
    }
}