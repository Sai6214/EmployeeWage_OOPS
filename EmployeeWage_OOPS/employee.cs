using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage_OOPS
{
    class Employee
    {
        public void Calculate()
        {
            int Is_Present = 1;
            Random r = new Random();
            int check = r.Next(0, 2);
            if (Is_Present == check)
                Console.WriteLine("Employee Is Present");
            else
                Console.WriteLine("Employee Is Absent");
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}