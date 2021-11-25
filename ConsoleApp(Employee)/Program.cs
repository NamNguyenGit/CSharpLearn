using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            EmployeeService ES = new EmployeeService(list);
            while (true)
            {
                
                Console.WriteLine("\n*************************MENU**************************\n");
                Console.WriteLine("\n**  1. Insert Employee information                   **\n");
                Console.WriteLine("\n**  2. Calculate Salary Employee                     **\n");
                Console.WriteLine("\n**  3. Display Employee                              **\n");
                Console.WriteLine("\n**  4. Search Employee by name                       **\n");
                Console.WriteLine("\n**  5. Exit                                          **\n");              
                Console.Write("\nYour choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Insert number employee:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        for(int i = 0; i < number; i++)
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
                            list.Add(emp);
                        }                    
                        break;
                    case 2:
                        foreach (Employee emp in list)
                        {
                            Console.WriteLine("Salary Employee: " + emp.Ratesalary*emp.Basesalary);
                        }
                        break;
                    case 3:
                        ES.DisplayData();
                        break;
                    case 4:
                        Console.Write("\nInsert name to find ");
                        string name = Convert.ToString(Console.ReadLine());
                        ES.Search(name);                   
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }      
            }
        }
    }
}


