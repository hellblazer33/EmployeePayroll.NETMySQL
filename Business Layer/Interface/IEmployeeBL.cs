
   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonLayer.Models;
using RepoLayer.Interface;
namespace BusinessLayer.Interface


{
    public interface IEmployeeBL
    {
        EmployeeModel AddEmployee(EmployeeModel employee);

        bool DeleteEmployee(int employeeId);

        List<EmployeeModel> GetAllemployees();

        EmployeeModel getGetemployeeByemployeeId(int employeeId);

        EmployeeModel UpdateBook(EmployeeModel employee);






    }
}
