using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Student
    {
        private string studentId;
        private string fullName;
        private string address;
        private int age;
        private string phone;

        public Student()
        {
        }

        public Student(string studentId, string fullName, string address, int age, string phone)
        {
            this.StudentId = studentId;
            this.FullName = fullName;
            this.Address = address;
            this.Age = age;
            this.Phone = phone;
        }

        public string StudentId { get => studentId; set => studentId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Address { get => address; set => address = value; }
        public int Age { get => age; set => age = value; }
        public string Phone { get => phone; set => phone = value; }

        public void Input()
        {
            Console.Write("Insert ID Student ");
            studentId = Console.ReadLine();
            Console.Write("Insert Full Name Student ");
            fullName = Console.ReadLine();
            Console.Write("Insert Address Student ");
            address = Console.ReadLine();
            Console.Write("Insert Age Student ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert Phone Student ");
            phone = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("Id:" + studentId);
            Console.WriteLine("FullName:" + fullName);
            Console.WriteLine("Sddress:" + address);
            Console.WriteLine("Sge:" + age);
            Console.WriteLine("Phone:" + phone);
        }

    }


}
