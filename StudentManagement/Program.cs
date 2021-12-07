using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
          
            StudentService ES = new StudentService();
            while (true)
            {

                Console.WriteLine("\n*************************MENU**************************\n");
                Console.WriteLine("\n1. Enter student’s information\n");
                Console.WriteLine("\n2. To display student’s information\n");
                Console.WriteLine("\n3. Search student by name and display\n");
                Console.WriteLine("\n4. Exit the program\n");          
                Console.Write("\nYour choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ES.InputData();
                         break;
                    case 2:
                        ES.DisplayData();
                        break;
                    case 3:
                        Console.WriteLine("Insert Name to find:");
                        string name = Console.ReadLine();
                        List<Student> result = ES.Search(name);  
                        if(result.Count == 0)
                        {
                            Console.WriteLine("No Student Found");
                        }
                        else
                        {
                            foreach (var e in result)
                            {
                                e.Show();
                            }
                        }
                        
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ngu a ? ");
                        break;
                    
                        
                }
            }
        }
    }
}
