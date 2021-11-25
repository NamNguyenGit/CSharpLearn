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
            
            EmployeeService ES = new EmployeeService();
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
                        ES.InputData();
                        break;
                    case 2:
                          
                        break;
                    case 3:
                        
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


