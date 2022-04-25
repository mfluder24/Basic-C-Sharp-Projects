using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates Employee object 'employee' and assigns values to properties
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            employee.SayName(); // Utilises superclass abstract method 'SayName' on employee object

            Console.ReadLine(); // Prevents program from terminating immediately
        }
    }
}
