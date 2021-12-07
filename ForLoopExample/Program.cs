using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, count = 0;
            Console.WriteLine("-----------------------");
            for (i = 0; i < 100; i++)
            {

                if (i % 5 == 0)
                {
                    Console.Write(i + "   ");
                    count++;
                }

                if (count == 5 && i < 75)
                {
                    count = 0;

                    Console.Write("\n");
                    Console.WriteLine("-----------------------");
                }
            }
            Console.WriteLine();
        }

    }
}
