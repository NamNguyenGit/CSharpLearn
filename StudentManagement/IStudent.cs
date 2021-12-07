using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    interface IStudent
    {
        void InputData();
        void DisplayData();
        List<Student> Search(string name);
    }
}
