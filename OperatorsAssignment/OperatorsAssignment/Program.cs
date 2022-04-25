using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { Id = 27, FirstName = "Ron", LastName = "Obvious" }; // Creates 'Employee' object with defined properties
            Employee employee2 = new Employee() { Id = 306, FirstName = "Michael", LastName = "Ellis" }; // Creates 'Employee' object with defined properties
            Employee employee3 = new Employee() { Id = 27, FirstName = "Doppleganger", LastName = "Obvious" }; // Creates 'Employee' object with defined properties

            bool result1 = employee1 == employee2; // Uses overloaded operator and saves result in bool
            Console.WriteLine(result1); // Displays result to user

            bool result2 = employee1 == employee3; // Uses overloaded operator and saves result in bool, used to test is working properly since Ids are identical
            Console.WriteLine(result2); // Displays result to user

            Console.ReadLine(); // Prevents program from terminating immediately
        }
    }
}
