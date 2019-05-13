using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCommunication.Repositories
{
    public class EmployeeRepository
    {
        public EmployeeModel GetEmployeeByID(int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings1.Default.ConnString))
            {
                EmployeeModel employee = new EmployeeModel();
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                    return employee;
                }


                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT * FROM Employees
                                            WHERE EmployeeID = @EmployeeID";
                    command.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = employeeID;

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                employee.EmployeeID = reader.GetInt32(0);
                                employee.Title = reader.GetString(1);
                                employee.LastName = reader.GetString(2);
                                employee.FirstName = reader.GetString(3);
                                //employee.ReportsTo = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4);
                                employee.Phone= reader.GetString(4);
                                employee.Email = reader.GetString(5);
                                employee.DepartmentID = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6);
                            }
                            return employee;
                        }
                    }

                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return employee;
                    }

                }
            }

        }

        public void AddEmployee(EmployeeModel employee)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings1.Default.ConnString))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                    return;
                }


                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO Employees(Title, FirstName, LastName, Phone, Email, DepartmentID)
                                                VALUES(@Title, @FirstName, @LastName, @Phone, @Email, @DepartmentID)";

                    command.Parameters.Add("@Title", SqlDbType.NVarChar).Value = employee.Title;
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = employee.FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = employee.LastName;
                    command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = employee.Phone;
                    command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = employee.Email;
                    command.Parameters.Add("@DepartmentID", SqlDbType.Int).Value = (object)employee.DepartmentID ?? DBNull.Value;

                    try
                    {
                        command.ExecuteNonQuery();
                    }

                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return;
                    }
                }
            }
        }

        public List<EmployeeModel> GetEmployeesByDept(int departmentID)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings1.Default.ConnString))
            {
                List<EmployeeModel> employees = new List<EmployeeModel>();
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                    return employees;
                }


                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"SELECT * FROM Employees
                                            WHERE DepartmentID = @DepartmentID";
                    command.Parameters.Add("@DepartmentID", SqlDbType.Int).Value = departmentID;

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            
                            while (reader.Read())
                            {
                                EmployeeModel employee = new EmployeeModel();
                                employee.EmployeeID = reader.GetInt32(0);
                                employee.Title = reader.GetString(1);
                                employee.LastName = reader.GetString(2);
                                employee.FirstName = reader.GetString(3);
                                //employee.ReportsTo = reader.IsDBNull(4) ? (int?)null : reader.GetInt32(4);
                                employee.Phone = reader.GetString(4);
                                employee.Email = reader.GetString(5);
                                employee.DepartmentID = reader.GetInt32(6);

                                employees.Add(employee);
                            }
                            return employees;
                        }
                    }

                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                        return employees;
                    }

                }
            }

        }

        public void RemoveEmployee(int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings1.Default.ConnString))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine("Exception throw when opening connection to database! Exception description follows");
                    Debug.WriteLine(e.ToString());
                }


                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"Delete from Employees where EmployeeID = @employeeId";
                    command.Parameters.Add("@employeeId", SqlDbType.Int).Value = employeeID;

                    try
                    {
                        command.ExecuteNonQuery();
                    }

                    catch (SqlException e)
                    {
                        Debug.WriteLine("Exception throw when executing SQL command. Exception description follows");
                        Debug.WriteLine(e.ToString());
                    }
                }
            }
        }
    }
}
