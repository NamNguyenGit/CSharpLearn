using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    interface IBusiness
    {
        void InputData();
        double CalculateSalary();
        void DisplayData(List<Employee> listemp);
        List<Employee> Search(string name);

    }
}
