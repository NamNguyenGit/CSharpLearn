using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class StudentService : IStudent
    {
        List<Student> list = new List<Student>();
        public void DisplayData()
        {
           foreach(var e in list)
            {
                e.Show();
            }
        }

        public void InputData()
        {
            Student st1 = new Student();
            st1.Input();
            list.Add(st1);
        }

        public List<Student> Search(string name)
        {
            
            return list.Where(x => x.FullName.ToUpper().Contains(name.ToUpper())).ToList();
        }
    }
}
