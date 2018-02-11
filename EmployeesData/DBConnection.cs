using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace EmployeesData
{
    class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            //string connectionString = "Data Source=WIN8;Initial Catalog=EmployeeDB;Integrated Security=True";
         
            // Connection string stored and retreived from App.config File.
            var connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
