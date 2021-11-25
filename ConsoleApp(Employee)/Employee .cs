using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Employee
    {
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public double Basesalary { get; set; }
        public double Ratesalary { get; set; }
        public double Salary { get;   }

        public Employee()
        {
        }

        public Employee(string employeeId, string firstName, string lastName, string address, string phone, double basesalary, double ratesalary, double salary)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
            Basesalary = basesalary;
            Ratesalary = ratesalary;
            Salary = salary;
        }

       
    }
}
