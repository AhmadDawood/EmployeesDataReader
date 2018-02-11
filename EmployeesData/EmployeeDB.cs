using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmployeesData
{
  public static class EmployeeDB
    {
        //This class will interact with Employees DB and Fetch data where ever needed.
      public static List<Employee> GetEmployeesNames()
      {
          //Return only EmpID, FirstName and LastNames to caller.

          //List Data Structure for holding Employees Objects
          List<Employee> empList = new List<Employee>();

          string selectStatement = "SELECT ID, FirstName, LastName FROM Employee";
          SqlConnection connection = DBConnection.GetConnection();
          SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

          try
          {
              connection.Open();
              SqlDataReader reader = selectCommand.ExecuteReader();
              while (reader.Read())
              {
                  Employee employee = new Employee();
                  employee.EmpID = Convert.ToInt32(reader["ID"]);
                  employee.FirstName = reader["FirstName"].ToString();
                  employee.LastName = reader["LastName"].ToString();
                  empList.Add(employee);
              }
          }
          catch (SqlException ex)
          {
              
              throw ex;
          }
          finally
          {
              connection.Close();
          }
          return empList;
      }

      public static List<Employee> GetEmployeesData(string sql)
      {
          //Gets Employees Data Against a Fixed Predefined Query.
          
          //List Data Structure for holding Employees Objects
          List<Employee> empList = new List<Employee>();

          string selectStatement = sql;
          SqlConnection connection = DBConnection.GetConnection();
          SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

          try
          {
              connection.Open();
              SqlDataReader reader = selectCommand.ExecuteReader();
              while (reader.Read())
              {
                  Employee employee = new Employee();
                  employee.EmpID = Convert.ToInt32(reader["ID"]);
                  employee.FirstName = reader["FirstName"].ToString();
                  employee.LastName = reader["LastName"].ToString();
                  employee.Designation = reader["Designation"].ToString();
                  employee.Department = reader["Department"].ToString();
                  employee.Salary = Convert.ToInt32(reader["Salary"]);
                  empList.Add(employee);
              }
          }
          catch (SqlException ex)
          {

              throw ex;
          }
          finally
          {
              connection.Close();
          }
          return empList;
      }
    }
}
