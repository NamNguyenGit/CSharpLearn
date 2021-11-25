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
        public double CalculateSalary()
        {
            return emp.Basesalary * emp.Ratesalary;
        }

        

        public void DisplayData(List<Employee> listemp)
        {
           if(listemp != null)
            {
                foreach(Employee emp in listemp)
                {
                    Console.WriteLine("\n ID Employee: " + emp.EmployeeId, "\nFirst name Employee : " + emp.FirstName, "Last name Employee: " + emp.LastName,
                        "Address Employee: " + emp.Address, "Phone Employee: " + emp.Phone, "Basesalary Employee: " + emp.Basesalary, "Ratesalary Employee: " + emp.Ratesalary
                        + "Salary: " + CalculateSalary());
                }
            }
        }

        public void InputData()
        {
            Employee emp = new Employee();
            Console.Write("Insert ID Employee ");
            emp.EmployeeId = Console.ReadLine();
            Console.Write("Insert First Name Employee ");
            emp.FirstName = Console.ReadLine();
            Console.Write("Insert Last Name Employee ");
            emp.LastName = Console.ReadLine();
            Console.Write("Insert Address Employee ");
            emp.Address = Console.ReadLine();
            Console.Write("Insert Phone Employee ");
            emp.Phone = Console.ReadLine();
            Console.Write("Insert Basesalary Employee ");
            emp.Basesalary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insert Ratesalary Employee ");
            emp.Ratesalary = Convert.ToDouble(Console.ReadLine());
            ListEmployee.Add(emp);
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
                        searchResult.Add(emp);
                    }
                }
            }
            return searchResult;
        }
    }
}
