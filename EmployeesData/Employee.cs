using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesData
{
    public class Employee
    {
        //This class will contain only Business Logic code for Employee Object.
        // Data From Multiple Tables will be stored and retreived in this Data Structure. 
        
        // 1- Properties
        public int EmpID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }
}
