using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp11
{
    class EmployeeService : IBusiness
    {
        private List<Employee> ListEmployee = null;
        Employee emp = new Employee();

        public EmployeeService(List<Employee> listEmployee)
        {
            ListEmployee = listEmployee;
        }

        public double CalculateSalary()
        {
            return emp.Basesalary * emp.Ratesalary;
        }

        public void DisplayData()
        {
            Console.WriteLine("List Employee");
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine(
                    "Id: {0} \t firstName: {1} \t lastName: {2} \t address: {3} \t phone: {4} \t basesalary: {5} \t ratesalary: {6} \t salary: {7}",
                    emp.EmployeeId, emp.FirstName, emp.LastName, emp.Address, emp.Phone, emp.Basesalary, emp.Ratesalary, CalculateSalary());
            }
        }

        public void InputData()
        {
        }

        public List<Employee> Search(string name)
        {
            List<Employee> searchResult = new List<Employee>();
            if (ListEmployee != null && ListEmployee.Count > 0)
            {
                foreach (Employee emp in ListEmployee)
                {
                    if (emp.FirstName.ToUpper().Contains(name.ToUpper()))
                    {
                        Console.WriteLine(
                    "Id: {0} \t firstName: {1} \t lastName: {2} \t address: {3} \t phone: {4} \t basesalary: {5} \t ratesalary: {6} \t salary: {7}",
                    emp.EmployeeId, emp.FirstName, emp.LastName, emp.Address, emp.Phone, emp.Basesalary, emp.Ratesalary, CalculateSalary());
                    }
                }
            }
            return searchResult;
        }
    }
}
