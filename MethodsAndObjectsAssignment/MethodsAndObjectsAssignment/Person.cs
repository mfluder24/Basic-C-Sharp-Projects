using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        public string FirstName { get; set; } // Defines string property 'FirstName'
        public string LastName { get; set; } // Defines string property 'LastName'

        public void SayName() // Creates method called 'SayName' with no parameters
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); // Displays values of properties to user
        }
    }
}
