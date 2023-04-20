namespace RepoLayer.Service
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    //using CloudinaryDotNet;
    //using CloudinaryDotNet.Actions;
    using MySql.Data.MySqlClient;
    using RepoLayer.Interface;
    using Microsoft.Extensions.Configuration;
    using CommonLayer.Models;
    using System.Configuration;

    /// <summary>
    ///  Service class for Interface 
    /// </summary>
    /// <seealso cref="RepoLayer.Interface.IemployeeRL" />
    public class EmployeeRL : IEmployeeRL
    {

        private MySqlConnection sqlConnection;




        public EmployeeRL(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }



        private IConfiguration Configuration { get; }



        public EmployeeModel AddEmployee(EmployeeModel employee)
        {
            try
            {
                string con = "server=127.0.0.1;user id=root;password=Pankaj@123;port=3306;database=employeepayroll";
                this.sqlConnection = new MySqlConnection(con);

                MySqlCommand cmd = new MySqlCommand("Addemployee", this.sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("_employeeId", employee.EmployeeId);
                cmd.Parameters.AddWithValue("_employeeName", employee.EmployeeName);
                cmd.Parameters.AddWithValue("_salary", employee.Salary);
                cmd.Parameters.AddWithValue("_da", employee.DA);
                cmd.Parameters.AddWithValue("_hra", employee.HRA);
                cmd.Parameters.AddWithValue("_bonus", employee.Bonus);
                this.sqlConnection.Open();
                int i = cmd.ExecuteNonQuery();
                this.sqlConnection.Close();
                if (i >= 1)
                {
                    return employee;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this.sqlConnection.Close();
            }
        }


        public EmployeeModel Updateemployee(EmployeeModel employee)
        {
            try
            {
                string con = "server=127.0.0.1;user id=root;password=Pankaj@123;port=3306;database=employeepayroll";
                this.sqlConnection = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand("Updateemployee", this.sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("_employeeId", employee.EmployeeId);
                cmd.Parameters.AddWithValue("_employeeName", employee.EmployeeName);
                cmd.Parameters.AddWithValue("_salary", employee.Salary);
                cmd.Parameters.AddWithValue("_da", employee.DA);
                cmd.Parameters.AddWithValue("_hra", employee.HRA);
                cmd.Parameters.AddWithValue("_bonus", employee.Bonus);
                this.sqlConnection.Open();
                int i = cmd.ExecuteNonQuery();
                this.sqlConnection.Close();
                if (i >= 1)
                {
                    return employee;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this.sqlConnection.Close();
            }
        }


        public bool Deleteemployee(int employeeId)
        {
            try
            {
                string con = "server=127.0.0.1;user id=root;password=Pankaj@123;port=3306;database=employeepayroll";
                this.sqlConnection = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand("Deleteemployee", this.sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("_employeeId", employeeId);
                this.sqlConnection.Open();
                int i = cmd.ExecuteNonQuery();
                this.sqlConnection.Close();
                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this.sqlConnection.Close();
            }
        }


        public EmployeeModel GetemployeeByemployeeId(int employeeId)
        {
            try
            {
                string con = "server=127.0.0.1;user id=root;password=Pankaj@123;port=3306;database=employeepayroll";
                this.sqlConnection = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand("GetemployeeByemployeeId", this.sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("_employeeId", employeeId);
                this.sqlConnection.Open();
                EmployeeModel employeeModel = new EmployeeModel();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employeeModel.EmployeeId = Convert.ToInt32(reader["employeeId"]);
                        employeeModel.EmployeeName = reader["employeeName"].ToString();
                        employeeModel.Salary = Convert.ToInt32(reader["salary"]);
                        employeeModel.HRA = Convert.ToInt32(reader["hra"]);
                        employeeModel.DA = Convert.ToInt32(reader["da"]);
                        employeeModel.Bonus = Convert.ToInt32(reader["bonus"]);
                        
                    }

                    this.sqlConnection.Close();
                    return employeeModel;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this.sqlConnection.Close();
            }
        }


        public List<EmployeeModel> GetAllemployees()
        {
            try
            {
                List<EmployeeModel> employee = new List<EmployeeModel>();
                string con = "server=127.0.0.1;user id=root;password=Pankaj@123;port=3306;database=employeepayroll";
                this.sqlConnection = new MySqlConnection(con);
                MySqlCommand cmd = new MySqlCommand("GetAllemployee", this.sqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                this.sqlConnection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        employee.Add(new EmployeeModel
                        {
                            EmployeeId = Convert.ToInt32(reader["employeeId"]),
                            EmployeeName = reader["employeeName"].ToString(),
                            Salary = Convert.ToInt32(reader["rating"]),
                            HRA = Convert.ToInt32(reader["totalRating"]),
                            DA = Convert.ToInt32(reader["discountPrice"]),
                            Bonus = Convert.ToInt32(reader["originalPrice"]),
                            
                        });
                    }

                    this.sqlConnection.Close();
                    return employee;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this.sqlConnection.Close();
            }
        }

        public EmployeeModel UpdateEmployee(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public EmployeeModel GetEmployeeByEmployeeId(int employeeId)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeModel> GetAllEmployee()
        {
            throw new NotImplementedException();
        }
    }

    public interface IConfiguration
    {
    }
}